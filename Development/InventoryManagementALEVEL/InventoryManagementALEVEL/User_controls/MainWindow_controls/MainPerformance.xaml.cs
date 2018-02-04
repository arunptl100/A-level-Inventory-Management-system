using InventoryManagementALEVEL;
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
    /// Interaction logic for MainPerformance.xaml
    /// </summary>
    public partial class MainPerformance : UserControl
    {

        PeformanceAnalysis perf = new PeformanceAnalysis();
        public MainPerformance()
        {
            InitializeComponent();
            TopFive_dataGrid.ItemsSource = perf.GetTopFiveThisMonth();
            TopFiveWorst_dataGrid.ItemsSource = perf.GetTopFiveWorstThisMonth();
        }

        private void topfive_refresh_button_Click(object sender, RoutedEventArgs e)
        {
            TopFive_dataGrid.ItemsSource = perf.GetTopFiveThisMonth();
            TopFive_dataGrid.Items.Refresh();
        }

        private void topfiveworst_refresh_button_Click(object sender, RoutedEventArgs e)
        {
            TopFiveWorst_dataGrid.ItemsSource = perf.GetTopFiveWorstThisMonth();
            TopFiveWorst_dataGrid.Items.Refresh();
        }

        private void submit_search_button_Click(object sender, RoutedEventArgs e)
        {
            if (search_textBox.Text != "Enter Item Name")
            {
                //populate the data grid with the performance records similar to the input item name
                SearchResults_dataGrid.ItemsSource = perf.GetSearchResults(search_textBox.Text);
                SearchResults_dataGrid.Items.Refresh();
            }
        }


        PerformanceTable perfItem = new PerformanceTable();
        private void generate_graph_button_Click(object sender, RoutedEventArgs e)
        {
            GraphDisplayWindow gdw = new GraphDisplayWindow(perfItem);
            gdw.Show();
        }

        private void selectItem_button_Click(object sender, RoutedEventArgs e)
        {
           
            if (SearchResults_dataGrid.SelectedItem != null)
            {
                //just take the first item
                foreach (PerformanceTable item in SearchResults_dataGrid.SelectedItems)
                {
                    perfItem = item;
                    break; 
                }
                report_textBox.Text = perf.GeneratePerformanceAnalysisText(perfItem);
                generate_graph_button.IsEnabled = true;
            }
            
            

        }

        private void search_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (search_textBox.Text == "Enter Item Name")
            {
                search_textBox.Text = "";
            }
        }
    }
}
