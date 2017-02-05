using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _33_用反射调用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Type stu = typeof(Student);

            //MethodInfo say = stu.GetMethod("Say",System.Type.EmptyTypes);//获得无参数方法
            //MethodInfo say = stu.GetMethod("Say",new Type[]{typeof(string)});//获得有参方法
            MethodInfo say = stu.GetMethod("Say", new Type[] { typeof(int) });

            object stuObj = Activator.CreateInstance(stu);

            //say.Invoke(stuObj, null);//设置参数
            //say.Invoke(stuObj,new object[]{(object)"string"});//设置参数
            object reObj = say.Invoke(stuObj, new object[] { 23 });
            
            Console.WriteLine(((int)reObj).ToString());

            Console.ReadLine();
        }
    }

    public class Student
    {
        public void Say()
        {
            Console.WriteLine("It's empty.");
        }

        public void Say(string str)
        {
            Console.WriteLine("It's "+ str);
        }

        //public void Say(int n)
        //{
        //    Console.WriteLine("It's "+n.ToString());
        //}

        public int Say(int n)
        {
            return n + 1;
        }
    }
}
