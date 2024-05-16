using System;

namespace GE_Program_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                #region 부호 없는 자료형
                #endregion

                //uint iTemp = -10;     음수는 불가능
                uint iTemp = 10000;
                ulong lTemp = 31415926535;
                ushort sTemp = 60000;

                Console.WriteLine($"값 : {iTemp}");
                Console.WriteLine($"값 : {lTemp}");
                Console.WriteLine($"값 : {sTemp}");
            }

            {
                #region 오버플로우와 언더플로우
                // 오버플로우 : 특정한 자료형이 표현할 수 있는 최대값의 범위를 넘어서 연산이 수행됨
                // 언더플로우 : 특정한 자료형이 표현할 수 있는 최소값을 범위를 넘어서 연산이 수행됨
                #endregion

                //short sExp = 65999;
                //short sLevel = -60000;

                Console.WriteLine($"경험치 : ");
            }

            {
                #region 조건문
                // 어떤 조건이 주어질 때 해당 조건에 따라 동작을 수행

                // 관계 연산자 : 두 개의 피연산자의 값들을 비교하여 그 결과를 0 또는 1로 나타냄
                // 참이면 1, 거짓이면 0을 반환
                // <
                // >
                // == 
                // !=
                // <=
                // >=
                #endregion

                int i1 = 10;
                int i2 = 5;
                bool bResult1 = i1 > i2;
                bool bResult2 = i1 < i2;
                bool bResult3 = i1 == i2;
                bool bResult4 = i1 != i2;
                bool bResult5 = i1 >= i2;
                bool bResult6 = i1 <= i2;

                Console.WriteLine($"{i1} < {i2} : {bResult1}");
                Console.WriteLine($"{i1} > {i2} : {bResult2}");
                Console.WriteLine($"{i1} == {i2} : {bResult3}");
                Console.WriteLine($"{i1} != {i2} : {bResult4}");
                Console.WriteLine($"{i1} <= {i2} : {bResult5}");
                Console.WriteLine($"{i1} >= {i2} : {bResult6}");
            }

            {
                #region IF
                //어떤 특정한 조건을 비교하여 조건이 맞다면 실행되는 명령문
                #endregion

                int iHealth = 100;
                iHealth = 0;

                if (iHealth <= 0)
                {
                    Console.WriteLine($"You Die");
                }

                #region ELSE IF
                // ELSE IF = IF 외 별도의 중복 가능한 조건문 (IF문이 선행되어야함)
                // if문에 연결된 모든 조건문의 조건이 맞을 때 가장 위에 있는 조건문만 실행됨
                #endregion

                char key = 'A';

                if (key == 'W')
                {
                    Console.WriteLine("↑");
                }
                else if (key == 'A')
                {
                    Console.WriteLine("←");
                }
                else if (key == 'S')
                {
                    Console.WriteLine("→");
                }

                #region ELSE
                // ELSE = IF문 조건문의 반환값이 FALSE일 때 실행되는 명령문
                #endregion

                Console.WriteLine($"ELSE 문 선택 : ");
                int iLevel = 99;
                iLevel = int.Parse(Console.ReadLine());

                if (iLevel == 11)
                {
                    Console.WriteLine("1차 전직");
                }
                else if (iLevel == 41)
                {
                    Console.WriteLine("2차 전직");
                }
                else
                {
                    Console.WriteLine("전직 불가");
                }
            }

            {
                #region Switch 문
                // 어떤 결과에 따라 그 결과로부터 실행되는 명령문
                // 조건에 해당되는 값에 따라 조건의 위치가 이동
                #endregion

                Console.WriteLine($"SWITCH 문 선택 : ");
                int istate = int.Parse(Console.ReadLine());
                switch (istate)
                {
                    case 0: 
                        Console.WriteLine("IDLE");
                        break;

                    case 1:
                        Console.WriteLine("MOVE");
                        break;

                    case 2:
                        Console.WriteLine("ATTACK");
                        break;

                    case 3:
                        Console.WriteLine("DIE");
                        break;

                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }

            // Conditional Statement
            {
                #region 논리연산자
                #endregion
                int iResult = 0;

                Console.WriteLine($"x값 : ");
                int ix = int.Parse(Console.ReadLine());

                Console.WriteLine($"y값 : ");
                int iy = int.Parse(Console.ReadLine());

                if (ix >= 0 && iy >= 0)
                {
                    iResult = 1;
                }
                else if (ix < 0 && iy >= 0)
                {
                    iResult = 2;
                }
                else if (ix >= 0 && iy < 0)
                {
                    iResult = 3;
                }
                else
                {
                    iResult = 4;
                }

                switch (iResult)
                {
                    case 1:
                        Console.WriteLine($"1사분면 : {iResult}");
                        break;

                    case 2:
                        Console.WriteLine($"2사분면 : {iResult}");
                        break;

                    case 3:
                        Console.WriteLine($"3사분면 : {iResult}");
                        break;

                    case 4:
                        Console.WriteLine($"4사분면 : {iResult}");
                        break;

                    default:
                        Console.WriteLine($"ERROR");
                        break;
                }
            }
        }
    }
}