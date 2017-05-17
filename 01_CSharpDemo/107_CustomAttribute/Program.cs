using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _107_CustomAttribute
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            HelpAttribute helpattribute;
            foreach (var attr in typeof(AnyClass).GetCustomAttributes(true))
            {
                helpattribute = attr as HelpAttribute;
                if (helpattribute != null)
                {
                    Console.WriteLine("AnyClass Description: {0}", helpattribute.Description);
                    Console.WriteLine("AnyClass Name: {0}",helpattribute.Name);
                }
            }

            Console.ReadLine();
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class HelpAttribute : Attribute
    {
        protected string description;

        public HelpAttribute(string description_in)
        {
            this.description = description_in;
        }

        public string Description
        {
            get { return this.description; }
        }

        public string Name
        {
            get;
            set;
        }
    }

    [Help("helpattribute", Name = "Jikexueyuan")]
    public class AnyClass
    {

    }
}
