using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositorio<T> where T : class  
    {
        OperationResult Delete(T entity);
        OperationResult Create(T entity);
        OperationResult Update(T entity);
        List<T> FindById(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null);
        int Save();
    }
}
