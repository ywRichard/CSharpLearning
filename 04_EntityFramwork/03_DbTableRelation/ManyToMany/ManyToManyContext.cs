using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DbTableRelation
{
    public class ManyToManyContext : DbContext
    {
        public ManyToManyContext():base("name=MyContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
