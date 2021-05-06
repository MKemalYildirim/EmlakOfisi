using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Dal.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Dal.Concrete.EntityFramework.Repository
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        public EmlakOfisiContext context;

        public EfGenericRepository()
        {
            context = new EmlakOfisiContext();
        }
        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }




        protected virtual void Dispose(bool dispose)
        {
            if (dispose)
            {

                context.Dispose();
            }
        }




        public List<T> GettAll()
        {
            return context.Set<T>().AsNoTracking().ToList();
        }


        public List<T> GettAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }



        public bool Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges() > 0;
        }
        public bool Remove(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            var entity = context.Set<T>().AsNoTracking().Where(predicate).FirstOrDefault();
            context.Set<T>().Attach(entity);
            context.Set<T>().Remove(entity);
            return context.SaveChanges() > 0;
        }

        public T Update(T entity)
        {
            context.Set<T>().AddOrUpdate(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
