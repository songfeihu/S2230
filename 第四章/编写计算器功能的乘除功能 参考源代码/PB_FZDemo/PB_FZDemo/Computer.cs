using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_FZDemo
{
    public class Computer
    {
        //编写加法运算类
        public void Add(int addOne,int addTwo)
        {
            Console.WriteLine("两数的和是：{0}", addOne + addTwo);
        }

        //编写减法运算类
        public void Sub(int subOne,int subTwo)
        {
            Console.WriteLine("两数的差是：{0}", subOne - subTwo);
        }

        // 算加法

        public void Com(Add add)
        {
            Console.WriteLine("方法重载计算两数的和是：{0}", add.AddOne + add.AddTwo);
        }

        // 算减法

        public void Com(Sub sub)
        {
            Console.WriteLine("方法重载计算两数的差是：{0}", sub.SubOne - sub.SubTwo);
        }
        
        // 算乘法

        public void Com(Multi multi)
        {
            Console.WriteLine("方法重载计算两数的积是：{0}", multi.MultiOne * multi.MultiTwo);
        }

        // 算除法
        public void Com(Div div)
        {
            Console.WriteLine("方法重载计算两数的商是：{0}", div.DivOne / div.DivTwo);
        }
    }
}
