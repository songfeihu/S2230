using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gongzuohuibao
{
    public  class Job 
    {
        //工作名称
        public string Name { get; set; }
        //描述
        public string Miaoshu { get; set; }
        //构造函数
        public Job(string name, string miaoshu) 
        {
            this.Name = name;
            this.Miaoshu = miaoshu;
        }
    }
}
