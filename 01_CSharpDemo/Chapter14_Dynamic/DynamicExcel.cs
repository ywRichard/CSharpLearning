using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Chapter14_Dynamic
{
    public class DynamicExcel
    {
        public static void StaticExcel()
        {
            var app = new Application { Visible = true };
            app.Workbooks.Add();
            Worksheet worksheet = (Worksheet)app.ActiveSheet;
            Range start = (Range)worksheet.Cells[1, 1];
            Range end = (Range)worksheet.Cells[1, 20];
            worksheet.Range[start, end].Value = Enumerable.Range(1, 20).ToArray();
        }

        /// <summary>
        /// 在使用主互操作程序集，在API中申明的任何object(字段，参数，返回类型)都会变成dynamic
        /// </summary>
        public static void DynamicExcelRecommend()
        {
            var app = new Application { Visible = true };
            app.Workbooks.Add();
            Worksheet worksheet = app.ActiveSheet;
            Range start = worksheet.Cells[1, 1];
            Range end = worksheet.Cells[1, 20];
            worksheet.Range[start, end].Value = Enumerable.Range(1, 20).ToArray();
        }

        /// <summary>
        /// 不推荐使用dynamic去修饰变量，
        /// 因为这样转换失败了也不会知道，只有在某些不支持的情况下才会抛异常
        /// </summary>
        public static void DynamicExcelBad()
        {
            var app = new Application { Visible = true };
            app.Workbooks.Add();
            dynamic worksheet = app.ActiveSheet;
            dynamic start = worksheet.Cells[1, 1];
            dynamic end = worksheet.Cells[1, 20];
            worksheet.Range[start, end].Value = Enumerable.Range(1, 20).ToArray();
        }
    }
}
