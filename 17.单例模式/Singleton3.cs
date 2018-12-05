using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.单例模式
{
    //多线程时的单例
    public class Singleton3
    {
        private static Singleton3 instance;
        //程序运行时创建一个静态只读的进程辅助对象
        private static readonly object syncRoot = new object();
        //构造私有，不能创建实例
        private Singleton3()
        {

        }
        //获得笨类实例的唯一全局访问点
        public static Singleton3 GetInstance()
        {
            //先判断实例是否存在，不存在再加锁处理
            if (instance == null)
            {
                //在同一时刻加了锁的那部分程序只有一个线程可以进入
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton3();
                    }
                }
            }
            return instance;
        }
    }
}
