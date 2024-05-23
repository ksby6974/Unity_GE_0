using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    internal class Unit
    {
        static protected int iIndex = 0;
        protected string sUnitname = "default_name";

        public Unit()
        {
            iIndex += 1;
        }

        public void ShowInfo()
        {
            Console.Write($"『{iIndex} - {sUnitname}』");
        }
    }
}
