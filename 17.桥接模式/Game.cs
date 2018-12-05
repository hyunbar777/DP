using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.桥接模式
{
    public class Game : App
    {
        public override void Run()
        {
            Console.WriteLine("王者荣耀");

        }
    }
    public class Message : App
    {
        public override void Run()
        {
            Console.WriteLine("短信");
        }
    }
}
