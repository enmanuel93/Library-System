namespace LibrarySystemApp.Presentation.Reports
{
    partial class frmDevolutionReport
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
            this.DevolutionReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DevolutionReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DevolutionReportViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DevolutionReportViewer
            // 
            this.DevolutionReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DevolutionDataSet";
            reportDataSource1.Value = this.DevolutionReportViewModelBindingSource;
            this.DevolutionReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.DevolutionReportViewer.LocalReport.ReportEmbeddedResource = "LibrarySystemApp.Reports.RptDevolution.rdlc";
            this.DevolutionReportViewer.Location = new System.Drawing.Point(0, 0);
            this.DevolutionReportViewer.Name = "DevolutionReportViewer";
            this.DevolutionReportViewer.ServerReport.BearerToken = null;
            this.DevolutionReportViewer.Size = new System.Drawing.Size(787, 637);
            this.DevolutionReportViewer.TabIndex = 0;
            // 
            // DevolutionReportViewModelBindingSource
            // 
            this.DevolutionReportViewModelBindingSource.DataSource = typeof(Domain.ViewModels.DevolutionReportViewModel);
            // 
            // frmDevolutionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 637);
            this.Controls.Add(this.DevolutionReportViewer);
            this.Name = "frmDevolutionReport";
            this.ShowIcon = false;
            this.Text = "DEVOLUTION REPORT";
            this.Load += new System.EventHandler(this.frmDevolutionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DevolutionReportViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer DevolutionReportViewer;
        private System.Windows.Forms.BindingSource DevolutionReportViewModelBindingSource;
    }
}