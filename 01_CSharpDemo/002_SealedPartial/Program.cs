using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_SealedPartial
{
    /// <summary>
    /// partial：解决同一命名空间下，类名不重复的问题。
    /// sealed: 不能被继承，可以继承与其他类。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public partial class Person
    {
        private string _name;
    }

    public partial class Person
    {
        public void Test()
        { 
        
        }

        //private string _name;
    }

    public sealed class Animal
    { 
    
    }

    //public class Monkey : Animal
    //{ 
    
    //}

    public sealed class Student : Person
    { 
    
    }
}
