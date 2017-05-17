using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_PolyByAbstract
{
    /// <summary>
    /// 矩形和圆形求面积案例，通过抽象类实现多态。
    /// 实现多态的三种方法：抽象类，虚方法，接口
    /// 抽象类：父类中没有默认实现，父类也不需要被实例化，则可以将该类定义为抽象类。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //用多态实现求矩形和圆形的面积和周长。
            Shape sp = new Circle(5);//new Squre(10, 12)
            Console.WriteLine("面积是{0}，周长是{1}", sp.Area(), sp.Perimeter());
            Console.ReadKey();
        }
    }

    #region 多态的练习
    //public abstract class Shape
    //{
    //    public abstract double Area();
    //    public abstract double PeriMeter();
    //}

    //public class Circle : Shape
    //{
    //    private double _r;

    //    public double R
    //    {
    //        get { return _r; }
    //        set { _r = value; }
    //    }

    //    public Circle(double r)
    //    {
    //        this.R = r;
    //    }

    //    public override double Area()
    //    {
    //        return Math.PI * this.R * this.R;
    //    }

    //    public override double PeriMeter()
    //    {
    //        return Math.PI * 2 * this.R;
    //    }
    //}

    //public class Squre : Shape
    //{
    //    private int _height;

    //    public int Height
    //    {
    //        get { return _height; }
    //        set { _height = value; }
    //    }

    //    private int _width;

    //    private int Width
    //    {
    //        get { return _width; }
    //        set { _width = value; }
    //    }

    //    public Squre(int height, int width)
    //    {
    //        this.Height = height;
    //        this.Width = width;
    //    }

    //    public override double Area()
    //    {
    //        return this.Height * this.Width;
    //    }

    //    public override double PeriMeter()
    //    {
    //        return (this.Height + this.Width) * 2;
    //    }
    //} 
    #endregion

    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle:Shape
    {
        int _r;
        public int R
        {
            get { return _r; }
            set {this._r = value; }
        }

        public Circle(int r)
        {
            this.R = r;
        }

        public override double Area()
        {
            return Math.PI * this.R * this.R;
        }

        public override double Perimeter()
        {
            return 2 * this.R * Math.PI;
        }
    }

    public class Squre:Shape
    {
        private int _height;
        public int Height
        {
            get { return _height; }
            set { this._height = value; }
        }

        private int _width;
        public int Width
        {
            get { return _width; }
            set { this._width = value; }
        }

        public Squre(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double Area()
        {
            return this.Height * this.Width;
        }

        public override double Perimeter()
        {
            return 2 * (this.Height * this.Width);
        }
    }
}
