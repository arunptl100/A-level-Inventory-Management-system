using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace InventoryManagementALEVEL
{
    /// <summary>
    /// Interaction logic for AddNewItemWindow.xaml
    /// </summary>
    public partial class AddNewItemWindow : Window
    {
        SQLServerAccessor SQLlink = new SQLServerAccessor();
        public string mainUsername;


        public AddNewItemWindow()
        {
            InitializeComponent();
            //populate the category combobox with all the categories in the category table
            Category_comboBox.ItemsSource = SQLlink.getCategories().ToList();
            Category_comboBox.DisplayMemberPath = "CategoryName";
            Category_comboBox.SelectedValuePath = "CategoryName";
            Category_comboBox.SelectedIndex = 0;
           
        }
        private void WindowMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();

        }
        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(Category_comboBox.Text);
            int passedval;
            //validate the input fields, is the name field empty? is the quantity an integer?
            if ((!string.IsNullOrWhiteSpace(ItemName_textBox.Text)) && (int.TryParse(Quantity_textBox.Text, out passedval)))
            {
                try
                {
                    //insert the new item
                    if (SQLlink.addNewItemInventory(ItemName_textBox.Text, Convert.ToInt32(Quantity_textBox.Text), Category_comboBox.Text.Replace(" ", string.Empty), mainUsername))
                    {
                        MessageBox.Show("Added new item");
                        this.Close();
                    }
                }
                catch (Exception en) { Console.WriteLine(en.ToString()); }

            }
            else if(string.IsNullOrWhiteSpace(ItemName_textBox.Text))
            {
                MessageBox.Show("You must not leave the item name field empty");
            }
            else if (!int.TryParse(Quantity_textBox.Text, out passedval))
            {
                MessageBox.Show("The quantity you have entered is not an integer");
            }

        }

        private void reset_button_Click(object sender, RoutedEventArgs e)
        {
            ItemName_textBox.Text = "Item name";
            Quantity_textBox.Text = "Quantity";
            Category_comboBox.SelectedIndex = 0;
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ItemName_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ItemName_textBox.Text == "Item name")
            {
                ItemName_textBox.Text = "";
            }
        }

        private void Quantity_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Quantity_textBox.Text == "Quantity")
            {
                Quantity_textBox.Text = "";
            }
       } 

       
    }
}
