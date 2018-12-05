using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.工厂模式
{
    /// <summary>
    /// 这个人会挣钱，会开公司，男人，女人都要学习
    /// </summary>
    public class MaYun
    {
        public void Money()
        {
            Console.WriteLine("挣钱");
        }
        public void Company()
        {
            Console.WriteLine("开公司");

        }
    }
}
