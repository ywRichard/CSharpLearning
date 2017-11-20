using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Dynamic;
using _07_MvcOA.IDAL;
using System.Reflection;

namespace _07_MvcOA.DALFactory
{
    /// <summary>
    /// 抽象工厂：与工厂本质是一样的，都是解决对象创建的问题。
    /// 区别：创建对象的方式不一样。
    /// 工厂-> 直接new一个对象。
    /// 抽象工厂-> 通过反射的方式创建实例
    /// </summary>
    public partial class AbstractFactory
    {
        private static readonly string DalAssemblyPath = ConfigurationManager.AppSettings["DalAssemblyPath"];
        private static readonly string NameSpace = ConfigurationManager.AppSettings["NameSpace"];

        //public static IUserInfoDal CreateUserInfoDal()
        //{
        //    //反射创建类实例，需要用类的全名：命名空间+类名
        //    var fullClassName = NameSpace + ".UserInfoDal";//构建类的全名称
        //    return CreateInstance(fullClassName) as IUserInfoDal;
        //}

        public static object CreateInstance(string fullClassName)
        {
            var assembly = Assembly.Load(DalAssemblyPath);//加载程序集
            return assembly.CreateInstance(fullClassName);
        }
    }
}
