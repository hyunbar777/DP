using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.工厂模式
{
    public interface  IFactory
    {
        MaYun CreateMaYun();
    }
    public class ManFactory : IFactory
    {
        public MaYun CreateMaYun()
        {
            return new Man();
        }
    }
    public class WomanFactory : IFactory
    {
        public MaYun CreateMaYun()
        {
            return new Woman();
        }
    }
}
