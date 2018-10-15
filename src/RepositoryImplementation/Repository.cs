using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryImplementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _queryableBase;

        public Repository(DbContext queryableBase)
        {
            _queryableBase = queryableBase;
        }

        public T Select(IFilter<T> filterClass)
        {
            return filterClass.Filter(_queryableBase.Set<T>().AsQueryable()).First();
        }
        public IEnumerable<T> SelectMany(IFilter<T> filterClass)
        {
            return filterClass.Filter(_queryableBase.Set<T>().AsQueryable());
        }

        public void Delete(T item)
        {
            _queryableBase.Set<T>().Remove(item);
        }

        public void Add(T item)
        {
            _queryableBase.Set<T>().Add(item);
        }

        public void SaveChanges()
        {
            _queryableBase.SaveChanges();
        }
    }
}