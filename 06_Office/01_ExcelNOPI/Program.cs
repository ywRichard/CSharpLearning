using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NPOI.HSSF.UserModel;

namespace _01_ExcelNOPI
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadExcel("1.xls");
        }

        private static void ReadExcel(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                var work = new HSSFWorkbook();//获取工作表
                var sheet = work.GetSheetAt(0);//获取第一张表

                var str = "";
                for (int i = 0; i <= sheet.LastRowNum; i++)
                {
                    var row = sheet.GetRow(i);
                    for (int j = 0; j < row.LastCellNum; j++)
                    {
                        if (row.GetCell(j).CellType == HSSFCell.CELL_TYPE_STRING)
                        {
                            str += row.GetCell(j).StringCellValue;
                        }
                        else if (row.GetCell(j).CellType == HSSFCell.CELL_TYPE_NUMERIC)
                        {
                            str += row.GetCell(j).NumericCellValue;
                        }
                        str += ",";
                    }

                }
                Console.WriteLine(str);
            }
        }

        public class Person
        {
            private string _name;
            private string _gender;
            private int _age;

            public string Name { get => _name; set => _name = value; }
            public string Gender { get => _gender; set => _gender = value; }
            public int Age { get => _age; set => _age = value; }
        }
    }
}
