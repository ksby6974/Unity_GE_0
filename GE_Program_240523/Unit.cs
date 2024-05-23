using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Program_240523
{
    internal class Unit
    {
        protected int hp;
        protected int attack;
        protected int defense;

        protected string skillname = "skill_default";

        public Unit()
        {
            Console.WriteLine($"Unit 생성 : ");  
        }

        public void Skill()
        {
             Console.WriteLine($"Unit 기술 : ({skillname})"); 
        }

        virtual public void Show()
        {
            Console.WriteLine($"Default_Show");

            // 가상 함수의 경우, 가상 함수 테이블을 사용하여 호출되는 함수를 실행시간에 결정됨ㅁ
            // 정적으로 선언된 함수는 가상 함수로 선언할 수 없음
        }
    }
}
