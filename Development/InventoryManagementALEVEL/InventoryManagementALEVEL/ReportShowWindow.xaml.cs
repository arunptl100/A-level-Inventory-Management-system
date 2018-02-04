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
    /// Interaction logic for ReportShowWindow.xaml
    /// </summary>
    public partial class ReportShowWindow : Window
    {
        public ReportShowWindow()
        {
            InitializeComponent();
            _reportViewer.Load += ReportViewer_Load;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private bool _isReportViewerLoaded;

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (!_isReportViewerLoaded)
            {
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
               InventoryManagementDBDataSet dataset = new InventoryManagementDBDataSet();

                dataset.BeginInit();

                reportDataSource1.Name = "DataSet1"; //Name of the report dataset in our .RDLC file
                reportDataSource1.Value = dataset.PerformanceTable;
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this._reportViewer.LocalReport.ReportEmbeddedResource = "InventoryManagementALEVEL/PerformanceReport.rdlc";

                dataset.EndInit();

                //fill data into adventureWorksDataSet
                InventoryManagementDBDataSetTableAdapters.PerformanceTableTableAdapter salesOrderDetailTableAdapter = new InventoryManagementDBDataSetTableAdapters.PerformanceTableTableAdapter();
                salesOrderDetailTableAdapter.ClearBeforeFill = true;
                salesOrderDetailTableAdapter.Fill(dataset.PerformanceTable);

                _reportViewer.RefreshReport();

                _isReportViewerLoaded = true;
            }
        }

    }
}
