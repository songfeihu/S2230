using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化对象
            Chef chef = new Chef();
            Waitress wang = new Waitress();
            Waitress zhang = new Waitress();
            Client ch01 = new Client();
            //菜单
            Order order = new Order();
            order.id = 99;
            order.mealList = "水煮鱼";
            order.customer = ch01;

            //顾客点菜
            ch01.Order(wang, order);
            //服务员把菜单告知厨师
            wang.SendOrder(chef);
            //厨师做菜
            chef.Cook();
            //厨师提示取菜
            chef.SendAlert(zhang);
            //服务员传菜
            zhang.TransCook();
            Console.ReadLine();
        }
    }
}
