using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_class
{
    public class Ticket
    {
        //写一个Ticket类,有一个距离属性(本属性只读,在构造方法中赋值),不能为负数,
        //有一个价格属性,价格属性只读,
        //并且根据距离distance计算价格Price (1元/公里):
        //有一个方法,可以显示这张票的信息.90公里90块钱

        #region 我的练习
        //public Ticket(int distance)
        //{
        //   _distance = distance;
        //}

        //int _distance;
        //public int Distance
        //{
        //    get
        //    {
        //        if (_distance < 0)
        //        {
        //            _distance = 0;
        //        }
        //        return _distance;
        //    }
        //}

        //double _price;
        //public double Price
        //{
        //    get
        //    {
        //        if (_price < 0)
        //        {
        //            _price = 0;
        //        }
        //        return _price;
        //    }
        //}

        //public void TotalPrice()
        //{
        //    double charge;
        //    int distance = this.Distance;
        //    //0-100公里        票价不打折
        //    //101-200公里    总额打9.5折
        //    //201-300公里    总额打9折
        //    //300公里以上    总额打8折

        //    if (distance > 0 && distance <= 100)
        //    {
        //        charge = 1;
        //    }
        //    else if (distance > 100 && distance <= 200)
        //    {
        //        charge = 0.95;
        //    }
        //    else if (distance > 200 && distance <= 300)
        //    {
        //        charge = 0.9;
        //    }
        //    else
        //    {
        //        charge = 0.8;
        //    }
        //    _price = distance * charge ;
        //}

        //public void ShowPrice()
        //{ 
        //    Console.WriteLine("行驶{0}公里，因付费{1}元",this.Distance,this.Price);
        //} 
        #endregion

        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }

        private double _distance;
        public double Distance
        {
            get { return _distance; }
        }

        private double _price;
        public double Price
        {
            get 
            {
                if (this.Distance>0&&this.Distance<=100)
                {
                    return this.Distance;
                }
                else if (this.Distance > 100 && this.Distance <= 200)
                {
                    return this.Distance * 0.95;
                }
                else if (this.Distance > 200 && this.Distance <= 300)
                {
                    return this.Distance * 0.9;
                }
                else
                {
                    return this.Distance * 0.8;
                }
            }
        }


        public void ShowPrice()
        {
            Console.WriteLine("共行驶{0}公里，所需{1}元",this.Distance,this.Price);
        }
    }//class
}
