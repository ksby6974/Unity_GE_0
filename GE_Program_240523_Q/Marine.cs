using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    internal class Marine : Unit
    {
        public Marine()
        {
            sUnitname = "Marine";

            Console.WriteLine($"{sUnitname}");
        }
    }
}
