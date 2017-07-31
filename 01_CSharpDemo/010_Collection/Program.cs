using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Jack"));
            animalCollection.Add(new Chicken("Vera"));

            for (int i = 0; i < animalCollection.Count; i++)
            {
                animalCollection[i].Feed();
            }
        }
    } 
}
