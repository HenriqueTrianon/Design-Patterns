using System.Collections.Generic;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsTests
{
    public class AbstractFactoryTest
    {
        private ITestOutputHelper Output { get; }
        private List<IUnit> Units { get; } = new List<IUnit>();
        public AbstractFactoryTest(ITestOutputHelper output)
        {
            Output = output;
        }
        [Fact]
        public void TestAsianFactory()
        {
            INationFactory nationFactory = new AsianFactory();
            Units.Add(nationFactory.CreateShortableRangeUnit());
            Units.Add(nationFactory.CreateLongableRangeUnit());
            PrintUnits();
        }
        [Fact]
        public void TestEuropeanFactory()
        {
            INationFactory nationFactory = new EuropeanFactory();
            Units.Add(nationFactory.CreateShortableRangeUnit());
            Units.Add(nationFactory.CreateLongableRangeUnit());
            PrintUnits();
        }

        private void PrintUnits()
        {
            foreach (var unit in Units)
            {
                Output.WriteLine($" {unit.Name}");
            }
        }
    }
}
