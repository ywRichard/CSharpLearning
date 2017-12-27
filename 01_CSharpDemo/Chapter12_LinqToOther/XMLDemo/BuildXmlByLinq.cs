using Chapter11_LinqToObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter12_LinqToOther.XMLDemo
{
    public class BuildXmlByLinq
    {
        /// <summary>
        /// 由查询方法构造xml
        /// </summary>
        static void CreateXmlByMethod()
        {
            var users = new XElement("users",
            SampleData.AllUsers.Select(user => new XElement("user",
                new XAttribute("name", user.Name),
                new XAttribute("type", user.UserType))));

            Console.WriteLine(users);
        }
        static void CreateXmlByExpression()
        {
            var developers = new XElement("developers",
                from user in SampleData.AllUsers
                where user.UserType == Chapter11_LinqToObject.UserType.Developer
                select new XElement("developer", user)
                );

            Console.WriteLine(developers);
        }
    }
}
