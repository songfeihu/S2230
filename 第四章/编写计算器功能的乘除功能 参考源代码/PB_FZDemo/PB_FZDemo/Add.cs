using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_FZDemo
{
    public class Add
    {
        //加法类
        private int addOne;//被加数

        public int AddOne
        {
            get { return addOne; }
            set { addOne = value; }
        }

        private int addTwo;//加数

        public int AddTwo
        {
            get { return addTwo; }
            set { addTwo = value; }
        }

        public Add(int addOne,int addTwo)
        {
            this.addOne = addOne;
            this.addTwo = addTwo;
        }
    }
}
