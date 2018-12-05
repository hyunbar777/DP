using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.装饰模式
{
    class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operationa()
        {
            base.Operationa();
            addedState = "A New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
    class ConcreteDecoratorB : Decorator
    {
        public override void Operationa()
        {
            base.Operationa();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior()
        {
            //Console.WriteLine("B New State");
        }
    }
}
