using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class CashContext
    {
        private CashSuper cs;
        ///// <summary>
        ///// 通过构造函数，传入具体的收费策略
        ///// </summary>
        ///// <param name="super"></param>
        //public CashContext(CashSuper super)
        //{
        //    this.cs = super;
        //}
        /// <summary>
        /// 工厂和策略模式结合
        /// </summary>
        /// <param name="super"></param>
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
                default: break;
            }
        }
        public double GetResult(double money)
        {
            //根据收费策略的不同，获得计算结果
            return cs.acceptCash(money);
        }
    }
}
