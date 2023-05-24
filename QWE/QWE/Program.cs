using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWE
{
    class Program
    {
        static void Main(string[] args)
        {
            //class s1 = new Class1();

            string Cast = "";
            string L1; string L2;
            string[] qwe = new string[] { "", "", "" };

            while (true)
            {
                char Liter = Console.ReadKey(true).KeyChar;

                if (qwe[0] == "")
                {
                    qwe[0] = Convert.ToString(Liter);
                }
                else if (qwe[1] == "")
                {
                    qwe[1] = Convert.ToString(Liter);
                }
                else if (qwe[2] == "")
                {
                    qwe[2] = Convert.ToString(Liter);
                }
                else
                {
                    L1 = qwe[2]; qwe[2] = "";
                    L2 = qwe[1]; qwe[1] = L1;
                    qwe[0] = L2;

                    qwe[2] = Convert.ToString(Liter);
                }

                Console.Clear();
                Console.WriteLine(qwe[0] + qwe[1] + qwe[2]);

                // Ссылаемся на другой класс для проверки комбинации
                // В классе содержится лист со всеми комбинациями и соответсвующими заклинаниями 
                string Combination = qwe[0] + qwe[1] + qwe[2];
                
            }
        }
    }
}
