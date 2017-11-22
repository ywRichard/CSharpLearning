using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.IBLL
{
    public partial interface IRoleInfoBLL:IBaseBLL<RoleInfo>
    {
        bool DeleteEntities(List<int> list);
    }
}
