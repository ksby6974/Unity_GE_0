using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Program_240523
{
    internal class Firebat : Unit
    {
        private int Steampack_panalty;

        public Firebat()
        {
            hp = 55;
            attack = 8;
            defense = 1;
            Steampack_panalty = 10;

            Console.WriteLine($"─ Firebat");
        }

        new public void Skill()
        {
            Console.WriteLine($"Steampack On : {skillname}");
        }

        override public void Show()
        {
            Console.WriteLine($"hp : {hp}");
            Console.WriteLine($"atk : {attack}");
            Console.WriteLine($"def : {defense}");

            // 가상 함수의 경우, 가상 함수 테이블을 사용하여 호출되는 함수를 실행시간에 결정됨ㅁ
            // 정적으로 선언된 함수는 가상 함수로 선언할 수 없음
        }
    }
}
