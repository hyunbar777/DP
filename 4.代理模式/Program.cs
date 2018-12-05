using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Girl mm = new Girl();
            mm.Name = "小甜甜";

            Proxy p = new Proxy(mm);
            p.GiveFlowers();
            Console.ReadKey();
        }
    }
}
