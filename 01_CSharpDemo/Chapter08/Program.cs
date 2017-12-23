using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            TryClassInitializer();
            var temp1 = new { Name = "111", Age = 11 };
            var temp2 = new { Name = 123, age = 12 };
        }

        static void TryClassInitializer()
        {
            var initilizer = new ClassInitializer();
            Console.WriteLine(initilizer.Tom.ToString());
            var dic = new Dictionary<string, int>
            {
                { "Holly",33},
                { "Jon",15}
            };

            var jack = new Person
            {
                Name = "Jack",
                Age = 15,
                Home = { Country = "USA", Town = "NYC" }
            };
        }
    }
}
