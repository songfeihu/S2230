using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvDemo
{
    class TV
    {
        private bool isOn = false;//是否开机
        //开机
        public void Open()
        {
            if (isOn)
            {
                Console.WriteLine("电视机已经打开");
            }
            else
            {
                Console.WriteLine("成功打开电视机");
                isOn = true;
            }
        }

        //关机
        public void TurnOff()
        {
            if (isOn)
            {
                Console.WriteLine("正在关机...");
                isOn = false;
            }
            else
            {
                Console.WriteLine("电视机已经关闭");
            }
        }

        //换台
        public void Change(int channelNo)
        {
            if (isOn)
            {
                Console.WriteLine("正在切换到{0}台",channelNo);
            }
        }
    }
}
