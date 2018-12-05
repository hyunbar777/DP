using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.代理模式
{
    /// <summary>
    /// 代理类也实现送礼物接口
    /// </summary>
    public class Proxy : IGiveGift
    {
        Pursuit gg;
        public Proxy(Girl mm)
        {
            gg = new Pursuit(mm);
        }
        /// <summary>
        /// 实现追求者类得相关方法
        /// </summary>
        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
