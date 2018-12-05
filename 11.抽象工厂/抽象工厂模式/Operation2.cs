using _11.抽象工厂.工厂模式访问数据库;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.抽象工厂.抽象工厂模式
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
    public interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }
    public class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Sql server中根据ID得到User表一条记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在Sql server中给User表增加一条记录");
        }
    }
    public class MysqlDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Mysql中根据ID得到Department表一条记录");
            return null;
        }

        public void Insert(Department user)
        {
            Console.WriteLine("在Mysql中给Department表增加一条记录");
        }
    }
    public interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
    public class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
    public class MysqlFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new MysqlDepartment();
        }

        public IUser CreateUser()
        {
            return new MysqlUser();
        }
    }
}
