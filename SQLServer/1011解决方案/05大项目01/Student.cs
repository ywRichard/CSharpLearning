using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05大项目01
{
    class Student
    {
        //TSID,TSName,TSGender,TSAddress,TSAge
        private int _tSID;
        public int TSID
        {
            get { return _tSID; }
            set { _tSID = value; }
        }

        private string _tSName;
        public string TSName
        {
            get { return _tSName; }
            set { _tSName = value; }
        }

        private char _tSGender;
        public char TSGender
        {
            get { return _tSGender; }
            set { _tSGender = value; }
        }

        private string _tSAddress;
        public string TSAddress
        {
            get { return _tSAddress; }
            set { _tSAddress = value; }
        }

        private int _tSAge;
        public int TSAge
        {
            get { return _tSAge; }
            set { _tSAge = value; }
        }
    }
}
