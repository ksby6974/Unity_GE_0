using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Program_240530
{
    public class Zerg
    {
        protected int hp;
        protected int atk;
    }

    public class GroundUnit : Zerg
    {
        public void Ground()
        {
            Console.WriteLine($"Ground");
        }
    }

    public class AirUnit : Zerg
    {
        public void Fly()
        {
            Console.WriteLine($"Fly");
        }

    }

    public class Zergling : GroundUnit
    {
        public Zergling()
        {
            Console.WriteLine($"「Zergling」");
            Ground();
        }
    }

    public class Mutalisk : AirUnit
    {
        public Mutalisk()
        {
            Console.WriteLine($"「Mutalisk」");
            Fly();
        }
    }

}
