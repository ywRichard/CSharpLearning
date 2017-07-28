using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _010_List
{
    /// <summary>
    /// List<T>, 泛型集合练习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 两个List集合{a,b,c,d,e}和{d,e,f,g,h}，去除重复项，合并集合
            //List<string> list1 = new List<string>() { "a", "b", "c", "d", "e" };
            //List<string> list2 = new List<string>() { "d", "e", "f", "g", "h" };

            //List<string> list = new List<string>();
            //list.AddRange(list1.Union(list2).Distinct());

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 随机生成1-100之间的数放到List中，要求这10个数不能重复，并且都是偶数.
            //List<int> list = new List<int>();
            //Random rd = new Random();
            //int count = 0;

            //while (list.Count < 10)
            //{
            //    int num = rd.Next(1, 101);
            //    if (num % 2 == 0)
            //    {
            //        if (!list.Contains(num))
            //        {
            //            list.Add(num);
            //        }
            //    }
            //    count++;
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine("循环次数{0}", count);
            #endregion

            #region T为对象
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "老虎", Age = 10, Gender = '男' });
            list.Add(new Person() { Name = "老鼠", Age = 12, Gender = '女' });
            list.Add(new Person() { Name = "老狼", Age = 9, Gender = '女' });

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            #endregion

            Console.ReadLine();
        }
    }

    public class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        /// <summary>
        /// 重写ToString函数
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
