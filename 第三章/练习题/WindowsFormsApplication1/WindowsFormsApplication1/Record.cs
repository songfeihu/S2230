using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Record
    {

       //保存父窗体的使用
       //签到的时间
        public DateTime SignInTime { get; set; } 
       //签退的时间
        public DateTime SignOutTime { get; set; }
       //工号
        public string ID { get; set; }
       //员工姓名
        public string Name { get; set; }
       
    }
}
