using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Strategy;
using Strategy.Strategies;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsTests
{
    public class StrategyTest
    {
        public StrategyTest()
        {
            SorteableContext = new SorteableContext<string>();
        }
        private SorteableContext<string> SorteableContext { get; }
        [Theory]
        [InlineData("Data/Strategy.json")]
        public void TestOrderedContext(string path)
        {
            var data = JsonDataReader.GetFromPath<string[]>(path);
            SorteableContext.SetStrategy(new SortByAscendingStrategy<string>());
            var orderedList = SorteableContext.Execute(data.Clone() as string[]);
            var first = data.Min(s => s);
            var last = data.Max(s => s);
            Assert.Equal(first, orderedList.FirstOrDefault());
            Assert.Equal(last, orderedList.LastOrDefault());
        }
        [Theory]
        [InlineData("Data/Strategy.json")]
        public void TestOrderedThanReversedContext(string path)
        {
            var data = JsonDataReader.GetFromPath<string[]>(path);
            SorteableContext.SetStrategy(new SortByDescendingStrategy<string>());
            var orderedByDescendingList = SorteableContext.Execute(data.Clone() as string[]);
            var first = data.Min(s => s);
            var last = data.Max(s => s);
            Assert.Equal(first, orderedByDescendingList.LastOrDefault());
            Assert.Equal(last, orderedByDescendingList.FirstOrDefault());
        }
    }
}
