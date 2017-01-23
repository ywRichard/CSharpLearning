using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _石头剪刀布1
{
    public enum Result
    { 
        电脑赢,
        选手赢,
        平手
    }
    class Judger
    {
        public static Result Judge(int plyNum,int cpuNum)
        {
            Result res = new Result();
            int resNum = plyNum - cpuNum;
            if (resNum == 1||resNum == -2)
            {
                res = Result.电脑赢;
            }
            else if (resNum == 0)
            {
                res = Result.平手;
            }
            else
            {
                res = Result.选手赢;
            }
            return res;
        }
    }
}
