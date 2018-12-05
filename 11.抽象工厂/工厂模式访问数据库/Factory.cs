using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.抽象工厂.工厂模式访问数据库
{
    public interface IFactory
    {
        IUser CreateUser();
    }
    public class SqlServerFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
    public class MysqlFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new MysqlUser();
        }
    }
}
