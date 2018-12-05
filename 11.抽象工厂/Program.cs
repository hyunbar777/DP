
using _11.抽象工厂.抽象工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.0 工厂模式访问
            //User user = new User();
            ////要改数据库，只需改 new MysqlFactory（）；
            //IFactory factory = new SqlServerFactory();
            //IUser iu = factory.CreateUser();
            //iu.insert(user);
            //iu.GetUser(1);
            #endregion

            #region 抽象工厂
            //User user = new User();
            //Department dep = new Department();
            ////只需要确定实例化哪一个数据库访问对象给factory
            //抽象工厂模式.IFactory factory = new 抽象工厂模式.MysqlFactory();

            //IUser iu = factory.CreateUser();
            //iu.insert(user);
            //iu.GetUser(1);

            //IDepartment idep = factory.CreateDepartment();
            //idep.Insert(dep);
            //idep.GetDepartment(1);


            #endregion

            #region 2.0 简单工厂
            //User user = new User();
            //Department dep = new Department();
            //IUser iu = 简单工厂.Data4.CreateUser();
            //iu.insert(user);
            //iu.GetUser(1);

            //IDepartment idep = 简单工厂.Data4.CreateDepartment();
            //idep.Insert(dep);
            //idep.GetDepartment(1);
            #endregion

            #region 反射 + 抽象工厂
            //User user = new User();
            //Department dep = new Department();
            //IUser iu = 反射抽象工厂.Data3.CreateUser();
            //iu.insert(user);
            //iu.GetUser(1);

            //IDepartment idep = 反射抽象工厂.Data3.CreateDepartment();
            //idep.Insert(dep);
            //idep.GetDepartment(1);
            #endregion

            Console.ReadKey();
        }
    }
}
