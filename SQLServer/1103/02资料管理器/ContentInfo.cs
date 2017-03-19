using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02资料管理器
{
    class ContentInfo
    {
        private int _dId;

        public int DId
        {
            get { return _dId; }
            set { _dId = value; }
        }
        private int _dTId;

        public int DTId
        {
            get { return _dTId; }
            set { _dTId = value; }
        }
        private string _dName;

        public string DName
        {
            get { return _dName; }
            set { _dName = value; }
        }
        private string _dContent;

        public string DContent
        {
            get { return _dContent; }
            set { _dContent = value; }
        }
    }
}
