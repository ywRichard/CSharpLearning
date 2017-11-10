using _07_MvcOA.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.IBLL
{
    public interface IBaseBLL<T> where T : class, new()
    {
        IDBSession GetCurrentSession { get; }
        IBaseDal<T> CurrentDal { get; set; }
        IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount,
            Expression<Func<T, bool>> whereLambda,
            Expression<Func<T, s>> orderbyLambda,
            bool isAsc);
        bool DeleteEntity(T entity);
        bool EditEntity(T entity);
        T AddEntity(T entity);
    }
}
