using LibrarySystemApp.Presentation.Consults;
using LibrarySystemApp.Presentation.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp.Presentation
{
    public partial class frmMain : Form
    {
        private FormConsultController formConsultController;

        public frmMain()
        {
            InitializeComponent();

            formConsultController = new FormConsultController();
        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registerUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmRegister.MdiParent = this;
            Singleton.FrmRegister.Show();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmStudent.MdiParent = this;
            Singleton.FrmStudent.Show();
        }

        private void registerBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmBook.MdiParent = this;
            Singleton.FrmBook.Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmAuthor.MdiParent = this;
            Singleton.FrmAuthor.Show();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmEditorial.MdiParent = this;
            Singleton.FrmEditorial.Show();
        }

        private void registerDevolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmDevolution.MdiParent = this;
            Singleton.FrmDevolution.Show();
        }

        private void registerLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmLoan.MdiParent = this;
            Singleton.FrmLoan.Show();
        }

        private void consutBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmConsultBook.MdiParent = this;
            Singleton.FrmConsultBook.Show();
            Singleton.FrmConsultBook.btnSelect.Visible = false;

        }

        private void consultAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmConsultAuthor.MdiParent = this;
            Singleton.FrmConsultAuthor.Show();
            Singleton.FrmConsultAuthor.btnSelect.Visible = false;

        }

        private void consultEditorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmConsultEditorial.MdiParent = this;
            Singleton.FrmConsultEditorial.Show();
            Singleton.FrmConsultEditorial.btnSelect.Visible = false;

        }

        private void consultStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmConsultStudent.MdiParent = this;
            Singleton.FrmConsultStudent.Show();
            Singleton.FrmConsultStudent.btnSelect.Visible = false;

        }

        private void consultUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.FrmConsultUsers.MdiParent = this;
            Singleton.FrmConsultUsers.Show();
            Singleton.FrmConsultUsers.btnSelect.Visible = false;

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentReport studentReport = new frmStudentReport();
            studentReport.ShowDialog();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookReport bookReport = new frmBookReport();
            bookReport.ShowDialog();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanReport loanReport = new frmLoanReport();
            loanReport.ShowDialog();
        }

        private void devolutionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDevolutionReport devolutionReport = new frmDevolutionReport();
            devolutionReport.ShowDialog();
        }
    }

    #region SINGLETON PATTERN
    public class Singleton
    {
        private static frmBook frmBook = null;
        private static frmEditorial frmEditorial = null;
        private static frmDevolution frmDevolution = null;
        private static frmLoan frmLoan = null;
        private static frmStudent frmStudent = null;
        private static frmAuthor frmAuthor = null;
        private static frmRegister frmRegister = null;

        private static frmConsultAuthor frmConsultAuthor = null;
        private static frmConsultBook frmConsultBook = null;
        private static frmConsultEditorial frmConsultEditorial = null;
        private static frmConsultLoan frmConsultLoan = null;
        private static frmConsultStudent frmConsultStudent = null;
        private static frmConsultUsers frmConsultUsers = null;

        #region Maintenance Forms
        public static frmBook FrmBook
        {
            get
            {
                if (frmBook == null || frmBook.IsDisposed == true)
                    frmBook = new frmBook();
                return frmBook;
            }
        }

        public static frmEditorial FrmEditorial
        {
            get
            {
                if (frmEditorial == null || frmEditorial.IsDisposed == true)
                    frmEditorial = new frmEditorial();
                return frmEditorial;
            }
        }

        public static frmDevolution FrmDevolution
        {
            get
            {
                if (frmDevolution == null || frmDevolution.IsDisposed == true)
                    frmDevolution = new frmDevolution();
                return frmDevolution;
            }
        }

        public static frmLoan FrmLoan
        {
            get
            {
                if (frmLoan == null || frmLoan.IsDisposed == true)
                    frmLoan = new frmLoan();
                return frmLoan;
            }
        }

        public static frmStudent FrmStudent
        {
            get
            {
                if (frmStudent == null || frmStudent.IsDisposed == true)
                    frmStudent = new frmStudent();
                return frmStudent;
            }
        }

        public static frmAuthor FrmAuthor
        {
            get
            {
                if (frmAuthor == null || frmAuthor.IsDisposed == true)
                    frmAuthor = new frmAuthor();
                return frmAuthor;
            }
        }

        public static frmRegister FrmRegister
        {
            get
            {
                if (frmRegister == null || frmRegister.IsDisposed == true)
                    frmRegister = new frmRegister();
                return frmRegister;
            }
        }

        #endregion

        #region Consults Forms
        public static frmConsultAuthor FrmConsultAuthor
        {
            get
            {
                if (frmConsultAuthor == null || frmConsultAuthor.IsDisposed == true)
                    frmConsultAuthor = new frmConsultAuthor();
                return frmConsultAuthor;
            }
        }

        public static frmConsultBook FrmConsultBook
        {
            get
            {
                if (frmConsultBook == null || frmConsultBook.IsDisposed == true)
                    frmConsultBook = new frmConsultBook();
                return frmConsultBook;
            }
        }

        public static frmConsultEditorial FrmConsultEditorial
        {
            get
            {
                if (frmConsultEditorial == null || frmConsultEditorial.IsDisposed == true)
                    frmConsultEditorial = new frmConsultEditorial();
                return frmConsultEditorial;
            }
        }

        public static frmConsultLoan FrmConsultLoan
        {
            get
            {
                if (frmConsultLoan == null || frmConsultLoan.IsDisposed == true)
                    frmConsultLoan = new frmConsultLoan();
                return frmConsultLoan;
            }
        }

        public static frmConsultStudent FrmConsultStudent
        {
            get
            {
                if (frmConsultStudent == null || frmConsultStudent.IsDisposed == true)
                    frmConsultStudent = new frmConsultStudent();
                return frmConsultStudent;
            }
        }

        public static frmConsultUsers FrmConsultUsers
        {
            get
            {
                if (frmConsultUsers == null || frmConsultUsers.IsDisposed == true)
                    frmConsultUsers = new frmConsultUsers();
                return frmConsultUsers;
            }
        }

        #endregion
    }
    #endregion
}
