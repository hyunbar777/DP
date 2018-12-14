using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.访问者模式
{
    //对象结构类
    public class ObjStructure
    {
        private List<Person> elements = new List<Person>();
        
        public void Attach(Person element)
        {
            elements.Add(element);
        }
        public void Remove(Person element)
        {
            elements.Remove(element);
        }
        public void Display(Action vistor)
        {
            foreach(var i in elements)
            {
                i.Accept(vistor);
            }
        }
    }
}
