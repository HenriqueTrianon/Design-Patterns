using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Adapter
{
    public class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Wokers");
            var xAttributes = WorkerDataProvider.GetData().Select(w => new XElement("Worker", new XAttribute(nameof(w.Name), w.Name),
                                                                      new XAttribute(nameof(w.Position), w.Position),
                                                                      new XAttribute(nameof(w.Salary), w.Salary)));
            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}
