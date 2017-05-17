using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_OOP
{
    public class Judge
    {
        public string Play(int numPlayer, int numCpt)
        {
            int num = numPlayer - numCpt;
            if (num==0)
            {
                return "你们棋逢对手";
            }
            else if (num==-1||num==2)
            {
                return "玩家赢";
            }
            else
            {
                return "电脑赢";
            }
        }
    }
}
