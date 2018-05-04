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

            SmallTruck st = new SmallTruck();
            st.SmallTruckRun();//自己的方法
            st.TruckRun();//父类的方法
            st.VehicleRun();//父类的父类的方法

            Console.ReadLine();
        }
    }
}
