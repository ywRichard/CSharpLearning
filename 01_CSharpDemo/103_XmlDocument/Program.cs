using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _103_XmlDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建XML文档第一遍
            ////代码创建XML文档
            ////1、引用命名空间            
            ////2、创建XML文档对象
            //XmlDocument doc = new XmlDocument();
            ////3、创建第一行描述信息，并添加到文档中
            //XmlDeclaration des = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //doc.AppendChild(des);
            ////4、创建根节点，并添加到文档中
            //XmlElement books = doc.CreateElement("Books");
            //doc.AppendChild(books);
            ////5、给根节点创建子节点添加到文档中
            //XmlElement book1 = doc.CreateElement("Book");
            //books.AppendChild(book1);
            ////6、给Book1添加子节点
            ////XmlElement name1 = doc.CreateElement("Name");
            ////name1.InnerText = "金瓶梅";
            ////book1.AppendChild(name1);
            //XmlElement name1 = doc.CreateElement("Name");
            //name1.InnerText = "金瓶梅";
            //book1.AppendChild(name1);

            //XmlElement price1 = doc.CreateElement("Price");
            //price1.InnerText = "10";
            //book1.AppendChild(price1);

            //XmlElement des1 = doc.CreateElement("Des");
            //des1.InnerText = "好看";
            //book1.AppendChild(des1);
            ////创建第二本书
            //XmlElement book2 = doc.CreateElement("Book");
            //books.AppendChild(book2);

            //XmlElement name2 = doc.CreateElement("Name");
            //name2.InnerText = "水浒传";
            //book2.AppendChild(name2);

            //XmlElement price2 = doc.CreateElement("Price");
            //price2.InnerText = "90";
            //book2.AppendChild(price2);

            //XmlElement des2 = doc.CreateElement("Des");
            //des2.InnerText = "108个好汉";
            //book2.AppendChild(des2); 
            #endregion

            #region 追加文档
            //XmlDocument doc = new XmlDocument();
            //XmlElement books;
            //if (File.Exists("Books.xml"))
            //{
            //    //文件存在,加载文件
            //    doc.Load("Books.xml");
            //    books = doc.DocumentElement;
            //}
            //else
            //{
            //    //文件不存在,创建
            //    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //    doc.AppendChild(dec);
            //    //创建更目录
            //    books = doc.CreateElement("Books");
            //    doc.AppendChild(books);
            //}

            //XmlElement book1 = doc.CreateElement("Book");
            //books.AppendChild(book1);

            //XmlElement name1 = doc.CreateElement("Name");
            //name1.InnerText = "C#开发大全";
            //book1.AppendChild(name1);

            //XmlElement price1 = doc.CreateElement("Price");
            //price1.InnerText = "120";
            //book1.AppendChild(price1);

            //XmlElement des1 = doc.CreateElement("Des");
            //des1.InnerText = "天书";
            //book1.AppendChild(des1);

            //doc.Save("Books.xml"); 
            #endregion

            #region 在文档中添加属性
            //XmlDocument doc = new XmlDocument();
            //XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //doc.AppendChild(dec);
            ////创建更目录
            //XmlElement order = doc.CreateElement("Order");
            //doc.AppendChild(order);
            ////创建子目录
            //XmlElement customer = doc.CreateElement("Customer");
            //customer.InnerText = "方世玉";
            //order.AppendChild(customer);

            //XmlElement customerNumber = doc.CreateElement("CustomerNumber");
            //customerNumber.InnerText = "洪熙官";
            //order.AppendChild(customerNumber);

            //XmlElement item = doc.CreateElement("Items");
            //order.AppendChild(item);

            //XmlElement orderItem1 = doc.CreateElement("OrderItem");
            //orderItem1.SetAttribute("Name", "娃娃");
            //orderItem1.SetAttribute("Price", "1000");
            //item.AppendChild(orderItem1);

            //XmlElement orderItem2 = doc.CreateElement("OrderItem");
            //orderItem2.SetAttribute("Name", "娃娃");
            //orderItem2.SetAttribute("Price", "1000");
            //item.AppendChild(orderItem2);

            //XmlElement orderItem3 = doc.CreateElement("OrderItem");
            //orderItem3.SetAttribute("Name", "娃娃");
            //orderItem3.SetAttribute("Price", "1000");
            //item.AppendChild(orderItem3);

            //doc.Save("Order.xml"); 
            #endregion

            #region 读取文档
            ////读取文档
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Book.xml");
            ////获得根目录
            //XmlElement books = doc.DocumentElement;
            ////获得子目录
            //XmlNodeList xnl = books.ChildNodes;
            //foreach (XmlNode node in xnl)
            //{
            //    Console.WriteLine(node.InnerText);
            //} 
            #endregion

            #region 读取带属性的Xml文档
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlNodeList xnl = doc.SelectNodes("/Order/Items/OrderItem");//xpath表达式
            //foreach (XmlNode node in xnl)
            //{
            //    Console.WriteLine(node.Attributes["Name"].Value);
            //    Console.WriteLine(node.Attributes["Price"].Value);
            //} 
            #endregion

            //删除节点
            XmlDocument doc = new XmlDocument();
            doc.Load("Order.xml");
            XmlElement orders = doc.DocumentElement;
            XmlNode xn = orders.SelectSingleNode("/Order/Items");
            xn.RemoveAll();
            doc.Save("Order.xml");

            Console.WriteLine("删除成功");
            Console.ReadKey();
        }
    }
}
