using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_SAGA
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Knight p1 = new Knight(rnd.Next(70, 100), rnd.Next(10, 20), Knight.nameList[rnd.Next(Knight.nameList.Length)], false);
            Player p2 = new Wizard(rnd.Next(40, 60), rnd.Next(20, 25), Wizard.nameList[rnd.Next(Wizard.nameList.Length)], false);
            Player p3 = new Archer(rnd.Next(40, 50), rnd.Next(20, 30), Archer.nameList[rnd.Next(Archer.nameList.Length)], false);

            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------");
                p1.Hit(p2);
                Console.WriteLine("-------------------------------------------------------------");
                if (p2.IsLose())
                {
                    Console.WriteLine($"{p2.Info()} проиграл...");
                    break;
                }
                Console.WriteLine("-------------------------------------------------------------");
                p2.Hit(p1);
                Console.WriteLine("-------------------------------------------------------------");
                if (p1.IsLose())
                {
                    Console.WriteLine($"{p1.Info()} проиграл...");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
