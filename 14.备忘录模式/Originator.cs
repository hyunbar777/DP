using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.备忘录模式
{
    //发起人类
    public class Originator
    {
        //需要保存的属性，可能有多个
        public string State { get; set; }
        //创建备忘录，将当前需要保存的信息导入并实例化一个备忘录
        public Memento CreateMemento()
        {
            return new Memento(State);
        }
        //恢复备忘录，将Memento导入并将相关数据恢复
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        //相关数据
        public void Show()
        {
            Console.WriteLine("State=" + State);
        }
    }
    //备忘录类
    public class Memento
    {
       //保存的数据属性，可以是多个
        public string State { get; set; }
        //将相关数据导入
        public Memento(string state)
        {
            this.State = state;
        }
    }
    //管理者类
    public class Caretaker
    {
        //得到或设置备忘录
        public Memento Memento { get; set; }
    }
}
