using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _部分类和密封类
{
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
