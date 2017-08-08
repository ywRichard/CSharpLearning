using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03_XmlDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            //增删改查
            XmlDocument document = new XmlDocument();
            document.Load(@"../../Book.xml");
            var root = document.DocumentElement;

            foreach (var node in root.ChildNodes)
            {
                if (node is XmlElement)
                {
                    //查
                    var element = node as XmlElement;
                    if (element.SelectSingleNode("author").InnerText == "Karin")
                    {
                        Console.WriteLine(element.SelectSingleNode("title").InnerText);
                    }

                    //删
                    foreach (var subNode in element.ChildNodes)
                    {
                        if (subNode is XmlComment)
                        {
                            var comment = subNode as XmlComment;
                            if (comment.Data == "For Delete")
                            {
                                comment.ParentNode.RemoveChild(comment);
                                Console.WriteLine("Deleted this comment:{0}", comment.Data);
                                //可以边操作，边保存
                                document.Save(@"../../Book.xml");
                            }
                        }
                    }
                }
            }
    
            foreach (var node in root.ChildNodes)
            {
                if ((node as XmlElement).Name == "book")
                {
                    var book = node as XmlElement;
                    book.SelectSingleNode("author");
                    //改
                    if (book.SelectSingleNode("author").InnerXml=="Hello")
                    {
                        book.SelectSingleNode("code").InnerXml = "####";
                        document.Save(@"../../Book.xml");
                        Console.WriteLine("Changed the Hello code");
                    }
                }
            }

            var newBook = document.CreateElement("New_Book");
            var newAuther = document.CreateElement("David");
            newBook.AppendChild(newAuther);
            root.InsertAfter(newBook, root.FirstChild);

            document.Save(@"../../Book.xml");
        }
    }
}
