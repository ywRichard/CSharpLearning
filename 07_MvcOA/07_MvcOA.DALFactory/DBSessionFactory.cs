using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.IDAL;
using System.Runtime.Remoting.Messaging;

namespace _07_MvcOA.DALFactory
{
    public class DBSessionFactory
    {
        public static IDBSession CreateDbSession()
        {
            IDBSession dbSession = (IDBSession)CallContext.GetData("dbSession");
            
            if (dbSession == null)
            {
                dbSession = new DBSession();
                CallContext.SetData("dbSession", dbSession);
            }

            return dbSession;
        }
    }
}
