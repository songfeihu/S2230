using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRun
{
    class Program
    {
        static void Main(string[] args)
        {
            //父类对象
            Vehicle v = new Vehicle("中国", "现代");
            v.VehicleRun();

            //子类对象
            Truck truck = new Truck("中国", "红旗");
            truck.TruckRun();//子类方法
            truck.VehicleRun();//父类方法
            Console.ReadLine();
        }
    }
}
