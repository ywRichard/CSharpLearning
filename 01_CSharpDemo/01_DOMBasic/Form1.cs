using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _01_DOMBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"../../Book.xml");
            txtResult.Text = FormatText(document.DocumentElement as XmlNode, "", "");
            
        }

        private string FormatText(XmlNode node, string text, string indent)
        {
            if (node is XmlText)
            {
                text += node.Value;
                return text;
            }

            if (string.IsNullOrEmpty(indent))
                indent = "";
            else
                text += "\r\n" + indent;

            if (node is XmlComment)
            {
                text += node.OuterXml;
                return text;
            }

            text += "<" + node.Name;
            if (node.Attributes.Count>0)
                AddAttributes(node, ref text);

            if (node.HasChildNodes)
            {
                text += ">";
                foreach (XmlNode child in node.ChildNodes)
                    text = FormatText(child, text, indent + " ");

                if (node.ChildNodes.Count==1&&
                    (node.FirstChild is XmlText || node.FirstChild is XmlComment))
                    text += "</" + node.Name + ">";
                else
                    text += "\r\n" + indent + "</" + node.Name + ">";
            }
            else
                text += "/>";

            return text;
        }

        private void AddAttributes(XmlNode node, ref string text)
        {
            foreach (XmlAttribute xa in node.Attributes)
            {
                text += " " + xa.Name + "='" + xa.Value + "'";
            }
        }

        private void btnCreateNode_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"../../Book.xml");

            XmlElement root = document.DocumentElement;

            XmlElement newBook = document.CreateElement("book");
            XmlElement newTitle = document.CreateElement("title");
            XmlElement newAuthor = document.CreateElement("author");
            XmlElement newCode = document.CreateElement("code");
            XmlText title = document.CreateTextNode("C# Basic");
            XmlText author = document.CreateTextNode("Karin");
            XmlText code = document.CreateTextNode("123456");
            XmlComment comment = document.CreateComment("This is Comment");

            newBook.AppendChild(comment);
            newBook.AppendChild(newTitle);
            newBook.AppendChild(newAuthor);
            newBook.AppendChild(newCode);
            newTitle.AppendChild(title);
            newAuthor.AppendChild(author);
            newCode.AppendChild(code);
            root.InsertAfter(newBook, root.FirstChild);
            document.Save(@"../../Book.xml");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"../../Book.xml");

            XmlElement root = document.DocumentElement;

            if (root.HasChildNodes)
            {
                XmlNode book = root.LastChild;
                root.RemoveChild(book);
                document.Save(@"../../Book.xml");
            }
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"../../Book.xml");

            XmlElement root = document.DocumentElement;

            XmlNode node = root.FirstChild.SelectSingleNode("title");
            txtResult.Text = node.InnerXml;

            XmlNode nodeBook = root.SelectSingleNode("book");
            txtResult.Text += nodeBook.InnerXml;
        }
    }
}
