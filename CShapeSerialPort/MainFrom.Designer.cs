namespace CShapeSerialPort
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.btnOpenClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDKH = new System.Windows.Forms.ComboBox();
            this.comboBoxBTL = new System.Windows.Forms.ComboBox();
            this.comboBoxSJW = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxXYW = new System.Windows.Forms.ComboBox();
            this.comboBoxTZW = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBoxHEX = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.chkBoxSendOntime = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.textBoxf = new System.Windows.Forms.TextBox();
            this.textBoxs = new System.Windows.Forms.TextBox();
            this.cajiidbut = new System.Windows.Forms.Button();
            this.famenidbut = new System.Windows.Forms.Button();
            this.senidbut = new System.Windows.Forms.Button();
            this.tcpBox = new System.Windows.Forms.TextBox();
            this.ptBox = new System.Windows.Forms.TextBox();
            this.tbuf = new System.Windows.Forms.Button();
            this.potbut = new System.Windows.Forms.Button();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.ipbut = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.readall = new System.Windows.Forms.Button();
            this.debug_off = new System.Windows.Forms.Button();
            this.debug_on = new System.Windows.Forms.Button();
            this.SetInfo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenClose.Location = new System.Drawing.Point(15, 206);
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(166, 38);
            this.btnOpenClose.TabIndex = 0;
            this.btnOpenClose.Text = "打开串口";
            this.btnOpenClose.UseVisualStyleBackColor = true;
            this.btnOpenClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // comboBoxDKH
            // 
            this.comboBoxDKH.FormattingEnabled = true;
            this.comboBoxDKH.Location = new System.Drawing.Point(60, 12);
            this.comboBoxDKH.Name = "comboBoxDKH";
            this.comboBoxDKH.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDKH.TabIndex = 3;
            // 
            // comboBoxBTL
            // 
            this.comboBoxBTL.FormattingEnabled = true;
            this.comboBoxBTL.Location = new System.Drawing.Point(60, 40);
            this.comboBoxBTL.Name = "comboBoxBTL";
            this.comboBoxBTL.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBTL.TabIndex = 4;
            // 
            // comboBoxSJW
            // 
            this.comboBoxSJW.FormattingEnabled = true;
            this.comboBoxSJW.Location = new System.Drawing.Point(60, 66);
            this.comboBoxSJW.Name = "comboBoxSJW";
            this.comboBoxSJW.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSJW.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据位";
            // 
            // comboBoxXYW
            // 
            this.comboBoxXYW.FormattingEnabled = true;
            this.comboBoxXYW.Location = new System.Drawing.Point(60, 92);
            this.comboBoxXYW.Name = "comboBoxXYW";
            this.comboBoxXYW.Size = new System.Drawing.Size(121, 20);
            this.comboBoxXYW.TabIndex = 7;
            // 
            // comboBoxTZW
            // 
            this.comboBoxTZW.FormattingEnabled = true;
            this.comboBoxTZW.Location = new System.Drawing.Point(60, 118);
            this.comboBoxTZW.Name = "comboBoxTZW";
            this.comboBoxTZW.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTZW.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "停止位";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.checkBoxHEX);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.chkBoxSendOntime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOpenClose);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxDKH);
            this.panel1.Controls.Add(this.comboBoxTZW);
            this.panel1.Controls.Add(this.comboBoxBTL);
            this.panel1.Controls.Add(this.comboBoxXYW);
            this.panel1.Controls.Add(this.comboBoxSJW);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(642, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 522);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(38, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = " ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 38);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "清空收区";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkBoxHEX
            // 
            this.checkBoxHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxHEX.AutoSize = true;
            this.checkBoxHEX.Location = new System.Drawing.Point(15, 494);
            this.checkBoxHEX.Name = "checkBoxHEX";
            this.checkBoxHEX.Size = new System.Drawing.Size(120, 16);
            this.checkBoxHEX.TabIndex = 15;
            this.checkBoxHEX.Text = "以16进制发送接收";
            this.checkBoxHEX.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "ms";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTime.Location = new System.Drawing.Point(93, 455);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(61, 21);
            this.txtTime.TabIndex = 13;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // chkBoxSendOntime
            // 
            this.chkBoxSendOntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBoxSendOntime.AutoSize = true;
            this.chkBoxSendOntime.Location = new System.Drawing.Point(15, 457);
            this.chkBoxSendOntime.Name = "chkBoxSendOntime";
            this.chkBoxSendOntime.Size = new System.Drawing.Size(72, 16);
            this.chkBoxSendOntime.TabIndex = 12;
            this.chkBoxSendOntime.Text = "定时发送";
            this.chkBoxSendOntime.UseVisualStyleBackColor = true;
            this.chkBoxSendOntime.CheckedChanged += new System.EventHandler(this.chkBoxSendOntime_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 522);
            this.panel2.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecv);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 334);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区";
            // 
            // txtRecv
            // 
            this.txtRecv.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtRecv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecv.ForeColor = System.Drawing.Color.Lime;
            this.txtRecv.Location = new System.Drawing.Point(3, 17);
            this.txtRecv.Multiline = true;
            this.txtRecv.Name = "txtRecv";
            this.txtRecv.Size = new System.Drawing.Size(636, 314);
            this.txtRecv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxc);
            this.groupBox1.Controls.Add(this.textBoxf);
            this.groupBox1.Controls.Add(this.textBoxs);
            this.groupBox1.Controls.Add(this.cajiidbut);
            this.groupBox1.Controls.Add(this.famenidbut);
            this.groupBox1.Controls.Add(this.senidbut);
            this.groupBox1.Controls.Add(this.tcpBox);
            this.groupBox1.Controls.Add(this.ptBox);
            this.groupBox1.Controls.Add(this.tbuf);
            this.groupBox1.Controls.Add(this.potbut);
            this.groupBox1.Controls.Add(this.ipBox);
            this.groupBox1.Controls.Add(this.ipbut);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.readall);
            this.groupBox1.Controls.Add(this.debug_off);
            this.groupBox1.Controls.Add(this.debug_on);
            this.groupBox1.Controls.Add(this.SetInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送区";
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(348, 155);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(76, 21);
            this.textBoxc.TabIndex = 16;
            // 
            // textBoxf
            // 
            this.textBoxf.Location = new System.Drawing.Point(348, 118);
            this.textBoxf.Name = "textBoxf";
            this.textBoxf.Size = new System.Drawing.Size(100, 21);
            this.textBoxf.TabIndex = 15;
            // 
            // textBoxs
            // 
            this.textBoxs.Location = new System.Drawing.Point(348, 77);
            this.textBoxs.Name = "textBoxs";
            this.textBoxs.Size = new System.Drawing.Size(76, 21);
            this.textBoxs.TabIndex = 14;
            // 
            // cajiidbut
            // 
            this.cajiidbut.Location = new System.Drawing.Point(211, 153);
            this.cajiidbut.Name = "cajiidbut";
            this.cajiidbut.Size = new System.Drawing.Size(120, 28);
            this.cajiidbut.TabIndex = 13;
            this.cajiidbut.Text = "设置采集器地址";
            this.cajiidbut.UseVisualStyleBackColor = true;
            this.cajiidbut.Click += new System.EventHandler(this.cajiidbut_Click);
            // 
            // famenidbut
            // 
            this.famenidbut.Location = new System.Drawing.Point(211, 114);
            this.famenidbut.Name = "famenidbut";
            this.famenidbut.Size = new System.Drawing.Size(120, 28);
            this.famenidbut.TabIndex = 12;
            this.famenidbut.Text = "设置阀门地址";
            this.famenidbut.UseVisualStyleBackColor = true;
            this.famenidbut.Click += new System.EventHandler(this.famenidbut_Click);
            // 
            // senidbut
            // 
            this.senidbut.Location = new System.Drawing.Point(211, 72);
            this.senidbut.Name = "senidbut";
            this.senidbut.Size = new System.Drawing.Size(120, 28);
            this.senidbut.TabIndex = 11;
            this.senidbut.Text = "设置传感器地址";
            this.senidbut.UseVisualStyleBackColor = true;
            this.senidbut.Click += new System.EventHandler(this.senidbut_Click);
            // 
            // tcpBox
            // 
            this.tcpBox.Location = new System.Drawing.Point(77, 153);
            this.tcpBox.Name = "tcpBox";
            this.tcpBox.Size = new System.Drawing.Size(50, 21);
            this.tcpBox.TabIndex = 10;
            // 
            // ptBox
            // 
            this.ptBox.Location = new System.Drawing.Point(77, 115);
            this.ptBox.Name = "ptBox";
            this.ptBox.Size = new System.Drawing.Size(50, 21);
            this.ptBox.TabIndex = 9;
            // 
            // tbuf
            // 
            this.tbuf.Location = new System.Drawing.Point(12, 148);
            this.tbuf.Name = "tbuf";
            this.tbuf.Size = new System.Drawing.Size(59, 28);
            this.tbuf.TabIndex = 8;
            this.tbuf.Text = "TCP/UDP";
            this.tbuf.UseVisualStyleBackColor = true;
            this.tbuf.Click += new System.EventHandler(this.tbuf_Click);
            // 
            // potbut
            // 
            this.potbut.Location = new System.Drawing.Point(12, 111);
            this.potbut.Name = "potbut";
            this.potbut.Size = new System.Drawing.Size(59, 28);
            this.potbut.TabIndex = 7;
            this.potbut.Text = "端口号";
            this.potbut.UseVisualStyleBackColor = true;
            this.potbut.Click += new System.EventHandler(this.potbut_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(77, 77);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(105, 21);
            this.ipBox.TabIndex = 6;
            // 
            // ipbut
            // 
            this.ipbut.Location = new System.Drawing.Point(12, 72);
            this.ipbut.Name = "ipbut";
            this.ipbut.Size = new System.Drawing.Size(59, 28);
            this.ipbut.TabIndex = 5;
            this.ipbut.Text = "IP地址";
            this.ipbut.UseVisualStyleBackColor = true;
            this.ipbut.Click += new System.EventHandler(this.ipbut_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(527, 32);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(98, 34);
            this.reset.TabIndex = 4;
            this.reset.Text = "设置完成";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // readall
            // 
            this.readall.Location = new System.Drawing.Point(399, 32);
            this.readall.Name = "readall";
            this.readall.Size = new System.Drawing.Size(98, 34);
            this.readall.TabIndex = 3;
            this.readall.Text = "查看所有";
            this.readall.UseVisualStyleBackColor = true;
            this.readall.Click += new System.EventHandler(this.readall_Click);
            // 
            // debug_off
            // 
            this.debug_off.Location = new System.Drawing.Point(270, 32);
            this.debug_off.Name = "debug_off";
            this.debug_off.Size = new System.Drawing.Size(97, 34);
            this.debug_off.TabIndex = 2;
            this.debug_off.Text = "调试关";
            this.debug_off.UseVisualStyleBackColor = true;
            this.debug_off.Click += new System.EventHandler(this.debug_off_Click);
            // 
            // debug_on
            // 
            this.debug_on.Location = new System.Drawing.Point(146, 32);
            this.debug_on.Name = "debug_on";
            this.debug_on.Size = new System.Drawing.Size(90, 34);
            this.debug_on.TabIndex = 1;
            this.debug_on.Text = "调试开";
            this.debug_on.UseVisualStyleBackColor = true;
            this.debug_on.Click += new System.EventHandler(this.debug_on_Click);
            // 
            // SetInfo
            // 
            this.SetInfo.Location = new System.Drawing.Point(29, 32);
            this.SetInfo.Name = "SetInfo";
            this.SetInfo.Size = new System.Drawing.Size(98, 34);
            this.SetInfo.TabIndex = 0;
            this.SetInfo.Text = "配置信息";
            this.SetInfo.UseVisualStyleBackColor = true;
            this.SetInfo.Click += new System.EventHandler(this.SetInfo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsDebugTool(V1_0)";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDKH;
        private System.Windows.Forms.ComboBox comboBoxBTL;
        private System.Windows.Forms.ComboBox comboBoxSJW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxXYW;
        private System.Windows.Forms.ComboBox comboBoxTZW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkBoxSendOntime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxHEX;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRecv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetInfo;
        private System.Windows.Forms.Button debug_off;
        private System.Windows.Forms.Button debug_on;
        private System.Windows.Forms.Button readall;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button ipbut;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox tcpBox;
        private System.Windows.Forms.TextBox ptBox;
        private System.Windows.Forms.Button tbuf;
        private System.Windows.Forms.Button potbut;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.TextBox textBoxf;
        private System.Windows.Forms.TextBox textBoxs;
        private System.Windows.Forms.Button cajiidbut;
        private System.Windows.Forms.Button famenidbut;
        private System.Windows.Forms.Button senidbut;

    }
}

