using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwwards("内马尔");
            b.Attack();
            Player m = new Guards("麦克格");
            m.Attack();

            //姚明，不懂中文Attach和Defense是什么意思
            //Player ym = new Center("姚明");
            //ym.Attack();
            //ym.Defense();
            Player ym = new Tarnslator("姚明");
            ym.Attack();
            ym.Defense();
            Console.ReadKey();
        }
    }
}
