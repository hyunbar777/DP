using _11.抽象工厂.抽象工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.抽象工厂.简单工厂
{
   public class Data4
    {
        private static readonly string db = "Sqlserver";
        public static IUser CreateUser()
        {
            IUser result = null;
            switch (db)
            {
                case "Sqlserver":
                    result = new SqlServerUser();
                    break;
                case "Mysql":
                    result = new MysqlUser();
                    break;
                default:
                    break;
            }
            return result;
        }
        public static IDepartment CreateDepartment()
        {
            IDepartment result = null;
            switch (db)
            {
                case "Sqlserver":
                    result = new SqlServerDepartment();
                    break;
                case "Mysql":
                    result = new MysqlDepartment();
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
