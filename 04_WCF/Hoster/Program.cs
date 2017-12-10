using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hoster
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address已经在配置文件中配置，这里不需要再传参
            using (ServiceHost host = new ServiceHost(typeof(BLL.UserInfoBLL)))
            {
                host.Open();
                Console.WriteLine("服务器启动！！");
                Console.ReadKey();
            }
        }
    }
}
