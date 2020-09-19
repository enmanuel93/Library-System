namespace LibrarySystemApp.Presentation.Reports
{
    partial class frmStudentReport
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
            this.StudentReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentReportViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentReportViewer
            // 
            this.StudentReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentDataSet";
            reportDataSource1.Value = this.StudentReportViewModelBindingSource;
            this.StudentReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.StudentReportViewer.LocalReport.ReportEmbeddedResource = "LibrarySystemApp.Reports.RptStudent.rdlc";
            this.StudentReportViewer.Location = new System.Drawing.Point(0, 0);
            this.StudentReportViewer.Name = "StudentReportViewer";
            this.StudentReportViewer.ServerReport.BearerToken = null;
            this.StudentReportViewer.Size = new System.Drawing.Size(787, 637);
            this.StudentReportViewer.TabIndex = 0;
            // 
            // StudentReportViewModelBindingSource
            // 
            this.StudentReportViewModelBindingSource.DataSource = typeof(Domain.ViewModels.StudentReportViewModel);
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 637);
            this.Controls.Add(this.StudentReportViewer);
            this.Name = "frmStudentReport";
            this.ShowIcon = false;
            this.Text = "STUDENT REPORT";
            this.Load += new System.EventHandler(this.frmStudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentReportViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer StudentReportViewer;
        private System.Windows.Forms.BindingSource StudentReportViewModelBindingSource;
    }
}