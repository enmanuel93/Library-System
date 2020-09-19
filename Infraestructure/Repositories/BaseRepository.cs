using Domain;
using Domain.Context;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class BaseRepository<T> : IRepositorio<T> where T : class
    {
        private LibraryContext _context;
        private DbSet<T> _dbSet;

        public BaseRepository()
        {
            this._context = new LibraryContext();
            this._dbSet = _context.Set<T>();
        }

        public OperationResult Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                int result = _context.SaveChanges();

                if (result > 0)
                {
                    return new OperationResult() { Result = true, Message = "Data saved successfully!" };
                }
                else
                {
                    return new OperationResult() { Result = false, Message = "Failed to save data!" };
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public OperationResult Delete(T entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;

                int result = Save();

                if (result > 0)
                {
                    return new OperationResult() { Result = true, Message = "data deleted successfully!" };
                }
                else
                {
                    return new OperationResult() { Result = false, Message = "Failed to delete data!" };
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<T> FindById(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query;
        }

        public OperationResult Update(T entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;

                int result = Save();

                if (result > 0)
                {
                    return new OperationResult() { Result = true, Message = "Data updated successfully!" };
                }
                else
                {
                    return new OperationResult() { Result = false, Message = "Error updating data!" };
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
