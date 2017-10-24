using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract partial class BaseDAL<T>
        where T : class
    {
        DbContext context = new MyContext();

        public IQueryable<T> GetEntityList(int pageSize,int index)
        {
            return context.Set<T>()
                .OrderByDescending(GetKey())
                .Skip((index - 1) * pageSize)
                .Take(pageSize);
        }

        public T GetEntity(int id)
        {
            return context.Set<T>()
                .Where(GetKeyById(id))
                .FirstOrDefault();
        }

        public int Add(T t)
        {
            context.Set<T>().Add(t);

            return context.SaveChanges();
        }

        public int Edit(T t)
        {
            context.Set<T>().Attach(t);
            context.Entry(t).State = EntityState.Modified;

            return context.SaveChanges();
        }

        public int Remove(int id)
        {
            var entity = GetEntity(id);
            context.Set<T>().Remove(entity);

            return context.SaveChanges();
        }

        public int GetCount()
        {
            return context.Set<BookInfo>().Count();
        }

        public abstract Expression<Func<T, bool>> GetKeyById(int id);
        public abstract Expression<Func<T, int>> GetKey();
    }
}
