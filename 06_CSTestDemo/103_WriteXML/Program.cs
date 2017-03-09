using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _18_WriteXml
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化
            XDocument xdoc = new XDocument();
            //创建一个节点
            XElement root = new XElement("school");
            //节点
            XElement cls = new XElement("Class");
            //节点属性
            cls.SetAttributeValue("num", "二年一班");
            //节点元素
            XElement stu1 = new XElement("Student");
            stu1.SetAttributeValue("id","001");
            stu1.SetElementValue("name", "Lanry");
            stu1.SetElementValue("gender", "male");
            stu1.SetElementValue("age","18");

            XElement stu2 = new XElement("Student");
            stu2.SetAttributeValue("id", "002");
            stu2.SetElementValue("name", "Vivian");
            stu2.SetElementValue("gender", "female");
            stu2.SetElementValue("age","18");
            //添加子节点，需要逐级添加
            cls.Add(stu1);
            cls.Add(stu2);
            root.Add(cls);

            //把根元素添加到xml中
            xdoc.Add(root);

            xdoc.Save("WriteXml.xml");

            Console.WriteLine("创建xml文件完成");
            Console.ReadLine();
        }
    }
}
