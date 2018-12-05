using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    public class OperationFactory
    {
        public static Operation CreateOperate(string type)
        {
            Operation oper = null;
            switch (type)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
}
