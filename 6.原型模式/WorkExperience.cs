using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.原型模式
{

    /// <summary>
    /// 1、工作经历类
    /// 2、ICloneable支持克隆，即用与现有实例相同的值创建类的新实例。
    /// </summary>
    public class WorkExperience : ICloneable
    {
        public string WorkDate { get; set; }
        public string Company { get; set; }
        public object Clone()
        {
            //返回当前 System.Object 的浅表副本。
            return this.MemberwiseClone();
        }
    }
}
