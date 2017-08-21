using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code First 创建数据库实例,
            //首先系统会查找 sqlexpress，
            //如果没找到实例会被创建到LocalDB中，服务器名称(locadb)\v11.0
            using (var ctx = new BloggingContext())
            {
                ctx.Blogs.Add(new Blog { BlogId = 1, Name = "FirstBlog" });
                ctx.Blogs.Add(new Blog { BlogId = 2, Name = "FirstBlog" });
                ctx.Blogs.Add(new Blog { BlogId = 3, Name = "FirstBlog" });
                ctx.SaveChanges();
            }
        }
    }
}
