using System;
using System.Xml;

namespace GE_Program_240528
{
    public class Unit
    {
        public string name = "DefaultName";
        public float x;
        public float y;

        public Unit(string s)
        {
            name = s;
        }

        public float X
        {
            set { x = value; }
            get { return x; }
        }

        public float Y
        {
            set { y = value; }
            get { return y; }

        }
        public void Show()
        {
            Console.WriteLine($"{name}의 좌표（{x},{y}）");
        }
    }

    public class Chara : Position
    {
        private int x;
        private int y;

        public Chara()
        {
            base.Update();
        }

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        static public Chara operator +(Chara left, Chara right)
        {
            Chara temp = new Chara();
            temp.x = left.x + right.x;
            temp.y = left.y + right.y;

            return temp;
        }

        static public Chara operator ++(Chara clone)
        {
            return clone;
        }

        public void Show()
        {
            Console.WriteLine($"（{x}, {y}）");
        }
    }

    public class Position
    {


        public void Update()
        {
            Console.WriteLine($"60 FPS");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"【두 점 사이의 거리】\n");
            {
                #region 두 점 사이의 거리
                bool bMainLoop = true;
                double dTemp = 0;

                // 메인 루프
                while (bMainLoop)
                {
                    bMainLoop = false;

                    Unit Unit_Player = new Unit("Player");
                    Unit Unit_Enemy = new Unit("Enemy");

                    Unit_Player.X = 0;
                    Unit_Player.Y = 0;

                    Unit_Enemy.X = 5;
                    Unit_Enemy.Y = 3;

                    Unit_Player.Show();
                    Unit_Enemy.Show();
                    dTemp = Distance(Unit_Player.x, Unit_Player.y, Unit_Enemy.x, Unit_Enemy.y);
                    Console.WriteLine($"값 : {Math.Round(dTemp, 2)}");

                    if (dTemp > 2.5)
                    {
                        Console.WriteLine($"공격 범위에서 벗어남");
                    }
                    else
                    {
                        Console.WriteLine($"공격 범위 안");
                    }
                }

                #endregion
            }

            static double Distance(double Px, double Py, double Ex, double Ey)
            {
                double dTemp = Math.Sqrt(Math.Pow(Ex - Px, 2) + Math.Pow(Ey - Ex, 2));
                return dTemp;
            }

            Console.WriteLine($"\n【연산자 오버로딩】\n");
            {
                #region 연산자 오버로딩
                Chara chara1 = new Chara();
                Chara chara2 = new Chara();

                chara1.X = 5;
                chara1.Y = 10;
                chara2.X = 7;
                chara2.Y = 6;

                Chara chara3 = chara1 + chara2;

                chara3.Show();

                #endregion
            }
        }
    }


}