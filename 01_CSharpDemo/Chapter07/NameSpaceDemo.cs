using System;
//指定命名空间别名
using WinForms = System.Windows.Forms;
using WebForms = System.Web.UI.WebControls;

class Configuration { }

namespace Chapter07
{
    class WinForms { }
    class Configuration { }
    class NameSpaceDemo
    {
        public NameSpaceDemo()
        {
            //命名空间修饰符，
            Console.WriteLine(typeof(WinForms::Button));
            Console.WriteLine(typeof(WebForms::Button));

            //全局命名空间
            Console.WriteLine(typeof(Configuration));
            Console.WriteLine(typeof(global::Configuration));
            Console.WriteLine(typeof(global::Chapter07.Configuration));//通过global也可以指根命名空间内部的类
        }
    }
}
