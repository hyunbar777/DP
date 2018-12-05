using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.迭代模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate c = new ConcreteAggregate();
            c[0] = "小美";
            c[1] = "大美";
            c[2] = "美眉";
            c[3] = "小宁";
            c[4] = "桑桑";
            c[5] = "念念";

            Iterator i = new ConcreteIterator(c);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine("{0} 吼一声", i.CurrentItem());
                i.Next();
            }
            Console.ReadKey();
        }
    }
}
