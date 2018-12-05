using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.模板模式
{
    public class TestPaper
    {
        public void TestQ1()
        {
            Console.WriteLine("小明：吃饭了吗？小白：吃你大爷！");
            Console.WriteLine("Q:小明吃饭了吗？");
            Console.WriteLine("a.吃你大爷 b.没有 c.吃了 d.一块吃了");
            //改成一个虚方法
            Console.WriteLine("答案：" + Answer1());
        }
        public void TestQ2()
        {
            Console.WriteLine("小花：他奶奶的，老娘居然来大姨妈了！");
            Console.WriteLine("Q:谁来大姨妈了");
            Console.WriteLine("a.小花 b.小花他奶奶 c.小花他老娘 d.大姨妈");
            Console.WriteLine("答案：" + Answer2());
        }
        //虚方法的目的就是给继承的子类重写，因为这里每个人的答案都是不同的
        protected virtual string Answer1()
        {
            return "";
        }
        protected virtual string Answer2()
        {
            return "";
        }
    }
    //学生A的试卷
    public class TestPaperA : TestPaper
    {
        protected override string Answer1()
        {
            return "b";
        }
        protected override string Answer2()
        {
            return "c";
        }
    }
    //学生A的试卷
    public class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "a";
        }
        protected override string Answer2()
        {
            return "d";
        }
    }
}
