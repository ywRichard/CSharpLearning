using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_资料管理器
{
    class Category
    {
        //TId, TName, TParentID, TNote, TNum
        private int _tId;

        public int TId
        {
            get { return _tId; }
            set { _tId = value; }
        }
        private string _tName;

        public string TName
        {
            get { return _tName; }
            set { _tName = value; }
        }
        private int _tParentID;

        public int TParentID
        {
            get { return _tParentID; }
            set { _tParentID = value; }
        }
        private string _tNote;

        public string TNote
        {
            get { return _tNote; }
            set { _tNote = value; }
        }
        private int _tNum;

        public int TNum
        {
            get { return _tNum; }
            set { _tNum = value; }
        }

    }
}
