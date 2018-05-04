using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRun
{
    public class Vehicle
    {
        public Vehicle() { }
        //带参构造函数
        public Vehicle(string place, string type)
        {
            this.Place = place;
            this.Type = type;
        }
        //属性
        public string Place { get; set; }
        public string Type { get; set; }

        //方法
        public void VehicleRun()
        {
            Console.WriteLine("汽车在奔跑");
        }
    }
}
