using System;
using System.Collections.Generic;
using Strategy.Interfaces;

namespace Strategy
{
    public class SorteableContext<T>
    {
        private ISorteableStrategy<T> _sorteableStrategy;
        public SorteableContext()
        { }
        public SorteableContext(ISorteableStrategy<T> sorteableStrategy)
        {
            _sorteableStrategy = sorteableStrategy;
        }
        public void SetStrategy(ISorteableStrategy<T> sorteableStrategy)
        {
            _sorteableStrategy = sorteableStrategy;
        }
        public List<T> Execute(params T [] list)
        {
            return _sorteableStrategy.Sort(list);
        }
    }
}