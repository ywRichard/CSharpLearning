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

        //public static implicit operator List<Animal>(Farm<T> farm)
        //{
        //    List<Animal> result = new List<Animal>();
        //    foreach (var animal in farm)
        //    {
        //        result.Add(animal);
        //    }

        //    return result;
        //}

        public static Farm<T> operator +(Farm<T> farm1, Farm<T> farm2)
        {
            Farm<T> result = new Farm<T>();

            foreach (var item in farm1)
            {
                result.Animals.Add(item);
            }

            foreach (var item in farm2)
            {
                if (!result.Animals.Contains(item))
                {
                    result.Animals.Add(item);
                }
            }

            return result;
        }

        //public static Farm<T> operator +(List<T> farm1, Farm<T> farm2)
        //{
        //    return farm1+farm2;
        //}

        public static implicit operator Farm<Animal>(Farm<T> farm)
        {
            Farm<Animal> result = new Farm<Animal>();

            foreach (var animal in farm)
            {
                result.Animals.Add(animal);
            }

            return result;
        }
    }
}
