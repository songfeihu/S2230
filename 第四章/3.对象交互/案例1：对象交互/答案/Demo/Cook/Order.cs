﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook
{
    //定单
    public class Order
    {
        public Client customer;//顾客 null
        public int id;//餐桌号
        public string mealList;//点的菜
    }
}
