using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.享元模式
{
    public abstract class WebSite
    {
        //"使用"方法需要传递“用户”对象
        public abstract void Use(User user);
    }
    public class ConcreteWebSite : WebSite
    {
        private string name;
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }
        public override void Use(User user)
        {
            Console.WriteLine("网站分类：" + name + " 用户：" + user.Name);
        }
    }
}
