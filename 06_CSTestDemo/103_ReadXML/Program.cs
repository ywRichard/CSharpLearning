using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ReadXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load(@"C:\Users\S2I\Desktop\read.xml");

            IEnumerable<XElement> eles = xdoc.Elements();

            foreach (var item in eles)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(xdoc.Root);

            Console.ReadLine();
        }
    }
}
