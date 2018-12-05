using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.中介模式
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitedNationsSecurtiy unsc = new UnitedNationsSecurtiy();
            USA c1 = new USA(unsc);
            Iraq c2 = new Iraq(unsc);

            unsc.Colleaque1 = c1;
            unsc.Colleaque2 = c2;

            c1.Declare("不准研制核武器，否则要发动战争");
            c2.Declare("去你娘的，你算老几");

            Console.Read();
        }
    }
}
