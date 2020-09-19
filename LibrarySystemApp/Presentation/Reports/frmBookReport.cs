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
    public partial class frmBookReport : FormReportController
    {
        public frmBookReport()
        {
            InitializeComponent();
        }

        private void frmBookReport_Load(object sender, EventArgs e)
        {
            var reportDataSource = new ReportDataSource("BookDataSet", repositoryReport.GetBookReportData());
            BookReportViewer.LocalReport.DataSources.Clear();
            BookReportViewer.LocalReport.DataSources.Add(reportDataSource);
            this.BookReportViewer.RefreshReport();
        }
    }
}
