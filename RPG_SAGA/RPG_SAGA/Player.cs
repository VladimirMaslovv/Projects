using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_SAGA
{
    internal abstract class Player
    {
        abstract public void Hit(Player target);
        abstract public void TakeDamage(int dmg);
        abstract public bool IsLose();
        abstract public string Info();
    }
}
