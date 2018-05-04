using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gongzuohuibao
{
   public  class Employee
    {
       public string Name{get;set;}
       public int ID{get;set;}
       public int Age{get;set;}
       public Gender Gender{get;set;}

        protected List<Job> WorkList { get; set; }//给Employee类添加工作列表属性
        //Employee类的构造函数
       public Employee(int id,int age,string name, Gender gender ,List<Job>list)
   {
       this.ID = id;
       this.Name = name;
       this.Age = age;
       this.Gender = gender;
       this.WorkList = list;
   }

    }
}
