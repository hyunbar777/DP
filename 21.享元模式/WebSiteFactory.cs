using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.享元模式
{
    public class WebSiteFactory
    {
        private Hashtable flyWeights = new Hashtable();
        //获得网站分类
        public WebSite GetWebSiteCategory(string key)
        {
            if (!flyWeights.ContainsKey(key))
            {
                flyWeights.Add(key, new ConcreteWebSite(key));
            }
            return (WebSite)flyWeights[key];
        }
        //获得网站分类总数
        public int GetWebSiteCount()
        {
            return flyWeights.Count;
        }
    }
}
