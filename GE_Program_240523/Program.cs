using System;
using System.Resources;
using InputSystem;

#region 이름 공간
// 속성을 구분할 수 있도록 유효범위를 설정하는 영역
#endregion

namespace GE_Program_240523
{
    internal class Program
    {
        static void Proceed(char x)
        {
            Console.WriteLine($"char : {x}의 값이 처리되었습니다.");
        }

        static void Proceed(int x)
        {
            Console.WriteLine($"int : {x}의 값이 처리되었습니다.");
        }

        static void Proceed(float x)
        {
            Console.WriteLine($"float : {x}의 값이 처리되었습니다.");
        }

        static void Proceed(string x)
        {
            Console.WriteLine($"string : {x}의 값이 처리되었습니다.");
        }

        static void Proceed(int x, int y)
        {
            Console.WriteLine($"int : {x}의 값이 처리되었습니다.");
            Console.WriteLine($"int : {y}의 값이 처리되었습니다.");
        }

        public enum state
        {
            IDLE,
            MOVE,
            ATTACK,
            DIE

            // 열거형에서 값을 특정한 위치에 새로 할당하게 되면 다음 열거형의 값은
            // 새로 할당한 값의 크기에 +1 됨
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"【상속】\n");
            {
                #region 상속
                // 상위 클래스의 속성을 하위 클래스가 사용할 수 있도록 설정하는 기능

                // 클래스 상속 관계에서 상위 클래스는 하위 클래스의 속성을 사용할 수 없으며
                // 하위 클래스는 상위 클래스의 메모리를 포함한 상태로 메모리 크기가 결정됨
                #endregion

                // 12 byte
                Unit unit = new Unit();

                // 4 byte
                Marine marine = new Marine();

                marine.Show();

                Keyboard keyboard = new Keyboard();

                keyboard.Connect();
            }

            Console.WriteLine($"\n【함수 오버로딩】\n");
            {
                #region 함수 오버로딩
                // 같은 이름의 함수를 매개 변수의 자료형과 매개 변수의 수로 구분하여
                // 여러 개를 선언할 수 있는 기능

                // 함수의 오버로딩의 경우, 함수의 매개 변수에 전달하는 인수의 형태를 보고 호출
                // 반환형으로 함수의 오버로딩을 생성할 수 없음
                #endregion

                Proceed('A');
                Proceed(10);
                Proceed(3.14f);
                Proceed("Starcraft");
                Proceed(6, 9);
            }

            Console.WriteLine($"\n【함수 오버라이딩】\n");
            {
                #region 함수 오버라이딩
                // 상위 클래스에 있는 함수를 하위 클래스에서 재정의하여 사용하는 기능

                // 함수의 오버라이드는 상속 관계에서만 이루어지며
                // 하위 클래스에서 함수를 재정의할 때 상위 클래스 함수 형태와 일치 필요
                #endregion

                Marine marine = new Marine();

                marine.Skill();
            }

            Console.WriteLine($"\n【다형성】\n");
            {
                #region 다형성
                // 서로 다른 객체가 동일한 기능을 서로 다른 방법으로 처리할 수 있는 작업

                // 다형성은 컴파일 시점에서 함수의 속성을 결정하는 정적 바인딩을 하지 않고
                // 실행 시간에 함수와 속성을 결정하는 동적 바인딩을 가능하게 함
                #endregion

                Unit unit = new Ghost();

                unit.Skill();
            }

            Console.WriteLine($"\n【가상 함수】\n");
            {
                #region 가상 함수
                // 상속하는 클래스 내에서 같은 형태의 함수로 재정의될 수 있는 함수

                // 가상 함수 실행 시간에 상위 클래스에 대한 참조로
                // 하위 클래스에 재정의된 함수를 호출할 수 있으며
                // 접근지정자는 설정해야 함.
                #endregion

                Unit unit = new Marine();

                unit.Show();

                unit = new Firebat();

                unit.Show();

                unit = new Ghost();

                unit.Show();
            }

            Console.WriteLine($"\n【열거형】\n");
            {
                #region 열거형
                // 여러 개의 상수를 하나의 컨테이너에서 관리하기 위해 사용하는 자료형
                #endregion

                state state = state.IDLE;

                switch (state)
                {
                    case state.IDLE:
                        Console.WriteLine("대기 상태");
                        break;

                    case state.MOVE:
                        Console.WriteLine("이동 상태");
                        break;

                    case state.ATTACK:
                        Console.WriteLine("공격 상태");
                        break;

                    case state.DIE:
                        Console.WriteLine("사망 상태");
                        break;
                }
            }

            Console.WriteLine($"\n【콘솔 입력】\n");
            {
                #region 콘솔 입력
                #endregion

                //string name = Console.ReadLine();
                //Console.WriteLine($"입력값 : {name}");

                // 입력값이 아닌 엉뚱한 수가 나온다. 아스키코드를 반환하기 때문.
                // 때문에 형변환이 필요.
                //int count = Console.Read();
                //Console.WriteLine($"count 입력값 : {count}");

                int level = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"level 입력값 : {level}");
            }
        }
    }
}