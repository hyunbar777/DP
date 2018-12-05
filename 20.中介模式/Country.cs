using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.中介模式
{

    //国家类
    public abstract class Country
    {
        protected UnitedNations mediator;
        public Country(UnitedNations mediator)
        {
            this.mediator = mediator;
        }
    }
    public class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator)
        {
        }
        //声明
        public void Declare(string message)
        {
            mediator.Declare(message,this);
        }
        //获得消息
        public void GetMessage(string message)
        {
            Console.WriteLine("USA获得对方信息:" + message);
        }
    }
    public class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator)
        {
        }
        //声明
        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }
        //获得消息
        public void GetMessage(string message)
        {
            Console.WriteLine("Iraq获得对方信息:" + message);
        }
    }
}
