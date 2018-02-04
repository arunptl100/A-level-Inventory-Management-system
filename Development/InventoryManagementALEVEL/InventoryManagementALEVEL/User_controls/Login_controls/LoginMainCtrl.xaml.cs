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

namespace InventoryManagementALEVEL.User_controls.Login_controls
{
    /// <summary>
    /// Interaction logic for LoginMainCtrl.xaml
    /// </summary>
    public partial class LoginMainCtrl : UserControl
    {
       
        public LoginMainCtrl()
        {
            InitializeComponent();
        }
        SQLServerAccessor SqlLink = new SQLServerAccessor();
        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            if (SqlLink.AuthenticateLogin(username_textBox.Text, password_passwordBox.Password))
            {
                //create an instance of the main window and show it if the login was authenticated
                MainWindow mw = new MainWindow(username_textBox.Text);
                mw.Show();
                var myWindow = Window.GetWindow(this);
                myWindow.Close();
            }
            else
            {
                error_label.Content = "Username or password incorrect , Please Try Again";
            }
        }


        private void username_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            //if the default text is shown clear it on mouse click
            if (username_textBox.Text == "USERNAME") 
            {
                username_textBox.Text = "";
            }
        }

        private void password_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            //causes the password field to be shown and set to the focus
            password_textBox.Visibility = Visibility.Hidden;
            Keyboard.Focus(password_passwordBox);
        }

       
    }
}
