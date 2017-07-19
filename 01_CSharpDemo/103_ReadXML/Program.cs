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
            #region
            //XDocument xdoc = XDocument.Load(@"C:\Users\S2I\Desktop\read.xml");

            //IEnumerable<XElement> eles = xdoc.Elements();

            //foreach (var item in eles)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.WriteLine(xdoc.Root);
            #endregion

            #region Root
            //XDocument XDoc = XDocument.Load("ReadXml.xml");

            //XElement xele = XDoc.Root;

            ////Console.WriteLine(xele);

            //IEnumerable<XElement> eles = xele.Elements();

            //foreach (XElement elesClass in eles)
            //{
            //    //Console.WriteLine(elesClass.Name);
            //    //Console.WriteLine(elesClass.Value);

            //    foreach (var elesStudent in elesClass.Elements())
            //    {
            //        Console.WriteLine(elesStudent.Attribute("id").Value);//student元素的属性id的值
            //        Console.WriteLine(elesStudent.Name);//student元素的名字

            //        Console.WriteLine(elesStudent.FirstAttribute.Value);//Student元素第一个属性的值
            //        Console.WriteLine(elesStudent.Element("name").Value);//按名称读取子元素的值
            //        //Console.WriteLine(elesStudent.FirstNode);//Student元素第一个节点
            //    }
            //}
            #endregion

            #region Test Element Value
            var xml = @"<Project>
                            <Labels>
                                <State></State>
                                <State>2</State>
                                <State>3</State>
                                <State>4</State>
                                <State></State>
                            </Labels>
                        </Project>";
            var element = XElement.Parse(xml);

            element.Elements().ToList().ForEach(child => Console.WriteLine("Name:{0}; Value:{1}", child.Name.LocalName, child.Value));
            Console.ReadLine();
            #endregion

            Console.ReadLine();
        }
    }
}
