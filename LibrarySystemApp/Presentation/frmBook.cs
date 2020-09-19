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
    public partial class frmBook : FormController
    {
        public readonly IWrapperRepository wrapperRepository;

        public frmBook()
        {
            InitializeComponent();

            wrapperRepository = new WrapperRepository();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource = wrapperRepository.BookRepository.ShowBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.BookRepository.ShowBookByID(id);

                    if (model != null)
                    {
                        dgvBook.DataSource = model;
                    }
                    else
                    {
                        MessageBox.Show("Book not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnConsultAuthor_Click(object sender, EventArgs e)
        {
            frmConsultAuthor _frmConsultAuthor = new frmConsultAuthor();
            _frmConsultAuthor.ShowDialog();

            if (_frmConsultAuthor.DialogResult == DialogResult.OK)
            {
                txtAuthorCode.Text = _frmConsultAuthor.dgvCommon.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnConsultEditorial_Click(object sender, EventArgs e)
        {
            frmConsultEditorial _frmConsultEditorial = new frmConsultEditorial();
            _frmConsultEditorial.ShowDialog();

            if (_frmConsultEditorial.DialogResult == DialogResult.OK)
            {
                txtEditorialCode.Text = _frmConsultEditorial.dgvCommon.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text)
                   && !string.IsNullOrWhiteSpace(txtId.Text)
                   && !string.IsNullOrWhiteSpace(txtEditorialCode.Text)
                   && !string.IsNullOrWhiteSpace(txtAuthorCode.Text))
                {
                    var model = wrapperRepository.BookRepository.GetAll(x => x.BookCode == txtId.Text && x.Deleted == false).FirstOrDefault();

                    if (model == null)
                    {
                        int authorId = GetAuthorlId(txtAuthorCode.Text);
                        int editorialId = GetEditorialId(txtEditorialCode.Text);

                        var book = new Book()
                        {
                            BookCode = txtId.Text,
                            Name = txtName.Text,
                            AuthorId = authorId,
                            EditorialId = editorialId,
                            Status = "A",
                            Deleted = false,
                            CreationDate = DateTimeOffset.Now,
                            ModificationDate = null,
                        };

                        var result = wrapperRepository.BookRepository.Create(book);
                        Clear();
                        MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There is already a Book with the same id!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    var model = wrapperRepository.BookRepository.GetAll(x => x.BookCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to update the registry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Name = txtName.Text;
                            model.EditorialId = GetEditorialId(txtEditorialCode.Text);
                            model.AuthorId = GetAuthorlId(txtAuthorCode.Text);
                            model.ModificationDate = DateTimeOffset.Now;

                            var result = wrapperRepository.BookRepository.Update(model);

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
                        MessageBox.Show("Book not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    var model = wrapperRepository.BookRepository.GetAll(x => x.BookCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to delete the registry?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Status = "I";
                            model.Deleted = true;

                            var result = wrapperRepository.BookRepository.Delete(model);

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
                        MessageBox.Show("Book not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookId = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
            var book = wrapperRepository.BookRepository.FindById(x => x.BookCode == bookId).FirstOrDefault();

            txtId.Text = bookId;
            txtAuthorCode.Text = wrapperRepository.AuthorRepository.FindById(x => x.Id == book.AuthorId).FirstOrDefault().AuthorCode;
            txtEditorialCode.Text = wrapperRepository.EditorialRepository.FindById(x => x.Id == book.EditorialId).FirstOrDefault().EditorialId;
            txtName.Text = dgvBook.SelectedRows[0].Cells[3].Value.ToString();
        }

        #region METHODS
        public int GetEditorialId(string editorialId) => wrapperRepository.EditorialRepository.FindById(x => x.EditorialId == editorialId).FirstOrDefault().Id;

        public int GetAuthorlId(string authorId) => wrapperRepository.AuthorRepository.FindById(x => x.AuthorCode == authorId).FirstOrDefault().Id;

        public override void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtAuthorCode.Clear();
            txtEditorialCode.Clear();
            dgvBook.DataSource = wrapperRepository.BookRepository.ShowBooks();
        }

        #endregion
    }
}
