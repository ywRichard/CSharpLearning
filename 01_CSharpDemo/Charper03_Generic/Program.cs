using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Charper03_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //GernericDeleagateDemo();
            //GernericDefaultCompare();
            //GernericRefEqual();
            //EqualityComparer();
            //ReflectOfGeneric.GetTypeof<int>();
            //TryEnumerator();
            //TryGenericOrConstructedType();
            //InvokeGenericMethod();
        }

        #region IEquatable && IEqualityComparer<T1>
        /// <summary>
        /// 两个值比较，和自身比较
        /// </summary>
        private static void EqualityComparer()
        {
            var pair = new Pair<int, string>(1, "1");
            var result = pair.Equals(new Pair<int, string>(2, "2")) ? "ok" : "no";
            Console.WriteLine(result);
        }

        #endregion

        #region GernericDeleagateDemo

        private static void GernericDeleagateDemo()
        {
            var list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);
            //ConvertAll就是通过泛型委托来调用泛型方法
            Converter<int, double> converter = GetSquart;
            //var doubles = list.ConvertAll(converter);
            var doubles = list.ConvertAll(i => Math.Sqrt(i));
            foreach (var value in doubles)
            {
                Console.WriteLine(value);
            }
        }

        static double GetSquart(int value)
        {
            return Math.Sqrt(value);
        }

        #endregion

        #region GernericDefaultCompare
        /// <summary>
        /// 每种类型都有默认值，与默认值比较。
        /// 大于：1；等于：0；小于：-1；
        /// </summary>
        static void GernericDefaultCompare()
        {
            //引用类型的默认值是null，所有引用类型的值都大于null
            Console.WriteLine(ComparerToDefault("x"));
            Console.WriteLine(ComparerToDefault(10));
            Console.WriteLine(ComparerToDefault(0));
            Console.WriteLine(ComparerToDefault(-10));
            Console.WriteLine(ComparerToDefault(DateTime.MinValue));
        }

        static int ComparerToDefault<T>(T value) where T : IComparable<T>
        {
            //比较泛型实参的默认值，也就是类型的默认值。在声明变量类型但未初始化之前，编译器会分配默认值
            return value.CompareTo(default(T));
        }

        static void GernericRefEqual()
        {
            var name = "Joy";
            var info1 = "My name is" + name;
            var info2 = "My name is" + name;
            Console.WriteLine(info1 == info2);
            Console.WriteLine(AreReferencesEqual(info1, info2));
        }

        static bool AreReferencesEqual<T>(T first, T second) where T : class
        {
            return first == second;
        }
        #endregion

        #region Enumerator枚举器的实现

        private static void TryEnumerator()
        {
            var counter = new CountingEnumerable();
            foreach (var count in counter)
            {
                Console.WriteLine(count);
            }
        }

        #endregion

        #region Get Generic & Constructed Type for class
        /// <summary>
        /// 获取泛型和已构造Type对象的各种方式
        /// 针对泛型类型
        /// </summary>
        private static void TryGenericOrConstructedType()
        {

            var listTypeName = "System.Collections.Generic.List`1";
            Type defByName = Type.GetType(listTypeName);

            //以下代码的作用---得到泛型类型已知的类型引用
            Type closedByName = Type.GetType(listTypeName + "[System.String]");
            //传递一个类型实参，使泛型封闭
            Type closedByMethod = defByName.MakeGenericType(typeof(string));
            Type closedByTypeof = typeof(List<string>);
            Console.WriteLine($"closedByMethod:{closedByMethod};closedByName:{closedByName}");
            Console.WriteLine(closedByMethod == closedByName);
            Console.WriteLine(closedByName == closedByTypeof);

            //以下代码的作用---得到泛型类型未指定的类型引用
            Type defByTypeof = typeof(List<>);
            //从已知类型的泛型中得到泛型类型的定义
            Type defByMethod = closedByName.GetGenericTypeDefinition();
            Console.WriteLine($"defByMethod:{defByMethod};defByName:{defByName}");
            Console.WriteLine(defByMethod == defByName);
            Console.WriteLine($"defByName:{defByName};defByTypeof:{defByTypeof}");
            Console.WriteLine(defByName == defByTypeof);
        }

        #endregion

        #region Get Generic & Constructed Type for method
        /// <summary>
        /// 如何调用一个泛型方法
        /// </summary>
        private static void InvokeGenericMethod()
        {
            Type type = typeof(Snippet);//1、获取类型的引用信息
            //对于泛型方法
            MethodInfo definition = type.GetMethod("PrintTypeParameter");//2、获取要调用的泛型方法
            MethodInfo constructed = definition.MakeGenericMethod(typeof(string));//3、指定泛型参数类型
            constructed.Invoke(null, null);//调用方法，第一个参数是调用方法的实例，静态类型方法为null；第二个参数是要传递的实参数组，没有参数的也为null

            //普通方法
            MethodInfo output = type.GetMethod("Output");//2、获取要调用的方法，不适用于重载
            var temp = new Snippet { Owner = "temp" };//3、非静态方法要先new实例
            output.Invoke(temp, new[] { "haha" });//4、调用方法，传递调用的实例和方法实参

            //方法重载
            MethodInfo[] outputs = type.GetMethods();
            foreach (var methodInfo in outputs)
            {
                if (methodInfo.Name != "OverloadMethod")
                    continue;
                var length = methodInfo.GetParameters().Length;
                if (length == 1)
                    methodInfo.Invoke(temp, new[] {"str"});
                else if(length==2)
                    methodInfo.Invoke(temp, new[] { "abc", "ABC"});
            }

        }
        #endregion
    }

    class Snippet
    {
        public string Owner { get; set; }
        public static void PrintTypeParameter<T>()
        {
            Console.WriteLine(typeof(T));
        }

        public void Output(string str)
        {
            Console.WriteLine($"{Owner} Invoked successful:{str}");
        }

        public void OverloadMethod(string str1, string str2)
        {
            Console.WriteLine($"Invoke overload method2: {str1}+{str2}");
        }
        public void OverloadMethod(string str)
        {
            Console.WriteLine($"Invoke overload method1: {str}");
        }
    }

}
