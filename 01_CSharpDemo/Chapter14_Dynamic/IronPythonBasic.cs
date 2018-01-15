using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Chapter14_Dynamic
{
    public class IronPythonBasic
    {
        /// <summary>
        /// 在C#中调用内嵌代码
        /// </summary>
        public static void EmbeddedHelloWorld()
        {
            ScriptEngine engine = Python.CreateEngine();
            engine.Execute("print 'hello, world'");
            engine.ExecuteFile("HelloWorld.py");
        }

        /// <summary>
        /// 给Python代码中的变量赋值
        /// </summary>
        public static void ScriptScopeDemo()
        {
            var python = @"
text='hello'
output=input+1
";
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("input", 10);
            engine.Execute(python, scope);
            Console.WriteLine(scope.GetVariable("text"));
            Console.WriteLine(scope.GetVariable("input"));
            Console.WriteLine(scope.GetVariable("output"));
        }

        /// <summary>
        /// 在Python中申明方法，在C#中调用
        /// </summary>
        public static void ScriptScopeDelegate()
        {
            var python = @"
def sayHello(user):
    print 'Hello %(name)s' %{'name':user}
";
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            engine.Execute(python, scope);

            dynamic function = scope.GetVariable("sayHello");
            function("Jon");
        }

        /// <summary>
        /// 演示C#中调用Python代码，python中调用C#代码
        /// </summary>
        public static void PythonComprehension()
        {
            var python = @"
def executeOnEven(list, action):
# Note: replace() with [] for eager evaluation
    evenList = (item for item in list if item % 2 == 0)
    for item in evenList:
        action(item)
";
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            engine.Execute(python, scope);
            dynamic function = scope.GetVariable("executeOnEven");
            IEnumerable<int> numbers = ZeroToTen();
            Action<int> print = x => Console.WriteLine("Received {0}", x);

            function(numbers, print);
        }
        private static IEnumerable<int> ZeroToTen()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Yielding {0}", i);
                yield return i;
            }
        }
    }
}
