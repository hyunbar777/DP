using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.访问者模式
{
    public class Success : Action
    {
        public override void GetManConclusion(Man concreteA)
        {
            Console.WriteLine("{0}{1}时，有一个伟大的女人", concreteA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteB)
        {
            Console.WriteLine("{0}{1}时，有一个花心的男人", concreteB.GetType().Name, this.GetType().Name);
        }
    }
    public class Fail : Action
    {
        public override void GetManConclusion(Man concreteA)
        {
            Console.WriteLine("{0}{1}时，有一个败家的女人", concreteA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteB)
        {
            Console.WriteLine("{0}{1}时，有一个勒色的男人", concreteB.GetType().Name, this.GetType().Name);
        }
    }
}
