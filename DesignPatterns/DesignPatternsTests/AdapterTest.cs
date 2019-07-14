using System;
using System.Collections.Generic;
using System.Text;
using Adapter;
using Adapter.Adapter;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsTests
{
    
    public class AdapterTest
    {
        private ITestOutputHelper Output { get; }
        public AdapterTest(ITestOutputHelper output)
        {
            Output = output;
        }
        [Fact]
        public void XmlToJsonAdapterTest()
        {
            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            Output.WriteLine(adapter.ConvertXmlToJson());
        }
    }
}
