using WindowsFormsApplication1;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //选择运算符号的下拉列表变量
            this.comboBox1.SelectedIndex = 0;
        }
        //单击 计算  按钮的相应
        private void button1_Click(object sender, EventArgs e)
        {

            //验证
            if (string.IsNullOrEmpty(this.textBox1.Text.Trim()))
            {
                MessageBox.Show("操作不能为空");
                this.textBox1.Focus();
                return;
            }
            try
            {
                Operation opr = new Operation();
                switch (this.comboBox1.SelectedItem.ToString().Trim())
                {
                    case "+":
                        {
                            opr = new Operation();
                            break;
                        }
                }
                //计算参加计算器的数据
                opr.NumberA = double.Parse(this.textBox1.Text.Trim());
                opr.NumberB = double.Parse(this.textBox2.Text.Trim());
                //计算
                this.label3.Text = opr.GetResult().ToString();
                this.label2.Visible = true;
                this.label3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误！" + ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
