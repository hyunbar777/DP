using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.观察者模式.抽象模式
{

    public class ConcreteSubject:Subject
    {

        private string action;
        //前台状态
        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
