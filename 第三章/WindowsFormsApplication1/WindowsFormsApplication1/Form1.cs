using System;
using System.Collections;
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
        }


        //公共列表<SE>工程师=新列表<SE>()；
      public  List<SE> engineers = new List<SE>();
        //公共<string,Record>列表显示<string,Record>()；
     public Dictionary<string, Record> recordList = new Dictionary<string, Record>();
  
        public void initial()
        {
            //初始化信息
            SE wang = new SE();
            wang.Name = "王小毛";
            wang.Age = 19;
            wang.ID = "20090101";
            wang.gender = Gender.男;
          
            SE joke = new SE();
            joke.Name = "周新宇";
            joke.Age = 19;
            joke.ID = "20090102";
            joke.gender = Gender.女;
            //添加元素
            engineers.Add(wang);
            engineers.Add(joke);
        }
        //泛型添加
        //公共void BindGrid(<SE>列出)
        public void BindGrid(List<SE> list)
        {
            //dataGridView1。 数据源=新BindingList<SE>(列表)；
            //添加显示数据  
            dataGridView1.DataSource = new BindingList<SE>(list);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //引用方法
            initial();
            BindGrid(engineers);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            //<SE>工程师=新列表List<SE>()；
            List<SE> engineer = new List<SE>();
            //foreach(SE项目工程师)
            foreach(SE item in engineers)
            {   

                    //判断数据是否存在
                if(item.ID.IndexOf(textBox1.Text.Trim())!=-1)
                {
                    engineer.Add(item);//导入数据
                }
            }
            BindGrid(engineer);//泛型添加
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.frmparent = this;
            frm.ShowDialog();//模式化窗体 显示
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {       
            //提示 是否删除
            DialogResult i = MessageBox.Show("是否删除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (i == DialogResult.Yes)
            {
                //字符串id=dataGridView1. 隐藏所选择[0]  ToString()；
            string id = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            foreach (SE item in engineers)
            {
                if (item.ID==id)
                {
                    engineers.Remove(item);// 删除
                    break;
                }
            }
            BindGrid(engineers);
            }
        }
        //签到操作
        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            string workNo = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //验证 确保有选中的行
            foreach (string id in recordList.Keys)
            {
                if (id == workNo)
                {
                    MessageBox.Show("今天已经签到过了");
                    return;
                }
            }
            //执行签到
            Record record = new Record();
            record.ID = workNo;
            record.Name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            record.SignInTime = DateTime.Now; //获取系统的当前时间
            recordList.Add(record.ID, record);//添加到签到记录中
            MessageBox.Show("签到成功");
       
        }
        //签退操作
        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            bool isOut = false; //标识是否已经签到过


     
            foreach(string key in recordList.Keys)
            {
                if(key==ID)
                {
                    //执行签到，设置签退的时间
                    this.recordList[key].SignOutTime = DateTime.Now;
                    MessageBox.Show("签退成功");
                    isOut = true;
                    break;
                }
            }
            if(isOut==false) //不成立
            {
                MessageBox.Show("尚未签到");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
     
            Form3 frm = new Form3();
            frm.name = "共有" + recordList .Count+ "条打卡记录"; //窗体传值
            frm.frmparent = this;
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
