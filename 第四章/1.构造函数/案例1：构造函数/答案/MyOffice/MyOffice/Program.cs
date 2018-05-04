﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyOffice
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu = new Student(20, "张小明");
            stu.SayHi();

            //用户没有定义构造函数,系统分默认分配无参的构造函数,一旦用户手动添加构造函数,系统就不分配无参构造函数
            SE se = new SE();
            //Console.WriteLine(se.SayHi()); 
            //se.ID = "111";
            //se.Name = "张三";
            //se.Age = 20;
            //se.Gender = Gender.female;
            //se.Popularity = 99;
            //Console.WriteLine(se.SayHi()); 

            //调用带参的构造函数:参数的个数\类型\顺序要一致
            SE se2 = new SE("112", "李四", 22, Gender.male, 10);

            Console.ReadLine();
        }
    }
}
