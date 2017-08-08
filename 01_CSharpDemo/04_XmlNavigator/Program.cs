using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _04_XmlNavigator
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new XPathDocument(@"../../Book.xml");
            var root = document.CreateNavigator();
            IterationXML(root);
            Console.WriteLine("Finished");
        }

        private static string IterationXML(XPathNavigator element)
        {
            if (element.HasChildren)
            {
                foreach (var item in element.SelectChildren(XPathNodeType.All))
                {

                }
            }
        }
    }

}
