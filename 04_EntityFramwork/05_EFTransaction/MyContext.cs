using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EFTransaction
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyContext")
        {

        }

        public DbSet<Class> Class { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
