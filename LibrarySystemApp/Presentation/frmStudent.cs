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
    public partial class frmStudent : FormController
    {
        public readonly IWrapperRepository wrapperRepository;

        public frmStudent()
        {
            InitializeComponent();

            wrapperRepository = new WrapperRepository();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            List<Student> students = wrapperRepository.StudentRepository.GetAll(x => x.Deleted == false).ToList();

            dgvStudent.DataSource = wrapperRepository.StudentRepository.ShowStudents(students);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    string id = txtId.Text;

                    var model = wrapperRepository.StudentRepository.GetAll(x => x.StudentCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        List<Student> students = new List<Student>();
                        students.Add(model);
                        dgvStudent.DataSource = wrapperRepository.StudentRepository.ShowStudents(students);
                    }
                    else
                    {
                        MessageBox.Show("Student not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                   && !string.IsNullOrWhiteSpace(txtAddress.Text)
                   && !string.IsNullOrWhiteSpace(mskPhone.Text))
                {
                    var model = wrapperRepository.StudentRepository.GetAll(x => x.StudentCode == txtId.Text && x.Deleted == false).FirstOrDefault();

                    if (model == null)
                    {
                        var student = new Student()
                        {
                            StudentCode = txtId.Text,
                            Name = txtName.Text,
                            LastName = txtLastName.Text,
                            Address = txtAddress.Text,
                            Phone = mskPhone.Text,
                            Status = "A",
                            Deleted = false,
                            CreationDate = DateTimeOffset.Now,
                            ModificationDate = null,
                        };

                        var result = wrapperRepository.StudentRepository.Create(student);
                        Clear();
                        MessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("There is already a student with the same id!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    var model = wrapperRepository.StudentRepository.GetAll(x => x.StudentCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to update the registry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Name = txtName.Text;
                            model.LastName = txtLastName.Text;
                            model.Address = txtAddress.Text;
                            model.Phone = mskPhone.Text;
                            model.ModificationDate = DateTimeOffset.Now;

                            var result = wrapperRepository.StudentRepository.Update(model);

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
                        MessageBox.Show("Student not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    var model = wrapperRepository.StudentRepository.GetAll(x => x.StudentCode == id && x.Deleted == false).FirstOrDefault();

                    if (model != null)
                    {
                        DialogResult DResult = MessageBox.Show("Do you want to delete the registry?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult.Yes == DResult)
                        {
                            model.Status = "I";
                            model.Deleted = true;

                            var result = wrapperRepository.StudentRepository.Delete(model);

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
                        MessageBox.Show("Student not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dgvStudent.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dgvStudent.SelectedRows[0].Cells[3].Value.ToString();
            mskPhone.Text = dgvStudent.SelectedRows[0].Cells[4].Value.ToString();
        }

        #region METHODS
        public override void Clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            mskPhone.Clear();
            List<Student> students = wrapperRepository.StudentRepository.GetAll(x => x.Deleted == false).ToList();
            dgvStudent.DataSource = wrapperRepository.StudentRepository.ShowStudents(students);
        }

        #endregion
    }
}

