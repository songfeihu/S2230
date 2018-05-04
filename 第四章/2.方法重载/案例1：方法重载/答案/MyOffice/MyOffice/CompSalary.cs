using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    class CompSalary
    {
        //PM作为参数
        public static void Pay(PM pm)
        {
            double money = pm.BasePay + pm.PgrPrize + pm.Bonus;
            Console.WriteLine("项目经理的薪水为:"+money);
        }
        //SE作为参数
        public static void Pay(SE se)
        {
            double money = se.BasePay + se.MeritPay;
            Console.WriteLine("程序的薪水为:"+money);
        }
    }
}
