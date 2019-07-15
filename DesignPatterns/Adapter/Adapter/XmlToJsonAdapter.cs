using System.Linq;
using Adapter.Interface;

namespace Adapter.Adapter
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private XmlConverter XmlConverter { get; }
        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            XmlConverter = xmlConverter;
        }
        public string ConvertXmlToJson()
        {
            var manufacturers = XmlConverter.GetXML()
                .Element("Wokers")
                .Elements("Worker")
                .Select(m => new Worker()
                 {
                     Name = m.Attribute("Name").Value,
                     Position = m.Attribute("Position").Value,
                     Salary = decimal.Parse(m.Attribute("Salary").Value)
                 });
            return new JsonConverter(manufacturers)
                .ConvertToJson();
        }
    }
}
