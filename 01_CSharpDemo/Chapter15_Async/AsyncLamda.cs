using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Async
{
    class AsyncLamda
    {
        /// <summary>
        /// 虽然second比first早finished,但是由于first.Result先调用，会阻塞线程。
        /// 所以会先输出first的结果，在输出second的结果
        /// </summary>
        public static void Demo()
        {
            Func<int, Task<int>> function = async x =>
            {
                Console.WriteLine($"Starting... x={x}");
                await Task.Delay(x * 1000);
                Console.WriteLine($"Finished... x={x}");
                return x * 2;
            };

            Task<int> first = function(5);
            Task<int> second = function(3);
            Console.WriteLine($"First result: {first.Result}");
            Console.WriteLine($"Second result: {second.Result}");
        }

        public async Task MainAsync()
        {
            Task<int> task = ComputeLengthAsync(null);
            Console.WriteLine("Fetched the task");
            int length = await task;
            Console.WriteLine($"Length: {length}");
        }

        /// <summary>
        /// 将参数验证和异步操作分离，
        /// 并将异步操作包含到lamda表达式中，同新建一个函数的效果一样
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private Task<int> ComputeLengthAsync(string text)
        {
            if (text==null)
            {
                throw new ArgumentNullException("text");
            }

            Func<Task<int>> func = async () =>
            {
                await Task.Delay(500);
                return text.Length;
            };

            return func();
        }
    }
}
