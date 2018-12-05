using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂
            MaYun man1 = SimpleFactory.CreateMaYun("Man");
            man1.Money();
            man1.Company();
            MaYun woman1 = SimpleFactory.CreateMaYun("Woman");
            woman1.Money();
            woman1.Company();
            #endregion

            #region 工厂
            IFactory factory = new ManFactory();
            MaYun mm = factory.CreateMaYun();
            mm.Company();
            mm.Money();
            #endregion
        }
    }
}
