using System.Collections.Generic;

namespace RepositoryImplementation
{
    public interface IRepository<T> where T : class
    {
        T Select(IFilter<T> filterClass);
        IEnumerable<T> SelectMany(IFilter<T> filterClass);
        void Delete(T item);
        void Add(T item);
        void SaveChanges();
    }
}