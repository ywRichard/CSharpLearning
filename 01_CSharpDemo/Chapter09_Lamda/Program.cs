using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter09_Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            //SubscribeEventByLamda();
            #region Try Expression Demo

            //ExpressionDemo.BuildExpression();
            //ExpressionDemo.CompileExpression();
            //ExpressionDemo.ExpressionByLamda();
            //ExpressionDemo.ComplicatedLamdaExpression();

            #endregion

            TryConvertTwice();
        }

        static void SubscribeEventByLamda()
        {
            var button = new Button { Text = "Click me" };
            button.Click += (src, e) => Log("Click", src, e);
            button.KeyPress += (src, e) => Log("KeyPress", src, e);
            button.MouseClick += (src, e) => Log("MouseClick", src, e);

            var form = new Form {AutoSize = true, Controls = {button}};
            Application.Run(form);
        }
        static void Log(string title, object sender, EventArgs e)
        {
            Console.WriteLine($"Event:{title}");
            Console.WriteLine($" Sender:{sender}");
            Console.WriteLine($" Arguments:{e.GetType()}");
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(e))
            {
                var name = prop.DisplayName;
                var value = prop.GetValue(e);
                Console.WriteLine($"    {name}={value}");
            }
        }

        #region 多级类型转换

        static void ConvertTwice<TInput, TMiddle, TOutput>(
            TInput input,
            Converter<TInput, TMiddle> firstConversion,
            Converter<TMiddle, TOutput> secondConversion)
        {
            TMiddle middle = firstConversion(input);
            TOutput output = secondConversion(middle);
            Console.WriteLine(output);
        }

        static void TryConvertTwice()
        {
            ConvertTwice("Another string", text => text.Length, length => Math.Sqrt(length));
        }

        #endregion
    }
}
