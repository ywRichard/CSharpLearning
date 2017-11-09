using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.IDAL;
using _07_MvcOA.Model;

namespace _07_MvcOA.DAL
{
    public class UserInfoDAL : IUserInfoDAL
    {
        DbContext context = new Model1Container();
        /// <summary>
        /// 查询
        /// </summary>
        public IQueryable<UserInfo> LoadEntities(Expression<Func<UserInfo, bool>> whereLambda)
        {
            return context.Set<UserInfo>().Where(whereLambda);
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="isAsc">true-升序;false-降序</param>
        public IQueryable<UserInfo> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<UserInfo, bool>> whereLambda,
            Expression<Func<UserInfo, s>> orderbyLambda, bool isAsc)
        {
            var temp = context.Set<UserInfo>().Where(whereLambda);
            totalCount = temp.Count();
            temp = isAsc ? temp.OrderBy(orderbyLambda) : temp.OrderByDescending(orderbyLambda);

            return temp.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        /// <summary>
        /// 删除
        /// </summary>
        public bool DeleteEntity(UserInfo entity)
        {
            //集合版
            //context.Set<UserInfo>().Remove(entity);
            //状态修改
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges() > 0;
        }
        /// <summary>
        /// 修改
        /// </summary>
        public bool EditEntity(UserInfo entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }
        /// <summary>
        /// 添加
        /// </summary>
        public UserInfo AddEntity(UserInfo entity)
        {
            context.Set<UserInfo>().Add(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
