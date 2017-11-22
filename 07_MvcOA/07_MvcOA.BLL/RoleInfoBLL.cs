using _07_MvcOA.IBLL;
using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.BLL
{
    public partial class RoleInfoBLL : BaseBLL<RoleInfo>, IRoleInfoBLL
    {
        public bool DeleteEntities(List<int> list)
        {
            GetCurrentSession.RoleInfoDal
                .LoadEntities(c => list.Contains(c.ID)).ToList()
                .ForEach(k => GetCurrentSession.RoleInfoDal.DeleteEntity(k));

            return GetCurrentSession.SaveChanges();
        }
    }
}
