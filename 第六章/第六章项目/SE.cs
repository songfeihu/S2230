using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章项目
{
    public class SE:show
    {
        public SE(string id, string name, int age, Gender gender, int popul) 
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
            this.gender = gender;
            this.Popul = popul;
        }
        public SE() { }
        private int _popul;
        public int Popul 
        {

            get { return _popul; }
            set { _popul = value; }
        }
        public string SayHi() 
        {
            string message;
            message = string.Format("大家好，我是{0},今年{1}岁，工号是{2}年，我的人气值{3}。", this.Name, this.Age,this.ID, this.Popul);
            return message;
        }

    }
}
