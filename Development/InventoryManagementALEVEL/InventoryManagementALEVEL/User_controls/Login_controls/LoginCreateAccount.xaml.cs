using InventoryManagementALEVEL.User_controls.MainWindow_controls;
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

namespace InventoryManagementALEVEL.User_controls.Login_controls
{
    /// <summary>
    /// Interaction logic for LoginCreateAccount.xaml
    /// </summary>
    public partial class LoginCreateAccount : UserControl
    {
        SQLServerAccessor SqlLink = new SQLServerAccessor();

        public LoginCreateAccount()
        {
            InitializeComponent();
        }
        private void ClearOnFirst(ref TextBox tb , string TextToCheck) 
        /*Pass by reference the textbox being cleared and its default text*/
        {
            if (tb.Text == TextToCheck) /*If the default text exists , then clear it*/
            {
                tb.Text = "";
            }
           
        }
        private void username_textBox_GotFocus(object sender, RoutedEventArgs e)
            /*When the user clicks on a textbox call the ClearOnFirst method */
        {
            ClearOnFirst(ref username_textBox , "USERNAME");
        }

        private void firstname_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearOnFirst(ref firstname_textBox, "FIRST NAME");
        }

        private void lastname_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearOnFirst(ref lastname_textBox, "LAST NAME");
        }

        private void password_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearOnFirst(ref password_textBox, "PASSWORD");
        }

    

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            /*Sets all of the textboxes text to its default values*/
            username_textBox.Text = "USERNAME";
            firstname_textBox.Text = "FIRST NAME";
            lastname_textBox.Text = "LAST NAME";
            password_textBox.Text = "PASSWORD";
            role_ComboBox.Text = "ROLE";
        }

        private void submit_button_Click(object sender, RoutedEventArgs e)
        {
            //check each field is not its default value
            if ((username_textBox.Text != "USERNAME") && (firstname_textBox.Text != "FIRST NAME")
                && (lastname_textBox.Text != "LAST NAME") && (password_textBox.Text != "PASSWORD")
                && (role_ComboBox.Text != "ROLE")
                )
            {
                if (SqlLink.CreateNewAccount(username_textBox.Text, firstname_textBox.Text, lastname_textBox.Text, password_textBox.Text, role_ComboBox.Text))
                {
                    MessageBox.Show("Account created! Username " + username_textBox.Text + " Password " + password_textBox.Text);
                }
                else
                {
                    MessageBox.Show("Username is already taken , please choose another");
                }
            }
            else
            {
                MessageBox.Show("You must fill out all fields");
            }
           
        }
    }
}
