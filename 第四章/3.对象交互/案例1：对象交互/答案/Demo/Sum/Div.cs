using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Div
    {
        //除法类
        private int divOne;//被除数

        public int DivOne
        {
            get { return divOne; }
            set { divOne = value; }
        }

        private int divTwo;//除数

        public int DivTwo
        {
            get { return divTwo; }
            set { divTwo = value; }
        }

        public Div(int divOne, int divTwo)
        {
            this.divOne = divOne;
            this.divTwo = divTwo;
        }
    }
}
