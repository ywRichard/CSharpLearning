using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12_LinqToOther.QueryableDemo
{
    public class FakeQueryProvider : IQueryProvider
    {
        public IQueryable CreateQuery(Expression expression)
        {
            Type queryType = typeof(FakeQuery<>).MakeGenericType(expression.Type);
            var constructorArgs = new object[] { this, expression };
            return (IQueryable)Activator.CreateInstance(queryType, constructorArgs);
        }

        public IQueryable<T> CreateQuery<T>(Expression expression)
        {
            Logger.Log(this, expression);
            return new FakeQuery<T>(this, expression);
        }

        public object Execute(Expression expression)
        {
            Logger.Log(this, expression);
            return null;
        }

        public T Execute<T>(Expression expression)
        {
            Logger.Log(this, expression);
            return default(T);
        }
    }
}
