using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.观察者模式.抽象模式
{
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private Secretary subject;
        public ConcreteObserver(Secretary subject,string name)
        {
            this.name = name;
            this.subject = subject;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}", name, observerState);
        }
        public Secretary Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
    //public class NBAObserver : Observer
    //{
    //    private string name;
    //    private string observerState;
    //    private Secretary subject;
    //    public NBAObserver(Secretary subject, string name)
    //    {
    //        this.name = name;
    //        this.subject = subject;
    //    }
    //    public override void Update()
    //    {
    //        observerState = subject.SubjectState;
    //        Console.WriteLine("观察者{0}的新状态是{1},关闭NBA直播", name, observerState);
    //    }
    //    public Secretary Subject
    //    {
    //        get { return subject; }
    //        set { subject = value; }
    //    }
    //}
}
