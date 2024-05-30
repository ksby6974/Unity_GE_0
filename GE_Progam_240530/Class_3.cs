using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Program_240530
{
    public interface IAttack
    {
        public void Attack();
    }

    public interface ITechnique
    {
        public void Skill();
    }

    public class Wraith : IAttack, ITechnique
    {
        public void Attack()
        {
            Console.WriteLine($"Wraith");
        }

        public void Skill()
        {
            Console.WriteLine($"『Cloaking』");
        }
    }

    public class Dropship : ITechnique
    {
        public void Skill()
        {
            Console.WriteLine($"『Transport』");
        }
    }

    public class Valkyrie : IAttack
    {
        public void Attack()
        {
            Console.WriteLine($"Valkyrie");
        }
    }

    public class Battlecrusier : IAttack, ITechnique
    {
        public void Attack()
        {
            Console.WriteLine($"Battlecrusier");
        }

        public void Skill()
        {
            Console.WriteLine($"『Yamato Cannon』");
        }
    }
}
