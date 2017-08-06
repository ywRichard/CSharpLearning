using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_LamdaBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            #region case 1
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //IEnumerable凡是继承这个接口的数据类型，都可以foreach遍历
            //IEnumerable<int> ies = list.Where(x => x > 5);

            //foreach (int item in ies)
            //{
            //    Console.WriteLine(item.ToString());
            //} 
            #endregion

            #region Action使用方法---声明不带返回值的委托
            //Action Show = delegate() { Console.WriteLine("无参的匿名方法"); };//匿名方法
            //action show = () => console.write("action 是无参的delegate");//拉姆达表达式

            //Show(); 
            #endregion

            #region Func使用方法---声明带返回值的委托
            //Func<int,int,int> Count = delegate(int n1, int n2) { return (n1 * n2); };//匿名方法
            //int n = Count(10, 2);

            //bool为返回值类型，Func<>最后一个参数为返回值类型
            //Func<int, int, bool> Count = delegate (int n1, int n2) { return (n1 == n2); };
            //Console.WriteLine(Count(5, 5));

            //Func<int, int> Count = x => x * 10;//Func<>，拉姆达表达式
            //int n = Count(10);
            //Console.WriteLine(n.ToString()); 
            #endregion

            #region learn Lamda from累加器的使用
            int[] myIntArray = { 1, 2, 3 };
            int result = myIntArray.Aggregate((a, b) => a * b);
            Console.WriteLine(result.ToString());

            string[] curries = { "pathia", "jalfreze", "korma" };
            Console.WriteLine(curries.Aggregate((a, b) => a + " " + b));
            Console.WriteLine(curries.Aggregate(10, (a, b) => a + b.Length));
            Console.WriteLine(curries.Aggregate(
                "Some curries:",
                (a, b) => a + " " + b,
                a => a));
            Console.WriteLine(curries.Aggregate(
                "Some curries:",
                (a, b) => a + " " + b,
                a => a.Length));
            #endregion

        }

        /// <summary>
        /// 含Func<>委托类型
        /// </summary>
        private static void LamdaExpres()
        {
            Func<int, bool> test = x => x == 5;

            Console.WriteLine(test(4));
        }
    }
}
