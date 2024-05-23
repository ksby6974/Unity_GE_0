using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    internal class Ghost : Unit
    {

        public Ghost()
        {
            sUnitname = "Ghost";

            Console.WriteLine($"{sUnitname}");
        }
    }
}
