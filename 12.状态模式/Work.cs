using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.状态模式
{
    public class Work
    {
        private State current;
        public Work()
        {
            //工作初始化为上午工作状态，即上午9点开始上班
            current = new ForenoonState();
        }
        //'钟点'属性，状态转换的依据
        public double Hour { get; set; }
        //'任务完成'属性，是否能下班的依据
        public bool TaskFinished { get; set; }
        public void SetState (State s)
        {
            current = s;
        }
        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
