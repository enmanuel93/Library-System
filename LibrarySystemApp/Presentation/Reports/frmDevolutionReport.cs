using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp.Presentation.Reports
{
    public partial class frmDevolutionReport : FormReportController
    {
        public frmDevolutionReport()
        {
            InitializeComponent();
        }

        private void frmDevolutionReport_Load(object sender, EventArgs e)
        {
            var reportDataSource = new ReportDataSource("DevolutionDataSet", repositoryReport.GetDevolutionReportData());
            DevolutionReportViewer.LocalReport.DataSources.Clear();
            DevolutionReportViewer.LocalReport.DataSources.Add(reportDataSource);
            this.DevolutionReportViewer.RefreshReport();
        }
    }
}
