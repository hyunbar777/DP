using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.单例模式
{
    //密封类不能被继承
    public sealed class Singleton4
    {
        //在第一次引用类的任何成员时创建实例。公共语言运行库负责处理变量初始化
        private static readonly Singleton4 instance = new Singleton4();

        private Singleton4() { }
        public static Singleton4 GetInstance()
        {
            return instance;
        }
    }
}
