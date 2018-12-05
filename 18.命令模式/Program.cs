using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer bb = new Barbecuer();
            Command c1 = new BakeMuttonCommand(bb);
            Command c3 = new BakeMuttonCommand(bb);
            Command c2 = new BakeChickenWingCommand(bb);
            Waiter gg = new Waiter();

            gg.SetOrader(c1);
            gg.SetOrader(c2);
            gg.SetOrader(c3);

            //订单完毕，通知厨房
            gg.Notify();
            Console.WriteLine("-----------------------");
            gg.CancelOrder(c3);
            gg.Notify();


            Console.ReadKey();

        }
    }
}
