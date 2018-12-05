using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.建造者模式
{
    public class PersonDirector
    {
        private PersonBuilder builder;

        //用户告诉指挥者，我需要什么样的小人
        public PersonDirector(PersonBuilder b)
        {
            this.builder = b;
        }
        //根据用户的选择建造小人
        public void CreatePerson()
        {
            builder.BuilderHead();
            builder.BuilderBody();
            builder.BuilderArmLeft();
            builder.BuilderArmRight();
            builder.BuilderLegLeft();
            builder.BuilderLegRight();
        }
    }
}
