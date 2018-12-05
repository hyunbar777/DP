using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.适配器模式
{
    //外籍中锋
    public class ForeignCenter
    {
        /// <summary>
        /// 外籍中锋类球员的姓名用属性而不是构造方法来区别与前面的球员类的不同
        /// </summary>
        public string Name { get; set; }
        //表示”外籍中锋“只懂中文”进攻“
        public void 进攻()
        {
            Console.WriteLine("中锋{0}进攻", Name);
        }
        //表示”外籍中锋“只懂中文”防守“
        public void 防守()
        {
            Console.WriteLine("中锋{0}防守", Name);
        }
    }
    public class Tarnslator : Player
    {
        private ForeignCenter w = new ForeignCenter();
        public Tarnslator(string name) : base(name)
        {
            w.Name = name;
        }
        //翻译者将“Attack”翻译为“进攻”告诉外籍中锋
        public override void Attack()
        {
            w.进攻();
        }
        //翻译者将“Defense”翻译为“防守”告诉外籍中锋
        public override void Defense()
        {
            w.防守();
        }
    }
}
