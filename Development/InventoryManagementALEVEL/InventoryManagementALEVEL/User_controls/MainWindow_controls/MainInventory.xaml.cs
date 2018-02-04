using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace InventoryManagementALEVEL.User_controls.MainWindow_controls
{
    /// <summary>
    /// Interaction logic for MainInventory.xaml
    /// </summary>
    public partial class MainInventory : UserControl
    {
        SQLServerAccessor SqlLink = new SQLServerAccessor();

        PeformanceAnalysis perf = new PeformanceAnalysis();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public string _MainUsername;
 
        public MainInventory()
        {
            InitializeComponent();

            //populate the data grid with the inventory table initially
            inventory_dataGrid.ItemsSource = SqlLink.DataContextInv.InventoryTables.ToList();
            //populate the category combo box with all the categories in the category table.
            category_comboBox.ItemsSource = SqlLink.getCategories().ToList();
           
            category_comboBox.DisplayMemberPath = "CategoryName";
            category_comboBox.SelectedValuePath = "CategoryName";
            category_comboBox.SelectedIndex = 0;

            item_order_comboBox.Items.Add("Any");
            item_order_comboBox.Items.Add("Alphabetical");
            item_order_comboBox.SelectedIndex = 0;

            quantity_comboBox.Items.Add("Any");
            quantity_comboBox.Items.Add("Ascending");
            quantity_comboBox.Items.Add("Descending");
            quantity_comboBox.SelectedIndex = 0;


            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }


        private void updateAll()
        {
            editmode_label.Content = "";

            inventory_dataGrid.ItemsSource = SqlLink.getNewInventoryTable(category_comboBox.Text.Replace(" ", string.Empty), name_textBox.Text);
            inventory_dataGrid.Items.SortDescriptions.Clear();
            foreach (var cols in inventory_dataGrid.Columns)
            {
                cols.SortDirection = null;
            }
            if (item_order_comboBox.Text == "Alphabetical")
            {
                //arrange the first column (item name) in alphabetical order
                var col = inventory_dataGrid.Columns[0];
                inventory_dataGrid.Items.SortDescriptions.Add(new SortDescription(col.SortMemberPath, ListSortDirection.Ascending));

                col.SortDirection = ListSortDirection.Ascending;
            }
            else if (quantity_comboBox.Text == "Ascending")
            {
                //arrange the third column (quantity) in ascending order
                var col = inventory_dataGrid.Columns[2];
                inventory_dataGrid.Items.SortDescriptions.Add(new SortDescription(col.SortMemberPath, ListSortDirection.Ascending));

                col.SortDirection = ListSortDirection.Ascending;
            }
            else if (quantity_comboBox.Text == "Descending")
            {
                //arrange the third column (quantity) in descending order
                var col = inventory_dataGrid.Columns[2];
                inventory_dataGrid.Items.SortDescriptions.Add(new SortDescription(col.SortMemberPath, ListSortDirection.Descending));

                col.SortDirection = ListSortDirection.Descending;
            }
            inventory_dataGrid.Items.Refresh();

        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //if the user has selected an item , then disable automatic updating
            if (inventory_dataGrid.SelectedItem == null)
            {
                updateAll();
            }
            else
            {
                editmode_label.Content = "edit mode enabled";
                Console.WriteLine("focused");
            }
        }

        private void GridMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //deselect the datagrid, if the user clicks on the main grid
            inventory_dataGrid.UnselectAll();
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            AddNewItemWindow Addwin = new AddNewItemWindow();
            Addwin.mainUsername = _MainUsername;
            Addwin.Show();
        }

        private void delete_button_Click(object sender, RoutedEventArgs e)
        {
            //Check that an item has actually been selected to be deleted
            if (inventory_dataGrid.SelectedItem != null)
            {
                //setup a list of item IDs , which have a datatype of integer
                List<int> itemIDs = new List<int>();
                //loop through the selected items
                foreach (InventoryTable item in inventory_dataGrid.SelectedItems)
                {
                    //add the item ID of each item to the itemID list
                    itemIDs.Add(item.ItemID);
                    Console.WriteLine(item.ItemID.ToString());
                }

                if (SqlLink.deleteItemsInventory(itemIDs.ToArray(),_MainUsername))
                {
                    MessageBox.Show("deleted");
                    Console.WriteLine("Updating table on delete");
                    //update the tables data to reflect the delete, also resumes auto updating
                    inventory_dataGrid.ItemsSource = SqlLink.getNewInventoryTable(category_comboBox.Text.Replace(" ", string.Empty), name_textBox.Text);
                }
            }
        }

       

        private void submit_changes_button_Click(object sender, RoutedEventArgs e)
        {
            if (SqlLink.GetAccountType(_MainUsername) != "Staff")
            {
                SqlLink.DataContextInv.SubmitChanges();
            }
            else
            {
                MessageBox.Show("You do not have permission to change items details");
            }
        }

        private void reset_button_Click(object sender, RoutedEventArgs e)
        {
            category_comboBox.SelectedIndex = 0;
            item_order_comboBox.SelectedIndex = 0;
            quantity_comboBox.SelectedIndex = 0;
            name_textBox.Text = "";
        }

        private void transferitems_button_Click(object sender, RoutedEventArgs e)
        {
            if (SqlLink.GetAccountType(_MainUsername) != "Staff")
            {
                List<InventoryTable> ItemsToTrans = new List<InventoryTable>();//no sell by date list
                List<InventoryTable> ItemsToTransSellByDate = new List<InventoryTable>(); //sell by date list
                if (inventory_dataGrid.SelectedItem != null)
                {
                    if (inventory_dataGrid.SelectedItems != null)
                    {
                        //iterate through the users selection
                        foreach (InventoryTable item in inventory_dataGrid.SelectedItems)
                        {
                            //if the item is a food or drink item , add it to the sell by date list
                            if ((item.CategoryName.Replace(" ", "") == "Food") || (item.CategoryName.Replace(" ", "") == "Drink"))
                            {
                                ItemsToTransSellByDate.Add(item);
                            }
                            else
                            {
                                ItemsToTrans.Add(item);
                            }
                        }
                    }
                }
                inventory_dataGrid.UnselectAll();
                updateAll();

                if (ItemsToTransSellByDate.Count != 0)
                //if there are any items to transfer with a sell by date
                {
                    foreach (InventoryTable itemToPushWithSellByDate in ItemsToTransSellByDate)
                    {
                        if (perf.GetPerformanceThisMonthAsBool(itemToPushWithSellByDate.ItemName))
                        {
                            MessageBox.Show("Warning! The item " + itemToPushWithSellByDate.ItemName.Replace(" ", "") + " Has shown to not sell well during this month");
                        }
                        //iterate through the list and instantiate the new window , sending in each item as a parameter
                        transferItemWindow transitemsellby = new transferItemWindow(itemToPushWithSellByDate);
                        transitemsellby.MainUserName = _MainUsername;
                        transitemsellby.Show();

                    }
                    //transfer the items that dont have a sell by date
                    SqlLink.TransferItemsToForSaleNoSellBy(ItemsToTrans, _MainUsername);
                }
                else
                {
                    foreach (InventoryTable nextItem in ItemsToTransSellByDate)
                    {
                        if (perf.GetPerformanceThisMonthAsBool(nextItem.ItemName))
                        {
                            MessageBox.Show("Warning! The item " + nextItem.ItemName.Replace(" ", "") + " Has shown to not sell well during this month");
                        }
                    }
                    //only transfer items that have no sell by date 
                    SqlLink.TransferItemsToForSaleNoSellBy(ItemsToTrans, _MainUsername);

                }
            }
            else
            {
                MessageBox.Show("You do not have permission to transfer items");
            }



        }

    }
}
