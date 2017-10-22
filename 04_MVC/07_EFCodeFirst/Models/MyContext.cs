using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _07_EFCodeFirst.Models;

namespace _07_EFCodeFirst.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {

        }

        public DbSet<ArticleInfo> ArticleInfo { get; set; }
        public DbSet<ArticleType> ArticleType { get; set; }
    }
}