using System.Collections.Generic;
using System.Linq;
using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class SortByAscendingStrategy<T> : ISorteableStrategy<T>
    {
        public List<T> Sort(params T[] data) 
            => data.OrderBy(c => c).ToList();
        
    }
}
