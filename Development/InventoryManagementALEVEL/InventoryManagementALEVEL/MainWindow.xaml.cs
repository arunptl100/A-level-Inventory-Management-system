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
using System.Windows.Navigation;
using System.Windows.Shapes;
using InventoryManagementALEVEL.User_controls.MainWindow_controls;

namespace InventoryManagementALEVEL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainPage mainPageIns = new MainPage();
        MainInventory mainInventoryIns = new MainInventory();
        MainForSale mainForSaleIns = new MainForSale();
        MainPerformance mainPerformanceIns = new MainPerformance();
        SQLServerAccessor SqlLink = new SQLServerAccessor();


        public MainWindow(string _username)
        {
            InitializeComponent();
            //Set the content control to the main page instance when the page loads
            this.mainContentControl.Content = mainPageIns;
            //sets the maximum width and heigh to the size of the users screen when maximising.
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            mainInventoryIns._MainUsername = _username;
            mainPageIns.MainUsername = _username;
            mainForSaleIns._MainUsername = _username;
            MessageBox.Show("Welcome " + _username);
            windowtitle.Text += " Welcome " + _username;
            string AccountType = SqlLink.GetAccountType(_username).Replace(" ", "");
            //disable the performance button if the user doesnt have permission to access it
            if (AccountType == "Staff" || AccountType == "Senior Staff")
            {
                Performance_button.IsEnabled = false;
            }
           
        }
        private void close_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void WindowMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Main_Menu_button_Click(object sender, RoutedEventArgs e)
        {
            //set the content control the main page instance
            this.mainContentControl.Content = mainPageIns;
        }

        private void Inventory_button_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = mainInventoryIns;
        }

        private void For_Sale_button_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = mainForSaleIns;
        }

        private void Performance_button_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = mainPerformanceIns;
            PeformanceAnalysis s = new PeformanceAnalysis();
        }

        private void maximize_button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            
        }

        private void minimize_button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void topbar_Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //restores the window back to its dimensions before it was maximized
            this.WindowState = WindowState.Normal;
        }
    }
}
