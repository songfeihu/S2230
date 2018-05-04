using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOffice
{
    
    /// <summary>
    /// 程序员类
    /// </summary>
    public class SE:Employee
    {
        //base() 隐式调用父类的无参构造函数
        public SE(string id,string name,int age,Gender g,int pop)
            :base(id,name,age,g)//显式调用父类带参构造函数
        {
            Console.WriteLine("我是SE带参构造函数");
            ////父类的公共属性
            //this.ID = id;
            //this.Name = name;
            //this.Age = age;
            //this.Gender = g;
            //自己特有属性
            this.Popularity = pop;
        }

        /// <summary>
        /// 人气值

        /// </summary>
        private int _popularity = 0;

        public int Popularity
        {
            get { return _popularity; }
            set { _popularity = value; }
        }

        /// <summary>
        /// 经理年度评分
        /// </summary>
        private int _score = 0;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        /// <summary>
        /// 经理评价
        /// </summary>
        private String _assess = "未评价";

        public String Assess
        {
            get { return _assess; }
            set { _assess = value; }
        }

        
        public string SayHi() 
        {
            string message = string.Format("大家好，我是 {0}, 今年 {1}岁，工号是 {2}，我的人气值高达 {3}!",
                base.Name,base.Age,base.ID,this.Popularity);
            return message;
        }
    }
}
