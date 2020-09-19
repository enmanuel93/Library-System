using Domain.Interfaces;
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

namespace LibrarySystemApp.Presentation.Consults
{
    public partial class FormConsultController : Form
    {
        public readonly IWrapperRepository wrapperRepository;

        protected bool IsTxtFilterEmpty = true;

        public FormConsultController()
        {
            InitializeComponent();

            wrapperRepository = new WrapperRepository();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void Clear()
        {
            txtFilter.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvCommon.Rows.Count == 0)
            {
                MessageBox.Show("There is not row selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgvCommon.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                IsTxtFilterEmpty = false;
            }
            else
            {
                MessageBox.Show("You must enter an ID!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
