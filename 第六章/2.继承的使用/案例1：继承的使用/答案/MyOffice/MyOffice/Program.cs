using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            //程序员对象
            SE se = new SE("111", "张三", 20, Gender.male, 99);

            PM pm = new PM("张经理", "112", 35, Gender.male, 10);

            List<Employee> emps = new List<Employee>();//泛型集合
            emps.Add(se);//添加子类对象到父类集合中
            emps.Add(pm);
            //循环集合
            foreach (Employee em in emps)
            {
                if (em is SE)//类型判断,是否是某种类型
                {
                    SE ss = (SE)em;//类型转换
                    Console.WriteLine(ss.SayHi());
                }
                else if (em is PM)
                {
                    PM p = (PM)em;
                    Console.WriteLine(p.SayHi());
                }
            }
           
             Console.ReadLine();
        }
    }
}
