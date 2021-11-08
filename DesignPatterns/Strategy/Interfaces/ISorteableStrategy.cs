using System.Collections.Generic;

namespace Strategy.Interfaces
{
    public interface ISorteableStrategy<T>
    {
        List<T> Sort(params T[] data);
    }
}