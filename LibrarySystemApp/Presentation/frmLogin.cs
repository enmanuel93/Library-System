using Domain.Interfaces;
using Infraestructure.Helpers;
using Infraestructure.Repositories;
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
    public partial class frmLogin : Form
    {
        public readonly IWrapperRepository wapperRepository;

        public frmLogin()
        {
            InitializeComponent();

            wapperRepository = new WrapperRepository();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                string encryptedPass = Encrypt.GetSHA256(txtPassword.Text);

                var model = wapperRepository.UserRepository.GetAll(x => x.UserName == txtUserName.Text && x.Password == encryptedPass && x.Deleted == false).FirstOrDefault();

                if (model != null)
                {
                    frmMain _frmMain = new frmMain();
                    _frmMain.Show();
                    this.Hide();

                    if (model.Rol == false)
                    {
                        _frmMain.registerUsersToolStripMenuItem.Visible = false;
                        _frmMain.consultUsersToolStripMenuItem.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Clear();
                    txtUserName.Clear();
                }
            }
            else
            {
                MessageBox.Show("Empty fields are not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
