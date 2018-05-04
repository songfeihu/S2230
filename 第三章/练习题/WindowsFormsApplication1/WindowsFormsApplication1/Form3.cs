using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //定义Form3的公共属性
      public  string name = "";

      //定义Form1 公用的属性
      public Form1 frmparent { get; set; } 


        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = name;//绑定数据
            NewMethod();//调用方法
        }

        private void NewMethod()
        {   
            //创建数据源的组件
            // 用BindingSource可以提高程序的性能和安全性
            BindingSource bs = new BindingSource();
            //把集合元素添加到数据原中
            bs.DataSource = frmparent.recordList.Values;
            //this  本对象
            //展示数据源中的数据
            this.dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
               //消息框.显示(frmparent。列表显示。 计数。 ToString())；
                //消息框展示集合中元素的数量
            MessageBox.Show(frmparent.recordList.Count.ToString());
        }









        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
