using System.Collections.Generic;
using System.Linq;
using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class SortByDescendingStrategy<T> : ISorteableStrategy<T>
    {
        public List<T> Sort(params T[] data) 
            => data?.OrderByDescending(s => s).ToList();
    }
}