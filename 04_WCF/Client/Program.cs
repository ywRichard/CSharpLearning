using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //svcutil工具
            var client = new UserInfoBLLClient();
            var result = client.Add(2, 3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
