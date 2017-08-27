using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItcastCater.Model
{
    public class MemberInfo
    {
        private int _memberId;
        private string _memName;
        private string _memPhone;
        private string _memMobilePhone;
        private string _memAddress;
        private int _memType;
        private string _memNum;
        private string _memGender;
        private decimal? _memDiscount = 1.00M;
        private decimal? _memMoney = 0M;
        private int? _delFlag = 0;
        private DateTime _subTime;
        private int? _memIntegral;
        private DateTime _memEndServerTime;
        private DateTime _memBirthday;

        public int MemberId { get => _memberId; set => _memberId = value; }
        public string MemName { get => _memName; set => _memName = value; }
        public string MemPhone { get => _memPhone; set => _memPhone = value; }
        public string MemMobilePhone { get => _memMobilePhone; set => _memMobilePhone = value; }
        public string MemAddress { get => _memAddress; set => _memAddress = value; }
        public int MemType { get => _memType; set => _memType = value; }
        public string MemNum { get => _memNum; set => _memNum = value; }
        public string MemGender { get => _memGender; set => _memGender = value; }
        public decimal? MemDiscount { get => _memDiscount; set => _memDiscount = value; }
        public decimal? MemMoney { get => _memMoney; set => _memMoney = value; }
        public int? DelFlag { get => _delFlag; set => _delFlag = value; }
        public DateTime SubTime { get => _subTime; set => _subTime = value; }
        public int? MemIntegral { get => _memIntegral; set => _memIntegral = value; }
        public DateTime MemEndServerTime { get => _memEndServerTime; set => _memEndServerTime = value; }
        public DateTime MemBirthday { get => _memBirthday; set => _memBirthday = value; }
    }
}
