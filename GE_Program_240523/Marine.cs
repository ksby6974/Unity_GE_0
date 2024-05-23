using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Program_240523
{
    internal class Marine : Unit
    {
        private int Steampack_panalty;

        public Marine()
        {
            hp = 40;
            attack = 6;
            defense = 0;
            Steampack_panalty = 10;
            skillname = "Steampack";

            Console.WriteLine($"─ Marine");
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
        }
    }
}
