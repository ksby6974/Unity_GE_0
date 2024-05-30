using System;
using System.ComponentModel;

namespace GE_Program_240530
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($":: 【SOLID 객체 지향 설계】::\n");

            Console.WriteLine($"\n【단일 책임 원칙 - SRP 】\n");
            {
                #region 단일 책임 원칙
                // 객체는 하나의 책임만 가질 것
                // 하나의 클래스는 하나의 기능을 담당하여 하나의 책임을 수행하는데 집중

                Character chara = new Character(10,10);

                chara.Move(20,20);
                chara.Info();

                #endregion
            }

            Console.WriteLine($"\n【개방 폐쇄 원칙 - OCP 】\n");
            {
                #region 개방 폐쇄 원칙
                // 소프트웨어 개체는 확장에 대해선 개방적이나
                // 변경에 대해선 폐쇄적이어야 한다.

                CreateManager createManager = new CreateManager();

                createManager.Create(new Marine());
                createManager.Create(new Firebat());
                createManager.Create(new Ghost());
                #endregion
            }

            Console.WriteLine($"\n【인터페이스 분리 원칙 - ISP 】\n");
            {
                #region 인터페이스 분리 원칙
                // 클라이언트가 자신이 이용하지 않는 함수에 의존하지 않아야 한다는 원칙

                Wraith wraith = new Wraith();
                Dropship dropship = new Dropship();
                Valkyrie valkyrie = new Valkyrie();
                Battlecrusier battlecrusier = new Battlecrusier();

                wraith.Attack();
                wraith.Skill();

                dropship.Skill();

                valkyrie.Attack();

                battlecrusier.Attack();
                battlecrusier.Skill();
                #endregion
            }

            Console.WriteLine($"\n【리스코프 치환 원칙 - LSP 】\n");
            {
                #region 리스코프 치환 원칙
                // 상위 클래스와 하위 클래스가 있을 때
                // 상위 클래스를 호출하는 동작에서 하위 클래스가 상위 클래스를 완벽히 대체해야 함.

                Zergling zergling = new Zergling();
                Mutalisk mutalisk = new Mutalisk();

                //zergling.Ground();
                //mutalisk.Fly();
                #endregion
            }

            Console.WriteLine($"\n【의존관계 역전 원칙 - DIP 】\n");
            {
                #region 의존관계 역전 원칙
                // 상위 계층이 에 의존하는 전통적인 의존 관계를 역전시켜
                // 상위 계층이 하위 계층의 구현으로부터 독립될 수 있도록 설계해야함
                // 변하기 쉬운 부분보다는 변화하기 어려운 부분을 참조해라

                Character chara = new Character(5, 5);

                chara.Select(new Knife());
                chara.Select(new Rifle());
                #endregion
            }
        }
    }
}