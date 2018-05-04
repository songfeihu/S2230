using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOffice
{
    /// <summary>
    /// 项目经理类
    /// </summary>
    class PM
    {
        /// <summary>
        /// 年龄
        /// </summary>
        private int _age;
        public int Age   
        {
            get { return _age; }
            set 
            {
                if (value >= 30 && value <= 100)
                {
                    _age = value;
                }
                else 
                {
                    _age = 30;
                }
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        private string _name; 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        private Gender _gender; 
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        /// <summary>
        /// 工号
        /// </summary>
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        /// <summary>
        /// 资历
        /// </summary>
        private int _yearOfExperience; 
        public int YearOfExperience
        {
            get { return _yearOfExperience; }
            set { _yearOfExperience = value; }
        }

        /// <summary>
        /// 问好
        /// </summary>
        /// <returns>问好的内容</returns>
        public string SayHi() 
        {
            string message;
            message = string.Format(
                "大家好，我是 {0} ，今年 {1} 岁，项目管理经验 {2}年。",
                this._name, this._age, this._yearOfExperience
            );
            return message;
        }
        public double BasePay { get; set; }//基本工资
        public double PgrPrize { get; set; }//项目奖金
        public double Bonus { get; set; }//分红
    }
}
