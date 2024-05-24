using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace GE_Program_UpandDown
{
    internal class Program
    {
        static bool iLoop = true;
        static int setNumber = 30;
        static int iPlayerLifeLimit = 5;
        static int iPlayerLife = iPlayerLifeLimit;
        static bool bCheck = false;

        static void Main(string[] args)
        {
            while (iLoop)
            {
                // 정답 설정
                Random random = new Random();
                int iRand = random.Next(1, setNumber + 1);
                int iInput = 0;

                // 반복
                while (iPlayerLife > 0 && bCheck == false)
                {
                    // UI
                    Console.WriteLine($"━【Up and Down】━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                    Console.Write($"─ lefted Chance :");
                    for (int i = iPlayerLifeLimit; i > 0; i--)
                    {
                        if (iPlayerLifeLimit >= iPlayerLife)
                        {
                            Console.Write($"★");
                        }
                        else
                        {
                            Console.Write($"☆");
                        }

                        // 개행
                        if (i == 1)
                            Console.WriteLine();
                    }

                    // 입력 반복
                    bool bLoop = true;
                    while (bLoop)
                    {
                        // 입력 받음
                        Console.Write($"\n수를 입력해주세요. （1 ~ {setNumber}）:");
                        iInput = Convert.ToInt32(Console.ReadLine());

                        // Down
                        if (LimitChecker(iInput) == 1)
                        {
                            // 반복 중지
                            bLoop = false;

                            // 목숨 소모
                            iPlayerLife -= 1;

                            if (iRand == iInput)
                            {
                                Console.WriteLine($"\n＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝");
                                Console.WriteLine($"\n정답입니다! {iRand}가 맞습니다!\n");
                                Console.WriteLine($"＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝\n");
                                bCheck = true;
                            }
                            else if (iRand > iInput)
                            {
                                Console.WriteLine($"\n정답은 {iInput}보다 큽니다!\n");
                            }
                            else
                            {
                                Console.WriteLine($"\n정답은 {iInput}보다는 작습니다!\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"※ 상정 외의 수입니다. （0에서 {setNumber} 사이의 값을 입력하십시오.）");
                        }
                    }
                }

                // 게임 종료 여부
                if (iPlayerLife == 0 || bCheck == true)
                {
                    iLoop = false;
                    bCheck = false;
                    EndPhase(iRand);
                }
            }
        }

        // 입력값 확인
        static int LimitChecker(int i)
        {
            if (i > 0 && i <= setNumber)
                return 1;
            else
                return 0;
        }

        // 게임 종료 여부
        static void EndPhase(int i)
        {
            bool bLoop = true;
            while (bLoop)
            {
                // 재도전
                Console.WriteLine($"\n정답은 {i}였습니다. 재도전하시겠습니까? （0 ~ 1）");
                Console.WriteLine($"[0]아니");
                Console.WriteLine($"[1]그래");
                int iInput = Convert.ToInt32(Console.ReadLine());

                if (iInput == 0 || iInput == 1)
                {
                    // 반복 중지
                    bLoop = false;

                    if (iInput == 1)
                    {
                        Console.Clear();
                        iPlayerLife = iPlayerLifeLimit;
                        iLoop = true;
                    }
                    else
                    {
                        // 종료
                        iLoop = false;
                    }

                }
                else
                {
                    Console.WriteLine($"※ 상정 외의 수입니다. （0에서 100 사이의 값을 입력하십시오.）");
                }
            }
        }
    }
}