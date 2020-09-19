using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IWrapperRepository
    {
        IAuthor AuthorRepository { get; }
        IBook BookRepository { get; }
        IDevolution DevolutionRepository { get; }
        IEditorial EditorialRepository { get; }
        ILoan LoanRepository { get; }
        IStudent StudentRepository { get; }
        IUser UserRepository { get; }
    }
}
