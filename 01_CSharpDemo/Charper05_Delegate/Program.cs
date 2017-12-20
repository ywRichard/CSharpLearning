using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper05_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryCovariance();
            //TryAnonymousMethod();
            //TryDelegateWithReturn();
            //TryEnclosing();
            TryBadEnclosing();
        }

        #region 委托返回类型的协变 covariance

        delegate Stream StreamFactory();

        static MemoryStream GenerateSampleData()
        {
            var buffer = new byte[16];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)i;
            }

            return new MemoryStream(buffer);
        }

        static void TryCovariance()
        {
            StreamFactory factory = GenerateSampleData;//利用协变性实现方法组的转换。MemoryStream转换为了Stream，转换后编译器不知道返回类型其实是MemoryStream，强转会报错。

            using (Stream stream = factory())
            {
                var temp = (MemoryStream)factory();

                int data;
                while ((data = stream.ReadByte()) != -1)
                {
                    Console.WriteLine(data);
                }
            }
        }

        #endregion

        #region Anonymous Method without Return

        static void TryAnonymousMethod()
        {
            Action<string> lamda = str => Console.WriteLine(str);
            lamda("Lamda");

            Action<string> anonymous = delegate (string str) { Console.WriteLine(str); };
            anonymous("Anonymous Method");

            Action<string> methodGroup = Console.WriteLine;//方法组转换，可以省略参数
            methodGroup("Method Group");
        }

        #endregion

        #region Anonymous Method with Return

        static void TryDelegateWithReturn()
        {
            Predicate<int> isEven = delegate (int x) { return x % 2 == 0; };
            Console.WriteLine(isEven(3));
            Console.WriteLine(isEven(4));
        }

        #endregion

        #region 闭包 enclosing

        static void TryEnclosing()
        {
            var list = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                var counter = i * 10;
                list.Add(() =>
                {
                    Console.WriteLine(counter);
                    counter++;
                });

                //list.Add(() =>
                //{
                //    Console.WriteLine(i);
                //    i++;
                //});
            }
            foreach (var action in list)
            {
                action();
            }
            list[0]();
            list[0]();
            list[0]();

            list[1]();
        }
        /// <summary>
        /// 共享和非共享变量的混合使用
        /// </summary>
        static void TryBadEnclosing()
        {
            Action[] actions = new Action[2];

            var outside = 0;
            for (int i = 0; i < 2; i++)
            {
                var inside = 0;
                actions[i] = delegate
                {
                    Console.WriteLine($"{outside},{inside}");
                    outside++;
                    inside++;
                };
            }

            Action first = actions[0];
            Action second = actions[1];

            first();
            first();
            first();

            second();
            second();
        }
        #endregion
    }
}
