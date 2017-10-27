using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DbTableRelation
{
    public class OneToManyContext : DbContext
    {
        public OneToManyContext() : base("name=MyContext")
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<BookReview> BookReview { get; set; }
    }
}
