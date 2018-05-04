using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRun
{
    //sealed密封类,不能有子类
     class Truck:Vehicle
    {
        public Truck() { }
        //卡车带参构造函数
        public Truck(string place, string type)
            : base(place, type)
        {

        }
        //卡车奔跑的方法
        public void TruckRun()
        {
            Console.WriteLine("型号为{0},产地为{1}的卡车正在行驶",this.Type,base.Place);
        }
    }

}
