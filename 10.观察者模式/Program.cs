using _10.观察者模式.抽象模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 抽象模式
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            //发出通知
            s.Notify();

            #endregion

            Console.ReadKey();
        }
    }
}
