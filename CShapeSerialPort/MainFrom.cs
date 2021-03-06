﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace CShapeSerialPort
{
    public partial class MainFrom : Form
    {
        private SerialPortUtil comPort = new SerialPortUtil();
        private System.Timers.Timer timer = new System.Timers.Timer();

        public MainFrom()
        {
            InitializeComponent();
        }

        private void COMOpen()
        {
            if (!comPort.IsOpen)
            {
                try
                {
                    comPort.OpenPort();
                    btnOpenClose.Text = "关闭串口";
                    label7.Text = comPort.PortName + "已打开";
                    label7.ForeColor = System.Drawing.Color.Green;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!comPort.IsOpen)
                {
                    btnOpenClose.Text = "打开串口";
                    label7.Text = " ";
                }
            }
        }

        private void COMSend()
        {
            try
            {
                if (checkBoxHEX.Checked)
                {
                    comPort.WriteData("");
                }
                else
                {
                    comPort.WriteData("");
                }
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show("发送错误：" + ex.Message);
            }

        }
        private void COMClose()
        {
            if (comPort.IsOpen)
            {
                try
                {
                    //comPort.DiscardBuffer();
                    //timer1.Enabled = false;
                    //chkBoxSendOntime.Checked = false;
                    comPort.ClosePort();
                    btnOpenClose.Text = "打开串口";
                    label7.Text = comPort.PortName + "已关闭";
                    label7.ForeColor = System.Drawing.Color.Red;
                }
                catch (System.Exception ex)
                {
                    btnOpenClose.Text = "关闭串口";
                    label7.Text = " ";
                    MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            //comboBox设置数据
            
            SerialPortUtil.SetPortNameValues(comboBoxDKH);
            if (comboBoxDKH.Items.Count == 0)
            {
                MessageBox.Show("未扫描到该计算机的COM口，请添加硬件后重新打开程序！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            SerialPortUtil.SetBauRateValues(comboBoxBTL);
            SerialPortUtil.SetDataBitsValues(comboBoxSJW);
            SerialPortUtil.SetParityValues(comboBoxXYW);
            SerialPortUtil.SetStopBitValues(comboBoxTZW);

            
            
            
            comboBoxDKH.SelectedIndex = 0;
            comboBoxBTL.SelectedIndex = 8;
            comboBoxSJW.SelectedIndex = 3;
            comboBoxXYW.SelectedIndex = 0;
            comboBoxTZW.SelectedIndex = 1;
            comboBoxDKH.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.PortName = comboBoxDKH.SelectedItem.ToString(); COMOpen(); };
            comboBoxBTL.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.BaudRate = (SerialPortBaudRates)Convert.ToInt32(comboBoxBTL.SelectedItem); COMOpen(); };
            comboBoxSJW.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.DataBits = (SerialPortDatabits)Convert.ToInt32(comboBoxSJW.SelectedItem.ToString()); COMOpen(); };
            comboBoxXYW.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.Parity = (Parity)(comboBoxXYW.SelectedIndex); COMOpen(); };
            comboBoxTZW.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.StopBits = (StopBits)(comboBoxTZW.SelectedIndex); COMOpen(); };
            comPort.DataReceived += new DataReceivedEventHandler(comPort_DataReceived);
            comPort.Error += new SerialErrorReceivedEventHandler(comPort_Error);;
            
            comPort.PortName = comboBoxDKH.SelectedItem.ToString();
            comPort.BaudRate = (SerialPortBaudRates)Convert.ToInt32(comboBoxBTL.SelectedItem);
            comPort.DataBits = (SerialPortDatabits)Convert.ToInt32(comboBoxSJW.SelectedItem.ToString());
            comPort.Parity = (Parity)(comboBoxXYW.SelectedIndex);
            comPort.StopBits = (StopBits)(comboBoxTZW.SelectedIndex);

            chkBoxSendOntime.Checked = false;
            checkBoxHEX.Checked = false;
            txtTime.Text = "200";
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }

        void comPort_Error(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        void comPort_DataReceived(DataReceivedEventArgs e)
        {
           this.txtRecv.BeginInvoke(
               new MethodInvoker(()=>{
                   if (checkBoxHEX.Checked)
                   {
                       this.txtRecv.AppendText(SerialPortUtil.ByteToHex(e.DataRecv));//输出到主窗口文本控件   
                   } 
                   else
                   {
                       StreamWriter fs3 = new StreamWriter(Application.StartupPath + "\\log.txt", true);
                       this.txtRecv.AppendText(System.Text.Encoding.Default.GetString(e.DataRecv));//输出到主窗口文本控件 
                       fs3.Write(System.Text.Encoding.Default.GetString(e.DataRecv));
                       fs3.Close();
                   }
               }
               )
            ); 
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                COMClose();
            }
            else
            {
                COMOpen();
            }
        }

        private void btnSendOnce_Click(object sender, EventArgs e)
        {
            COMSend();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkBoxSendOntime.Checked)
            {
                if (txtTime.Text=="")
                {
                    timer1.Enabled = false;
                    MessageBox.Show("请输入时间！");
                } 
                else
                {
                    if (comPort.IsOpen)
                    {
                        COMSend();
                    }
                }
            }
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //throw new NotImplementedException();
            if (chkBoxSendOntime.Checked)
            {
                if (txtTime.Text == "")
                {
                    timer1.Enabled = false;
                    MessageBox.Show("请输入时间！");
                }
                else
                {
                    if (comPort.IsOpen)
                    {
                        COMSend();
                    }
                }
            }
        }

        private void chkBoxSendOntime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSendOntime.Checked)
            {
                if (txtTime.Text == "")
                {
                    MessageBox.Show("请输入时间！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    chkBoxSendOntime.Checked = false;
                }
                else
                {
                    try
                    {
                        //timer1.Interval = Convert.ToInt32(txtTime.Text);
                        //timer1.Enabled = true;
                        timer.Interval = Convert.ToInt32(txtTime.Text);
                        timer.Enabled = true;
                    }
                    catch (System.Exception ex)
                    {
                        //timer1.Enabled = false;
                        timer.Enabled = false;
                        MessageBox.Show("时间输入错误：" + ex.Message);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecv.Text = "";
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
//                 timer1.Interval = Convert.ToInt32(txtTime.Text);
//                 timer1.Enabled = true;
                timer.Interval = Convert.ToInt32(txtTime.Text);
                timer.Enabled = true;
            }
            catch (System.Exception ex)
            {
                //timer1.Enabled = false;
                timer.Enabled = false;
                MessageBox.Show("时间输入错误：" + ex.Message);
            }
        }

        private void SetInfo_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$$setinfo\r\n");
        }

        private void debug_on_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$$debug 2\r\n");
        }

        private void debug_off_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$$debug 0\r\n");
        }

        private void readall_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$info-all\r\n");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$reset\r\n");
        }

        private void ipbut_Click(object sender, EventArgs e)
        {
            if (ipBox.Text == "")
            {

            }
            else
            {
                comPort.WriteData("$setip " + ipBox.Text+"\r\n");
            }
           
        }

        private void potbut_Click(object sender, EventArgs e)
        {
            if (ptBox.Text == "")
            {

            }
            else
            {
                comPort.WriteData("$setpot " + ptBox.Text + "\r\n");
            }
        }

        private void tbuf_Click(object sender, EventArgs e)
        {
            if (tcpBox.Text == "")
            {

            }
            else
            {
                if (tcpBox.Text == "tcp" || tcpBox.Text == "TCP")comPort.WriteData("$tcp 1\r\n");
                if (tcpBox.Text == "udp" || tcpBox.Text == "UDP") comPort.WriteData("$tcp 0\r\n");
            }
        }

        private void senidbut_Click(object sender, EventArgs e)
        {
            if (textBoxs.Text == "")
            {
                MessageBox.Show("非法的地址!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBoxs.Text.Length == 6)
                {
                    comPort.WriteData("$setsxsenid " + textBoxs.Text + "\r\n");
                }
                else
                {
                    MessageBox.Show("非法的地址!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void famenidbut_Click(object sender, EventArgs e)
        {
            if (textBoxf.Text == "")
            {
                MessageBox.Show("非法的地址!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBoxf.Text.Length == 8)
                {
                    comPort.WriteData("$$setvalveid " + textBoxf.Text + "\r\n");
                }
                else
                {
                    MessageBox.Show("非法的地址!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cajiidbut_Click(object sender, EventArgs e)
        {
            if (textBoxc.Text == "")
            {
                MessageBox.Show("非法的地址!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBoxc.Text.Length == 6)
                {
                    comPort.WriteData("$$setcenterid " + textBoxc.Text + "\r\n");
                }
                else
                {
                    MessageBox.Show("非法的地址!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void buttonjiange_Click(object sender, EventArgs e)
        {
            if (textBoxj.Text == "")
            {
                MessageBox.Show("非法的采集时间!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comPort.WriteData("$sethnd " + textBoxj.Text + "\r\n");
            }
            
        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonshijian_Click(object sender, EventArgs e)
        {
            if (textBoxn.Text.Length == 2)
            {
                textBoxn.Text = "20" + textBoxn.Text;
            }
            comPort.WriteData("$settime " + textBoxn.Text + "-" + textBoxy.Text + "-" + textBoxr.Text + "- " + textBoxshi.Text + ":" + textBoxfen.Text + ":" + textBoxmiao.Text+"\r\n");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonmoshi_Click(object sender, EventArgs e)
        {
            if (radioButtonc.Checked)
            {
                comPort.WriteData("$setworkmod 1\r\n");
            }
            if (radioButtonx.Checked)
            {
                comPort.WriteData("$setworkmod 0\r\n");
            }
        }

        private void button_clearsensor_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$clearsxsenid 0\r\n");
        }

        private void button_famenjiedong_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$seticealloff\r\n");
        }

        private void button_famenchongdian_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$setchageall\r\n");
        }

        private void button_famenkai_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$setvalvallon\r\n");
        }

        private void button_famenguan_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$setvalvalloff\r\n");
        }

        private void button_checksen_Click(object sender, EventArgs e)
        {
            comPort.WriteData("$checksensordata\r\n");
        }

        private void button_SN_Click(object sender, EventArgs e)
        {
            if (textBox_sn.Text == "")
            {
                MessageBox.Show("非法的SN!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comPort.WriteData("$setsn " + textBox_sn.Text + "\r\n");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

       
    }
}
