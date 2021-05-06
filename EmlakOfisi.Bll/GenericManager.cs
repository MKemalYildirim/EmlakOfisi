using EmlakOfisi.Dal.Abstract;
using EmlakOfisi.Entities;
using EmlakOfisi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOfisi.Bll
{
      public class GenericManager<T> : IGenericService<T> where T: BaseEntity
    {
        private readonly IGenericRepository<T> genericRepository;

        public GenericManager(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public T Add(T entity)
        {
            return genericRepository.Add(entity);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                genericRepository.Dispose();
            }
        }

 

        public List<T> GettAll()
        {
            return genericRepository.GettAll();
        }

        public List<T> GettAll(Expression<Func<T, bool>> predicate)
        {
            return genericRepository.GettAll(predicate);
        }



        public bool Remove(T entity)
        {
            return genericRepository.Remove(entity);

        }
        public bool Remove(Expression<Func<T, bool>> predicate)
        {
            return genericRepository.Remove(predicate);

        }

        public T Update(T entity)
        {
            return genericRepository.Update(entity);

        }
    }
}
