using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1建造者模式
{
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
    public class ConcreteBuilder1 : Builder
    {
        private Product p = new Product();
        public override void BuildPartA()
        {
            p.Add("A");
        }

        public override void BuildPartB()
        {
            p.Add("B");
        }

        public override Product GetResult()
        {
            return p;
        }
    }
    public class ConcreteBuilder2 : Builder
    {
        private Product p = new Product();
        public override void BuildPartA()
        {
            p.Add("X");
        }

        public override void BuildPartB()
        {
            p.Add("Y");
        }

        public override Product GetResult()
        {
            return p;
        }
    }
}
