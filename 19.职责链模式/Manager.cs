using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.职责链模式
{
    public abstract class Manager
    {
        protected string name;
        //管理者的上级
        protected Manager superior;
        public Manager(string name)
        {
            this.name = name;
        }
        //设置管理者的上级
        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }
        //申请请求
        public abstract void RequestApplication(Request request);
    }
    //经理类
    public class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }
        public override void RequestApplication(Request request)
        {
            //经理所能有的权限就是可批准下属两天内的假期
            if (request.RequestType == "请假" && request.Number <= 2)
            {
                Console.WriteLine("{0}:{1} 数量{2} 被比准", name, request.RequestContent, request.Number);
            }
            else
            {
                //其余的申请都需要转到上级
                if (superior != null)
                {
                    superior.RequestApplication(request);
                }
            }
        }
    }
    //总监
    public class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        {
        }

        public override void RequestApplication(Request request)
        {
            //总监所能有的权限就是可批准下属一周内的假期
            if (request.RequestType == "请假" && request.Number <= 5)
            {
                Console.WriteLine("{0}:{1} 数量{2} 被比准", name, request.RequestContent, request.Number);
            }
            else
            {//其余的申请都需要转到上级
                if (superior != null)
                {
                    superior.RequestApplication(request);
                }
            }
        }
    }
    //总经理
    public class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void RequestApplication(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine("{0}:{1} 数量{2} 被比准", name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine("{0}:{1} 数量{2} 被比准", name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine("{0}:{1} 数量{2} 滚蛋吧你", name, request.RequestContent, request.Number);
            }
        }
    }
}
