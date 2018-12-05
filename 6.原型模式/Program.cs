using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("甜甜");
            a.SetPersonalInfo("女", "23");
            a.SetWorkExperience("2000-2003", "aa公司");
            a.Display();

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2006-2010", "bb公司");
            b.Display();

            Console.ReadKey();
        }
    }
}
