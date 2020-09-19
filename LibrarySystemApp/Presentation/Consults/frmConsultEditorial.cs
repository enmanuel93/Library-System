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
    public partial class frmConsultEditorial : FormConsultController
    {
        public frmConsultEditorial()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!IsTxtFilterEmpty)
            {
                List<Editorial> editorials = wrapperRepository.EditorialRepository.FindById(x => x.EditorialId == txtFilter.Text && x.Deleted == false);
                dgvCommon.DataSource = wrapperRepository.EditorialRepository.ShowEditorials(editorials);
            }
        }

        private void frmConsultEditorial_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            List<Editorial> editorials = wrapperRepository.EditorialRepository.GetAll(x => x.Deleted == false).ToList();
            dgvCommon.DataSource = wrapperRepository.EditorialRepository.ShowEditorials(editorials);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }
    }
}
