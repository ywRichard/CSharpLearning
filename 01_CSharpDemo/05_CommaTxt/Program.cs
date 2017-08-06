using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_CommaTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> columns;
            List<Dictionary<string, string>> myData = GetData(out columns);

            foreach (var column in columns)
            {
                Console.Write("{0,-20}", column);
            }

            Console.WriteLine();

            foreach (var row in myData)
            {
                foreach (var column in columns)
                {
                    Console.Write("{0,-20}", row[column]);
                }
                Console.WriteLine();
            }
        }

        //适用于提取用“，”分隔的数据文件，CSV, ini...
        private static List<Dictionary<string, string>> GetData(out List<string> columns)
        {
            string line;
            string[] stringArray;
            char[] charArray = new char[] { ',' };
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();

            columns = new List<string>();
            try
            {
                using (FileStream aFile = new FileStream(@"..\..\dataSource.txt", FileMode.Open))
                {
                    StreamReader sr = new StreamReader(aFile);

                    line = sr.ReadLine();
                    stringArray = line.Split(charArray);

                    for (int i = 0; i <= stringArray.GetUpperBound(0); i++)
                    {
                        columns.Add(stringArray[i]);
                    }

                    line = sr.ReadLine();
                    while (line != null)
                    {
                        stringArray = line.Split(charArray);
                        Dictionary<string, string> dataRow = new Dictionary<string, string>();

                        for (int i = 0; i <= stringArray.GetUpperBound(0); i++)
                        {
                            dataRow.Add(columns[i], stringArray[i]);
                        }

                        data.Add(dataRow);

                        line = sr.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("IOException");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }

            return data;
        }
    }
}
