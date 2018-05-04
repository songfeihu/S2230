using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gongzuohuibao
{
   public  class SE:Employee
    {
       //public string Name { get; set; }
       //public string ID { get; set; }
       //public int Age { get; set; }
       //public Gender Gender { get; set; }
       public int Popu { get; set; }
       //protected List<Job> WorkList { get; set; }
       public string DoWork() 
       {
           StringBuilder sd = new StringBuilder();
           sd.Append(this.Name+"\n");
           for (int i = 0; i < this.WorkList.Count; i++)
           {
               sd.Append((i+1)+"."+WorkList[i].Name+":"+WorkList[i].Miaoshu+"\n");
           }
           return sd.ToString();
       }
       //修改SE类的构造函数
       public SE(int id, int age, string name, Gender gender, int popu, List<Job> list)
              : base(id,age,name,gender,list)
       {
           this.Popu = popu;
       }
    }
}
