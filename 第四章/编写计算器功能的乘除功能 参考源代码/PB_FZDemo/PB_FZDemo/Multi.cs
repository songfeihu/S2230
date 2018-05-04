using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_FZDemo
{
    public class Multi
    {
        //乘法类
        private int multiOne;//乘数

        public int MultiOne
        {
            get { return multiOne; }
            set { multiOne = value; }
        }

        private int multiTwo;//乘数

        public int MultiTwo
        {
            get { return multiTwo; }
            set { multiTwo = value; }
        }

        public Multi(int multiOne,int multiTwo)
        {
            this.multiOne = multiOne;
            this.multiTwo = multiTwo;
        }
    }
}
