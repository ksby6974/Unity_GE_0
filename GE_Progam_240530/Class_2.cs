using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Program_240530
{
    public abstract class Unit
    {
        public abstract void Move();
    }

    public class Marine : Unit
    {
        public override void Move()
        {
            Console.WriteLine($"Marine : Who wanna piece of me, boy?");
        }
    }

    public class Firebat : Unit
    {
        public override void Move()
        {
            Console.WriteLine($"Firebat : Need a light?");
        }
    }

    public class Ghost : Unit
    {
        public override void Move()
        {
            Console.WriteLine($"Ghost : Somebody call for an exterminator?");
        }

    }

    public class CreateManager
    {
        public void Create(Unit unit)
        {
            unit.Move();
        }
    }
}
