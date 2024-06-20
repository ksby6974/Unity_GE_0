using System;
using System.Reflection.Metadata;

namespace GE_Program_240521
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                #region 재귀함수
                // 자기자신을 호출하여 작업을 수행하는 함수

                // 재귀함수는 함수를 계속 호출하기 때문에 스택 영역에 메모리가 계속 쌓이게 됨
                // 그래서 스택 오버플로우가 발생함

                // 때문에 특정한 시점에서 함수를 반환해야 하며
                // 재귀적으로 호출한 ㅎ마수는 스택 프레임에 의해 마지막에 호출된 함수부터 차례대로 스택 영역에서 해제
                #endregion

                Console.WriteLine($"【재귀Ⅰ - 반환 없음】\n");
                Recc1(3);

                Console.WriteLine($"\n【재귀Ⅱ - 반환】\n");
                Console.WriteLine($"반복수 : {Recc2(3)}");
            }

            {
                #region 박싱과 언박싱
                // 박싱 : 값 형식을 참조 형식으로 변환하는 과정
                // 언박싱 : 참조 형식을 값 형식으로 변환하는 과정
                // 기본적으로 연산이 많이 들어가게 됨
                // 복사비용
                #endregion

                Console.WriteLine($"\n【박싱】\n");

                int attack = 10;

                object box = attack;

                Console.WriteLine($"boxing : {box}");

                int result = (int)box;

                Console.WriteLine($"unboxing : {result}");

                object[] datalist = new object[5];

                datalist[0] = 10;
                datalist[1] = "Marine";
                datalist[2] = 55.5f;

                Info_(datalist);
            }
        }

        static void Recc1(int count)
        {
            Console.WriteLine($"Recc1_Process : {count}");

            if (count <= 0)
            {
                return;
            }
            else
            {
                Recc1(count - 1);
            } 
        }

        static int Recc2(int count)
        {
            Console.WriteLine($"Recc2_Process : {count}");

            if (count <= 0)
            {
                return 0;
            }
            else
            {
                //Recc2(count - 1);
                //return count;

                return Recc2(count - 1) + 1;
            }

        }

        static void Info_(object[] itemlist)
        {
            foreach(object element in itemlist)
            {
                Console.WriteLine(element);
            }
        }
    }
}