namespace LibrarySystemApp.Presentation.Reports
{
    partial class frmLoanReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.loanReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LoanReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoanReportViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loanReportViewer
            // 
            this.loanReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LoanDataSet";
            reportDataSource1.Value = this.LoanReportViewModelBindingSource;
            this.loanReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.loanReportViewer.LocalReport.ReportEmbeddedResource = "LibrarySystemApp.Reports.RptLoan.rdlc";
            this.loanReportViewer.Location = new System.Drawing.Point(0, 0);
            this.loanReportViewer.Name = "loanReportViewer";
            this.loanReportViewer.ServerReport.BearerToken = null;
            this.loanReportViewer.Size = new System.Drawing.Size(787, 637);
            this.loanReportViewer.TabIndex = 0;
            // 
            // LoanReportViewModelBindingSource
            // 
            this.LoanReportViewModelBindingSource.DataSource = typeof(Domain.ViewModels.LoanReportViewModel);
            // 
            // frmLoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 637);
            this.Controls.Add(this.loanReportViewer);
            this.Name = "frmLoanReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOAN REPORT";
            this.Load += new System.EventHandler(this.frmLoanReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoanReportViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer loanReportViewer;
        private System.Windows.Forms.BindingSource LoanReportViewModelBindingSource;
    }
}