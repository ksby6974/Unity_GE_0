using System;
using System.Xml;


//참조 : 이진 공간 분할법을 통한 랜덤 맵 생성


namespace GE_Program_240529
{
    public class Map
    {
        public int[,] Arraymap = new int[10, 10]
        {
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                    { 1, 0, 0, 0, 0, 0, 0, 1, 0, 1},
                    { 1, 0, 1, 0, 0, 1, 0, 0, 0, 1},
                    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1},
                    { 1, 0, 1, 0, 1, 1, 0, 1, 1, 1},
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1},
                    { 1, 0, 0, 0, 1, 0, 0, 1, 0, 1},
                    { 1, 0, 1, 0, 1, 0, 0, 0, 1, 1},
                    { 1, 1, 1, 1, 1, 2, 1, 1, 1, 1},
        };
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool bMainLoop = true;

            int iX = 1;
            int iY = 1;
            int iInput = 0;
            int iTurn = 0;
            int iLimit = 9;
            int iOver = 0;

            //Map
            Map map = new Map();

            while (bMainLoop)
            {
                iTurn += 1;
                Console.WriteLine($"「Turn:{iTurn}」 ㅡ （{iX},{iY}）");

                for (int i = 0; i < map.Arraymap.GetLength(0); i++)
                {
                    for (int j = 0; j < map.Arraymap.GetLength(1); j++)
                    {
                        if (iX == i && iY == j)
                        {
                            Console.Write("★");
                        }
                        else
                        {
                            DrawMap(i, j, map.Arraymap[i, j]);
                        }
                    }
                    Console.WriteLine();
                }

                if (iOver == 0)
                {
                    ConsoleKeyInfo key;
                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow:
                            if (PlayerMoveCS(map, iX, iY + 1) == 1)
                            {
                                iY += 1;
                            }
                            break;

                        case ConsoleKey.LeftArrow:
                            if (PlayerMoveCS(map, iX, iY - 1) == 1)
                            {
                                iY -= 1;
                            }
                            break;

                        case ConsoleKey.UpArrow:
                            if (PlayerMoveCS(map, iX - 1, iY) == 1)
                            {
                                iX -= 1;
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            if (PlayerMoveCS(map, iX + 1, iY) == 1)
                            {
                                iX += 1;
                            }
                            break;

                        default:
                            Console.WriteLine("상정 외의 값입니다");
                            break;
                    }
                }

                //Limit
                if (iX < 0)
                    iX = 0;

                if (iY < 0)
                    iY = 0;

                if (iX > iLimit)
                    iX = iLimit;

                if (iY > iLimit)
                    iY = iLimit;

                if (iOver == 1)
                {
                    bMainLoop = false;
                }

                if (iOver == 0)
                    Console.Clear();

                if (map.Arraymap[iX, iY] == 2)
                {
                    iOver = 1;
                }
            }

            Console.WriteLine("Winner！！！！！！");
        }

        static void DrawMap(int x, int y, int value)
        {
            switch (value)
            {
                case 0:
                    Console.Write($"　");
                    break;

                case 1:
                    Console.Write($"■");
                    break;

                case 2:
                    Console.Write($"Ⅹ");
                    break;

                default:
                    break;
            }
        }

        static int PlayerMoveCS(Map map, int x, int y)
        {
            int iTemp = map.Arraymap[x, y];
            int iResult = 1;

            if (iTemp == 1)
                iResult = 0;

            return iResult;
        }
    }
}