using Domain.Models;
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
    public partial class frmConsultStudent : FormConsultController
    {
        public frmConsultStudent()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!IsTxtFilterEmpty)
            {
                List<Student> students = wrapperRepository.StudentRepository.FindById(x => x.StudentCode == txtFilter.Text && x.Deleted == false);
                dgvCommon.DataSource = wrapperRepository.StudentRepository.ShowStudents(students);
            }
        }

        private void frmConsultStudent_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            List<Student> students = wrapperRepository.StudentRepository.GetAll(x => x.Deleted == false).ToList();
            dgvCommon.DataSource = wrapperRepository.StudentRepository.ShowStudents(students);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }
    }
}
