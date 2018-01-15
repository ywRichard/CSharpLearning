using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryDynamicBasic();
            //TryDynamicBasic1();
            //TryDynamicBasic2();

            //IronPythonBasic.EmbeddedHelloWorld();
            //IronPythonBasic.ScriptScopeDemo();
            //IronPythonBasic.ScriptScopeDelegate();
            //IronPythonBasic.PythonComprehension();

            //TryDynamicTypeInference();

            //TryDynamicSum();
            //TryDynamicTimeSpanSum();

            //TryDuckTypeCount();

            TryMultipleDispatch();
        }


        static void TryDynamicBasic()
        {
            dynamic list = new List<string> { "First", "Second", "Third" };
            dynamic valueToAdd = "!";
            foreach (dynamic item in list)
            {
                string result = item + valueToAdd;
                Console.WriteLine(result);
            }
        }
        static void TryDynamicBasic1()
        {
            dynamic list = new List<string> { "First", "Second", "Third" };
            dynamic valueToAdd = 2;
            foreach (dynamic item in list)
            {
                string result = item + valueToAdd;
                Console.WriteLine(result);
            }
        }
        static void TryDynamicBasic2()
        {
            dynamic list = new List<int> { 1, 2, 3 };
            dynamic valueToAdd = 2;
            foreach (dynamic item in list)
            {
                //抛RuntimeBinderException
                //string result = item + valueToAdd;
                //Console.WriteLine(result);

                //利用重载，不直接使用结果变量
                Console.WriteLine(item + valueToAdd);
            }
        }

        static void TryDynamicTypeInference()
        {
            object list = new List<string> { "x", "y" };
            object item = "z";
            Console.WriteLine(Reflection.AddConditionally(list, item));
        }

        static void TryDynamicSum()
        {
            var bytes = new byte[] { 1, 2, 3 };
            Console.WriteLine(bytes.DynamicSum());
        }
        static void TryDynamicTimeSpanSum()
        {
            var times = new List<TimeSpan>
            {
                2.Hours(),25.Minutes(),30.Seconds(),45.Seconds(),40.Minutes()
            };

            Console.WriteLine(times.DynamicSum());
        }

        static void TryDuckTypeCount()
        {
            DuckTypeCount.PrintCount(new BitArray(10));
            DuckTypeCount.PrintCount(new HashSet<int> { 1, 3 });
            DuckTypeCount.PrintCount(new List<int> { 1, 3, 5 });
        }

        static void TryMultipleDispatch()
        {
            MultipleDispatch.PrintCount(new BitArray(5));
            MultipleDispatch.PrintCount(new HashSet<int> { 1, 3 });
            MultipleDispatch.PrintCount("ABC");
            MultipleDispatch.PrintCount("ABCDEF".Where(c => c > 'B'));
        }
    }
}
