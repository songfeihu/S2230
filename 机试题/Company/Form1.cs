using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Company> com = new List<Company>();
        public Dictionary<string, Company> dic = new Dictionary<string, Company>();
        public void Initial()
        {
            Company ib = new Company();
            ib.CompanyName = "IBM";
            ib.Country = "美国";
            ib.Product = "高端服务器";
            Company ic = new Company();
            ic.CompanyName = "Google";
            ic.Country = "美国";
            ic.Product = "搜索引擎";
            Company id = new Company();
            id.CompanyName = "Oracle";
            id.Country = "美国";
            id.Product = "数据库软件";
            com.Add(ib);
            com.Add(ic);
            com.Add(id);
            dic.Add(ib.CompanyName,ib);
            dic.Add(ic.CompanyName, ic);
            dic.Add(id.CompanyName, id);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Initial();
            NewMethod();
        }

        private void NewMethod()
        {
            ListViewItem item = null;
            listView1.Items.Clear();
            foreach (Company cp in com)
            {
                item = new ListViewItem();
                item.Text = cp.CompanyName;
                item.SubItems.Add(cp.Country);
                item.SubItems.Add(cp.Product);
                listView1.Items.Add(item);
            }
            //foreach (Company cp in dic.Values)
            //{
            //    item = new ListViewItem();
            //    item.Text = cp.CompanyName;
            //    item.SubItems.Add(cp.Country);
            //    item.SubItems.Add(cp.Product);
            //    listView1.Items.Add(item);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(com.Count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listView1.SelectedItems[0].Index;
            com.RemoveAt(i);
            NewMethod();
            //string name = listView1.SelectedItems[0].Text;
            //dic.Remove(name);
            //NewMethod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
    }
}
