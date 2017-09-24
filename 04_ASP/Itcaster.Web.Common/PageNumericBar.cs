using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcaster.Web.Common
{
    public static class PageNumericBar
    {
        public static string GetNumericBar(int index, int count)
        {
            if (count == 1)
            {
                return string.Empty;
            }

            int start, end;
            start = index - 1 >= 1 ? index - 1 : 1;
            end = start + 2;
            if (end > count)
            {
                end = count;
                start = count - 2;
            }

            var sb = new StringBuilder();
            if (index > 1)
            {
                sb.Append(string.Format("<a href='?pageIndex={0}'>上一页</a>", index - 1));
            }

            for (int i = start; i <= end; i++)
            {
                if (i == index)
                {
                    sb.Append(i);
                }
                else
                {
                    sb.Append(string.Format("<a href='?pageIndex={0}'>{0}</a>", i));
                }
            }

            if (index < count)
            {
                sb.Append(string.Format("<a href='?pageIndex={0}'>下一页</a>", index + 1));
            }

            return sb.ToString();
        }
    }
}
