using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            //指挥者用ConcreteBuilder1的方法建造产品
            d.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            //指挥者用ConcreteBuilder2的方法建造产品
            d.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.ReadKey();
        }
    }
}
