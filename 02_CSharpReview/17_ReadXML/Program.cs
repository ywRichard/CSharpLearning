using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _17_ReadXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument XDoc = XDocument.Load("ReadXml.xml");

            XElement xele = XDoc.Root;

            //Console.WriteLine(xele);
            
            IEnumerable<XElement>eles = xele.Elements();

            foreach (XElement elesClass in eles)
            {
                //Console.WriteLine(elesClass.Name);
                //Console.WriteLine(elesClass.Value);
                
                foreach (var elesStudent in elesClass.Elements())
                {
                    Console.WriteLine(elesStudent.Attribute("id").Value);//student元素的属性id的值
                    Console.WriteLine(elesStudent.Name);//student元素的名字

                    Console.WriteLine(elesStudent.FirstAttribute.Value);//Student元素第一个属性的值
                    Console.WriteLine(elesStudent.Element("name").Value);//按名称读取子元素的值
                    //Console.WriteLine(elesStudent.FirstNode);//Student元素第一个节点
                }
            }

            Console.ReadLine();
        }
    }
}
