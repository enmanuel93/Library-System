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
    public partial class frmConsultBook : FormConsultController
    {
        public frmConsultBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!IsTxtFilterEmpty) { }
                dgvCommon.DataSource = wrapperRepository.BookRepository.ShowBookByID(txtFilter.Text);
        }

        private void frmConsultBook_Load(object sender, EventArgs e)
        {
            dgvCommon.DataSource = wrapperRepository.BookRepository.ShowBooks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvCommon.DataSource = wrapperRepository.BookRepository.ShowBooks();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }
    }
}
