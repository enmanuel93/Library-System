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
    public partial class frmConsultLoan : FormConsultController
    {
        public frmConsultLoan()
        {
            InitializeComponent();
        }

        private void frmConsultLoan_Load(object sender, EventArgs e)
        {
            dgvCommon.DataSource = wrapperRepository.LoanRepository.ShowBooksLoans();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!IsTxtFilterEmpty)
                dgvCommon.DataSource = wrapperRepository.LoanRepository.FindBookLoanById(txtFilter.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvCommon.DataSource = wrapperRepository.LoanRepository.ShowBooksLoans();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }
    }
}
