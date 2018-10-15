using System.Collections.Generic;

namespace RepositoryImplementation
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> queryableBase);
    }
}