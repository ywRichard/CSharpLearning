using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_GenericClass
{

    class Farm<T> : IEnumerable<T>
        where T : Animal
    {
        private List<T> animals = new List<T>();

        public List<T> Animals
        {
            get
            {
                return animals;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        public void Shout()
        {
            foreach (var animal in animals)
            {
                animal.Shout();
            }
        }

        public void Eat()
        {
            foreach (var animal in animals)
            {
                animal.Eat();
            }
        }

        public Farm<Dog> GetDogs()
        {
            Farm<Dog> dogFarm = new Farm<Dog>();

            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    dogFarm.Animals.Add(animal as Dog);
                }
            }

            return dogFarm;
        }
    }
}
