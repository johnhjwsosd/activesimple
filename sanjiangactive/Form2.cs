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
    public partial class Form2 : Form
    {
        private string _Card = string.Empty;
        private string activeName;
        private int activeID;
        private int sourceActive;
        List<Model.dt_active_user> listActive_user;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string objName,int objID)
        {
            activeID=objID;
            activeName = objName;
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            bind_lbl(activeName);
            getData();
            bind_dgv();
            get_active_source();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.dt_article bll_a = new BLL.dt_article();
            Model.dt_article model_a = bll_a.GetModel(activeID);
            model_a.isStart = 1;
            bll_a.Update(model_a);
            List<Model.dt_active_user> tempList= listActive_user.Where(x => x.joinDate != null).ToList();
            BLL.dt_users bll_u = new BLL.dt_users();
            foreach (var item in tempList)
            {
                Model.dt_users user = bll_u.GetModel(item.UserId);
                user.point += sourceActive;
                bll_u.Update(user);
            }
            this.Close();
        }

        private void get_active_source() {
            BLL.dt_article_attribute_value bll = new BLL.dt_article_attribute_value();
            Model.dt_article_attribute_value model = bll.GetModel(activeID);
            sourceActive = model.activity_integral == null ? 0 : (int)model.activity_integral;
        }

        private void getData(){
            BLL.dt_active_user bll = new BLL.dt_active_user();
            List<Model.dt_active_user> modeList = new List<Model.dt_active_user>();
            string strWhere = "a.activityId = " + activeID;
            listActive_user = bll.GetModelListExt(strWhere);
        }

        private void bind_dgv() {
            this.dataGridView1.DataSource = listActive_user;    
        }

        private void bind_lbl(string ObjName){
            this.label1.Text = ObjName;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
                char c = Convert.ToChar(e.KeyValue);
                switch ((int)c)
                {
                    case 13:
                        ReadCardEnd();
                        break;
                    default:
                        if (_Card == null)
                            _Card = string.Empty;
                        _Card += c;
                        break;
                }
        }
        private void ReadCardEnd()
        {
            Model.dt_active_user ac_usr = listActive_user.Where(x => x.address == _Card).SingleOrDefault();
            if (ac_usr != null)
            {
                ac_usr.joinDate = DateTime.Now;
                BLL.dt_active_user bll = new BLL.dt_active_user();
                bll.Update(ac_usr);
                getData();
                bind_dgv();
            }

            _Card = string.Empty;
        }
    }
}
