using InventoryManagementALEVEL.User_controls.Login_controls;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
            /*Global var instances for each usercontrol*/
        LoginMainCtrl loginMainIns = new LoginMainCtrl();
        LoginCreateAccount loginCreateAccountIns = new LoginCreateAccount();
        LoginForgotPassword loginForgotPasswordIns = new LoginForgotPassword();
        LoginAbout loginAboutIns = new LoginAbout();
        LoginHelp loginHelpIns = new LoginHelp();

        public Login()
        {
            InitializeComponent();
            /*Set the contents of the page to the login main page user control*/
            this.mainContentControl.Content = loginMainIns;
        }
        private void WindowMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            /*Allows the user to drag the screen around the window*/
            DragMove();
        }

        private void forgotten_password_button_Click(object sender, RoutedEventArgs e)
        {
            /*Set the contents of the page to the forgotten password user control
             When the user clicks on the forgotten password button*/
            this.mainContentControl.Content = loginForgotPasswordIns;
        }

        private void home_button_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = loginMainIns;
        }

        private void create_button_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = loginCreateAccountIns;
        }

        private void about_button_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = loginAboutIns;
        }

        private void help_button_Click(object sender, RoutedEventArgs e)
        {
            this.mainContentControl.Content = loginHelpIns;
        }
    }
}
