using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.IDAL;
using _07_MvcOA.Model;
using System.Data.Entity;
using System.Linq.Expressions;

namespace _07_MvcOA.DAL
{
    public class BaseDal<T> where T : class, new()
    {
        DbContext context = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 查询
        /// </summary>
        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return context.Set<T>().Where(whereLambda);
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="isAsc">true-升序;false-降序</param>
        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda,
            Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            var temp = context.Set<T>().Where(whereLambda);
            totalCount = temp.Count();
            temp = isAsc ? temp.OrderBy(orderbyLambda) : temp.OrderByDescending(orderbyLambda);

            return temp.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        /// <summary>
        /// 删除
        /// </summary>
        public bool DeleteEntity(T entity)
        {
            //集合版
            //context.Set<UserInfo>().Remove(entity);
            //状态修改
            context.Entry(entity).State = EntityState.Deleted;
            //return context.SaveChanges() > 0;
            return true;
        }
        /// <summary>
        /// 修改
        /// </summary>
        public bool EditEntity(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            //return context.SaveChanges() > 0;
            return true;
        }
        /// <summary>
        /// 添加
        /// </summary>
        public T AddEntity(T entity)
        {
            //context.Set<T>().Add(entity);
            context.Entry(entity).State = EntityState.Added;
            //context.SaveChanges();
            return entity;
        }
    }
}
