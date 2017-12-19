using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryNullableDisplay();
            //TryBoxNullable();
            //TryMergeNullable();
            //TryAsNullable(10);
            TryCompare();
        }

        #region Nullable Convert Value
        /// <summary>
        /// 转换有值和无值的可空类型
        /// </summary>
        /// <param name="x"></param>
        private static void Display(Nullable<int> x)
        {
            Console.WriteLine("HasValue:{0}", x.HasValue);
            if (x.HasValue)
            {
                Console.WriteLine("Value:{0}", x.Value);
            }
            Console.WriteLine("GetValueOrDefault(): {0}", x.GetValueOrDefault());
            //指定返回的默认值
            Console.WriteLine("GetValueOrDefault(10): {0}", x.GetValueOrDefault(10));
            Console.WriteLine("ToString():\"{0}\"", x.ToString());
            Console.WriteLine("GetHashCode():\"{0}\"", x.GetHashCode());
            Console.WriteLine("==================");
        }

        private static void TryNullableDisplay()
        {
            //int? x = 5;
            Nullable<int> x = 5;
            //x=new int? (5);
            x = new Nullable<int>(5);
            Console.WriteLine("Instance with value:");
            Display(x);

            x = new Nullable<int>();//new空的值类型
            Console.WriteLine("Instance without value:");
            Display(x);
        }

        #endregion

        #region nullable box & unbox

        private static void TryBoxNullable()
        {
            Nullable<int> nullable = 5;
            object boxed = nullable;
            Console.WriteLine(boxed.GetType());//获得装箱后的类型

            int normal = (int)boxed;
            Console.WriteLine(normal);//拆箱 -> 值类型

            nullable = (Nullable<int>)boxed;
            Console.WriteLine(nullable);//拆箱 -> 可空的值类型

            nullable = new Nullable<int>();
            boxed = nullable;//装箱空的值类型

            Console.WriteLine(boxed == null);

            nullable = (Nullable<int>)boxed;//拆箱空的值类型
            Console.WriteLine(nullable.HasValue);
            Console.WriteLine("+++" + nullable + "====");
        }

        #endregion

        #region ?? -> 空合并操作符

        private static void TryMergeNullable()
        {
            int? a = 5;
            int b = 10;
            int? d = null;
            int c = a ?? b;
            var e = d ?? a;
            Console.WriteLine(c);
            Console.WriteLine(e);
        }

        #endregion

        #region as -> 可空类型

        private static void TryAsNullable(object o)
        {
            int? a = o as int?;
            Console.WriteLine(a.HasValue ? a.Value.ToString() : "null");
        }

        #endregion

        #region Customer

        private static int Compare(Customer first, Customer second)
        {
            return PartialComparer.ReferenceCompare(first, second) ??
                   //调换参数位置，可以反转排列顺序
                   PartialComparer.Compare(second.Country, first.Country) ??
                   PartialComparer.Compare(first.Region, second.Region) ??
                   PartialComparer.Compare(first.Sales, second.Sales) ?? 
                   0;
        }

        private static void TryCompare()
        {
            List<Customer> customers = new List<Customer>
                {
                    new Customer { ID="A", City="New York", Country="USA",
                    Region="North America", Sales=9999},
                    new Customer { ID="B", City="Mumbai", Country="India",
                    Region="Asia", Sales=8888},
                    new Customer { ID="C", City="Karachi", Country="Pakistan",
                    Region="Asia", Sales=7777},
                    new Customer { ID="D", City="Delhi", Country="India",
                    Region="Asia", Sales=6666},
                    new Customer { ID="E", City="São Paulo", Country="Brazil",
                    Region="South America", Sales=5555 },
                    new Customer { ID="F", City="Moscow", Country="Russia",
                    Region="Europe", Sales=4444 },
                    new Customer { ID="G", City="Seoul", Country="Korea",
                    Region="Asia", Sales=3333 },
                    new Customer { ID="H", City="Istanbul", Country="Turkey",
                    Region="Asia", Sales=2222 },
                    new Customer { ID="I", City="Shanghai", Country="China",
                    Region="Asia", Sales=1111 },
                    new Customer { ID="J", City="Lagos", Country="Nigeria",
                    Region="Africa", Sales=1000 },
                    new Customer { ID="K", City="Mexico City", Country="Mexico",
                    Region="North America", Sales=2000 },
                    new Customer { ID="L", City="Jakarta", Country="Indonesia",
                    Region="Asia", Sales=3000 },
                    new Customer { ID="M", City="Tokyo", Country="Japan",
                    Region="Asia", Sales=4000 },
                    new Customer { ID="N", City="Los Angeles", Country="USA",Region="North America", Sales=5000 },
                    new Customer { ID="O", City="Cairo", Country="Egypt",
                    Region="Africa", Sales=6000 },
                    new Customer { ID="P", City="Tehran", Country="Iran",
                    Region="Asia", Sales=7000 },
                    new Customer { ID="Q", City="London", Country="UK",
                    Region="Europe", Sales=8000 },
                    new Customer { ID="R", City="Beijing", Country="China",
                    Region="Asia", Sales=9000 },
                    new Customer { ID="S", City="Bogotá", Country="Colombia",
                    Region="South America", Sales=1001 },
                    new Customer { ID="T", City="Lima", Country="Peru",
                    Region="South America", Sales=2002 }
                };//For Complicated Object

            customers.Sort(Compare);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ID);
            }
        }

        #endregion
    }

    class Customer
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public decimal Sales { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + " City: " + City + " Country: " + Country +
                   " Region: " + Region + " Sales: " + Sales;
        }
    }
}
