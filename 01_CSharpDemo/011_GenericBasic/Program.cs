using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_GenericBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 可空类型
            //System.Nullable<int> nullInt;
            //int? nullInt;
            //nullInt = null;

            //if (nullInt == null)
            //{
            //    Console.WriteLine("nullInt={0}", nullInt.GetValueOrDefault(3));
            //}

            ////引用类型会抛异常 -> 对象为null调用成员
            //if (nullInt.HasValue)
            //{
            //    Console.WriteLine("nullInt.HasValue");
            //}

            //int? para = null;
            //int para2 = 5;
            //int? result = para * para2;
            //Console.WriteLine(result);
            #endregion

            #region ??运算符
            //int? obj1 = null;
            //int? obj2 = null;
            ////若第一个null,则判断第二个。
            ////int result = obj1 * 2 ?? 5;
            //int? result = obj1 * obj2;
            //Console.WriteLine(result);
            #endregion

            #region 可空类型实例
            //Vector v1 = GetVector("vector1");
            //Vector v2 = GetVector("vector2");

            //Console.WriteLine("{0}+{1}={2}", v1, v2, v1 + v2);
            //Console.WriteLine("{0}+{1}={2}", v1, v2, v1 - v2);
            #endregion

            #region 泛型的排序和搜素
            //Vectors route = new Vectors();
            //route.Add(new Vector(2.0, 90.0));
            //route.Add(new Vector(1.0, 180.0));
            //route.Add(new Vector(0.5, 45.0));
            //route.Add(new Vector(2.5, 315.0));

            //Console.WriteLine(route.Sum());

            ////Comparison -> 用于泛型排序
            //Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegates.Compare);
            //route.Sort(sorter);
            //Console.WriteLine(route.Sum());

            ////Predictate -> 用于泛型搜索
            //Predicate<Vector> searcher = new Predicate<Vector>(VectorDelegates.TopRightQuadrant);
            //Vectors topRightQuadrantRoute = new Vectors(route.FindAll(searcher));
            //Console.WriteLine(topRightQuadrantRoute.Sum());
            #endregion

            #region Dictionary
            //不区分大小写
            Dictionary<string, int> dc = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

            dc.Add("abd", 1);
            dc.Add("aBd", 2);
            #endregion

        }

        static Vector GetVector(string name)
        {
            Console.WriteLine("Input {0} magnitude:", name);
            double? r = GetNullableDouble();
            Console.WriteLine("Input {0} angle (in degrees):", name);
            double? theta = GetNullableDouble();
            return new Vector(r, theta);
        }

        static double? GetNullableDouble()
        {
            double? result;
            string userInput = Console.ReadLine();
            try
            {
                result = double.Parse(userInput);
            }
            catch
            {
                result = null;
            }
            return result;
        }
    }

    class Vector
    {
        public double? R = null;
        public double? Theta = null;

        public double? ThetaRadians
        {
            get
            {
                return (Theta * Math.PI / 180.0);
            }
        }

        public Vector(double? r, double? theta)
        {
            if (r < 0)
            {
                r = -r;
                theta += 180;
            }
            theta = theta % 360;

            R = r;
            Theta = theta;
        }

        public static Vector operator +(Vector op1, Vector op2)
        {
            try
            {
                double newX = op1.R.Value * Math.Sin(op1.ThetaRadians.Value);
                double newY = op2.R.Value * Math.Sin(op2.ThetaRadians.Value);

                double newR = Math.Sqrt(newX * newX + newY * newY);
                double newTheta = Math.Atan2(newX, newY) * 180.0 / Math.PI;

                return new Vector(newR, newTheta);
            }
            catch
            {
                return new Vector(null, null);
            }
        }

        public static Vector operator -(Vector op1)
        {
            return new Vector(-op1.R, op1.Theta);
        }

        public static Vector operator -(Vector op1, Vector op2)
        {
            return op1 + (-op2);
        }

        public override string ToString()
        {
            string rString = R.HasValue ? R.ToString() : "null";
            string thetaString = Theta.HasValue ? Theta.ToString() : "null";

            return string.Format("({0},{1})", rString, thetaString);
        }
    }

    class Vectors : List<Vector>
    {
        public Vectors()
        {

        }

        public Vectors(IEnumerable<Vector> initialItems)
        {
            foreach (Vector item in initialItems)
            {
                //这是在构造函数中，Add是为当前要构造的对象实例添加item。this被省略
                Add(item);
            }
        }
        public string Sum()
        {
            StringBuilder sb = new StringBuilder();
            Vector currentPoint = new Vector(0.0, 0.0);
            sb.Append("origin");
            foreach (var item in this)
            {
                sb.AppendFormat("+{0}", item);
                currentPoint += item;
            }
            sb.AppendFormat("={0}", currentPoint);
            return sb.ToString();
        }
    }

    static class VectorDelegates
    {
        public static int Compare(Vector x, Vector y)
        {
            if (x.R > y.R)
            {
                return 1;
            }
            else if (x.R < y.R)
            {
                return -1;
            }
            return 0;
        }

        public static bool TopRightQuadrant(Vector target)
        {
            if (target.Theta >= 0.0 && target.Theta <= 90.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
