using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOffice
{
    /// <summary>
    /// 项目经理类
    /// </summary>
    class PM:Employee
    {
        //参数的类型\个数\顺序要一致
        public PM(string n, string i, int a, Gender g, int year)
            :base(i,n,a,g)
        {
            Console.WriteLine("我是PM带参构造函数");
            ////父类的公共属性
            //this.Name = name;
            //this.ID = id;
            //this.Age = age;
            //this.Gender = g;
            //自己特有的属性
            this.YearOfExperience = year;
        }

        /// <summary>
        /// 资历
        /// </summary>
   
        public int YearOfExperience { get; set; }
        /// <summary>
        /// 问好
        /// </summary>
        /// <returns>问好的内容</returns>
        public string SayHi() 
        {
            string message;
            message = string.Format(
                "大家好，我是 {0} ，今年 {1} 岁，项目管理经验 {2}年。",
                base.Name, base.Age, this.YearOfExperience
            );
            return message;
        }

        /// <summary>
        /// 项目经理评分
        /// </summary>
        /// <param name="se"></param>
        public void Judge(SE se, String assess, int score)
        {
            se.Assess = assess;
            se.Score = score;
        }
    }
}
