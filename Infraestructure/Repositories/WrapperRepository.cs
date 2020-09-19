using Domain.Context;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class WrapperRepository : IWrapperRepository
    {
        #region CONTRACTS
        private IAuthor authorRepository;

        private IBook bookRepository;

        private IDevolution devolutionRepository;

        private IEditorial editorialRepository;

        private ILoan loanRepository;

        private IStudent studentRepository;

        private IUser userRepository;
        #endregion


        public WrapperRepository()
        {
           
        }

        public IAuthor AuthorRepository 
        { 
            get 
            {
                if (authorRepository is null)
                    authorRepository = new AuthorRepository();

                return authorRepository;
            } 
        }

        public IBook BookRepository
        {
            get
            {
                if (bookRepository is null)
                    bookRepository = new BookRepository();

                return bookRepository;
            }
        }

        public IDevolution DevolutionRepository
        {
            get
            {
                if (devolutionRepository is null)
                    devolutionRepository = new DevolutionRepository();

                return devolutionRepository;
            }
        }

        public IEditorial EditorialRepository
        {
            get
            {
                if (editorialRepository is null)
                    editorialRepository = new EditorialRepository();

                return editorialRepository;
            }
        }

        public ILoan LoanRepository
        {
            get
            {
                if (loanRepository is null)
                    loanRepository = new LoanRepository();

                return loanRepository;
            }
        }

        public IStudent StudentRepository
        {
            get
            {
                if (studentRepository is null)
                    studentRepository = new StudentRepository();

                return studentRepository;
            }
        }

        public IUser UserRepository
        {
            get
            {
                if (userRepository is null)
                    userRepository = new UserRepository();

                return userRepository;
            }
        }
    }
}
