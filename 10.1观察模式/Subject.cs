using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1观察模式
{
    public interface Subject
    {
        void Notify();
        string SubjectState { get; set; }
    }
}
