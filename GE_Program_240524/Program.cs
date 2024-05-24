using System;
using static GE_Program_240524.Program;

namespace GE_Program_240524
{
    abstract public class Vehicle
    {
        private string name;
        private float speed;
        abstract public void Move();
    }

    public class Bicycle : Vehicle
    {

        override public void Move()
        {
            Console.WriteLine($"Bicycle Move");
        }
    }

    public class Motocycle : Vehicle
    {
        override public void Move()
        {
            Console.WriteLine($"Motocycle Move");
        }
    }

    public class Computer : IMouse, IKeyboard
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public void Input()
        {
            Console.WriteLine("Keyboard Input");
        }

        public void Select()
        {
            Console.WriteLine("Select Mouse");
        }
    }

    public interface IMouse
    {
        public void Select();
    }

    public interface IKeyboard
    {
        public void Input();
    }

    internal class Program
    {
        // 대리자 선언
        public delegate void Calculator(int x , int y);

        static void Add(int x, int y)
        {
            Console.WriteLine($"합산（{x} + {y}）＝{x + y}");
        }

        static void Sub(int x, int y)
        {
            Console.WriteLine($"감산（{x} - {y}）＝{x - y}");
        }

        static void Mul(int x, int y)
        {
            Console.WriteLine($"곱하기（{x} * {y}）＝{x * y}");
        }

        static void Div(int x, int y)
        {
            Console.WriteLine($"나누기（{x} / {y}）＝{x / y}");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("【랜덤】\n");
            {
                #region 랜덤 함수

                Random random = new Random();

                for (int j = 0; j < 5; j++)
                {
                    int iRand = random.Next(0, 2);
                    Console.WriteLine($"{iRand}");
                }

                #endregion
            }


            {
                #region ASCII 코드
                // 미국 국가표준 협회에서 표준화한 정보 교환용 7 bit부호체계

                char alphabet = 'A';

                Console.WriteLine($"{(int)alphabet}");
                #endregion
            }

            Console.WriteLine("\n【추상 클래스】\n");
            {
                #region 추상 클래스
                // 미완성 클래스. 미완성 메소드를 포함하고 있는 클래스.
                // 추상 함수 선언으로 부모 클래스에서 공통적인 정의를 제공한 다음
                // 상속을 통해 하위 클래스에서 함수를 완성하도록 유도하는 클래스
                // 인스턴스를 생성할 수 없어서 자식 클래스 상속을 통해서만 구현됨

                // OOP(객체 지향 프로그램) 4대 특징
                // 1. 추상화
                // 2. 상속
                // 3. 다형성
                // 4. 캡슐화

                // 아래의 코드는 불가
                // Vehicle vehicle = new Vehicle();

                // 자식 클래스로 구현
                Bicycle bicycle = new Bicycle();
                bicycle.Move();

                Motocycle motocycle = new Motocycle();

                motocycle.Move();
                #endregion
            }

            Console.WriteLine("\n【인터페이스】\n");
            {
                #region 인터페이스
                // 여러 Base 클래스를 가질 수 있음. 그래서 유지보수가 편함.
                // 접근제한 사용 안 함 (public 따위)

                Computer computer = new Computer();

                computer.Input();
                computer.Select();  

                #endregion
            }

            Console.WriteLine("\n【대리자】\n");
            {
                #region 대리자 (Delegate)
                // 함수의 주소값을 저장한 다음 함수를 대신 호출하는 기능
                // 대리자는 함수의 반환형과 매개 변수 타입이 일치해야 하며

                // 데이터 타입을 안전하게 처리가능
                // 수많은 메서드와 로직을 작성할 필요 없이 압축할 수 있음

                Calculator calcuator;

                calcuator = Add;

                calcuator(10, 20);

                calcuator = Sub;

                calcuator(10, 20);

                calcuator = Mul;

                calcuator(10, 20);

                calcuator = Div;

                calcuator(20, 10);
                #endregion
            }

            Console.WriteLine("\n【대리자 체인】\n");
            {
                #region 델리게이트 체인
                // 하나의 호출자에 여러 개의 함수를 등록해서 사용하는 기법

                Calculator caclulator;

                caclulator = Add;
                caclulator += Sub;
                caclulator += Mul;
                caclulator += Div;

                caclulator(5, 5);

                Console.WriteLine($"──────────────────");

                caclulator -= Div;

                caclulator(10, 2);
                #endregion
            }
        }
    }
}