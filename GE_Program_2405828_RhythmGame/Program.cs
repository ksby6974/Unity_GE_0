using System;
using System.Linq;
using System.Security.Cryptography;

namespace GE_Program_240528_RhythmGame
{
    internal class Program
    {
        static int iPlayerLifeLimit = 5;
        static int iPlayerLife = 5;
        static int iNoteLimit = 4;
        static int iInput = 0;
        static int iGameOver = 0;
        static int iNote = 0;
        static string sShow = "";
        static bool bGameLoop = true;

        static void Main(string[] args)
        {
            bool bMainLoop = true;

            // 게임 전체 루프
            while (bGameLoop)
            {
                // 노트 배열 설정
                int[] list = new int[iNoteLimit];

                // 무작위 노트 설정
                Random random = new Random();

                for (int i = 0; i < iNoteLimit; i++)
                {
                    int iRand = random.Next(1, 5);
                    list[i] = iRand;
                }
                iNote = list.Length;

                // 메인 루프
                while (bMainLoop)
                {
                    Console.Write("━ 【 Rhythm Game 】 ━━");
                    Console.Write($"　　Life（{iPlayerLife}） : 『");

                    for (int i = 0; i < iPlayerLifeLimit; i++)
                    {
                        if (iPlayerLife > i)
                            Console.Write($"♥");
                        else
                            Console.Write($"♡");
                    }
                    Console.WriteLine($"』＝＝＝＝＝＝＝＝＝＝＝{sShow}\n");

                    // 노트 표시
                    for (int i = 0; i < iNote; i++)
                    {
                        string sTemp = "N";
                        switch (list[i])
                        {
                            case 1:
                                sTemp = "→";
                                break;

                            case 2:
                                sTemp = "←";
                                break;

                            case 3:
                                sTemp = "↑";
                                break;

                            case 4:
                                sTemp = "↓";
                                break;
                        }
                        Console.Write($"{sTemp}");

                        if (i == iNote - 1 || iNote == 0)
                            Console.WriteLine();
                    }

                    // 노트 입력받기
                    bool bInputLoop = true;

                    while (bInputLoop && iNote > 0)
                    {
                        // 초기화
                        iInput = 0;
                        bInputLoop = false;

                        ConsoleKeyInfo key;
                        key = Console.ReadKey(true);

                        switch (key.Key)
                        {
                            case ConsoleKey.RightArrow:
                                iInput = 1;
                                break;

                            case ConsoleKey.LeftArrow:
                                iInput = 2;
                                break;

                            case ConsoleKey.UpArrow:
                                iInput = 3;
                                break;

                            case ConsoleKey.DownArrow:
                                iInput = 4;
                                break;

                            default:
                                bInputLoop = true;
                                Console.WriteLine("상정 외의 값입니다");
                                break;
                        }
                    }

                    // 체력 없음
                    if (iPlayerLife == 0)
                    {
                        iGameOver -= 1;
                    }
                    // 노트 남아있음
                    else if (iNote > 0)
                    {
                        // 노트 입력 성공
                        if (iInput == list[iNote - 1])
                        {
                            sShow = "COOL ! ! !";

                            iNote -= 1;
                        }
                        // 노트 입력 실패
                        else
                        {
                            sShow = "FAILED ! ! !";
                            iPlayerLife -= 1;
                        }

                        Console.Clear();
                    }
                    else
                    {
                        iGameOver = 1;
                    }

                    if (iGameOver != 0)
                    {
                        bMainLoop = false;
                    }
                }

                if (iGameOver != 0)
                {
                    EndPhase(iGameOver);
                    iGameOver = 0;
                    bMainLoop = true;
                }
            }
        }

        static void EndPhase(int i)
        {
            bool bLoop = true;
            while (bLoop)
            {
                switch (i)
                {
                    case -1:
                        // 게임 오버
                        Console.WriteLine("Game Over…");
                        break;

                    case 1:
                        // 게임 오버
                        Console.WriteLine("Win!");
                        break;

                    default:
                        // 게임 지속
                        Console.WriteLine("Keep going");
                        break;
                }

                // 재도전
                Console.WriteLine($"\n재도전하시겠습니까? （0 ~ 1）");
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
                    }
                    else
                    {
                        // 종료
                        bGameLoop = false;
                    }

                }
                else
                {
                    Console.WriteLine($"※ 상정 외의 수입니다. （0이나 1 값을 입력하십시오.）");
                }
            }
        }
    }
}