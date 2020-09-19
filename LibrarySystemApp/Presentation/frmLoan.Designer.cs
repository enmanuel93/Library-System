namespace LibrarySystemApp.Presentation
{
    partial class frmLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoan));
            this.btnConsultBook = new System.Windows.Forms.Button();
            this.btnConsultStudent = new System.Windows.Forms.Button();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLoan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new System.Drawing.Point(720, 423);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(633, 423);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Location = new System.Drawing.Point(543, 423);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(457, 423);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultBook);
            this.groupBox1.Controls.Add(this.btnConsultStudent);
            this.groupBox1.Controls.Add(this.txtBookCode);
            this.groupBox1.Controls.Add(this.txtStudentCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Size = new System.Drawing.Size(753, 165);
            this.groupBox1.Controls.SetChildIndex(this.btnSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtId, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtStudentCode, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtBookCode, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnConsultStudent, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnConsultBook, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(224, 27);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 35);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(71, 38);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Location = new System.Drawing.Point(18, 423);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConsultBook
            // 
            this.btnConsultBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultBook.BackgroundImage")));
            this.btnConsultBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultBook.FlatAppearance.BorderSize = 0;
            this.btnConsultBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultBook.Location = new System.Drawing.Point(335, 105);
            this.btnConsultBook.Name = "btnConsultBook";
            this.btnConsultBook.Size = new System.Drawing.Size(30, 26);
            this.btnConsultBook.TabIndex = 13;
            this.btnConsultBook.UseVisualStyleBackColor = true;
            this.btnConsultBook.Click += new System.EventHandler(this.btnConsultBook_Click);
            // 
            // btnConsultStudent
            // 
            this.btnConsultStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultStudent.BackgroundImage")));
            this.btnConsultStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultStudent.FlatAppearance.BorderSize = 0;
            this.btnConsultStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultStudent.Location = new System.Drawing.Point(334, 66);
            this.btnConsultStudent.Name = "btnConsultStudent";
            this.btnConsultStudent.Size = new System.Drawing.Size(30, 26);
            this.btnConsultStudent.TabIndex = 11;
            this.btnConsultStudent.UseVisualStyleBackColor = true;
            this.btnConsultStudent.Click += new System.EventHandler(this.btnConsultStudent_Click);
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(110, 106);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.ReadOnly = true;
            this.txtBookCode.Size = new System.Drawing.Size(219, 20);
            this.txtBookCode.TabIndex = 12;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(110, 70);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.ReadOnly = true;
            this.txtStudentCode.Size = new System.Drawing.Size(219, 20);
            this.txtStudentCode.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Book Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Student Code:";
            // 
            // dgvLoan
            // 
            this.dgvLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoan.Location = new System.Drawing.Point(18, 211);
            this.dgvLoan.Name = "dgvLoan";
            this.dgvLoan.ReadOnly = true;
            this.dgvLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoan.Size = new System.Drawing.Size(753, 180);
            this.dgvLoan.TabIndex = 16;
            this.dgvLoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoan_CellClick);
            // 
            // frmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.dgvLoan);
            this.Name = "frmLoan";
            this.Text = "LOAN";
            this.Load += new System.EventHandler(this.frmLoan_Load);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.dgvLoan, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultBook;
        private System.Windows.Forms.Button btnConsultStudent;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLoan;
    }
}