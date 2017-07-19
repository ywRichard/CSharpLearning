using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _300_Color
{
    class Program
    {
        static void Main(string[] args)
        {
            var blueStr = "FF0000";
            //var blueHex = Int32.Parse(blueStr, 16);
            var blueInt = Convert.ToInt32(blueStr, 16);

            var blueHex = RGBtoINT("FF");

            Console.WriteLine(blueHex);

        }

        private static int RGBtoINT(string rgb)
        {
            if (rgb.Length != 6)
            {
                var count = 6 - rgb.Length;
                for (int i = 0; i < count; i++)
                {
                    rgb = "0" + rgb;
                }
            }

            var blue = rgb.Substring(0, 2);
            var green = rgb.Substring(2, 2);
            var red = rgb.Substring(4);
            rgb = red + green + blue;

            var result = Convert.ToInt32(rgb, 16);

            return result;
        }
    }


}
