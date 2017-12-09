using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace _07_MvcOA.Quartz
{
    public class IndexJob:IJob
    {
        private IBLL.IKeywordsRankBLL bll = new BLL.KeywordsRankBLL();

        public void Execute(IJobExecutionContext context)
        {
            bll.DeleteAllKeywords();
            bll.InsertKeywords();
        }
    }
}
