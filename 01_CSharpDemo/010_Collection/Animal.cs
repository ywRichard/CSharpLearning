using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Collection
{
    public abstract class Animal
    {
        protected string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public Animal()
        {

        }

        public Animal(string newName)
        {
            _name = newName;
        }

        public void Feed()
        {
            Console.WriteLine("{0} has been fed.", _name);
        }
    }
}
