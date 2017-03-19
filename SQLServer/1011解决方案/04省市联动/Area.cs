using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04省市联动
{
    class Area
    {
        private int _areaID;

        public int AreaID
        {
            get { return _areaID; }
            set { _areaID = value; }
        }
        private string _areaName;

        public string AreaName
        {
            get { return _areaName; }
            set { _areaName = value; }
        }
        private int _areaPID;

        public int AreaPID
        {
            get { return _areaPID; }
            set { _areaPID = value; }
        }

    }
}
