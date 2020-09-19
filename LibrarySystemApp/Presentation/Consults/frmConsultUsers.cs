using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp.Presentation.Consults
{
    public partial class frmConsultUsers : FormConsultController
    {
        public frmConsultUsers()
        {
            InitializeComponent();
        }

        private void frmConsultUsers_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!IsTxtFilterEmpty)
            {
                List<Users> users = wrapperRepository.UserRepository.FindById(x => x.UserId == txtFilter.Text && x.Deleted == false);
                dgvCommon.DataSource = wrapperRepository.UserRepository.ShowUsers(users);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            List<Users> users = wrapperRepository.UserRepository.GetAll(x => x.Deleted == false).ToList();
            dgvCommon.DataSource = wrapperRepository.UserRepository.ShowUsers(users);
        }
    }
}
