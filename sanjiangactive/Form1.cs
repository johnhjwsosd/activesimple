using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanjiangactive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            bind_dgv("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valuesStr = this.textBox1.Text.Trim();
            bind_dgv(valuesStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string objName = this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            int objID = Convert.ToInt32(this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value);
            Form2 f2 = new Form2(objName,objID);
            f2.ShowDialog();
            bind_dgv("");
        }

        private void bind_dgv(string valuesStr)
        {
            string strWhere = "channel_id = 12 and isStart= 0 ";
            if (!string.IsNullOrEmpty(valuesStr))
            {
                strWhere += " and title like '%" + valuesStr + "%'";
            }
            BLL.dt_article bll = new BLL.dt_article();
            List<Model.dt_article> listModel = new List<Model.dt_article>();
            listModel = bll.GetModelList(strWhere);
            this.dataGridView1.DataSource = listModel;
        }
    }
}
