using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1观察模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss huhansan = new Boss();
            //看股票的同事
            StockObserver tong1 = new StockObserver(huhansan,"小美");

            //看NBA的同事
            NBAObserver tong2 = new NBAObserver(huhansan, "小花");


            huhansan.Update += new EventHandler(tong1.CloseStockMarket);
            huhansan.Update += new EventHandler(tong2.CloseNBA);
            //老板回来
            huhansan.SubjectState = "我胡汉三回来了";
            //通知
            huhansan.Notify();

            Console.ReadKey();
        }
    }
}
