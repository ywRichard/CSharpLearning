using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.Model;

namespace _07_MvcOA.DAL
{
    public class DbContextFactory
    {
        /// <summary>
        /// 保证EF上下文实例在线程内唯一
        /// </summary>
        /// <returns></returns>
        public static DbContext CreateDbContext()
        {
            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new OAEntities();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
}
