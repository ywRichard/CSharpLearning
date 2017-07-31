using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _010_CollectionIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ////编译器自己推断item的类型
            //foreach (var item in SimpleList())
            //{
            //    Console.WriteLine(item);
            //}

            #region 计算质数
            //Primes primesFrom2To1000 = new Primes(2, 1000);
            //foreach (var item in primesFrom2To1000)
            //    Console.Write("{0} ", item);
            #endregion

            #region 浅复制
            //ShallowCloner mySource = new ShallowCloner(5);
            //ShallowCloner myTarget = (ShallowCloner)mySource.GetCopy();
            //Console.WriteLine("myTarget.MyContent.Val={0}",myTarget.MyContent.Val);
            //mySource.MyContent.Val = 2;
            ////复制的是mySource的引用，并没有新创建实例，所以mySource的值更改之后myTarget的也会更改。
            //Console.WriteLine("myTarget.MyContent.Val={0}", myTarget.MyContent.Val);
            #endregion

            #region 深复制
            DeepCloner mySource = new DeepCloner(5);
            DeepCloner myTarget = (DeepCloner)mySource.Clone();
            Console.WriteLine("myTarget.MyContent.Val={0}", myTarget.MyContent.Val);
            mySource.MyContent.Val = 2;
            //深复制：myTarget是新建的实例，与mySource没有联系。两者互不影响
            Console.WriteLine("myTarget.MyContent.Val={0}", myTarget.MyContent.Val);
            #endregion


        }

        /// <summary>
        /// 迭代成员
        /// yield->foreach返回值
        /// </summary>
        public static IEnumerable SimpleList()
        {
            yield return "string 1";
            yield return DateTime.Now;
            yield return "string 3";
        }
    }

    /// <summary>
    /// 迭代类 -> 计算质数
    /// </summary>
    public class Primes
    {
        private long min;
        private long max;

        public Primes(long mininum, long maxinum)
        {
            if (min < 2)
                min = 2;
            else
                min = mininum;

            max = maxinum;
        }

        public IEnumerator GetEnumerator()
        {
            for (long posiPrime = min; posiPrime <= max; posiPrime++)
            {
                bool isPrime = true;
                for (long posiFactor = 2; posiFactor <= (long)Math.Floor(Math.Sqrt(posiPrime)); posiFactor++)
                {
                    long remainderAfterDivision = posiPrime % posiFactor;
                    if (remainderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    yield return posiPrime;
                }
            }
        }
    }

    /// <summary>
    /// 浅复制
    /// </summary>
    public class ShallowCloner
    {
        public Content MyContent { get; set; }

        public ShallowCloner(int newVal)
        {
            MyContent = new Content();
            MyContent.Val = newVal;
        }

        public object GetCopy()
        {
            return MemberwiseClone();
        }
    }

    /// <summary>
    /// 深复制
    /// </summary>
    public class DeepCloner:ICloneable
    {
        public Content MyContent { get; set; }

        public object Clone()
        {
            DeepCloner clone = new DeepCloner(MyContent.Val);
            return clone;
        }

        public DeepCloner(int newVal)
        {
            MyContent = new Content();
            MyContent.Val = newVal;
        }
    }

    public class Content
    {
        public int Val { get; set; }
    }

}
