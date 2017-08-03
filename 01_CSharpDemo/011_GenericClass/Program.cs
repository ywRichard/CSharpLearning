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
            #region 泛型类
            //Farm<Animal> farm = new Farm<Animal>();
            //farm.Animals.Add(new Dog("Jack"));
            //farm.Animals.Add(new Cat("Jerry"));
            //farm.Animals.Add(new Chicken("Kimi"));
            //farm.Animals.Add(new SuperDog("Dafei"));
            //farm.Shout();

            //Farm<Dog> dairyFarm = farm.GetDogs();
            //dairyFarm.Eat();

            //foreach (var dog in dairyFarm)
            //{
            //    if (dog is SuperDog)
            //    {
            //        (dog as SuperDog).Fly();
            //    }
            //}
            #endregion

            #region 重载泛型运算符
            //Farm<Animal> newFarm = farm + dairyFarm;
            #endregion

            #region 泛型结构体
            //Cat cat = new Cat("Tom");
            //Dog newDog = new Dog("WatchDog");

            //MyStruct<Cat, Dog> ms = new MyStruct<Cat, Dog> { item1 = cat, item2 = newDog };
            //Console.WriteLine(cat.Name);
            //Console.WriteLine(newDog.Name);
            #endregion

            #region 泛型接口
            //Duck duck = new Duck();
            //Dog old = new Dog("Old Dog");
            //Dog young = new Dog("Young Dog");

            //duck.AttempToBreed(old, young);
            //duck.Information();
            #endregion

            #region 泛型方法
            Farm<Animal> farm = new Farm<Animal>();
            farm.Animals.Add(new Dog("Jack"));
            farm.Animals.Add(new Cat("Jerry"));
            farm.Animals.Add(new Chicken("Kimi"));
            farm.Animals.Add(new SuperDog("Dafei"));

            foreach (var item in farm.GetSpecies<Cat>())
            {
                item.Shout();
            }

            foreach (var item in farm.GetSpecies<Dog>())
            {
                item.Shout();
            }
            #endregion

            #region 非泛型类的泛型方法
            GenericMethod gd = new GenericMethod();
            gd.OutputDirect<int>(100);
            gd.OutputDirect<string>("This is good!");

            Console.WriteLine("##################");
            int a = 101;
            int b = 202;
            string str1 = "aaa";
            string str2 = "bbb";

            Console.WriteLine("a:{0},b:{1}", a, b);
            Console.WriteLine("str1:{0},str2:{1}", str1, str2);

            gd.SwitchValue<int>(ref a, ref b);
            gd.SwitchValue<string>(ref str1, ref str2);

            Console.WriteLine("a:{0},b:{1}", a, b);
            Console.WriteLine("str1:{0},str2:{1}", str1, str2);

            Console.WriteLine("##################");
            gd.MultiGenericMed<int, string>(100, "one hundred");
            Console.ReadLine();
            #endregion
        }
    }

    /// <summary>
    /// 泛型结构体
    /// </summary>
    public struct MyStruct<T1, T2>
    {
        public T1 item1;
        public T2 item2;
    }

    /// <summary>
    /// 泛型接口
    /// </summary>
    interface MyFarmingInterface<T>
        where T : Animal
    {
        bool AttempToBreed(T animal1, T animal2);

        T OldestInHerd { get; }
    }
    class Duck : MyFarmingInterface<Dog>
    {
        public Dog _oldestInHerd;
        public Dog OldestInHerd
        {
            get { return _oldestInHerd; }
        }

        public bool AttempToBreed(Dog dog1, Dog dog2)
        {
            if (dog1.Name.Length < dog2.Name.Length)
            {
                _oldestInHerd = dog1;
                return true;
            }
            else
            {
                _oldestInHerd = dog2;
                return false;
            }
        }

        public void Information()
        {
            Console.WriteLine("{0} too old to eat duck", OldestInHerd.Name);
        }
    }

    /// <summary>
    /// 泛型类的泛型方法
    /// </summary>
    class GenericClass<T> where T : new()
    {
        public K GenericMethod<K>() where K : struct
        {
            return default(K);
        }
    }

    /// <summary>
    /// 非泛型类的泛型方法
    /// </summary>
    public class GenericMethod
    {
        public void OutputDirect<T>(T t)
        {
            Console.WriteLine(t);
        }

        public void SwitchValue<T>(ref T t, ref T d)
        {
            T temp = t;
            t = d;
            d = temp;
        }

        public void MultiGenericMed<T, K>(T t, K k)
        {
            Console.WriteLine("{0} = {1}", k, t);
        }
    }
}
