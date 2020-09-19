using Domain;
using Domain.Context;
using Domain.Interfaces;
using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthor
    {

        public List<AuthorViewModel> ShowAuthors(List<Author> authors)
        {
            var _authors = new List<AuthorViewModel>();

            foreach (var item in authors)
            {
                _authors.Add(new AuthorViewModel()
                {
                    ID = item.AuthorCode,
                    Name = item.Name,
                    LastName = item.LastName,
                    Nationality = item.Nationality
                });
            }

            return _authors;
        }
    }
}
