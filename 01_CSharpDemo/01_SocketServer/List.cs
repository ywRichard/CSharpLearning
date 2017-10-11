using System;
using System.IO;

namespace _01_SocketServer
{
    internal class List : IHttpHandlerModel
    {
        public string RenderHtml()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            if (dir.EndsWith(@"\bin\Debug\") || dir.EndsWith(@"\bin\Release\"))
            {
                dir = Directory.GetParent(dir).Parent.Parent.FullName;
            }
            var fullDir = dir + "/model.html";
            var fileContent = File.ReadAllText(fullDir);
            return fileContent.Replace("$title", "新闻").Replace("$body", "新闻列表页面");
        }
    }
}