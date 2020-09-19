using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILoan : IRepositorio<Loan>
    {
        List<LoanViewModel> ShowBooksLoans();
        List<LoanViewModel> FindBookLoanById(string id);
    }
}
