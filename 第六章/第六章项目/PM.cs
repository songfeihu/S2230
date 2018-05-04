using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章项目
{

    //Pm类 ：项目经理
    public  class PM: show
    {

        //带参构造函数，仍然可以调用取到show类中的属性
        public PM(string id, string name, int age, Gender gender, int year) 
        {   
            this.Name = name;
            this.ID = id;
            this.Age = age;
            this.gender = gender;
            this.Year = year;
        }
        public PM() { }
        //项目经验
        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        //返回值：内容
        public string SayHi() 
        {
            string message;
            message = string.Format("大家好，我是{0},今年{1}岁，项目经验{2}年。",this.Name,this.Age,this.Year);
            return message;
        }
    }
}
