using System;
using Barrack;

namespace Barrack
{
    internal class Program
    {
        static int iLimit = 5;
        static int iTemp = 0;
        static int iIndex = 0;

        static void Main(string[] args)
        {
            Console.WriteLine($"【병영】");

            for (int iTemp = 0; iTemp < iLimit; iTemp++)
            {
                Console.WriteLine($"\n【{iTemp + 1}】 생산할 유닛은? - 1(Marine), 2(Firebat), 3(Ghost)");

                //char cInput = Convert.ToChar(Console.Read());
                int iInput = Convert.ToInt32(Console.ReadLine());

                if (iInput == 1 || iInput == 2 || iInput == 3)
                {
                    Console.Write($"{iTemp + 1}번째로 생성 : ");

                    Unit unit = null;

                    switch (iInput)
                    {
                        case 1:
                            unit = new Marine();
                            break;

                        case 2:
                            unit = new Firebat();
                            break;

                        case 3:
                            unit = new Ghost();
                            break;

                        default:
                            break;
                    }

                    unit.ShowInfo();
                }

                else
                {
                    Console.WriteLine($"\n※상정외의 값입니다. 다시 입력하십시오");
                    iTemp--;
                }


                if (iTemp == (iLimit - 1))
                {
                    Console.WriteLine($"\n유닛 다섯 기를 모두 생성하였습니다!");
                }
            }
        }
    }
}