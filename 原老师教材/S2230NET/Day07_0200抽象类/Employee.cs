﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0200抽象类
{
    public class Employee
    {
        public void GoHome(Traffic traffic)
        {
            traffic.Run();
        }
    }
}
