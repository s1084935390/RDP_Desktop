using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;        
using System.IO;

namespace RDP_Desktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Get_Load();
        }


        public DataTable Create() 
        {
            DataTable dt = new DataTable();
            DataColumn ip = new DataColumn("ip",typeof(string));
            DataColumn username = new DataColumn("username", typeof(string));
            DataColumn password = new DataColumn("password", typeof(string));
            DataColumn port = new DataColumn("port", typeof(int));
            DataColumn remark = new DataColumn("remark", typeof(string));
            dt.Columns.Add(ip);
            dt.Columns.Add(username);
            dt.Columns.Add(password);
            dt.Columns.Add(port);
            dt.Columns.Add(remark);
            return dt;
        }

        public void Get_Load()
        {
            JArray array = Common.Read();
            DataTable dt = Create();
            for (int i = 0; i < array.Count; i++)
            {
                JObject jb = JObject.Parse(array[i].ToString());
                DataRow row = dt.NewRow();
                row["ip"] = jb["ip"].ToString();
                row["username"] = jb["username"].ToString();
                row["password"] = jb["password"].ToString();
                row["port"] = jb["port"].ToString();
                row["remark"] = jb["remark"].ToString();
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
        }

        private void 新建连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Connect conn = new New_Connect();
            conn.myRefresh += new New_Connect.Refresh(Get_Load); //事务 刷新
            conn.ShowDialog();
        }

        public static string ip, username, password, remark;

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {                           
            JArray array = Common.Read();     
            string ip = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["ip"].ToString() == ip)
                {
                    dt.Rows.RemoveAt(i);
                    array.RemoveAt(i);
                }
            }
            Common.Write(array);
            Get_Load();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("row");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            ip = dt.Rows[e.RowIndex]["ip"].ToString();
            username = dt.Rows[e.RowIndex]["username"].ToString();
            password = dt.Rows[e.RowIndex]["password"].ToString();
            port = int.Parse(dt.Rows[e.RowIndex]["port"].ToString());
            remark = dt.Rows[e.RowIndex]["remark"].ToString();
            Desktop desktop = new Desktop();
            desktop.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        public static int port;
       
    }
}
