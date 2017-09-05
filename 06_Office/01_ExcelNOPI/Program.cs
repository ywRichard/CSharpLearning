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
            WriteExcel("1.xls");

            Console.ReadKey();
        }

        private static void ReadExcel(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                var work = new HSSFWorkbook(fs);//获取工作表
                var sheet = work.GetSheetAt(0);//获取第一张表

                for (int i = 0; i <= sheet.LastRowNum; i++)
                {
                    var row = sheet.GetRow(i);//获取行
                    var str = "";
                    for (int j = 0; j < row.LastCellNum; j++)
                    {
                        //Excel表中值有数据类型
                        if (row.GetCell(j).CellType == HSSFCell.CELL_TYPE_STRING)
                        {
                            str += row.GetCell(j).StringCellValue;//获取单元格的值，类型转换
                        }
                        else if (row.GetCell(j).CellType == HSSFCell.CELL_TYPE_NUMERIC)
                        {
                            str += row.GetCell(j).NumericCellValue;
                        }
                        str += ",";
                    }
                    Console.WriteLine(str);
                }
            }
        }

        private static void WriteExcel(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var list = new List<Person>(){
                    new Person(){ Name="张三",Age=15,Gender="男"},
                    new Person(){ Name="李四",Age=16,Gender="女"},
                    new Person(){ Name="王五",Age=17,Gender="女"},
                    new Person(){ Name="赵六",Age=18,Gender="男"}
                };

                var work = new HSSFWorkbook();
                var sheet = work.CreateSheet("student");
                for (int i = 0; i < list.Count; i++)
                {
                    //行要根据页创建
                    var row = sheet.CreateRow(i);//指定行号
                    row.CreateCell(0, HSSFCell.CELL_TYPE_STRING).SetCellValue(list[i].Name);//指定单元格纵坐标
                    row.CreateCell(1, HSSFCell.CELL_TYPE_STRING).SetCellValue(list[i].Gender);
                    row.CreateCell(2, HSSFCell.CELL_TYPE_STRING).SetCellValue(list[i].Age);
                }

                work.Write(fs);
            }

            Console.WriteLine("写入完成");
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
