using Domain.Interfaces;
using Domain.Models;
using Infraestructure.Helpers;
using Infraestructure.Repositories;
using LibrarySystemApp.Validations;
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
    public partial class frmRegister : FormController
    {
        public readonly IWrapperRepository wrapperRepository;
        bool isIdLengthRight = true;

        public frmRegister()
        {
            InitializeComponent();

            wrapperRepository = new WrapperRepository();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            List<Users> users = wrapperRepository.UserRepository.GetAll(x => x.Deleted == false).ToList();

            dgvUsers.DataSource = wrapperRepository.UserRepository.ShowUsers(users);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePassword(txtPassword.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txtName.Text)
                       && !string.IsNullOrWhiteSpace(txtId.Text)
                       && !string.IsNullOrWhiteSpace(txtLastName.Text)
                       && !string.IsNullOrWhiteSpace(txtPassword.Text)
                       && !string.IsNullOrWhiteSpace(txtUserName.Text))
                    {
                        var model = wrapperRepository.UserRepository.GetAll(x => x.UserId == txtId.Text && x.Deleted == false).FirstOrDefault();

                        if (model == null)
                        {
                            var user = new Users()
                            {
                                UserId = txtId.Text,
                                Name = txtName.Text,
                                LastName = txtLastName.Text,
                                UserName = txtUserName.Text,
                                Password = Encrypt.GetSHA256(txtPassword.Text),
                                Rol = chckRol.Checked,
                                Status = "A",
                                Deleted = false,
                                CreationDate = DateTimeOffset.Now,
                                ModificationDate = null,
                            };

                            var result = wrapperRepository.UserRepository.Create(user);
                            Clear();
                            MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("There is already a user with the same id!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("You must fill in all fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.SelectedRows[0].Cells[2].Value.ToString();
            txtUserName.Text = dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
            chckRol.Checked = Convert.ToBoolean(dgvUsers.SelectedRows[0].Cells[4].Value);

            chckRol.Text = ChangeTextCheckBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePassword(txtPassword.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txtId.Text)
                        && !string.IsNullOrWhiteSpace(txtPassword.Text)
                        && !string.IsNullOrWhiteSpace(txtUserName.Text))
                    {
                        string id = txtId.Text;

                        var model = wrapperRepository.UserRepository.GetAll(x => x.UserId == id && x.Deleted == false).FirstOrDefault();

                        if (model != null)
                        {
                            DialogResult DResult = MessageBox.Show("Do you want to update the registry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (DialogResult.Yes == DResult)
                            {
                                model.Name = txtName.Text;
                                model.LastName = txtLastName.Text;
                                model.Rol = chckRol.Checked;
                                model.UserName = txtUserName.Text;
                                model.Password = Encrypt.GetSHA256(txtPassword.Text);
                                model.ModificationDate = DateTimeOffset.Now;

                                var result = wrapperRepository.UserRepository.Update(model);

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
                            MessageBox.Show("User not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must fill in all fields!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    var model = wrapperRepository.UserRepository.GetAll(x => x.UserId == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to delete the registry?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Status = "I";
                            model.Deleted = true;

                            var result = wrapperRepository.UserRepository.Delete(model);

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
                        MessageBox.Show("User not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.UserRepository.GetAll(x => x.UserId == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        List<Users> users = new List<Users>();
                        users.Add(model);
                        dgvUsers.DataSource = wrapperRepository.UserRepository.ShowUsers(users);
                    }
                    else
                    {
                        MessageBox.Show("User not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void chckRol_Click(object sender, EventArgs e)
        {
            chckRol.Text = ChangeTextCheckBox();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FieldValidations.ValidateLetters(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FieldValidations.ValidateLetters(e);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isIdLengthRight)
                e.Handled = FieldValidations.ValidateNumbers(e);
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            int idlength = txtId.Text.Length;
            if (idlength == 11)
            {
                isIdLengthRight = false;
            }
            else
            {
                isIdLengthRight = true;
            }
        }

        #region METHODS
        private bool ValidatePassword(string pass) => pass == txtConfirmPassword.Text ? true : false;

        public string ChangeTextCheckBox() => (chckRol.Checked) ? "Admin" : "User";

        public override void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtUserName.Clear();
            txtLastName.Clear();
            chckRol.Checked = false;
            chckRol.Text = "User";
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            List<Users> users = wrapperRepository.UserRepository.GetAll(x => x.Deleted == false).ToList();
            dgvUsers.DataSource = wrapperRepository.UserRepository.ShowUsers(users);
        }

        #endregion
    }
}
