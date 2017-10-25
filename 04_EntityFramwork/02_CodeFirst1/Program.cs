using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DbContext context = new MyContext())
            {
                Console.WriteLine("数据库中有{0}本书", context.Set<Book>().Count());
            }
        }
    }
}
