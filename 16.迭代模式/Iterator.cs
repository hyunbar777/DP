using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.迭代模式
{
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
    public class ConcreteIterator : Iterator
    {
        //定义一个具体聚集对象
        private ConcreteAggregate aggregate;

        private int current = 0;
        //初始化时将具体的聚集对象传入
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        //得到聚集的第一个对象
        public override object First()
        {
            return aggregate[0];
        }
        //返回当前聚集对象
        public override object CurrentItem()
        {
            return aggregate[current];
        }

        //判断当前是否遍历到结尾
        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }
        //得到聚集的下一个对象
        public override object Next()
        {
            object ret = null;
            current++;
            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
    public class ConcreteIteratorDesc : Iterator
    {
        //定义一个具体聚集对象
        private ConcreteAggregate aggregate;

        private int current = 0;
        //初始化时将具体的聚集对象传入
        public ConcreteIteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            current = aggregate.Count - 1;
        }
        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[aggregate.Count - 1];
        }

        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if (current >= 0)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
