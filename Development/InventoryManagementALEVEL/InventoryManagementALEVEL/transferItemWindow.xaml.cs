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
    /// Interaction logic for transferItemWindow.xaml
    /// </summary>
    public partial class transferItemWindow : Window
    {
        SQLServerAccessor SqlLink = new SQLServerAccessor();
        InventoryTable globItem;
        public string MainUserName;
        public transferItemWindow(InventoryTable item)
        {
            InitializeComponent();
            itemname_textBox.Text = item.ItemName;
            globItem = item;
         
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

       

        private void submit_button_Click(object sender, RoutedEventArgs e)
        {
            if (sellbydate_datepicker.SelectedDate == null)
            {
                MessageBox.Show("You must enter a sell by date in order to submit");
            }
            else
            {
                SqlLink.TransferItemsToForWITHsellByDate(globItem, sellbydate_datepicker.SelectedDate.Value, MainUserName);
                this.Close();
            }
        }
    }
}
