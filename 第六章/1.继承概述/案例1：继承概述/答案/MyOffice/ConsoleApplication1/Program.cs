using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public class Operate
        {
            protected int a, b;
            public Operate(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public virtual int op()
            {
                return -1;
            }
        }
        /// <summary>
        /// 整数相加
        /// </summary>
        public class Sum : Operate
        {
            public Sum(int a, int b)
                : base(a, b)
            { }
            public override int op()
            {
                return this.a + this.b;
            }
        }
        /// <summary>
        /// 整数相减
        /// </summary>
        public class Sub : Operate
        {
            public Sub(int a, int b)
                : base(a, b)
            { }
            public override int op()
            {
                return this.a - this.b;
            }
        }
        /// <summary>
        /// 整数相乘
        /// </summary>
        public class Muli : Operate
        {
            public Muli(int a, int b)
                : base(a, b)
            { }
            public override int op()
            {
                return this.a * this.b;
            }
        }
        /// <summary>
        /// 整数相除
        /// </summary>
        public class chu : Operate
        {
            public chu(int a, int b)
                : base(a, b)
            { }
            public override int op()
            {
                return this.a/this.b;
            }
        }

      public  class Programdgd
        {
            static void Main(string[] args)
            {
                Console.WriteLine("请录入两个整数：");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());


                Operate sum = new Sum(num1, num2);
                int result1 = sum.op();
                Console.WriteLine("相加的结果:{0}", result1);

                Operate sub = new Sub(num1, num2);
                int result2 = sub.op();
                Console.WriteLine("相减的结果:{0}", result2);

                Operate muli = new Muli(num1, num2);
                int result3 = muli.op();
                Console.WriteLine("相乘的结果:{0}", result3);

                Operate chu = new chu(num1,num2);
                int result4 = chu.op();
                Console.WriteLine("相除的结果:{0}",result4);

                Console.ReadLine();
            }
        }
    }
}
