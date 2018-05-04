using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvDemo
{
    //摇控器类
    class RemoteContorl
    {
        //开机
        public void TurnOn(TV tv)
        {
            tv.Open();
        }

        //关机
        public void TurnOff(TV tv)
        {
            tv.TurnOff();
        }

        //换台
        public void ChangeChannel(TV tv)
        {
            Console.WriteLine("请输入频道号:");
            int num =int.Parse( Console.ReadLine());
            tv.Change(num);
        }
    }
}
