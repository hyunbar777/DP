using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.观察者模式.抽象模式
{
    /// <summary>
    /// 主题或抽象通知者
    /// </summary>
    public abstract class Subject
    { 
        //同事列表
        private IList<Observer> observers = new List<Observer>();

        //增加
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        //减少

        public void Detach(Observer observer)
        {
            observers.Remove(observer);

        }
        //通知
        public void Notify()
        {
            foreach (var i in observers)
                i.Update();
        }
    }
}
