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
            //this本对象
            //
            this.dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frmparent.recordList.Count.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
