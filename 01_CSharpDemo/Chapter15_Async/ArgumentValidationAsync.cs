using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Async
{
    class ArgumentValidationAsync
    {
        public static async Task MainAsync()
        {
            //var task = ComputerLengthAsync(null);
            var task = ComputerLengthAsyncEager(null);
            Console.WriteLine("Fetched the task");
            var length = await task;
            Console.WriteLine($"Length:{length}");
        }

        /// <summary>
        /// 异步的参数验证
        /// 即使在await之前，已经抛出了异常。调用方法也只能在到等待返回任务的时候获得这个异常
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static async Task<int> ComputerLengthAsync(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }
            await Task.Delay(500);
            return text.Length;
        }

        /// <summary>
        /// 将参数验证和异步方法分离开
        /// 如果验证参数失败，调用代码会立即获得这个异常，并终止代码的继续进行。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static Task<int> ComputerLengthAsyncEager(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }
            return ComputerLengthAsyncImpl(text);
        }

        /// <summary>
        /// 真正的异步方法
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static async Task<int> ComputerLengthAsyncImpl(string text)
        {
            await Task.Delay(500);
            return text.Length;
        }
    }
}
