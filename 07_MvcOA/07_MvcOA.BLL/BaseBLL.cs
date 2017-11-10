using System;
using System.Linq;
using System.Linq.Expressions;
using _07_MvcOA.DALFactory;
using _07_MvcOA.IDAL;

namespace _07_MvcOA.BLL
{
    public abstract class BaseBLL<T> where T : class, new()
    {
        public IDBSession GetCurrentSession
        {
            get
            {
                //return new DBSession();//会多次new对象，且线程内不唯一
                return DBSessionFactory.CreateDbSession();
            }
        }

        public IBaseDal<T> CurrentDal { get; set; }
        public abstract void SetCurrentDal();

        public BaseBLL()
        {
            SetCurrentDal();
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.LoadEntities(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount,
            Expression<Func<T, bool>> whereLambda,
            Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            return CurrentDal.LoadPageEntities(pageIndex, pageSize, out totalCount, whereLambda, orderbyLambda, isAsc);
        }

        public bool DeleteEntity(T entity)
        {
            CurrentDal.DeleteEntity(entity);
            return GetCurrentSession.SaveChanges();
        }
        public bool EditEntity(T entity)
        {
            CurrentDal.EditEntity(entity);
            return GetCurrentSession.SaveChanges();
        }
        public T AddEntity(T entity)
        {
            CurrentDal.AddEntity(entity);
            return entity;
        }
    }
}