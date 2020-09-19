namespace LibrarySystemApp.Presentation
{
    partial class frmBook
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
            this.btnConsultEditorial = new System.Windows.Forms.Button();
            this.btnConsultAuthor = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEditorialCode = new System.Windows.Forms.TextBox();
            this.txtAuthorCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new System.Drawing.Point(726, 476);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(638, 476);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Location = new System.Drawing.Point(547, 476);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(466, 476);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultEditorial);
            this.groupBox1.Controls.Add(this.btnConsultAuthor);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtEditorialCode);
            this.groupBox1.Controls.Add(this.txtAuthorCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Size = new System.Drawing.Size(753, 193);
            this.groupBox1.Controls.SetChildIndex(this.btnSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtId, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtAuthorCode, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEditorialCode, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtName, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnConsultAuthor, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnConsultEditorial, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(213, 27);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(98, 35);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(71, 35);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Location = new System.Drawing.Point(24, 476);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConsultEditorial
            // 
            this.btnConsultEditorial.BackgroundImage = global::LibrarySystemApp.Properties.Resources.icons8_ver_archivo_80;
            this.btnConsultEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultEditorial.FlatAppearance.BorderSize = 0;
            this.btnConsultEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultEditorial.Location = new System.Drawing.Point(270, 106);
            this.btnConsultEditorial.Name = "btnConsultEditorial";
            this.btnConsultEditorial.Size = new System.Drawing.Size(30, 26);
            this.btnConsultEditorial.TabIndex = 12;
            this.btnConsultEditorial.UseVisualStyleBackColor = true;
            this.btnConsultEditorial.Click += new System.EventHandler(this.btnConsultEditorial_Click);
            // 
            // btnConsultAuthor
            // 
            this.btnConsultAuthor.BackgroundImage = global::LibrarySystemApp.Properties.Resources.icons8_ver_archivo_80;
            this.btnConsultAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultAuthor.FlatAppearance.BorderSize = 0;
            this.btnConsultAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultAuthor.Location = new System.Drawing.Point(270, 67);
            this.btnConsultAuthor.Name = "btnConsultAuthor";
            this.btnConsultAuthor.Size = new System.Drawing.Size(30, 26);
            this.btnConsultAuthor.TabIndex = 10;
            this.btnConsultAuthor.UseVisualStyleBackColor = true;
            this.btnConsultAuthor.Click += new System.EventHandler(this.btnConsultAuthor_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtEditorialCode
            // 
            this.txtEditorialCode.Location = new System.Drawing.Point(98, 108);
            this.txtEditorialCode.Name = "txtEditorialCode";
            this.txtEditorialCode.ReadOnly = true;
            this.txtEditorialCode.Size = new System.Drawing.Size(166, 20);
            this.txtEditorialCode.TabIndex = 11;
            // 
            // txtAuthorCode
            // 
            this.txtAuthorCode.Location = new System.Drawing.Point(98, 72);
            this.txtAuthorCode.Name = "txtAuthorCode";
            this.txtAuthorCode.ReadOnly = true;
            this.txtAuthorCode.Size = new System.Drawing.Size(166, 20);
            this.txtAuthorCode.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Editorial Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Author Code:";
            // 
            // dgvBook
            // 
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(24, 243);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(752, 197);
            this.dgvBook.TabIndex = 16;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.dgvBook);
            this.Name = "frmBook";
            this.Text = "BOOK";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.dgvBook, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultEditorial;
        private System.Windows.Forms.Button btnConsultAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEditorialCode;
        private System.Windows.Forms.TextBox txtAuthorCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBook;
    }
}