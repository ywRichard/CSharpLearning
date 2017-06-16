using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _103_XDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = XDocument.Load("VJD_Rectangle.vxml");
            //Console.WriteLine(root);
            //XName target = "Target";
            var proElement = root.Element("Project");
            var target = proElement.Element("Target");

            //ele --> <ElementName>content</ElementName>
            //var ele = new XElement("ElementName","content");

            var rectElement = proElement.Element("Target").Element("GraphicalPanels").Element("BasePanels").Element("Panel").Element("Rectangle");
            //attributes(rectElement).ToList().ForEach(item => Console.WriteLine(item));
            attributes(rectElement, item => item.Name != null)
                .ToList().ForEach(item=>Console.WriteLine(item));
            Console.ReadKey();
        }

        private static IEnumerable<XAttribute> attributes(XElement element, Func<XAttribute,bool> func)
        {
            return element.Attributes().Where(func);
        }
    }
}
