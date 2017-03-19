using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03大项目
{
    public class DeskInfo
    {
        //DeskId, DeskName, DeskNamePinYin, DeskDelFlag, DeskNum
        private int _deskId;
        /// <summary>
        /// 餐桌的ID
        /// </summary>
        public int DeskId
        {
            get { return _deskId; }
            set { _deskId = value; }
        }
        private string _deskName;
        /// <summary>
        /// 餐桌的名字
        /// </summary>
        public string DeskName
        {
            get { return _deskName; }
            set { _deskName = value; }
        }
        private string _deskNamePinYin;
        /// <summary>
        /// 餐桌名字的拼音
        /// </summary>
        public string DeskNamePinYin
        {
            get { return _deskNamePinYin; }
            set { _deskNamePinYin = value; }
        }
        private string _deskDelFlag;
        /// <summary>
        /// 删除标记，0---未删除，1----已删除
        /// </summary>
        public string DeskDelFlag
        {
            get { return _deskDelFlag; }
            set { _deskDelFlag = value; }
        }
        private string _deskNum;
        /// <summary>
        /// 餐桌的编号
        /// </summary>
        public string DeskNum
        {
            get { return _deskNum; }
            set { _deskNum = value; }
        }
    }
}
