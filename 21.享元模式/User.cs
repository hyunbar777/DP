﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.享元模式
{
    public class User
    {
        private string name;
        public User(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
}
