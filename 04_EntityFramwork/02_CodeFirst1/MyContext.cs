using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst1
{
    public class MyContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookReview> Reviews { get; set; }
        public DbSet<Fiction> Fictions { get; set; }
    }
}
