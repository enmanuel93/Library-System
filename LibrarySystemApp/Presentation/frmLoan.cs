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
    public partial class frmLoan : FormController
    {
        public readonly IWrapperRepository wrapperRepository;

        public frmLoan()
        {
            InitializeComponent();

            wrapperRepository = new WrapperRepository();
        }

        private void frmLoan_Load(object sender, EventArgs e)
        {
            dgvLoan.DataSource = wrapperRepository.LoanRepository.ShowBooksLoans();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.LoanRepository.FindBookLoanById(id);

                    if (model != null)
                    {
                        dgvLoan.DataSource = model;
                    }
                    else
                    {
                        MessageBox.Show("Loan not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnConsultStudent_Click(object sender, EventArgs e)
        {
            frmConsultStudent _frmConsultStudent = new frmConsultStudent();
            _frmConsultStudent.ShowDialog();

            if (_frmConsultStudent.DialogResult == DialogResult.OK)
            {
                txtStudentCode.Text = _frmConsultStudent.dgvCommon.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnConsultBook_Click(object sender, EventArgs e)
        {
            frmConsultBook _frmConsultBook = new frmConsultBook();
            _frmConsultBook.ShowDialog();

            if (_frmConsultBook.DialogResult == DialogResult.OK)
            {
                txtBookCode.Text = _frmConsultBook.dgvCommon.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text)
                   && !string.IsNullOrWhiteSpace(txtStudentCode.Text)
                   && !string.IsNullOrWhiteSpace(txtBookCode.Text))
                {
                    var model = wrapperRepository.LoanRepository.GetAll(x => x.LoanCode == txtId.Text && x.Deleted == false).FirstOrDefault();

                    if (model == null)
                    {
                        int studentId = GetStudentId(txtStudentCode.Text);
                        int boodkId = GetBookId(txtBookCode.Text);

                        var loan = new Loan()
                        {
                            LoanCode = txtId.Text,
                            StudentId = studentId,
                            BookId = boodkId,
                            Status = "A",
                            Deleted = false,
                            CreationDate = DateTimeOffset.Now,
                            ModificationDate = null,
                        };

                        var result = wrapperRepository.LoanRepository.Create(loan);
                        Clear();
                        MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There is already a Loan with the same id!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    var model = wrapperRepository.LoanRepository.GetAll(x => x.LoanCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to update the registry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.StudentId = GetStudentId(txtStudentCode.Text);
                            model.BookId = GetBookId(txtBookCode.Text);
                            model.ModificationDate = DateTimeOffset.Now;

                            var result = wrapperRepository.LoanRepository.Update(model);

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
                        MessageBox.Show("Loan not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    var model = wrapperRepository.LoanRepository.GetAll(x => x.LoanCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to delete the registry?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Status = "I";
                            model.Deleted = true;

                            var result = wrapperRepository.LoanRepository.Delete(model);

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
                        MessageBox.Show("Loan not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string loanId = dgvLoan.SelectedRows[0].Cells[0].Value.ToString();
            var loan = wrapperRepository.LoanRepository.FindById(x => x.LoanCode == loanId).FirstOrDefault();

            txtId.Text = loanId;
            txtStudentCode.Text = wrapperRepository.StudentRepository.FindById(x => x.Id == loan.StudentId).FirstOrDefault().StudentCode;
            txtBookCode.Text = wrapperRepository.BookRepository.FindById(x => x.Id == loan.BookId).FirstOrDefault().BookCode;
        }

        #region METHODS
        public int GetStudentId(string studentId) => wrapperRepository.StudentRepository.FindById(x => x.StudentCode == studentId).FirstOrDefault().Id;

        public int GetBookId(string bookId) => wrapperRepository.BookRepository.FindById(x => x.BookCode == bookId).FirstOrDefault().Id;

        public override void Clear()
        {
            txtId.Clear();
            txtBookCode.Clear();
            txtStudentCode.Clear();
            dgvLoan.DataSource = wrapperRepository.LoanRepository.ShowBooksLoans();
        }

        #endregion
    }
}
