using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract partial class BaseBLL<T>
        where T : class
    {
        private BaseDAL<T> dal;
        public abstract BaseDAL<T> GetDAL();

        public BaseBLL()
        {
            dal = GetDAL();
        }

        public IQueryable<T> GetEntityList(int pageSize, int index)
        {
            return dal.GetEntityList(pageSize, index);
        }

        public T GetEntity(int id)
        {
            return dal.GetEntity(id);
        }

        public bool Add(T t)
        {
            return dal.Add(t) > 0;
        }

        public bool Edit(T t)
        {
            return dal.Edit(t) > 0;
        }

        public bool Remove(int id)
        {
            return dal.Remove(id) > 0;
        }
    }
}
