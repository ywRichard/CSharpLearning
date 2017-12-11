using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            var client=new UserInfoServiceReference.UserInfoBLLClient();
            var sum = client.Add(1, 2);
            Console.WriteLine(sum);

        }
    }
}
