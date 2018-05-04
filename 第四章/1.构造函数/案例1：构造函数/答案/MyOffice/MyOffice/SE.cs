using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOffice
{  
    /// <summary>
    /// 员工类
    /// </summary>
    public class SE
    {
        //无参构造函数
        public SE()
        {
            Console.WriteLine("我是无参数构造函数");
        }
        ////带参构造函数
        public SE(string id, string name, int age, Gender g, int pop)
        {
            Console.WriteLine("我是带参数构造函数");
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Gender = g;
            this.Popularity = pop;
        }

        //public SE()
        //{
        //    this.ID = "001";
        //    this.Name = "无名氏";
        //    this.Age = 18;
        //    this.Gender = Gender.male;
        //    this.Popularity = 0;
        //}
        public string ID { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// 人气值

        /// </summary>
        private int _popularity = 0;
        public int Popularity
        {
            get { return _popularity; }
            set { _popularity = value; }
        }

        public string SayHi() 
        {
            string message = string.Format("大家好，我是 {0}, 今年 {1}岁，工号是 {2}，我的人气值高达 {3}!",this.Name,this.Age,this.ID,this.Popularity);
            return message;
        }
    }
}
