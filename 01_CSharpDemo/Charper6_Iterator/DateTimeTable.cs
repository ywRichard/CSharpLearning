using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper6_Iterator
{
    public class DateTimeTable
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 将业务代码封装到专属的类中，实现在一个地方封装，多个地方调用。简化代码
        /// 一次只返回一条
        /// </summary>
        public IEnumerable<DateTime> DateRange
        {
            get
            {
                for (DateTime day = StartDate;
                    day < EndDate;
                    day = day.AddDays(1))
                {
                    yield return day;
                }
            }
        }
    }
}
