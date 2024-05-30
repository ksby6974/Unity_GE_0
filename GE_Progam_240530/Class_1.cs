using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Program_240530
{
    class Controller
    {
        public int x;
        public int y;

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
            Console.WriteLine($"x가 {x}의 값만큼 이동");
            Console.WriteLine($"y가 {y}의 값만큼 이동");
        }

        public void Attack()
        {
            Console.WriteLine("공격！");
        }
    }


    class Character
    {
        private Controller controller;

        private string name;
        private int hp;

        public Character(int x, int y)
        {
            controller = new Controller();
            controller.x = x;
            controller.y = y;
        }

        public void Move(int x, int y)
        {
            controller.Move(x, y);
        }

        public void Info()
        {
            Console.WriteLine($"캐릭터 좌표 : {controller.x}, {controller.y}");
        }

        public void Select(Weapon w)
        {
            w.Attack();
        }
    }

    public abstract class Weapon
    {
        public abstract void Attack();
    }

    public class Knife : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine($"Knife Attack");
        }
    }

    public class Rifle : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine($"Rifle Attack");
        }
    }
}
