using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_FZDemo
{
    public class Sub
    {
        //减法类
        private int subOne;//被减数

        public int SubOne
        {
            get { return subOne; }
            set { subOne = value; }
        }

        private int subTwo;//减数

        public int SubTwo
        {
            get { return subTwo; }
            set { subTwo = value; }
        }

        public Sub(int subOne, int subTwo)
        {
            this.subOne = subOne;
            this.subTwo = subTwo;
        }
    }
}
