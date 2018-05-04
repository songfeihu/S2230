using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxDemo
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void frmComboBox_Load(object sender, EventArgs e)
        {
            //员工对象
            SE se1 = new SE();
            se1.ID = "111";
            se1.Name = "张三丰";

            SE se2 = new SE();
            se2.ID = "112";
            se2.Name = "李四";

            //两个泛型类对象.ComboBox项
            ComboBoxItem<SE> item1 = new ComboBoxItem<SE>();
            item1.ItemText = se1.Name;
            item1.ItemValue = se1;

            ComboBoxItem<SE> item2 = new ComboBoxItem<SE>();
            item2.ItemText = se2.Name;
            item2.ItemValue = se2;

            List<ComboBoxItem<SE>> items = new List<ComboBoxItem<SE>>();
            items.Add(item1);
            items.Add(item2);

            cboType.DisplayMember = "ItemText";//显示的值
            cboType.ValueMember = "ItemValue";//实际的值
            cboType.DataSource = items;//数据源

        }
        //下拉列表改变的事件
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SE se =(SE) cboType.SelectedValue;//得到实际的值
            MessageBox.Show("工号为:"+se.ID+",姓名为:"+se.Name);
        }
    }
}
