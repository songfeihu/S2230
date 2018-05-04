using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    class Student
    {
        //带参构造
        public Student(int age, string name)
        {
            this.Age = age;
            this.Name = name;
            this.StudentNo = "0000";
        }
        //属性
        public string StudentNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //方法 
        public void SayHi()
        {
            Console.WriteLine("大家好,我叫{0},我的学号为:{1},年龄为{2}",this.Name,this.StudentNo,this.Age);
        }
    }
}
