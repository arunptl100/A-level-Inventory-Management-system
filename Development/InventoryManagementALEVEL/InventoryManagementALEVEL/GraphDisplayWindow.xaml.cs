using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InventoryManagementALEVEL
{
    /// <summary>
    /// Interaction logic for GraphDisplayWindow.xaml
    /// </summary>
    public partial class GraphDisplayWindow : Window
    {
        public GraphDisplayWindow(PerformanceTable perfData)
        {
            InitializeComponent();
            //links the x axis (month) to the transfers for that month ( y axis)
            ((LineSeries)Perf_Chart.Series[0]).ItemsSource =
            new KeyValuePair<string, int>[]{
            new KeyValuePair<string, int>("January", perfData.January.Value),
            new KeyValuePair<string, int>("February", perfData.February.Value),
            new KeyValuePair<string, int>("March", perfData.March.Value),
            new KeyValuePair<string, int>("April", perfData.April.Value),
            new KeyValuePair<string, int>("May", perfData.May.Value),
            new KeyValuePair<string, int>("June", perfData.June.Value),
            new KeyValuePair<string, int>("July", perfData.July.Value),
            new KeyValuePair<string, int>("August", perfData.August.Value),
            new KeyValuePair<string, int>("September", perfData.September.Value),
            new KeyValuePair<string, int>("October", perfData.October.Value),
            new KeyValuePair<string, int>("November", perfData.November.Value),
            new KeyValuePair<string, int>("December", perfData.December.Value),};

        }
    }
}
