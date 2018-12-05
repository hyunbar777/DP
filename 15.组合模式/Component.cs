using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.组合模式
{
    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        //通常用add方法来提供增加树叶或树枝的功能
        public abstract void Add(Component c);
        //通常用remove方法来提供移除树叶或树枝的功能
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
