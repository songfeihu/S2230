using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook
{
    //顾客类
   public class Client
    {
       //点菜
       public void Order(Waitress wait, Order order)
       {
           Console.WriteLine("顾客开始点菜:{0}",order.mealList);
           wait.GetOrder(order);
       }

       //用餐
       public void Eat()
       {
           Console.WriteLine("客人正在用餐");
       }
    }
}
