using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RDP_Desktop
{
    public partial class New_Connect : Form
    {
        public New_Connect()
        {
            InitializeComponent();
        }
        //定义委托
        public delegate void Refresh();

        //定义事件
        public event Refresh myRefresh;


        private void button1_Click(object sender, EventArgs e)
        {
            JArray array = Common.Read();    
            Connfig config = new Connfig();
            config.ip = this.ip.Text;
            config.username = this.username.Text;
            config.password = this.password.Text;
            config.port = int.Parse(this.port.Text);
            config.remark = this.remark.Text;
            array.Add(JsonConvert.SerializeObject(config));
            for (int i = 0; i < array.Count; i++)
            {
                JObject jb = JObject.Parse(array[i].ToString());
                if (jb["ip"].ToString() == config.ip.ToString()) {
                    MessageBox.Show("请勿重复添加!");
                    return;
                }
            }

            Common.Write(array);
            myRefresh();
        }
    }
}
