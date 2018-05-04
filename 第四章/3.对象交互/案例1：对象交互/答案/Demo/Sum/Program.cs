using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            //实现计算器的功能
            Computer com = new Computer();
            Add add = new Add(11, 22);
            Sub sub = new Sub(1, 1);
            Multi multi = new Multi(1, 1);
            Div div = new Div(1, 1);

            com.Add(add.AddOne, add.AddTwo);//算加法
            com.Sub(sub.SubOne, sub.SubTwo);//算减法

            //以上是旧的用法
            //以下是重载方法的用法

            com.Com(add);//算加法
            com.Com(sub);//算减法
            com.Com(multi);//算除法
            com.Com(div);//算乘法
            Console.ReadLine();
        }
    }
}
