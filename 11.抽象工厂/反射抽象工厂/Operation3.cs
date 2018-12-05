using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Configuration;
using _11.抽象工厂.抽象工厂模式;

namespace _11.抽象工厂.反射抽象工厂
{
    public class Data3
    {
        //程序集名称
        private static readonly string AssemblyName = "抽象工厂模式";
        //数据库名称，mysql，oracle等
        //private static readonly string db = "Sqlserver";

        //配置文件中获取
        private static readonly string db = ConfigurationManager.AppSettings.Get("_db");
        public static IUser CreateUser()
        {
            string classname = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(classname);
        }
        public static IDepartment CreateDepartment()
        {
            string classname = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(classname);
        }
    }
}
