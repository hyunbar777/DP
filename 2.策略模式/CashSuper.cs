using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 现金收取父类的抽取方法，收取现金，参数为原价，返回当前价
    /// </summary>
    public abstract class CashSuper
    {
        public abstract double acceptCash(double money);
    }
    /// <summary>
    /// 正常收费
    /// </summary>
    public class CashNormal : CashSuper
    {
        /// <summary>
        /// 正常收费，原价返回
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double acceptCash(double money)
        {
            return money;
            
        }
    }
    /// <summary>
    /// 打折收费子类
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
    /// <summary>
    /// 返利收费子类
    /// </summary>
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        /// <summary>
        /// 如：满300返100，则moneyCondition=300，moneyReturn=100
        /// </summary>
        /// <param name="moneyCondition"></param>
        /// <param name="moneyReturn"></param>
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double acceptCash(double money)
        {
            double result = money;
            if (result > moneyCondition)
            {
                //若大于返利条件，则需要减去返利值
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }

    public class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300","100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
                default:break;
            }
            return cs;
        }
    }
}
