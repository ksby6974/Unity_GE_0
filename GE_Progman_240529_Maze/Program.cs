using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;

namespace GE_Program_240529_Maze1
{
    class Screen
    {
        private const int width = 30;
        private const int height = 30;

        public Screen()
        {
            Console.SetWindowSize(width, height);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool bMainLoop = true;

            int iX = 0;
            int iY = 0;
            int iInput = 0;
            int iTurn = 0;
            int iLimit = 25;

            Screen screen = new Screen();

            while (bMainLoop)
            {
                iTurn += 1;
                Console.WriteLine($"「Turn:{iTurn}」 ㅡ （{iX},{iY}）");

                // 
                Console.Write($"┏");
                for (int i = 0; i < iLimit + 3; i++)
                {
                    Console.Write($"━");
                }
                Console.WriteLine($"┓");

                //
                for (int j = 0; j < iLimit + 1; j++)
                {
                    Console.Write($"┃");
                    for (int i = 0; i < iLimit + 3; i++)
                    {
                        Console.Write($" ");
                    }
                    Console.WriteLine($"┃");
                }

                // 
                Console.Write($"┗");
                for (int i = 0; i < iLimit + 3; i++)
                {
                    Console.Write($"━");
                }
                Console.WriteLine($"┘");

                Console.SetCursorPosition(2 + iX, 2 + iY);
                Console.WriteLine("★");

                ConsoleKeyInfo key;
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        iX += 1;
                        break;

                    case ConsoleKey.LeftArrow:
                        iX -= 1;
                        break;

                    case ConsoleKey.UpArrow:
                        iY -= 1;
                        break;

                    case ConsoleKey.DownArrow:
                        iY += 1;
                        break;

                    default:
                        Console.WriteLine("상정 외의 값입니다");
                        break;
                }
                Console.Clear();

                //Limit
                if (iX < 0)
                    iX = 0;

                if (iY < 0)
                    iY = 0;

                if (iX > iLimit)
                    iX = iLimit;

                if (iY > iLimit)
                    iY = iLimit;
            }
        }

    }
}