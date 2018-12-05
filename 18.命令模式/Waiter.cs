using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.命令模式
{
    //服务员类，不管用户想要什么烤肉，反正都是‘命令’，只管记录订单，
    //然后通知‘烤肉者’执行即可
    public class Waiter
    {
        private List<Command> orders = new List<Command>();
        //设置订单
        public void SetOrader(Command command)
        {
            if (command.ToString() == "_18.命令模式.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加订单：" + command.ToString() +
                    " 时间：" + DateTime.Now.ToString());
            }
        }
        //取消订单
        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单：" + command.ToString() +
                   " 时间：" + DateTime.Now.ToString());
        }
        //通知执行
        public void Notify()
        {
            foreach (var i in orders)
            {
                i.ExcuteCommand();
            }
        }
    }
}
