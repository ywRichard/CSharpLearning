using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18随机数的复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //该程序使用一个数组存储30个学生的考试成绩，并给各个数组元素指定一个1-100的随机值，然后计算平均成绩。
            int[] grade = new int[30];
            Random r = new Random();
            for (int i = 0; i < grade.Length; i++)
            {
                grade[i] = r.Next(0,101);
            }

            //int gradeSum = grade.Sum();
            //grade.Average();
            int gradeSum = 0;
            for (int i = 0; i < grade.Length; i++)
            {
                gradeSum += grade[i];
            }

            Console.WriteLine("平均成绩：{0:n2}",gradeSum / grade.Length);
            Console.ReadKey();
        }
    }
}
