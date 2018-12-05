using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1观察模式
{
    public class StockObserver
    {
        private string name;
        private string observerState;
        private Subject subject;
        public StockObserver(Subject subject, string name)
        {
            this.name = name;
            this.subject = subject;
        }
        public void CloseStockMarket()
        {
            Console.WriteLine("{0}{1} 关闭股票行情，继续工作！",subject.SubjectState,name);
        }
    }
    public class NBAObserver
    {
        private string name;
        private string observerState;
        private Subject subject;
        public NBAObserver(Subject subject, string name)
        {
            this.name = name;
            this.subject = subject;
        }
        public void CloseNBA()
        {
            Console.WriteLine("{0}{1} 关闭NBA直播，继续工作！", subject.SubjectState, name);
        }
    }
}
