using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.IBLL
{
    public partial interface IActionInfoBLL : IBaseBLL<ActionInfo>
    {
        bool DeleteEntities(List<int> list);
        bool SetActionRoleInfo(int actionId, List<int> roleIdList);
    }
}
