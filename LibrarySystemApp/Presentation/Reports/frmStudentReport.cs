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
    public partial class frmStudentReport : FormReportController
    {
        public frmStudentReport()
        {
            InitializeComponent();
        }

        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            var reportDataSource = new ReportDataSource("StudentDataSet", repositoryReport.GetStudentReportData());
            StudentReportViewer.LocalReport.DataSources.Clear();
            StudentReportViewer.LocalReport.DataSources.Add(reportDataSource);
            this.StudentReportViewer.RefreshReport();
        }
    }
}
