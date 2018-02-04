using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MainForSale.xaml
    /// </summary>
    public partial class MainForSale : UserControl
    {

        SQLServerAccessor SqlLink = new SQLServerAccessor();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public string _MainUsername;




        public MainForSale()
        {
            InitializeComponent();


            //populate the data grid with the for sale table initially
            for_sale_dataGrid.ItemsSource = SqlLink.DataContextInv.ForSaleTables.ToList();
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
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (for_sale_dataGrid.SelectedItem == null)
            {
                editmode_label.Content = "";
                for_sale_dataGrid.ItemsSource = SqlLink.getNewForSaleTable(category_comboBox.Text.Replace(" ", string.Empty), name_textBox.Text);
                for_sale_dataGrid.Items.SortDescriptions.Clear();
                foreach (var cols in for_sale_dataGrid.Columns)
                {
                    cols.SortDirection = null;
                }
                if (item_order_comboBox.Text == "Alphabetical")
                {
                    //arrange the first column (item name) in alphabetical order
                    var col = for_sale_dataGrid.Columns[0];
                    for_sale_dataGrid.Items.SortDescriptions.Add(new SortDescription(col.SortMemberPath, ListSortDirection.Ascending));

                    col.SortDirection = ListSortDirection.Ascending;
                }
                else if (quantity_comboBox.Text == "Ascending")
                {
                    //arrange the third column (quantity) in ascending order
                    var col = for_sale_dataGrid.Columns[2];
                    for_sale_dataGrid.Items.SortDescriptions.Add(new SortDescription(col.SortMemberPath, ListSortDirection.Ascending));

                    col.SortDirection = ListSortDirection.Ascending;
                }
                else if (quantity_comboBox.Text == "Descending")
                {
                    //arrange the third column (quantity) in descending order
                    var col = for_sale_dataGrid.Columns[2];
                    for_sale_dataGrid.Items.SortDescriptions.Add(new SortDescription(col.SortMemberPath, ListSortDirection.Descending));

                    col.SortDirection = ListSortDirection.Descending;
                }
                
                for_sale_dataGrid.Items.Refresh();
            }
            else
            {
                editmode_label.Content = "edit mode enabled";
                Console.WriteLine("focused");
            }

        }


        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            AddNewItemWindowForSale additemforsale = new AddNewItemWindowForSale();
            additemforsale.mainUsername = _MainUsername;
            additemforsale.Show();
        }
        private void delete_button_Click(object sender, RoutedEventArgs e)
        {

            //Check that an item has actually been selected to be deleted
            if (for_sale_dataGrid.SelectedItem != null) 
            {
                //setup a list of item IDs , which have a datatype of integer
                List<int> itemIDs = new List<int>();
                //loop through the selected items
                if (for_sale_dataGrid.SelectedItems != null)
                {
                    foreach (ForSaleTable item in for_sale_dataGrid.SelectedItems)
                    {
                        //add the item ID of each item to the itemID list
                        itemIDs.Add(item.ItemID);
                        Console.WriteLine(item.ItemID.ToString());
                    }

                    if (SqlLink.deleteItemsForSale(itemIDs.ToArray() , _MainUsername))
                    {
                        MessageBox.Show("deleted");
                        Console.WriteLine("Updating table on delete");
                        //update the tables data to reflect the delete, also resumes auto updating
                        for_sale_dataGrid.ItemsSource = SqlLink.getNewForSaleTable(category_comboBox.Text.Replace(" ", string.Empty), name_textBox.Text);
                    }
                }
            }
        }
        private void submit_changes_button_Click(object sender, RoutedEventArgs e)
        {
            if (SqlLink.GetAccountType(_MainUsername) != "Staff")
            {
                SqlLink.DataContextInv.SubmitChanges();
            }
        }
        private void reset_button_Click(object sender, RoutedEventArgs e)
        {
            category_comboBox.SelectedIndex = 0;
            item_order_comboBox.SelectedIndex = 0;
            quantity_comboBox.SelectedIndex = 0;
            name_textBox.Text = "";
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            for_sale_dataGrid.UnselectAll();
        }
    }
}
