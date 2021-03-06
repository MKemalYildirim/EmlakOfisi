using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Dal.Abstract
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        T Add(T entity);
        List<T> GettAll();
        List<T> GettAll(Expression<Func<T, bool>> predicate);

        bool Remove(T entity);
        bool Remove(Expression<Func<T, bool>> predicate);

        T Update(T entity);
     
    }
}
