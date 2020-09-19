using Domain.Interfaces;
using Domain.Models;
using Infraestructure.Repositories;
using LibrarySystemApp.Presentation.Consults;
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
    public partial class frmDevolution : FormController
    {
        public readonly IWrapperRepository wrapperRepository;

        public frmDevolution()
        {
            InitializeComponent();

            wrapperRepository = new WrapperRepository();
        }

        private void frmDevolution_Load(object sender, EventArgs e)
        {
            List<Devolution> devolutions = wrapperRepository.DevolutionRepository.GetAll(x => x.Deleted == false).ToList();
            dgvDevolution.DataSource = wrapperRepository.DevolutionRepository.ShowDelvolutions(devolutions);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.DevolutionRepository.GetAll(x => x.DevolutionCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        List<Devolution> devolutions = new List<Devolution>();
                        devolutions.Add(model);
                        dgvDevolution.DataSource = wrapperRepository.DevolutionRepository.ShowDelvolutions(devolutions);
                    }
                    else
                    {
                        MessageBox.Show("Devolution not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You must enter an ID!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultPres_Click(object sender, EventArgs e)
        {
            frmConsultLoan _frmConsultLoan = new frmConsultLoan();
            _frmConsultLoan.ShowDialog();

            if (_frmConsultLoan.DialogResult == DialogResult.OK)
            {                
                txtLoanCode.Text = _frmConsultLoan.dgvCommon.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text)
                   && !string.IsNullOrWhiteSpace(txtLoanCode.Text))
                {
                    var model = wrapperRepository.DevolutionRepository.GetAll(x => x.DevolutionCode == txtId.Text && x.Deleted == false).FirstOrDefault();

                    if (model == null)
                    {
                        int loanId = GetLoanId(txtLoanCode.Text);

                        var devolution = new Devolution()
                        {
                            DevolutionCode = txtId.Text,
                            LoanId = loanId,
                            Status = "A",
                            Deleted = false,
                            CreationDate = DateTimeOffset.Now,
                            ModificationDate = null,
                        };

                        var result = wrapperRepository.DevolutionRepository.Create(devolution);
                        Clear();
                        MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There is already a Devolution with the same id!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("You must fill in all fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.DevolutionRepository.GetAll(x => x.DevolutionCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to update the registry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.DevolutionCode = txtId.Text;
                            model.LoanId = GetLoanId(txtLoanCode.Text);
                            model.ModificationDate = DateTimeOffset.Now;

                            var result = wrapperRepository.DevolutionRepository.Update(model);

                            if (result.Result)
                            {
                                Clear();
                                MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Devolution not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You must enter an ID!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.DevolutionRepository.GetAll(x => x.DevolutionCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to delete the registry?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Status = "I";
                            model.Deleted = true;

                            var result = wrapperRepository.DevolutionRepository.Delete(model);

                            if (result.Result)
                            {
                                Clear();
                                MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Devolution not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You must enter an ID!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvDevolution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string devoId = dgvDevolution.SelectedRows[0].Cells[0].Value.ToString();
            var devolution = wrapperRepository.DevolutionRepository.FindById(x => x.DevolutionCode == devoId).FirstOrDefault();

            txtId.Text = devoId;
            txtLoanCode.Text = wrapperRepository.LoanRepository.FindById(x => x.Id == devolution.LoanId).FirstOrDefault().LoanCode;
        }

        #region METHODS
        public int GetLoanId(string loanId) => wrapperRepository.LoanRepository.FindById(x => x.LoanCode == loanId).FirstOrDefault().Id;

        public override void Clear()
        {
            txtId.Clear();
            txtLoanCode.Clear();
            List<Devolution> devolutions = wrapperRepository.DevolutionRepository.GetAll(x => x.Deleted == false).ToList();
            dgvDevolution.DataSource = wrapperRepository.DevolutionRepository.ShowDelvolutions(devolutions);
        }

        #endregion
    }
}
