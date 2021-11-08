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
            var adapter = new XmlToJsonAdapter(new XmlConverter());
            Output.WriteLine(adapter.ConvertXmlToJson());
        }
    }
}
