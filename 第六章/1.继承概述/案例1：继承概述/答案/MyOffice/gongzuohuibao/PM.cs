using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gongzuohuibao
{
   public  class PM:Employee
    {
       public string ID { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
       public Gender Gender { get; set; }
       public int Year { get; set; }

          public string DoWork()
          {
              string message = this.Name+"管理员完成工作内容！";
              return message;
          }
          public PM(int id,int age,string name, Gender gender ,int year,List<Job> list)
              : base(id,age,name,gender,list)
          ///int id,int age,string name, Gender gender ,List<Job>
          {
              this.Year = year;
          }
    }
}

