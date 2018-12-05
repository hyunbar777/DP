using _7.模板模式.template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.模板模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("学生A的试卷");
            //TestPaper a = new TestPaperA();
            //a.TestQ1();
            //a.TestQ2();
            //Console.WriteLine("==================");
            //Console.WriteLine("学生B的试卷");
            //TestPaper b = new TestPaperB();
            //b.TestQ1();
            //b.TestQ2();

            AbstractClass c;
            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();



            Console.ReadKey();
        }
    }
}
