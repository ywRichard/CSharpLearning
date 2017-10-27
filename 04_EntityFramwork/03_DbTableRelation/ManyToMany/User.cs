using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DbTableRelation
{
    public class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }
        public int UserID { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Role> Roles { get; set; } 
    }
}
