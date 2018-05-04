using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook
{
    //厨师类
    public class Chef
    {
        private Order order;
        //获得菜单 
        public void GetOrder(Order order)
        {
            this.order = order;
        }

        //做菜
        public void Cook()
        {
            Console.WriteLine("厨师烹制:{0}",order.mealList);
            Console.WriteLine("制作完毕");
        }

        //提示服务员取菜
        public void SendAlert(Waitress wait)
        {
            Console.WriteLine("厨师提示服务员取菜");
            wait.GetOrder(order);
        }
    }
}
