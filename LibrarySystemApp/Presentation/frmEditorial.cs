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
    public partial class frmEditorial : FormController
    {
        public readonly IWrapperRepository wrapperRepository;

        public frmEditorial()
        {
            InitializeComponent();

            wrapperRepository = new WrapperRepository();
        }

        private void frmEditorial_Load(object sender, EventArgs e)
        {
            List<Editorial> editorials = wrapperRepository.EditorialRepository.GetAll(x => x.Deleted == false).ToList();
            dgvEditorial.DataSource = wrapperRepository.EditorialRepository.ShowEditorials(editorials);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.EditorialRepository.GetAll(x => x.EditorialId == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        List<Editorial> editorials = new List<Editorial>();
                        editorials.Add(model);
                        dgvEditorial.DataSource = wrapperRepository.EditorialRepository.ShowEditorials(editorials);
                    }
                    else
                    {
                        MessageBox.Show("Editorial not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                   && !string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    var model = wrapperRepository.EditorialRepository.GetAll(x => x.EditorialId == txtId.Text && x.Deleted == false).FirstOrDefault();

                    if (model == null)
                    {
                        var editorial = new Editorial()
                        {
                            EditorialId = txtId.Text,
                            Name = txtName.Text,
                            Address = txtAddress.Text,
                            Status = "A",
                            Deleted = false,
                            CreationDate = DateTimeOffset.Now,
                            ModificationDate = null,
                        };

                        var result = wrapperRepository.EditorialRepository.Create(editorial);
                        Clear();
                        MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There is already a Editorial with the same id!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    var model = wrapperRepository.EditorialRepository.GetAll(x => x.EditorialId == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to update the registry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Name = txtName.Text;
                            model.Address = txtAddress.Text;
                            model.ModificationDate = DateTimeOffset.Now;

                            var result = wrapperRepository.EditorialRepository.Update(model);

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
                        MessageBox.Show("Editorial not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    var model = wrapperRepository.EditorialRepository.GetAll(x => x.EditorialId == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to delete the registry?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Status = "I";
                            model.Deleted = true;

                            var result = wrapperRepository.EditorialRepository.Delete(model);

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
                        MessageBox.Show("Editorial not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvEditorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvEditorial.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvEditorial.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dgvEditorial.SelectedRows[0].Cells[2].Value.ToString();
        }

        #region METHODS
        public override void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            List<Editorial> editorials = wrapperRepository.EditorialRepository.GetAll(x => x.Deleted == false).ToList();
            dgvEditorial.DataSource = wrapperRepository.EditorialRepository.ShowEditorials(editorials);
        }

        #endregion
    }
}
