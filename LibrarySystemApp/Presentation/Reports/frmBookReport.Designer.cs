namespace LibrarySystemApp.Presentation.Reports
{
    partial class frmBookReport
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
            this.BookReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BookViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BookViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BookReportViewer
            // 
            this.BookReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BookDataSet";
            reportDataSource1.Value = this.BookViewModelBindingSource;
            this.BookReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.BookReportViewer.LocalReport.ReportEmbeddedResource = "LibrarySystemApp.Reports.RptBook.rdlc";
            this.BookReportViewer.Location = new System.Drawing.Point(0, 0);
            this.BookReportViewer.Name = "BookReportViewer";
            this.BookReportViewer.ServerReport.BearerToken = null;
            this.BookReportViewer.Size = new System.Drawing.Size(787, 637);
            this.BookReportViewer.TabIndex = 0;
            // 
            // BookViewModelBindingSource
            // 
            this.BookViewModelBindingSource.DataSource = typeof(Domain.ViewModels.BookViewModel);
            // 
            // frmBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 637);
            this.Controls.Add(this.BookReportViewer);
            this.Name = "frmBookReport";
            this.ShowIcon = false;
            this.Text = "BOOK REPORT";
            this.Load += new System.EventHandler(this.frmBookReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer BookReportViewer;
        private System.Windows.Forms.BindingSource BookViewModelBindingSource;
    }
}