using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Collection
{
    public class Cow : Animal
    {
        public void Milk()
        {
            Console.WriteLine("{} has been milked.", Name);
        }

        public Cow(string newName) : base(newName)
        {

        }
    }
}
