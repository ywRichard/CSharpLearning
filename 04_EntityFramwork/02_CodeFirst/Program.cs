using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContext context = new MyContext();

            var result = context.Database.CreateIfNotExists() ? "Create OK" : "Create NG";
            result += " ++ " + (context.SaveChanges() > 0 ? "Save OK" : "Save NG");

            Console.WriteLine(result);
        }
    }
}
