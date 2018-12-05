using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            List<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
               


            foreach(var e in list)
            {
                e.Interpret(context);
            }
            Console.Read();
        }
    }
}
