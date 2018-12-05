using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.单例模式
{
    public class Singleton1
    {
        private static Singleton1 instance;
        //构造私有，不能创建实例
        private Singleton1()
        {

        }
        //获得笨类实例的唯一全局访问点
        public static Singleton1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton1();
            }
            return instance;
        }
    }
}
