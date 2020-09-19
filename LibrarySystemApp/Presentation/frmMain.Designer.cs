namespace LibrarySystemApp.Presentation
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDevolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consutBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultEditorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolutionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.devolutionToolStripMenuItem,
            this.loansToolStripMenuItem,
            this.consultsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.configurationToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_ajustes_50;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // singOutToolStripMenuItem
            // 
            this.singOutToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_salida_50;
            this.singOutToolStripMenuItem.Name = "singOutToolStripMenuItem";
            this.singOutToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.singOutToolStripMenuItem.Text = "Sing out";
            this.singOutToolStripMenuItem.Click += new System.EventHandler(this.singOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_apagar_50;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerUsersToolStripMenuItem,
            this.registerStudentToolStripMenuItem});
            this.usersToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_usuario_50;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // registerUsersToolStripMenuItem
            // 
            this.registerUsersToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_administrador_del_hombre_100;
            this.registerUsersToolStripMenuItem.Name = "registerUsersToolStripMenuItem";
            this.registerUsersToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.registerUsersToolStripMenuItem.Text = "Register User";
            this.registerUsersToolStripMenuItem.Click += new System.EventHandler(this.registerUsersToolStripMenuItem_Click);
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_estudiante_masculino_50;
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.registerStudentToolStripMenuItem.Text = "Register Student";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerBookToolStripMenuItem});
            this.booksToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_estante_de_libro_50;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // registerBookToolStripMenuItem
            // 
            this.registerBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.editorialToolStripMenuItem});
            this.registerBookToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_libros_50;
            this.registerBookToolStripMenuItem.Name = "registerBookToolStripMenuItem";
            this.registerBookToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.registerBookToolStripMenuItem.Text = "Register Book";
            this.registerBookToolStripMenuItem.Click += new System.EventHandler(this.registerBookToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_user_typing_using_typewriter_50;
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_blog_50;
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.editorialToolStripMenuItem.Text = "Editorial";
            this.editorialToolStripMenuItem.Click += new System.EventHandler(this.editorialToolStripMenuItem_Click);
            // 
            // devolutionToolStripMenuItem
            // 
            this.devolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerDevolutionToolStripMenuItem});
            this.devolutionToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_arriba_izquierda_50;
            this.devolutionToolStripMenuItem.Name = "devolutionToolStripMenuItem";
            this.devolutionToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.devolutionToolStripMenuItem.Text = "Devolution";
            // 
            // registerDevolutionToolStripMenuItem
            // 
            this.registerDevolutionToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_arriba_izquierda_50;
            this.registerDevolutionToolStripMenuItem.Name = "registerDevolutionToolStripMenuItem";
            this.registerDevolutionToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.registerDevolutionToolStripMenuItem.Text = "Register Devolution";
            this.registerDevolutionToolStripMenuItem.Click += new System.EventHandler(this.registerDevolutionToolStripMenuItem_Click);
            // 
            // loansToolStripMenuItem
            // 
            this.loansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerLoanToolStripMenuItem});
            this.loansToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_lectura_50;
            this.loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            this.loansToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.loansToolStripMenuItem.Text = "Loans";
            // 
            // registerLoanToolStripMenuItem
            // 
            this.registerLoanToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_lectura_50;
            this.registerLoanToolStripMenuItem.Name = "registerLoanToolStripMenuItem";
            this.registerLoanToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.registerLoanToolStripMenuItem.Text = "Register Loan";
            this.registerLoanToolStripMenuItem.Click += new System.EventHandler(this.registerLoanToolStripMenuItem_Click);
            // 
            // consultsToolStripMenuItem
            // 
            this.consultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consutBooksToolStripMenuItem,
            this.consultAuthorsToolStripMenuItem,
            this.consultEditorialsToolStripMenuItem,
            this.consultStudentsToolStripMenuItem,
            this.consultUsersToolStripMenuItem});
            this.consultsToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_ver_archivo_80;
            this.consultsToolStripMenuItem.Name = "consultsToolStripMenuItem";
            this.consultsToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.consultsToolStripMenuItem.Text = "Consults";
            // 
            // consutBooksToolStripMenuItem
            // 
            this.consutBooksToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_libros_501;
            this.consutBooksToolStripMenuItem.Name = "consutBooksToolStripMenuItem";
            this.consutBooksToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.consutBooksToolStripMenuItem.Text = "Consut Books";
            this.consutBooksToolStripMenuItem.Click += new System.EventHandler(this.consutBooksToolStripMenuItem_Click);
            // 
            // consultAuthorsToolStripMenuItem
            // 
            this.consultAuthorsToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_user_typing_using_typewriter_50;
            this.consultAuthorsToolStripMenuItem.Name = "consultAuthorsToolStripMenuItem";
            this.consultAuthorsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.consultAuthorsToolStripMenuItem.Text = "Consult Authors";
            this.consultAuthorsToolStripMenuItem.Click += new System.EventHandler(this.consultAuthorsToolStripMenuItem_Click);
            // 
            // consultEditorialsToolStripMenuItem
            // 
            this.consultEditorialsToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_blog_50;
            this.consultEditorialsToolStripMenuItem.Name = "consultEditorialsToolStripMenuItem";
            this.consultEditorialsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.consultEditorialsToolStripMenuItem.Text = "Consult Editorials";
            this.consultEditorialsToolStripMenuItem.Click += new System.EventHandler(this.consultEditorialsToolStripMenuItem_Click);
            // 
            // consultStudentsToolStripMenuItem
            // 
            this.consultStudentsToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_estudiante_masculino_50;
            this.consultStudentsToolStripMenuItem.Name = "consultStudentsToolStripMenuItem";
            this.consultStudentsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.consultStudentsToolStripMenuItem.Text = "Consult Students";
            this.consultStudentsToolStripMenuItem.Click += new System.EventHandler(this.consultStudentsToolStripMenuItem_Click);
            // 
            // consultUsersToolStripMenuItem
            // 
            this.consultUsersToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_grupo_de_usuarios_hombre_hombre_501;
            this.consultUsersToolStripMenuItem.Name = "consultUsersToolStripMenuItem";
            this.consultUsersToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.consultUsersToolStripMenuItem.Text = "Consult Users";
            this.consultUsersToolStripMenuItem.Click += new System.EventHandler(this.consultUsersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.loanToolStripMenuItem,
            this.devolutionToolStripMenuItem1});
            this.reportsToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_print_100_2;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_estudiante_masculino_50;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_libros_50;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Image = global::LibrarySystemApp.Properties.Resources.icons8_lectura_50;
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.loanToolStripMenuItem.Text = "Loan";
            this.loanToolStripMenuItem.Click += new System.EventHandler(this.loanToolStripMenuItem_Click);
            // 
            // devolutionToolStripMenuItem1
            // 
            this.devolutionToolStripMenuItem1.Image = global::LibrarySystemApp.Properties.Resources.icons8_arriba_izquierda_50;
            this.devolutionToolStripMenuItem1.Name = "devolutionToolStripMenuItem1";
            this.devolutionToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.devolutionToolStripMenuItem1.Text = "Devolution";
            this.devolutionToolStripMenuItem1.Click += new System.EventHandler(this.devolutionToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 586);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "LIBRARY SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerDevolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consutBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultEditorialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultStudentsToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem registerUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem consultUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolutionToolStripMenuItem1;
    }
}