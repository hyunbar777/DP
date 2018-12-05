using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Brand b;
            b= new Brandhuawei();
            b.SetApp(new Game());
            b.Run();
            b.SetApp(new Message());
            b.Run();

            b = new BrandMI();
            b.SetApp(new Game());
            b.Run();
            b.SetApp(new Message());
            b.Run();


            Console.ReadKey();
        }
    }
}
