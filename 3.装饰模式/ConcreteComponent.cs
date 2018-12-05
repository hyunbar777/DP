using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.装饰模式
{
    public class ConcreteComponent : Component
    {
        public override void Operationa()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}
