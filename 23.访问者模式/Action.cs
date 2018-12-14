using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.访问者模式
{
    //状态抽象类
    public abstract class Action
    {
        //得到男人结论或反应
        public abstract void GetManConclusion(Man concreteA);
        //得到女人结论或反应
        public abstract void GetWomanConclusion(Woman concreteB);
    }
    //人抽象类
    public abstract class Person
    {
        //接受
        public abstract void Accept(Action vistor);
    }
}
