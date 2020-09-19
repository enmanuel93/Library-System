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
    public partial class frmLoanReport : FormReportController
    {
        public frmLoanReport()
        {
            InitializeComponent();
        }

        private void frmLoanReport_Load(object sender, EventArgs e)
        {
            var reportDataSource = new ReportDataSource("LoanDataSet", repositoryReport.GetLoanReportData());
            loanReportViewer.LocalReport.DataSources.Clear();
            loanReportViewer.LocalReport.DataSources.Add(reportDataSource);
            this.loanReportViewer.RefreshReport();
        }
    }
}
