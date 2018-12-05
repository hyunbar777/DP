using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.建造者模式
{
    public class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(Graphics g, Pen p) : base(g, p)
        {
        }

        public override void BuilderArmLeft()
        {
            g.DrawLine(p, 60, 50, 40, 100);
        }

        public override void BuilderArmRight()
        {
            g.DrawLine(p, 70, 50, 90, 100);
        }

        public override void BuilderBody()
        {
            g.DrawRectangle(p, 60, 50, 10, 50);
        }

        public override void BuilderHead()
        {
            g.DrawEllipse(p, 50, 20, 30, 30);
        }

        public override void BuilderLegLeft()
        {
            g.DrawLine(p, 60, 100, 45, 150);
        }

        public override void BuilderLegRight()
        {
            g.DrawLine(p, 70, 100, 85, 150);
        }
    }
}
