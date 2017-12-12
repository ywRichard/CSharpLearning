using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace _03_MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取连接字符串
            var connStr = ConfigurationManager.AppSettings["MongoDbServer"];
            //创建mongodb服务对应的对象
            MongoServer _server = MongoServer.GetAllServers()[0];//如果读取mongoServer?
            //获取数据库；如果没有会自动创建一个
            MongoDatabase _db = _server.GetDatabase("Shop");
            //指定集合的名字
            var collectionName = typeof(Customer).Name;
            //获取集合，如果集合不存在，那么直接创建一个
            var collection = _db.GetCollection<Customer>(collectionName);

            #region 添加实体

            for (int i = 0; i < 100; i++)
            {
                var customer = new Customer();//创建实体
                customer.CusId = i;
                customer.Name = "abc" + i;
                customer.SubTime = DateTime.Now;

                customer.Demo = "ddd";
                if (i == 10)
                {
                    customer.Demo = "sssss";
                }

                customer.Datetime = DateTime.Now.ToString();
                //蒋数据插入到集合里面
                collection.Insert(customer);
            }

            //Console.WriteLine(collection.Count());

            #endregion

            #region 查询全部

            //var temp = collection.FindAll();//查询全部
            //foreach (var customer in temp)
            //{
            //    Console.WriteLine(customer.Id + "--" + customer.CusId + "-----" + customer.SubTime.ToString());
            //}

            #endregion

            ////查询demo
            ////var queryDemoData = collection.FindOneById();
            //var queryDemoData = collection.Find(Query.EQ("CusId", 3));
            ////查询使用静态类Query所在命名空间 MongoDB.Driver.Builders;
            //foreach (var customer in queryDemoData)
            //{
            //    Console.WriteLine(customer.Name);
            //}

            Console.ReadKey();
        }
    }
}
