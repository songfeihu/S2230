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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //定义Form1 公用的属性
        public Form1 frmparent{ get; set; }
        private void button1_Click(object sender, EventArgs e)
        {   
              //初始化信息
            SE pr = new SE();
            //窗体传值
            pr.ID = textBox1.Text;
            pr.Name = textBox3.Text;
            pr.Age = Convert.ToInt32(textBox2.Text);
            //判断男女
            if (comboBox1.SelectedValue.ToString() == "男")
            {
                pr.gender = Gender.男;
            }
            else
            {
                pr.gender = Gender.女;
            }
            foreach (SE item in frmparent.engineers)
            {
                if (item.ID == pr.ID)
                {
                    MessageBox.Show("此工号已存在");
                    return;
                }
            }
            //绑定数据源
            frmparent.engineers.Add(pr);
            this.Close();
            this.frmparent.BindGrid(frmparent.engineers);
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            Com();//调用Com方法
        }

        private void Com()
        {

            //初始化
            ComboBoxItem<Gender> itemmale = new ComboBoxItem<Gender>();
            itemmale.ItemText = Gender.男.ToString();
            itemmale.ItemValue = Gender.男;


            ComboBoxItem<Gender> itemfemale = new ComboBoxItem<Gender>();
            itemfemale.ItemText = Gender.女.ToString();
            itemfemale.ItemValue = Gender.女;

            //声明集合  
            List<ComboBoxItem<Gender>> item = new List<ComboBoxItem<Gender>>();

            //添加集合中的数据
            item.Add(itemmale);
            item.Add(itemfemale);



            //绑定信息
            comboBox1.DataSource = item;
            comboBox1.DisplayMember = "ItemText";
            comboBox1.ValueMember = "ItemValue";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
