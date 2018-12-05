using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.命令模式
{
    //抽象命令
    public abstract class Command
    {
        protected Barbecuer receiver;
        //确定烤肉串者
        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        public abstract void ExcuteCommand();
    }
    //烤羊肉串命令
    public class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
    //烤鸡翅串命令
    public class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
