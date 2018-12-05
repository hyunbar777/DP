using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1建造者模式
{
    public class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("创建产品======");
            foreach(var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
