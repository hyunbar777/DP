using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.中介模式
{
    //联合国机构
    public abstract class UnitedNations
    {
        public abstract void Declare(string message, Country colleague);
    }
    //联合国安理会
    public class UnitedNationsSecurtiy : UnitedNations
    {
        private USA colleague1;
        private Iraq colleaque2;
        //美国
        public USA Colleaque1
        {
            set { colleague1 = value; }
        }
        //伊拉克
        public Iraq Colleaque2
        {
            set { colleaque2 = value; }
        }
        //声明
        public override void Declare(string message, Country colleague)
        {
            if (colleague == colleague1)
            {
                colleaque2.GetMessage(message);
            }
            else
            {
                colleague1.GetMessage(message);
            }
        }
    }

}
