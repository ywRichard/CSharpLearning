using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EFCodeFirst
{
    public class BloggingContext:DbContext
    {
        public BloggingContext()
        {
            //创建类之前初始化数据库
            Database.SetInitializer<BloggingContext>(new CreateDatabaseIfNotExists<BloggingContext>());
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
