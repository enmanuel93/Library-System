using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IReport
    {
        List<BookReportViewModel> GetBookReportData();
        List<StudentReportViewModel> GetStudentReportData();
        List<LoanReportViewModel> GetLoanReportData();
        List<DevolutionReportViewModel> GetDevolutionReportData();

    }
}
