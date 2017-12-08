using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.IBLL
{
    public partial interface IKeywordsRankBLL
    {
        bool DeleteAllKeywords();
        bool InsertKeywords();
        List<string> GetSearchWord(string str);
    }
}
