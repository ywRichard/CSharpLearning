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

        public DbSet<BookInfo1> BookInfo1 { get; set; }
        public DbSet<BookType1> BookType1 { get; set; }
    }
}