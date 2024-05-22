using System;

namespace GE_Program_240522
{
    public class GameObject
    {
        #region 바이트 패딩
        // 멤버 변수를 메모리에서 CPU로 읽을 때 한번에 읽을 수 있도록
        // 컴파일러가 레지스터Ⅰ블록에 맞춰 바이트를 패링해주는 최적화 작업

        // 멤버 변수의 나열된 형 순서에 따라 메모리 크기가 달라짐
        // 클래스의 크기는 클래스를 구성하는 멤버 중에서 크기가 가장 큰 자료형의 배수가 되도록 설정

        // 클래스의 오프셋
        #endregion

        private int x = 1;
        private int y = 2;
        private int z = 3;

        private double weight = 5;

        public void Info()
        {
            Console.WriteLine($"x, y, z : {x}, {y}, {z}");
        }
    }

    public class Collider
    {
        int size = 0;
        static int score = 100;

        public void IncreaseScore()
        {
            score++;

            Console.WriteLine($"score : {score}");
        }
    }

    public class Unit
    {
        #region 생성자
        // 클래스의 인스턴스가 생성되는 시점에서 자동으로 호출되는 특수한 멤버함수
        // 생성자의 경우 객체가 생성될 때 한 번만 호출되며 생성자는 반환형이 존재
        // 고로, 호출되기 전에는 객체에 대한 메모리가 할당되지 않음 
        // 생성자의 이름은 클래스의 이름과 동일
        #endregion

        private int hp;
        private string name;
        private int[] attack;

        // 생성자
        public Unit(int h, string n)
        {
            this.hp = h;
            this.name = n;
            attack = new int[3];

            Console.WriteLine($"생성자 Unit 확인 : {name}");
        }

        // 얕은 복사 생성자
        /*
        public Unit(Unit unit)
        {
            hp = unit.hp;
            name = unit.name;
            attack = unit.attack;
        }
        */

        // 깊은 복사 생성자
        public Unit(Unit unit)
        {
            this.hp = unit.hp;
            this.name = unit.name;
            attack = new int[unit.attack.Length];
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Info : {name}（{hp}）");

            for(int i = 0; i < attack.Length; i++)
            {
                Console.WriteLine($"attack[{i}] : {attack[i]}");
            }
        }

        public void SetData(int value)
        {
            attack[0] = value;
        }
    }

    public class Position
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }

            set 
            { 
                if (0 < value && value <= 100)
                {
                    x = value;
                }
                else
                {
                    Console.WriteLine($"ERROR : x의 값 상정외 {value}");
                } 
            }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"【클래스】\n");
            {
                #region 클래스
                // 사용자 정의 데이터 유형으로 속성과 함수가 포함됨
                // 클래스를 통해 객체를 생성하여 접근하고 사용할 수 있는 집합체

                // 클래스의 경우, 클래스 내부에 있는 변수는 클래스 메모리 영역에 포함됨
                // 정적 변수와 함수의 메모리는 클래스 영역에 포함되지 않음
                #endregion

                GameObject gameObject = new GameObject();

                gameObject.Info();
            }


            Console.WriteLine($"\n【변수의 범위】\n");
            {
                #region 변수의 범위
                // 전역 변수 : 어느 곳에서든 접근할 수 있는 변수. 힙에 할당됨.


                // 지역 변수 : 선언된 블록(중괄호) 안에서만 사용할 수 있음
                // 스택에 할당되기에 범위에서 벗어나면 메모리에서 제거됨

                // 정적 변수 : static. 프로그램이 실행될 때 한 번만 초기화가 이루어짐
                // 프로그램이 실행될 때 메모리에 생성되고 종료될 때 제거됨.
                // 초기화하지 않아도 0으로 초기화됨
                // 함수 내 static을 선언할 경우, 함수가 재호출되어도 해당 변수는 초기화되지 않음.
                #endregion

                Collider collider = new Collider();

                collider.IncreaseScore();
            }

            {
                Unit unit1 = new Unit(40,"Marine");
                Unit unit2 = new Unit(65, "Firtbat");
            }

            Console.WriteLine($"\n【얕은 복사】\n");
            {
                #region 얕은 복사 (Shallow Copy)
                // 객체를 복사할 때 주소값을 복사하여 같은 메모리를 가리키도록 하는 복사

                // 얕은 복사의 경우 같은 객체가 서로 같은 메모리 공간을 참조하기 때문에
                // 하나의 객체로 값을 변경하면 서로 참조된 객체도 함께 영향을 받음
                #endregion

                Unit unit1 = new Unit(20, "Slime");
                Unit unit2 = unit1;

                unit1.ShowInfo();
                unit2.ShowInfo();

                #region 복사 생성자
                // 같은 객체를 복사하여 생성시킬 때 호출되는 생성자
                // 복사 생성자를 정의하지 않고 객체를 복사하게 되면 
                // 기본 복사 생성자가 호출되기 때문에 얕은 복사로 객체가 복사됨
                #endregion

                Unit Sans1 = new Unit(30, "Sans");
                Unit Sans2 = new Unit(Sans1);

                Sans1.SetData(10);
                Sans2.SetData(20);

                Sans1.ShowInfo();
                Sans2.ShowInfo();
            }

            Console.WriteLine($"\n【깊은 복사】\n");
            {
                #region 깊은 복사 (deep Copy)
                // 객체를 복사할 때 참조 값이 아닌 인스턴스 자체를 새로 복사.
                // 서로 다른 메모리를 가지는 독립된 객체가 됨.
                #endregion

                Unit Slime1 = new Unit(30, "Slime");
                Unit Slime2 = new Unit(Slime1);

                Slime1.SetData(10);
                Slime2.SetData(20);

                Slime1.ShowInfo();
                Slime2.ShowInfo();
            }

            Console.WriteLine($"\n【프로퍼티】\n");
            {
                #region Garbage Collecter
                // 시스템에서 더 이상 사용하지 않는 메모리를 찾아 자동으로 해제하는 기법
                #endregion

                #region Property
                // 선언한 변수의 값을 외부에서 접근할 수 있도록 하면서 동시에 캡슐화
                #endregion

                Position position = new Position();

                position.X = 10;
                position.Y = 20;

                Console.WriteLine($"position1.X : {position.X}");  //getter
                Console.WriteLine($"position1.Y : {position.Y}");  //getter
            }

        }
    }
}