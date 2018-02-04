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
    /// Interaction logic for logWindow.xaml
    /// </summary>
    public partial class logWindow : Window
    {
        SQLServerAccessor SqlLink = new SQLServerAccessor();

        public logWindow()
        {
            InitializeComponent();

            log_dataGrid.ItemsSource = SqlLink.DataContextInv.EventLogTables.ToList();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void close_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void log_DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            if (log_DatePicker.SelectedDate != null)
            {
                log_dataGrid.ItemsSource = SqlLink.GetLogEntriesAfterDate(log_DatePicker.SelectedDate.Value);
                log_dataGrid.Items.Refresh();
            }
        }
    }
}
