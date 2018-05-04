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
            
            Console.WriteLine(se.SayHi());

            PM pm = new PM("张经理", "112", 35, Gender.male, 10);
            Console.WriteLine(pm.SayHi());

             Console.ReadLine();
        }
    }
}
