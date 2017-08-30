using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItcastCater.Model
{
    public class MemberType
    {
        private int _memType;
        private string _memTpName;

        public int MemType { get => _memType; set => _memType = value; }
        public string MemTpName { get => _memTpName; set => _memTpName = value; }
    }
}
