using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09_Lamda
{
    public class ExpressionDemo
    {
        public static void BuildExpression()
        {
            Expression first = Expression.Constant(2);
            Expression second = Expression.Constant(3);
            Expression add = Expression.Add(first, second);
            Console.WriteLine(add);
        }

        public static void CompileExpression()
        {
            Expression first = Expression.Constant(2);
            Expression second = Expression.Constant(3);
            Expression add = Expression.Add(first, second);

            Func<int> compiled = Expression.Lambda<Func<int>>(add).Compile();
            Console.WriteLine(compiled());
        }

        public static void ExpressionByLamda()
        {
            Expression<Func<int>> return5 = () => 5;//lamda表达式来创建表达式树
            Func<int> compiled = return5.Compile();
            Console.WriteLine(compiled());
        }

        public static void ComplicatedLamdaExpression()
        {
            Expression<Func<string, string, bool>> expression = (x, y) => x.StartsWith(y);
            var compiled = expression.Compile();

            Console.WriteLine(compiled("First", "Second"));
            Console.WriteLine(compiled("First", "Fir"));
        }

       
    }
}
