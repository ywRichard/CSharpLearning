using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.BLL
{
    public partial class ActionInfoBLL:BaseBLL<ActionInfo>, IActionInfoBLL
    {
        public bool DeleteEntities(List<int> listId)
        {
            GetCurrentSession.ActionInfoDal.LoadEntities(a=>listId.Contains(a.ID)).ToList()
               .ForEach(a=> GetCurrentSession.ActionInfoDal.DeleteEntity(a));

            return GetCurrentSession.SaveChanges();
        }
    }
}
