using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryStreamUtil();
            TryNullUtil();
        }
        /// <summary>
        /// Add Extension Method for Stream
        /// </summary>
        static void TryStreamUtil()
        {
            WebRequest request = WebRequest.Create("http://manning.com");
            using (WebResponse response = request.GetResponse())
            using (Stream input = response.GetResponseStream())
            using (FileStream output = File.Create("response.dat"))
            {
                input.CopyTo(output);
            }
        }

        static void TryNullUtil()
        {
            var x = (object)null;
            Console.WriteLine(x.IsNull());

            var y = new object();
            Console.WriteLine(y.IsNull());
        }
    }
}
