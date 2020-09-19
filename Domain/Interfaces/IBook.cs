using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBook : IRepositorio<Book>
    {
        List<BookViewModel> ShowBooks();
        List<BookViewModel> ShowBookByID(string id);
    }
}
