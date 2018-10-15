using System.Collections.Generic;
using System.Linq;

namespace RepositoryImplementation
{
    class FilterThis : IFilter<ATestObject>
    {
        public IEnumerable<ATestObject> Filter(IEnumerable<ATestObject> queryableBase)
        {
            
            return queryableBase.Where(o => o.FirstName == "Chris");

        }
    }
}