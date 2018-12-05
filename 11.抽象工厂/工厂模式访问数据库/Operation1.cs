using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.抽象工厂.工厂模式访问数据库
{
    public interface IUser
    {
        void insert(User user);
        User GetUser(int id);
    }
    public class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Sql server中根据ID得到User表一条记录");
            return null;
        }

        public void insert(User user)
        {
            Console.WriteLine("在Sql server中给User表增加一条记录");
        }
    }
    public class MysqlUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Mysql中根据ID得到User表一条记录");
            return null;
        }

        public void insert(User user)
        {
            Console.WriteLine("在Mysql中给User表增加一条记录");
        }
    }
}
