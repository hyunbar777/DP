using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory f = new WebSiteFactory();

            WebSite f1 = f.GetWebSiteCategory("产品展示");
            f1.Use(new User("美美"));

            WebSite f2 = f.GetWebSiteCategory("产品展示");
            f2.Use(new User("柔柔"));

            WebSite f3 = f.GetWebSiteCategory("产品展示");
            f3.Use(new User("香香"));

            WebSite f4 = f.GetWebSiteCategory("博客");
            f4.Use(new User("丽丽"));

            WebSite f5= f.GetWebSiteCategory("博客");
            f5.Use(new User("探探"));

            WebSite f6 = f.GetWebSiteCategory("博客");
            f6.Use(new User("静静"));

            Console.WriteLine("网站分类总数：{0}", f.GetWebSiteCount());
            Console.Read();
        }
    }
}
