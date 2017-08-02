using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = new Farm<Animal>();
            farm.Animals.Add(new Dog("Jack"));
            farm.Animals.Add(new Cat("Jerry"));
            farm.Animals.Add(new Chicken("Kimi"));
            farm.Animals.Add(new SuperDog("Dafei"));
            farm.Shout();

            Farm<Dog> dairyFarm = farm.GetDogs();
            dairyFarm.Eat();

            foreach (var dog in dairyFarm)
            {
                if (dog is SuperDog)
                {
                    (dog as SuperDog).Fly();
                }
            }
        }
    }
}
