using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
   public class Employee
    {
       public Employee()
       {
           Console.WriteLine("我是Employee无参构造函数");
       }

       public Employee(string id, string name, int age, Gender g)
       {
           Console.WriteLine("我是Employee带参构造函数");
           this.ID = id;
           this.Name = name;
           this.Age = age;
           this.Gender = g;
       }
        /// <summary>
        /// 工号
        /// </summary>
        protected string ID { get; set; }//属性

        /// <summary>
        /// 年龄
        /// </summary>
        protected int Age { get; set; }

        /// <summary>
        /// 姓名
        /// protected 当前类和子类可以访问
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        protected Gender Gender { get; set; }

        public virtual string SayHi()
        {
            return "大家好,我是员工类";
        }
    }
}
