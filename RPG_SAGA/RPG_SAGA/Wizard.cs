using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_SAGA
{
    class Wizard : Player
    {
        Random shield = new Random();
        int hp;
        int str;
        string name;
        string _class;
        bool Shield = false;

        public static string[] nameList = new string[] { "Гендальф" };

        public Wizard(int hp, int str, string name, bool stan)
        {
            this.hp = hp;
            this.str = str;
            this.name = name;
            _class = "Волшебник";
        }

        public override void Hit(Player target)
        {
            if (shield.Next(2) == 1)
            {
                Console.WriteLine($"{Info()} под защитой сил природы");
                Shield = true;
            }
            Console.WriteLine($"{Info()} ударяет {target.Info()}");
            target.TakeDamage(str);
        }

        public override void TakeDamage(int dmg)
        {
            if (Shield == true)
            {
                Console.WriteLine($"Защита {Info()} полностью блокировала удар");
            }
            else
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
