using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComboBoxDemo
{  
    /// <summary>
    /// 员工类
    /// </summary>
    public class SE
    {
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
