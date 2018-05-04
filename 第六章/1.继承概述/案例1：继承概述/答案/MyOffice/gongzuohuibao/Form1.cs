using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gongzuohuibao
{
    public partial class Form1 : Form
    {
        //员工集合
        List<Employee> empls = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        //员工信息初始化
        public void Init() 
        {
            //实例化SE对象
            List<Job> list1 = new List<Job>();
            list1.Add(new Job("编码","购物车模块"));
            list1.Add(new Job("测试", "给购物车模块做单元测试"));
            SE ai = new SE(112,25,"Son",Gender.男,100,list1);
            //int id, int age, string name, Gender gender, int popu, List<Job> list

            List<Job> list2 = new List<Job>();
            list2.Add(new Job("设计", "数据库模块"));
            list2.Add(new Job("编写", "详细说明书"));
            SE joe = new SE(114,20,"xxn",Gender.女,100, list2);

            //实例化 PM对象
            PM pm = new PM(113, 35, "tcv", Gender.男, 100,null);
            empls.Add(ai);
            empls.Add(joe);
            empls.Add(pm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in empls)
            {
                if (emp is PM)
                {
                    MessageBox.Show(((PM)emp).DoWork(), "汇报");
                }
                if (emp is SE)
                {
                    MessageBox.Show(((SE)emp).DoWork(), "汇报");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
