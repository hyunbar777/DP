using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.工厂模式
{
    public class Man : MaYun
    {

    }
    public class Woman : MaYun
    {

    }
    public class SimpleFactory
    {
        public static MaYun CreateMaYun(string type)
        {
            MaYun m = null;
            switch (type)
            {
                case "Man":
                    m = new Man();
                    break;
                case "Woman":
                    m = new Woman();
                    break;
                default:
                    break;

            }
            return m;
        }
    }
}
