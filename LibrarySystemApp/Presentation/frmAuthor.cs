using Domain.Interfaces;
using Domain.Models;
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
    public partial class frmAuthor : FormController
    {
        public readonly IWrapperRepository wrapperRepository;

        public frmAuthor()
        {
            InitializeComponent();

            wrapperRepository = new WrapperRepository();
        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {
            List<Author> authors = wrapperRepository.AuthorRepository.GetAll(x => x.Deleted == false).ToList();
            dgvAuthor.DataSource = wrapperRepository.AuthorRepository.ShowAuthors(authors);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.AuthorRepository.GetAll(x => x.AuthorCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        List<Author> authors = new List<Author>();
                        authors.Add(model);
                        dgvAuthor.DataSource = wrapperRepository.AuthorRepository.ShowAuthors(authors);
                    }
                    else
                    {
                        MessageBox.Show("Author not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text)
                   && !string.IsNullOrWhiteSpace(txtId.Text)
                   && !string.IsNullOrWhiteSpace(txtLastName.Text)
                   && !string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    var model = wrapperRepository.AuthorRepository.GetAll(x => x.AuthorCode == txtId.Text && x.Deleted == false).FirstOrDefault();

                    if (model == null)
                    {
                        var author = new Author()
                        {
                            AuthorCode = txtId.Text,
                            Name = txtName.Text,
                            LastName = txtLastName.Text,
                            Nationality = txtNationality.Text,
                            Status = "A",
                            Deleted = false,
                            CreationDate = DateTimeOffset.Now,
                            ModificationDate = null,
                        };

                        var result = wrapperRepository.AuthorRepository.Create(author);
                        Clear();
                        MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There is already a Author with the same id!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    var model = wrapperRepository.AuthorRepository.GetAll(x => x.AuthorCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to update the registry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Name = txtName.Text;
                            model.LastName = txtLastName.Text;
                            model.Nationality = txtNationality.Text;
                            model.ModificationDate = DateTimeOffset.Now;

                            var result = wrapperRepository.AuthorRepository.Update(model);

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
                        MessageBox.Show("Author not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    var model = wrapperRepository.AuthorRepository.GetAll(x => x.AuthorCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to delete the registry?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Status = "I";
                            model.Deleted = true;

                            var result = wrapperRepository.AuthorRepository.Delete(model);

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
                        MessageBox.Show("Author not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvAuthor.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvAuthor.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dgvAuthor.SelectedRows[0].Cells[2].Value.ToString();
            txtNationality.Text = dgvAuthor.SelectedRows[0].Cells[3].Value.ToString();
        }

        #region METHODS
        public override void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtNationality.Clear();
            List<Author> authors = wrapperRepository.AuthorRepository.GetAll(x => x.Deleted == false).ToList();
            dgvAuthor.DataSource = wrapperRepository.AuthorRepository.ShowAuthors(authors);
        }

        #endregion
    }
}
