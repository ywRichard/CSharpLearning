using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07_CodeFirst
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
