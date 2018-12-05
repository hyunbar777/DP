using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.建造者模式
{
    public abstract class PersonBuilder
    {
        protected Graphics g;
        protected Pen p;
        public PersonBuilder(Graphics g,Pen p)
        {
            this.g = g;
            this.p = p;
        }
        public abstract void BuilderHead();
        public abstract void BuilderBody();
        public abstract void BuilderArmLeft();
        public abstract void BuilderArmRight();
        public abstract void BuilderLegLeft();
        public abstract void BuilderLegRight();
    }
}
