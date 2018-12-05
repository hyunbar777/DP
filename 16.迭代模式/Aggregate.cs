using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.迭代模式
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        //集合总数
        public int Count { get { return items.Count; } }
        //声明一个索引
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

}
