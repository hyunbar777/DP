using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //紧急项目
            Work p = new Work();
            p.Hour = 9;
            p.WriteProgram();
            p.Hour = 10;
            p.WriteProgram();
            p.Hour = 12;
            p.WriteProgram();
            p.Hour = 13;
            p.WriteProgram();
            p.Hour = 14;
            p.WriteProgram();
            p.Hour = 17;
            p.WriteProgram();

            p.TaskFinished = false;
            p.WriteProgram();
            p.Hour = 19;
            p.WriteProgram();
            p.Hour = 22;
            p.WriteProgram();

            Console.ReadKey();
        }
    }
}
