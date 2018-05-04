using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章项目
{
    class Program
    {
        static void Main(string[] args)
        {
            SE eng = new SE("112","jake",25,Gender.男,100);
            Console.WriteLine(eng.SayHi());
            PM pm = new PM("890","Timo",50,Gender.女,30);
            Console.WriteLine(pm.SayHi());
            Console.ReadLine();
        }
    }
}
