using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1建造者模式
{
    public class Director
    {
        //指挥创建过程
        public void Construct(Builder b)
        {
            b.BuildPartA();
            b.BuildPartB();
        }
    }
}
