using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.桥接模式
{
    //手机品牌抽象类
    public abstract class Brand
    {
        protected App soft;
        public void SetApp(App soft)
        {
            this.soft = soft;
        }
        public abstract void Run();
    }
    //华为手机
    public class Brandhuawei : Brand
    {
        public Brandhuawei()
        {
            Console.WriteLine("华为手机");
        }
        public override void Run()
        {
            soft.Run();
        }
    }
    //小米手机
    public class BrandMI : Brand
    {
        public BrandMI()
        {
            Console.WriteLine("小米手机");
        }
        public override void Run()
        {
            soft.Run();
        }
    }
}
