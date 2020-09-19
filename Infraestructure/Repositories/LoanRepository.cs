using Domain.Context;
using Domain.Interfaces;
using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class LoanRepository : BaseRepository<Loan>, ILoan
    {

        public List<LoanViewModel> FindBookLoanById(string id)
        {
            List<LoanViewModel> booksLoans = null;

            try
            {
                using (var db = new LibraryContext())
                {
                    var models = (from p in db.loans
                                  join l in db.books on p.BookId equals l.Id
                                  join es in db.students on p.StudentId equals es.Id
                                  where p.Deleted == false && p.LoanCode == id
                                  select new LoanViewModel
                                  {
                                      ID = p.LoanCode,
                                      Student = es.Name + " " + es.LastName,
                                      Book = l.Name
                                  }).ToList();

                    booksLoans = models;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return booksLoans;
        }

        public List<LoanViewModel> ShowBooksLoans()
        {
            List<LoanViewModel> booksLoans = null;

            try
            {
                using (var db = new LibraryContext())
                {
                    var models = (from p in db.loans
                                  join l in db.books on p.BookId equals l.Id
                                  join es in db.students on p.StudentId equals es.Id
                                  where p.Deleted == false
                                  select new LoanViewModel
                                  {
                                      ID = p.LoanCode,
                                      Student = es.Name + " " + es.LastName,
                                      Book = l.Name
                                  }).ToList();

                    booksLoans = models;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return booksLoans;
        }
    }

}
