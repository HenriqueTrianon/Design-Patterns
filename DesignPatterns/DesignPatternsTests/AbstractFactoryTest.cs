using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsTests
{
    public class AbstractFactoryTest
    {
        private ITestOutputHelper Output { get; }
        private List<IUnit> units { get; set; } = new List<IUnit>();
        public AbstractFactoryTest(ITestOutputHelper output)
        {
            Output = output;
        }
        [Fact]
        public void TestAsianFactory()
        {
            INationFactory nationFactory = new AsianFactory();
            units.Add(nationFactory.CreateShortableRangeUnit());
            units.Add(nationFactory.CreateLongableRangeUnit());
            printUnits();
        }
        [Fact]
        public void TestEuropeanFactory()
        {
            
            INationFactory nationFactory = new EuropeanFactory();
            units.Add(nationFactory.CreateShortableRangeUnit());
            units.Add(nationFactory.CreateLongableRangeUnit());
            printUnits();
        }

        private void printUnits()
        {
            foreach (var unit in units)
            {
                Output.WriteLine($" {unit.Name}");
            }
        }
    }
}
