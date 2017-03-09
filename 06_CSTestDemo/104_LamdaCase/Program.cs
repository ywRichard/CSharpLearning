using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27_拉姆达表达式案例
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 案例一
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
            //Action Show = () => Console.Write("Action 是无参的delegate");//拉姆达表达式

            //Show(); 
            #endregion

            #region Func使用方法---声明带返回值的委托
            //Func<int,int,int> Count = delegate(int n1, int n2) { return (n1 * n2); };//匿名方法
            //int n = Count(10, 2);

            //Func<int, int> Count = x => x * 10;//Func<>，拉姆达表达式
            //int n = Count(10);
            //Console.WriteLine(n.ToString()); 
            #endregion

            Console.ReadLine();


        }
    }
}
