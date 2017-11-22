using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.DAL;
using _07_MvcOA.IDAL;
using _07_MvcOA.Model;
using System.Data.Entity;

namespace _07_MvcOA.DALFactory
{
    /// <summary>
    /// DBSession：工厂类（数据会话层）
    /// 作用：创建数据操作类的实例，业务层通过DBSession调用相应的数据操作类的实例，这样的业务层和数据层解耦。
    /// </summary>
    public partial class DBSession : IDBSession
    {
        public DbContext Context
        {
            get { return DbContextFactory.CreateDbContext(); }
        }

        /// <summary>
        /// 一个业务中有可能涉及到对多张表的操作，那么可以将操作的数据传递到数据层中相应的方法，打上相应的标记，最后调用该方法。
        /// 将数据一次性递交到数据库中，避免多次链接数据库
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            return Context.SaveChanges() > 0;
        }
    }
}
