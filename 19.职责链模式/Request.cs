﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.职责链模式
{
    public class Request
    {
        public string RequestType { get; set; }
        public string RequestContent { get; set; }
        public int Number { get; set; }
    }
}
