using System;

namespace GE_Program_240520
{
    internal class Program
    {
        struct Unit
        {
            public char grade;
            string name;
            int hp;
            float attack;
        }

        static void Main(string[] args)
        {
            //값 타입 (Value)
            //ex) 자료형 번수

            //참조 타입 (Reference)
            //ex) class, aTemp, string 등

            {
                #region 메모리 구조
                // CODE     : 실행할 프로그램의 코드가 저장되는 영역
                // CPU는 코드 영역에 저장된 명령을 하나씩 가져와서 처리하게 됨
                // 프로그램이 시작하여 종료될 때까지 메모리에 남아있음
                // 함수의 주소

                // DATA     : 전역 변수와 정적 변수가 저장되는 영역
                // 프로그램의 시작과 함께 할당되며 프로그램이 종료될 때까지 메모리에 남아있음
                //

                // HEAP     : 사용자가 직접 메모리 공간을 할당하고 해제하는 메모리 영역
                // 사용자가 정의한 데이터의 영역

                // STACK    : 프로그램이 자동으로 사용하는 임시 메모리 영역
                // 함수 호출 시 생성되는 지역변수와 매개변수가 저장되는 영역
                // 함수 호출이 끝나면 메모리에서 사라짐
                // 스택 프레임 = 스택 영역에 저장되는 함수의 호출 정보
                #endregion
            }

            Console.WriteLine($"【배열】\n");
            {
                #region 배열
                // 같은 자료형의 변수들로 이루어진 유한 집합
                // 배열의 경우 첫번째 원소는 0부터 시작
                #endregion

                int[] aTemp = new int[5];
                int[] bTemp = new int[] { 1, 2, 3, 4, 5 };
                int[] cTemp = new int[] { 1, 2, 3 };

                aTemp[0] = 10;
                aTemp[1] = 20;
                aTemp[2] = 30;
                aTemp[3] = 40;
                aTemp[4] = 50;

                Console.Write($"aTemp :");
                for (int i = 0; i < aTemp.Length; i++)
                {
                    Console.Write($" {aTemp[i]}");
                    if (i == aTemp.Length - 1)
                        Console.WriteLine();
                }

                Console.Write($"bTemp :");
                for (int i = 0; i < bTemp.Length; i++)
                {
                    Console.Write($" {bTemp[i]}");
                    if (i == bTemp.Length - 1)
                        Console.WriteLine();
                }

                Console.Write($"cTemp :");
                for (int i = 0; i < cTemp.Length; i++)
                {
                    Console.Write($" {cTemp[i]}");
                    if (i == cTemp.Length - 1)
                        Console.WriteLine();
                }

                cTemp = new int[] { 1, 2, 3, 4, 5 };

                Console.Write($"cTemp :");
                for (int i = 0; i < cTemp.Length; i++)
                {
                    Console.Write($" {cTemp[i]}");
                    if (i == cTemp.Length - 1)
                        Console.WriteLine();
                }


                Console.Write($"Test kTemp[]:");
                int[] kTemp = new int[5] { 7, 5, 2, 3, 1 };
                int iMin = 0;
                int iMax = 0;
                for (int i = 0; i < kTemp.Length; i++)
                {
                    Console.Write($" {kTemp[i]}");
                }
                Console.WriteLine();

                for (int i = 0; i < kTemp.Length; i++)
                {
                    if (kTemp[i] >= iMax)
                    {
                        iMax = kTemp[i];
                    }

                    if (iMin == 0)
                    {
                        iMin = kTemp[i];
                    }
                    else if (kTemp[i] < iMin)
                    {
                        iMin = kTemp[i];
                    }
                }

                Console.WriteLine($"iMin : {iMin}");
                Console.WriteLine($"iMax : {iMax}");
            }

            {
                #region 문자열
                // 연속적으로 메모리 공간에 저장된 문자 변수의 집합
                // 공백도 함께 메모리 공간에 포함하여 크기가 결정됨
                // 마지막에는 문자열의 끝을 알려주는 제어 문자(null)가 추가됨

                // 서로 연속적인 메모리 공간으로 연결되어있으나
                // 문자 배열 사이에 무효의 문자를 넣게 되면 무효의 문자까지만 문자열 출력


                // string sName = "Marine";
                //
                // Console.WriteLine($"sName : {sName}");
                //
                // sName = "Mar\0ine";
                //
                // Console.WriteLine($"sName : {sName}");
                #endregion
            }

            {
                #region 접근 지정자
                // 구조체 내부에 포함되어있는 속성에 접근범위를 제한하는 지정자
                // private      : 구조체 내부에서만 접근을 허용
                // 구조체 외부 또는 자기가 상속한 구조체에는 접근을 허용할 수 없는 지정자

                // public       : 구조체 내부와 자신이 상속하고 있는 구조체는 물론
                // 구조체 외부에서도 접근이 가능


                // protected    : 구조체 내부와 자기가 상속하고 있는 구조체에 접근을 허용
                // 구조체 외부에서는 접근을 불허
                #endregion
            }

            Console.WriteLine($"\n【구조체】\n");
            {
                #region 구조체
                // 여러 개의 변수를 집합으로 구조화한 하나의 객체
                // 구조체를 선언하기 전에 구조체는 메모리 공간이 생성되지 않으므로
                // 구조체 내부에 있는 데이터를 초기화할 수 없음
                #endregion

                Unit unit;
                unit.grade = 'A';

                Console.WriteLine(unit.grade);
            }

            Console.WriteLine($"\n【함수】\n");
            {
                #region 함수
                //
                #endregion
            }

            Calculator();
            Damage(10);
            Recovery(100);

            {
                #region 매개 변수
                // 함수의 정의에서 전달받은 인수를 함수 내부로 전달하기 위해 사용하는 변수

                // 매개 변수는 함수 내부에서만 연산이 이루어지며 함수 종료 시 메모리에서 제거됨
                #endregion
            }
        }

        // void : 반환값 없음
        static void Calculator()
        {
            Console.WriteLine($"Function : Calculator");
        }

        static int Damage(int damage)
        {
            int iResult = 10 + damage;

            Console.WriteLine($"Function : Damage({iResult})");
            return iResult;
        }

        static void Recovery(int health)
        {
            Console.WriteLine($"Function : Recovery({health})");
        }
    }
}