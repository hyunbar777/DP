using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA a = new ConcreteDecoratorA();
            ConcreteDecoratorB b = new ConcreteDecoratorB();

            c.Operationa();
            Console.WriteLine("===================");
            a.SetComponent(c);
            a.Operationa();
            Console.WriteLine("===================");
            b.SetComponent(a);
            b.Operationa();

            Console.ReadKey();
        }
    }
}
