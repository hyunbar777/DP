using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.模板模式.template
{
    public abstract class AbstractClass
    {
        //一些抽象行为，放到子类去实现
        public abstract void Operation1();
        public abstract void Operation2();
        //模板方法，给出了逻辑的骨架，而逻辑的组成是一些相应的抽象操作，它们都推迟到子类实现
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
        }
    }
    public class ConcreteClassA : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("具体类A方法1实现");
        }

        public override void Operation2()
        {
            Console.WriteLine("具体类A方法2实现");
        }
    }
    public class ConcreteClassB : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("具体类B方法1实现");
        }

        public override void Operation2()
        {
            Console.WriteLine("具体类B方法2实现");
        }
    }
}
