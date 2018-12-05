using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1观察模式
{
    //声明一个委托，名称叫“EventHandler(事件处理程序)”,无参数，无返回值
    public delegate void EventHandler();
    public class Boss : Subject
    {
        //声明一事件Update，类型为委托EventHandler
        public event EventHandler Update;
        private string action;
        public string SubjectState
        {
            get
            {
                return action;
            }

            set
            {
                action = value;
            }
        }
        //在访问“通知”方法时，调用“更新”
        public void Notify()
        {
            Update();
        }
    }
}
