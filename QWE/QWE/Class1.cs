using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWE
{
    class Class1
    {
        string[] ListOfSpels = new string[]
        {
            "qqq", "eee", "www",
            "qqe", "eeq", "eew",
            "qqw", "wwq", "wwe",
            "qwe"
        };
        int SpelN;

        

        public void Spel(string Combinatoin)
        {
            for(int i = 0; i<10; i++)
            {
                if(ListOfSpels[i] == Combinatoin)
                {
                    SpelN = i;
                    break;
                }
            }
            SpelKod(SpelN);
        }

        public int SpelKod(int spelN)
        {
            return spelN;
        }
    }
}
