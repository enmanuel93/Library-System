using Domain.Context;
using Domain.Interfaces;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class ReportsRepotiry : IReport
    {
        private LibraryContext context;

        public ReportsRepotiry()
        {
            this.context = new LibraryContext();
        }

        public List<BookReportViewModel> GetBookReportData()
        {
            List<BookReportViewModel> books = null;

            try
            {
                using (var db = context)
                {
                    var models = (from b in db.books
                                  join a in db.authors on b.AuthorId equals a.Id
                                  join e in db.editorials on b.EditorialId equals e.Id
                                  where b.Deleted == false
                                  select new BookReportViewModel
                                  {
                                      ID = b.BookCode,
                                      Author = a.Name + " " + a.LastName,
                                      Editorial = e.Name,
                                      Name = b.Name,
                                      Date = b.CreationDate
                                  }).ToList();

                    books = models;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return books;
        }

        public List<DevolutionReportViewModel> GetDevolutionReportData()
        {
            List<DevolutionReportViewModel> devolutions = null;

            try
            {
                using (var db = context)
                {
                    var models = (from d in db.devolutions
                                  join l in db.loans on d.LoanId equals l.Id
                                  where d.Deleted == false
                                  select new DevolutionReportViewModel
                                  {
                                      ID = d.DevolutionCode,
                                      Code = l.LoanCode,
                                      Date = d.CreationDate
                                  }).ToList();

                    devolutions = models;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return devolutions;
        }

        public List<LoanReportViewModel> GetLoanReportData()
        {
            List<LoanReportViewModel> booksLoans = null;

            try
            {
                using (var db = context)
                {
                    var models = (from p in db.loans
                                  join l in db.books on p.BookId equals l.Id
                                  join es in db.students on p.StudentId equals es.Id
                                  where p.Deleted == false
                                  select new LoanReportViewModel
                                  {
                                      ID = p.LoanCode,
                                      Student = es.Name + " " + es.LastName,
                                      Book = l.Name,
                                      Date = l.CreationDate
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

        public List<StudentReportViewModel> GetStudentReportData()
        {
            List<StudentReportViewModel> students = null;

            try
            {
                using (var db = context)
                {
                    var models = db.students.Where(x => x.Deleted == false).Select(x => new StudentReportViewModel
                    {
                        ID = x.StudentCode,
                        Name = x.Name,
                        LastName = x.LastName,
                        Address = x.Address,
                        Phone = x.Phone,
                        Date = x.CreationDate
                    }).ToList();

                    students = models;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return students;
        }
    }
}
