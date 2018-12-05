using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.适配器模式
{
    //球员类 
    public abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }
        public abstract void Attack();
        public abstract void Defense();
    }
    //前锋
    public class Forwwards : Player
    {
        public Forwwards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("前锋{0}进攻",name);
        }

        public override void Defense()
        {
            Console.WriteLine("前锋{0}防守", name);
        }
    }
    //中锋
    public class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("中锋{0}进攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("中锋{0}防守", name);
        }
    }
    //后卫
    public class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("后卫{0}进攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("后卫{0}防守", name);
        }
    }
}
