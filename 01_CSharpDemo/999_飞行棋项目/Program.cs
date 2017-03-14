using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _飞行棋项目
{
    class Program
    {
        static int[] Maps = new int[100];
        static int[] PlayerPos = new int[2];
        static string[] PlayerName = new string[2];

        static void Main(string[] args)
        {
            GameShow();
            #region 输入玩家名
            Console.WriteLine("请输入玩家A姓名");
            PlayerName[0] = Console.ReadLine();
            while ("" == PlayerName[0])
            {
                Console.WriteLine("玩家A的姓名不能为空");
                PlayerName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B姓名");
            PlayerName[1] = Console.ReadLine();

            while ("" == PlayerName[1] || PlayerName[0] == PlayerName[1])
            {
                if ("" == PlayerName[1])
                {
                    Console.WriteLine("玩家B的姓名不能为空");
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能和玩家A的姓名相同");
                }
                PlayerName[1] = Console.ReadLine();
            }
            #endregion
            Console.Clear();
            GameShow();
            Console.WriteLine("{0}的士兵用A表示", PlayerName[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayerName[1]);
            InitialMap();
            DrawMap();
            while (true)
            {

                break;
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 显示游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*********V0.1 飞行棋***********");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*******************************");
        }
        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitialMap()
        {
            //我用0表示普通,显示给用户就是 □
            //....1...幸运轮盘,显示组用户就◎ 
            //....2...地雷,显示给用户就是 ☆
            //....3...暂停,显示给用户就是 ▲
            //....4...时空隧道,显示组用户就 卐
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            int[] pause = { 9, 27, 60, 93 };//暂停▲
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐

            for (int i = 0; i < luckyturn.Length; i++)//幸运轮盘
            {
                Maps[luckyturn[i]] = 1;
            }
            for (int i = 0; i < landMine.Length; i++)//地雷☆
            {
                Maps[landMine[i]] = 2;
            }
            for (int i = 0; i < pause.Length; i++)//地雷☆
            {
                Maps[pause[i]] = 3;
            }
            for (int i = 0; i < timeTunnel.Length; i++)//地雷☆
            {
                Maps[timeTunnel[i]] = 4;
            }

        }

        /// <summary>
        /// 画地图
        /// </summary>
        public static void DrawMap()
        {
            Console.WriteLine("图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
            #region 第一个横杠
            for (int i = 0; i < 30; i++)
            {
                Console.Write(SubDrawMap(i));
            }
            Console.WriteLine();
            #endregion
            #region 第一个竖杠
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(SubDrawMap(i));
                Console.WriteLine();
            }
            #endregion
            for (int i = 64; i >= 35; i--)//第二个横杠
            {
                Console.Write(SubDrawMap(i));
            }
            Console.WriteLine();
            for (int i = 65; i < 70; i++)//第二个竖杠
            {
                Console.WriteLine(SubDrawMap(i));
            }
            for (int i = 70; i < 100; i++)
            {
                Console.Write(SubDrawMap(i));
            }

            Console.WriteLine();
        }//draw map
        /// <summary>
        /// 画地图的横杠和竖杠
        /// </summary>
        /// <param name="i">Maps数组的索引</param>
        /// <returns>地图的字符</returns>
        public static string SubDrawMap(int i)
        {
            string str = "";

            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)//玩家重叠
            {
                Console.ForegroundColor = ConsoleColor.Red;
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                str = "Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        str = "卐";
                        break;
                    default: break;
                }
            }//else
            return str;
        }//SubDrawMap 

        public static void PlayGame(int number)
        {
            Console.WriteLine("玩家{0}按任意键开始游戏",PlayerName[number]);
            Console.ReadKey(true);
            Random r = new Random();
            int step = r.Next(1, 7);
            PlayerPos[number] += step;
            Console.WriteLine("玩家{0}掷出了{1}",PlayerName[number],step);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}按任意键开始行动");
            Console.ReadKey(true);

            switch (Maps[PlayerPos[number]])
            { 
                case 0:
                    Console.WriteLine("玩家{0}踩到了方块，正常行走", PlayerName[number]);
                    break;
                case 1:
                    Console.WriteLine("玩家{0}踩到了方块幸运轮盘", PlayerName[number]);
                    Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择 1--交换位置 2--轰炸对方",PlayerName[number]);
                    string str=Console.ReadLine();
                    if ("1" == str)
                    {
                        string temp;
                        temp = PlayerName[number];
                        PlayerName[number] = PlayerName[1-number];
                        PlayerName[1 - number] = temp;
                    }
                    else("2"==str)
                    {
                        
                    }

            }

            
        }
    }
}
