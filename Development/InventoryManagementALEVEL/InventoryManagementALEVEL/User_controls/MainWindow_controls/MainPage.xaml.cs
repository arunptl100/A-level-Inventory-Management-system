
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

namespace InventoryManagementALEVEL.User_controls.MainWindow_controls
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public string MainUsername;
        SQLServerAccessor SqlLink = new SQLServerAccessor();

        public MainPage()
        {
            InitializeComponent();

        }

        private void log_button_Click(object sender, RoutedEventArgs e)
        {
            //only show the log window if the user is an admin or manager
            if (SqlLink.GetAccountType(MainUsername) == "Manager" || SqlLink.GetAccountType(MainUsername) == "Admin")
            {
                logWindow logwin = new logWindow();
                logwin.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to view the log window");
            }
        }
    }
}
