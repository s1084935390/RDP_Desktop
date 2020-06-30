using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDP_Desktop
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            this.TopLevel = true;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            // 服务器地址
            yc.Server =Main.ip;
            // 远程登录账号
            yc.UserName = Main.username;
            // 远程端口号
            yc.AdvancedSettings7.RDPPort = Main.port;
            // 自动控制屏幕显示尺寸
            //yc.AdvancedSettings9.SmartSizing = true;
            // 启用CredSSP身份验证（有些服务器连接没有反应，需要开启这个）
            yc.AdvancedSettings7.EnableCredSspSupport = true;
            // 远程登录密码
            yc.AdvancedSettings7.ClearTextPassword = Main.password;
            // 颜色位数 8,16,24,32
            yc.ColorDepth = 32;
            // 开启全屏 true|flase
            yc.FullScreen = false;
            // 设置远程桌面宽度为显示器宽度
            yc.DesktopWidth = Screen.PrimaryScreen.Bounds.Width;
            // 设置远程桌面宽度为显示器高度
            yc.DesktopHeight = Screen.PrimaryScreen.Bounds.Height;
            // 远程连接
            yc.Connect();
           
        }

        private void Desktop_Resize(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Width = 890;
                this.Height = 570;
                this.Left = 300;
                this.Top = 300;
            }
            else {
                this.WindowState = FormWindowState.Maximized;
            }

        }
    }
}
