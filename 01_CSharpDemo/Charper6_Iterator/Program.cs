using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Charper6_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryIterationSampple();
            //TryIterateDateTable();
            //TryReadFileByIterator("");
            //TryIteratorProcess();
        }

        #region IterationSample

        static void TryIterationSampple()
        {
            object[] values = { "a", "b", "c", "d", "e" };
            IterationSample collection = new IterationSample(values, 3);
            foreach (object x in collection)
            {
                Console.WriteLine(x);
            }
        }

        #endregion

        #region 迭代时刻表中的日期
        static void TryIterateDateTable()
        {
            DateTimeTable timeTable = new DateTimeTable
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(3)
            };

            foreach (var item in timeTable.DateRange)
            {
                Console.WriteLine(item.Day);
            }
        }
        #endregion

        #region 迭代器块实现文件读取

        static void TryReadFileByIterator(string fileName)
        {
            //常规方法
            //using (TextReader reader=File.OpenText(fileName))
            //{
            //    string line;
            //    while ((line=reader.ReadLine())!=null)
            //    {

            //    }
            //}

            //迭代器来实现文件读取方式
            foreach (var line in LineReader.ReadLines(fileName))
            {
                Console.WriteLine(line);
            }
        }

        #endregion

        #region 模拟迭代器块的执行流程

        static void TryIteratorProcess()
        {
            IEnumerable<int> iterable = SimulateIteratorProcess.CreateEnumerable();
            IEnumerator<int> iterator = iterable.GetEnumerator();
            Console.WriteLine("Starting to iterator");
            while (true)
            {
                Console.WriteLine("Calling MoveNext()...");
                bool result = iterator.MoveNext();
                Console.WriteLine("... MoveNext Result={0}", result);
                if (!result)
                {
                    break;
                }
                Console.WriteLine("Fetching Current ...");
                Console.WriteLine($"... Current result={iterator.Current}");
            }
        }

        #endregion
    }
}
