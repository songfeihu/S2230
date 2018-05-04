using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            TV tv2= new TV();
            RemoteContorl tc = new RemoteContorl();
            tc.TurnOn(tv);//摇控器控制电视开机
            tc.ChangeChannel(tv);//换台
            tc.TurnOff(tv);//关机
            Console.ReadLine();
        }
    }
}
