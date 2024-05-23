using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Program_240523
{
    internal class Ghost : Unit
    {
        public Ghost()
        {
            hp = 45;
            attack = 10;
            defense = 0;

            skillname = "Lockdown";

            Console.WriteLine($"─ Ghost");
        }

        new public void Skill()
        {
            Console.WriteLine($"Lockdown On : {skillname}");
        }

        override public void Show()
        {
            Console.WriteLine($"hp : {hp}");
            Console.WriteLine($"atk : {attack}");
            Console.WriteLine($"def : {defense}");
        }
    }
}
