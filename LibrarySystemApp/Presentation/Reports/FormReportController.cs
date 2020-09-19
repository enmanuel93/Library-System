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

namespace LibrarySystemApp.Presentation.Reports
{
    public partial class FormReportController : Form
    {
        protected readonly IReport repositoryReport;

        public FormReportController()
        {
            InitializeComponent();

            repositoryReport = new ReportsRepotiry();
        }
    }
}
