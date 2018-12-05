using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.原型模式
{
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;
        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }
        private Resume(WorkExperience work)
        {
            //提供Clone方法调用自己的私有构造函数，以便克隆“工作经历”的数据
            this.work = (WorkExperience)work.Clone();
        }
        //设置个人信息
        public void SetPersonalInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }
        //设置工作经历
        public void SetWorkExperience(string workDate,string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }
        public void Display()
        {
            Console.WriteLine("{0} {1}{2}", name, sex, age);
            Console.WriteLine("工作经历：{0}{1}", work.WorkDate, work.Company);
        }
        /// <summary>
        /// 调用私有构造函数，让“工作经历”克隆完成，然后再给这个“简历”对象的相关字段赋值，
        /// 最终返回一个深赋值的简历对象
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Resume obj = new Resume(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}
