using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _108_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicConcept();
            //QueryStep();
            //QueryOperation();
            QueryKeyword();

            Console.ReadLine();
        }

        public static void BasicConcept()
        {
            //Linq: Language Integrated Query
            //SQL: SELECT ID, Name FROM tablename
            //IEnumerable,
            //LINQ to SQL, LINQ to XML, LINQ to DataSet, LINQ to Objects
            #region First
            //int[] numbers = { 5, 10, 8, 3, 6, 12 };

            ////1.Query syntax
            //IEnumerable<int> numQuery1 = from num in numbers
            //                where num % 2 == 0
            //                orderby num
            //                select num;
            //foreach (int num in numQuery1)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("###################");
            ////2.Method Syntax
            //IEnumerable<int> numQuery2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

            //foreach (int item in numQuery2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
            #endregion

            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            //1.Query Syntax
            IEnumerable<int> numQuery1 = from num in numbers
                                         where num % 2 == 0
                                         orderby num
                                         select num;
            foreach (int n in numQuery1)
            {
                Console.WriteLine(n);
            }
            //2.Method Syntax

            IEnumerable<int> numQuery2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            foreach (int i in numQuery2)
            {
                Console.WriteLine(i);
            }
        }

        public static void QueryStep()
        {
            //1.Data Source
            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            //2.Query Creation
            IEnumerable<int> numQuery = from num in numbers
                                        where num % 2 == 0
                                        select num;
            //force to execute
            int count = numQuery.Count();
            Console.WriteLine(count);
            numQuery.ToList();
            numQuery.ToArray();
            //3.Query Execution
            foreach (var item in numQuery)//delay to execute
            {

            }
        }

        public static void QueryOperation()
        {
            int[] numbers = { 0, 1, 2, 4, 6, 7 };

            IEnumerable<int> numQuery = from num in numbers
                                        //where num % 2 == 1 && num % 3 == 1
                                        where num % 2 == 1 || num % 3 == 1
                                        select num;
            foreach (int item in numQuery)
            {
                Console.Write("{0} ", item);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Jack", City = "BeiJing" });
            customers.Add(new Customer { Name = "LiLei", City = "ShangHai" });
            customers.Add(new Customer { Name = "Wangmeimei", City = "BeiJing" });
            IEnumerable<IGrouping<string, Customer>> queryCustomer = from c in customers
                                                                     group c by c.City;
            foreach (var cg in queryCustomer)
            {
                Console.WriteLine(cg.Key);
                foreach (var c in cg)
                {
                    Console.WriteLine(c.Name);
                }
            }

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name = "Jack", ID = 101 });
            employees.Add(new Employee { Name = "Emily", ID = 202 });

            var queryJoin = from c in customers
                            join e in employees on c.Name equals e.Name
                            select new { PersonName = c.Name, PersonID = e.ID, PersonCity = c.City };

            foreach (var p in queryJoin)
            {
                Console.WriteLine("{0},{1},{2}", p.PersonName, p.PersonID, p.PersonCity);
            }
            Console.ReadLine();
        }

        public static void QueryKeyword()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Zhangsan", City = "ShangHai" });
            customers.Add(new Customer { Name = "Lisi", City = "Beijing" });
            customers.Add(new Customer { Name = "Wangwu", City = "Beijing" });
            var queryCustomer = from c in customers
                                group c by c.City into cusGroup
                                where cusGroup.Count() >= 2
                                select new { City = cusGroup.Key, Number = cusGroup.Count() };
            foreach (var c in queryCustomer)
            {
                Console.WriteLine("{0}, {1}",c.City,c.Number);
            }

            string[] strBuffer = { "Hello World","This is Friday","Are you happy?"};
            IEnumerable<string> queryStr = from str in strBuffer
                           let words = str.Split(' ')
                           from word in words
                           let w = word.ToUpper()
                           select w;

            foreach (string item in queryStr)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }

        public string City { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
