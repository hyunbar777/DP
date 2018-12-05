using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op;
            op = OperationFactory.CreateOperate("+");
            op.NumberA = 1;
            op.NumberB = 2;
            Console.WriteLine(op.GetResult());
            Console.WriteLine("__________________");
            op = OperationFactory.CreateOperate("-");
            op.NumberA = 5;
            op.NumberB = 3;
            Console.WriteLine(op.GetResult());
            Console.ReadKey();
        }
    }
}
