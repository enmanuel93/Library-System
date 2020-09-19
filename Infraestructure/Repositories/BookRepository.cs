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
    public class BookRepository : BaseRepository<Book>, IBook
    {

        public List<BookViewModel> ShowBooks()
        {
            List<BookViewModel> books = null;

            try
            {
                using (var db = new LibraryContext())
                {
                    var models = (from b in db.books
                                  join a in db.authors on b.AuthorId equals a.Id
                                  join e in db.editorials on b.EditorialId equals e.Id
                                  where b.Deleted == false
                                  select new BookViewModel
                                  {
                                      ID = b.BookCode,
                                      Author = a.Name + " " + a.LastName,
                                      Editorial = e.Name,
                                      Name = b.Name
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

        public List<BookViewModel> ShowBookByID(string id)
        {
            List<BookViewModel> books = null;

            try
            {
                using (var db = new LibraryContext())
                {
                    var models = (from b in db.books
                                  join a in db.authors on b.AuthorId equals a.Id
                                  join e in db.editorials on b.EditorialId equals e.Id
                                  where b.Deleted == false && b.BookCode == id
                                  select new BookViewModel
                                  {
                                      ID = b.BookCode,
                                      Author = a.Name + " " + a.LastName,
                                      Editorial = e.Name,
                                      Name = b.Name
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
    }
}
