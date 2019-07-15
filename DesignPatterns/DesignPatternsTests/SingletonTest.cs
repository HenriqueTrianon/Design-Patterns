using System;
using System.Collections.Generic;
using System.Text;
using Singleton;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsTests
{
    public class SingletonTest
    {
        private ITestOutputHelper TestOutputHelper { get; }

        public SingletonTest(ITestOutputHelper testOutputHelper)
        {
            TestOutputHelper = testOutputHelper;
        }
        [Fact]
        public void ServerBalancerTest()
        {
            var b1 = ServerBalancer.GetServerBalancer();
            var b2 = ServerBalancer.GetServerBalancer();
            var b3 = ServerBalancer.GetServerBalancer();
            var b4 = ServerBalancer.GetServerBalancer();
            Assert.Equal(b1, b2);
            Assert.Equal(b3, b4);
            Assert.Equal(b3, b2);
            for (var i = 0; i < 10; i++)
            {
               var server = b1.NextServer;
               TestOutputHelper.WriteLine($"Request Handled By... {server.Name} {server.IP}");

            }
        }
    }
}
