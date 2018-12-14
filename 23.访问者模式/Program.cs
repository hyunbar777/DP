using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjStructure o = new ObjStructure();
            o.Attach(new Man());
            o.Attach(new Woman());

            //成功的反应
            Success e1 = new Success();
            o.Display(e1);

            //失败时的反应
            Fail e2 = new Fail();
            o.Display(e2);

            Console.Read();
        }
    }
}
