namespace RDP_Desktop
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.yc = new AxMSTSCLib.AxMsRdpClient8NotSafeForScripting();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.max = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yc)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yc
            // 
            this.yc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yc.Enabled = true;
            this.yc.Location = new System.Drawing.Point(0, 0);
            this.yc.Name = "yc";
            this.yc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("yc.OcxState")));
            this.yc.Size = new System.Drawing.Size(893, 517);
            this.yc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.min);
            this.flowLayoutPanel1.Controls.Add(this.max);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(893, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(802, 3);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(42, 25);
            this.max.TabIndex = 2;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(850, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(40, 25);
            this.min.TabIndex = 3;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 517);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.yc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.Resize += new System.EventHandler(this.Desktop_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.yc)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient8NotSafeForScripting yc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
    }
}