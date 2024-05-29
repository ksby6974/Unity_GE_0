using System;

namespace GE_Program_240529
{
    public class Shot
    {
        public int iLimit = 10;
        private int[] damage = new int[10];

        public int this[int index]
        {
            get { return damage[index]; }
            set { damage[index] = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"【좌표 이동 함수】\n");
            {
                #region 좌표 이동 함수
                //Console.SetCursorPosition(0, 0);
                #endregion
            }

            Console.WriteLine($"\n【2차원 배열】\n");
            {
                #region 2차원 배열
                // 배열의 요소로 또다른 배열을 가지는 배열

                // 2차원 배열은 행과 열로 구분됨
                // 앞에 있는 배열은 열을 의미하고 뒤에 있는 배열을 행을 의미

                int[,] array2D = new int[3, 3]
                {
                    { 1, 2, 3},
                    { 4, 5, 6},
                    { 7, 8, 9},
                };

                for (int i = 0; i < array2D.GetLength(0); i++)
                {
                    for (int j = 0; j < array2D.GetLength(1); j++)
                    {
                        Console.WriteLine(array2D[i, j]);
                    }
                }

                #endregion
            }

            Console.WriteLine($"\n【인덱서】\n");
            {
                #region 인덱서
                // 객체의 인스턴스 변수에 대한 배열 형태의 접근 방법을 제공하는 기능

                Shot shot = new Shot();

                for (int i = 0; i < 10; i++)
                {
                    shot[i] = i + 1;
                    Console.WriteLine($"shot[{i}] : {shot[i]}");
                }

                #endregion
            }

            Console.WriteLine($"\n【무명 형식】\n");
            {
                #region 무명 형식
                // 무명 형식의 경우 데이터를 접근하는 건 불가능하지만
                // 데이터를 출력하는 형태는 가능

                var GameObject = new
                { 
                    grade = 'A',
                    id = 100,
                    name = "Object",
                };

                Console.WriteLine($"GameObect의 grade : {GameObject.grade}");
                Console.WriteLine($"GameObect의 id : {GameObject.id}");
                Console.WriteLine($"GameObect의 name : {GameObject.name}");
                #endregion
            }
        }
    }
}