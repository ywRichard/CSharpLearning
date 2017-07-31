using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Collection
{
    public class Chicken:Animal
    {
        public void LayEgg()
        {
            Console.WriteLine("{0} has laid an egg.",Name);
        }

        public Chicken(string newName):base(newName)
        {

        }
    }
}
