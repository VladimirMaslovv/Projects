using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_SAGA
{
    class Archer : Player
    {
        Random burn = new Random();

        int hp;
        int str;
        string name;
        string _class;

        bool Burn = false;

        public static string[] nameList = new string[] { "Леголас" };
        public Archer(int hp, int str, string name, bool stan)
        {
            this.hp = hp;
            this.str = str;
            this.name = name;
            _class = "Лучник";
        }

        public override void Hit(Player target)
        {
            if (burn.Next(2) == 1)
            {
                Console.WriteLine($"{Info()} стреляет подожженой стрелой в {target.Info()}");
                target.TakeDamage(str);
                Burn = true;
            }
            else
            {
                Console.WriteLine($"{Info()} стреляет в {target.Info()}");
                target.TakeDamage(str);
            }
            if(Burn == true)
            {
                target.TakeDamage(5);
            }
        }

        public override void TakeDamage(int dmg)
        {
            if (dmg == 5)
            {
                Console.WriteLine($"{Info()} получил {dmg} урона от горения");
                hp -= dmg;
            }
            else
            {
                Console.WriteLine($"{Info()} получил {dmg} урона");
                hp -= dmg;
            }
        }

        public override bool IsLose()
        {
            return hp <= 0;
        }

        public override string Info()
        {
            if (hp <= 0)
            {
                hp = 0;
            }
            return $"[{_class}]{name}[{hp}]";
        }
    }
}
