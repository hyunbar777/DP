using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.代理模式
{
    /// <summary>
    /// 追求者实现“送礼物”接口
    /// </summary>
    public class Pursuit : IGiveGift
    {
        Girl girl;
        public Pursuit(Girl girl)
        {
            this.girl = girl;
        }
        public void GiveFlowers()
        {
            Console.WriteLine("给 "+ girl.Name+" 送花");
        }
    }
}
