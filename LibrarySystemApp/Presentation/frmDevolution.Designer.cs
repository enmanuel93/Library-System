namespace LibrarySystemApp.Presentation
{
    partial class frmDevolution
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
            this.btnConsultPres = new System.Windows.Forms.Button();
            this.txtLoanCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDevolution = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolution)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new System.Drawing.Point(723, 381);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(635, 381);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Location = new System.Drawing.Point(544, 381);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(463, 381);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultPres);
            this.groupBox1.Controls.Add(this.txtLoanCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Size = new System.Drawing.Size(753, 128);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtLoanCode, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnConsultPres, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtId, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(208, 24);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 32);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 35);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Location = new System.Drawing.Point(22, 381);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConsultPres
            // 
            this.btnConsultPres.BackgroundImage = global::LibrarySystemApp.Properties.Resources.icons8_ver_archivo_80;
            this.btnConsultPres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultPres.FlatAppearance.BorderSize = 0;
            this.btnConsultPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultPres.Location = new System.Drawing.Point(280, 66);
            this.btnConsultPres.Name = "btnConsultPres";
            this.btnConsultPres.Size = new System.Drawing.Size(30, 26);
            this.btnConsultPres.TabIndex = 10;
            this.btnConsultPres.UseVisualStyleBackColor = true;
            this.btnConsultPres.Click += new System.EventHandler(this.btnConsultPres_Click);
            // 
            // txtLoanCode
            // 
            this.txtLoanCode.Location = new System.Drawing.Point(93, 70);
            this.txtLoanCode.Name = "txtLoanCode";
            this.txtLoanCode.ReadOnly = true;
            this.txtLoanCode.Size = new System.Drawing.Size(181, 20);
            this.txtLoanCode.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loan Code:";
            // 
            // dgvDevolution
            // 
            this.dgvDevolution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevolution.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDevolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolution.Location = new System.Drawing.Point(22, 179);
            this.dgvDevolution.Name = "dgvDevolution";
            this.dgvDevolution.ReadOnly = true;
            this.dgvDevolution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolution.Size = new System.Drawing.Size(752, 174);
            this.dgvDevolution.TabIndex = 16;
            this.dgvDevolution.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolution_CellClick);
            // 
            // frmDevolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.dgvDevolution);
            this.Name = "frmDevolution";
            this.Text = "DEVOLUTION";
            this.Load += new System.EventHandler(this.frmDevolution_Load);
            this.Controls.SetChildIndex(this.dgvDevolution, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultPres;
        private System.Windows.Forms.TextBox txtLoanCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDevolution;
    }
}