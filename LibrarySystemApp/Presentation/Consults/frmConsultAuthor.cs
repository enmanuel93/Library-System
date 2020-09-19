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
    public partial class frmConsultAuthor : FormConsultController
    {
        public frmConsultAuthor()
        {
            InitializeComponent();
        }
        private void frmConsultAuthor_Load(object sender, EventArgs e)
        {
            FillDgvGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!IsTxtFilterEmpty)
            {
                List<Author> authors = wrapperRepository.AuthorRepository.FindById(x => x.AuthorCode == txtFilter.Text && x.Deleted == false);
                dgvCommon.DataSource = wrapperRepository.AuthorRepository.ShowAuthors(authors);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillDgvGrid();
        }

        public void FillDgvGrid()
        {
            List<Author> authors = wrapperRepository.AuthorRepository.GetAll(x => x.Deleted == false).ToList();
            dgvCommon.DataSource = wrapperRepository.AuthorRepository.ShowAuthors(authors);
        }
    }
}
