using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientOfWebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client=new UserInfoBLLReference.UserInfoBLLClient();
            var sum = client.Add(2, 7);
            Console.WriteLine(sum);
        }
    }
}
