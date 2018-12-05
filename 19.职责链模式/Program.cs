using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager nini = new CommonManager("剑圣");
            Majordomo dada = new Majordomo("夫子");
            GeneralManager yeye = new GeneralManager("昊天");
            
            //设置上级，可以根据实际需求更改
            nini.SetSuperior(dada);
            dada.SetSuperior(yeye);


            /*
             * 客户端的申请都是由 ’经理‘ 发起，但实际谁来决策由具体管理类来处理，客户端不知道
             */ 
            Request request = new Request();
            request.RequestType = "请假";
            request.RequestContent = "剑圣娶亲";
            request.Number = 1;
            nini.RequestApplication(request);

            Request request2 = new Request();
            request2.RequestType = "请假";
            request2.RequestContent = "夫子娶亲";
            request2.Number = 1;
            nini.RequestApplication(request2);

            Request request3 = new Request();
            request3.RequestType = "加薪";
            request3.RequestContent = "夫子加钱";
            request3.Number = 500;
            nini.RequestApplication(request3);

            Request request4 = new Request();
            request4.RequestType = "加薪";
            request4.RequestContent = "昊天加钱";
            request4.Number = 1000;
            nini.RequestApplication(request4);

            Console.ReadKey();
        }
    }
}
