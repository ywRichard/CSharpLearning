using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DbTableRelation
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Authority { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
