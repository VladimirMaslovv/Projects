using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_SAGA
{
    class Knight : Player
    {
        int hp;
        int str;
        string name;
        string _class;

        Random crit = new Random();

        public static string[] nameList = new string[] { "Владимир", "Николай", "Дмитрий", "Сергей", "Антон", "Александр" };
        public Knight(int hp, int str, string name, bool stan)
        {
            this.hp = hp;
            this.str = str;
            this.name = name;
            _class = "Рыцарь";
        }
        
        public override void Hit(Player target)
        {
            if (crit.Next(2) == 1)
            {
                Console.WriteLine($"{Info()} ударяет {target.Info()} и наносит критический удар");
                double critDmg = Convert.ToDouble(str) * 1.3;
                critDmg = Math.Round(critDmg); 
                target.TakeDamage(Convert.ToInt32(critDmg));
            }
            else
            {
                Console.WriteLine($"{Info()} ударяет {target.Info()}");
                target.TakeDamage(str);
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
