namespace ClientDemo
{
    partial class frmVideo
    {
        
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txPort = new System.Windows.Forms.TextBox();
            this.txUser = new System.Windows.Forms.TextBox();
            this.txPswd = new System.Windows.Forms.TextBox();
            this.txStream = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txChannelNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txBufferTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCloseTream = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNoDecoderCapture = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.button_NVR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(125, 15);
            this.txtIP.Margin = new System.Windows.Forms.Padding(8);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(244, 42);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.1.4";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(18, 469);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(165, 58);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "连接视频";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(443, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 208);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 536);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "抓取单张图片(需解码)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txPort
            // 
            this.txPort.Location = new System.Drawing.Point(125, 79);
            this.txPort.Margin = new System.Windows.Forms.Padding(8);
            this.txPort.Name = "txPort";
            this.txPort.Size = new System.Drawing.Size(244, 42);
            this.txPort.TabIndex = 0;
            this.txPort.Text = "6002";
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(125, 145);
            this.txUser.Margin = new System.Windows.Forms.Padding(8);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(244, 42);
            this.txUser.TabIndex = 0;
            this.txUser.Text = "system";
            // 
            // txPswd
            // 
            this.txPswd.Location = new System.Drawing.Point(125, 209);
            this.txPswd.Margin = new System.Windows.Forms.Padding(8);
            this.txPswd.Name = "txPswd";
            this.txPswd.Size = new System.Drawing.Size(244, 42);
            this.txPswd.TabIndex = 0;
            this.txPswd.Text = "system";
            // 
            // txStream
            // 
            this.txStream.Location = new System.Drawing.Point(125, 275);
            this.txStream.Margin = new System.Windows.Forms.Padding(8);
            this.txStream.Name = "txStream";
            this.txStream.Size = new System.Drawing.Size(244, 42);
            this.txStream.TabIndex = 0;
            this.txStream.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "地 址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "端 口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "用 户";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "密 码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "码 流";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "通 道";
            // 
            // txChannelNum
            // 
            this.txChannelNum.Location = new System.Drawing.Point(125, 339);
            this.txChannelNum.Margin = new System.Windows.Forms.Padding(8);
            this.txChannelNum.Name = "txChannelNum";
            this.txChannelNum.Size = new System.Drawing.Size(244, 42);
            this.txChannelNum.TabIndex = 0;
            this.txChannelNum.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 412);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "缓 冲";
            // 
            // txBufferTime
            // 
            this.txBufferTime.Location = new System.Drawing.Point(125, 405);
            this.txBufferTime.Margin = new System.Windows.Forms.Padding(8);
            this.txBufferTime.Name = "txBufferTime";
            this.txBufferTime.Size = new System.Drawing.Size(134, 42);
            this.txBufferTime.TabIndex = 0;
            this.txBufferTime.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(25, 1121);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(358, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "不解码抓图需要先\"登录\",";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(25, 1166);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(343, 30);
            this.label9.TabIndex = 5;
            this.label9.Text = "并将要抓图的码流设置成";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(28, 1209);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 30);
            this.label10.TabIndex = 5;
            this.label10.Text = "MJPEG格式";
            this.label10.Visible = false;
            // 
            // btnCloseTream
            // 
            this.btnCloseTream.Location = new System.Drawing.Point(195, 469);
            this.btnCloseTream.Margin = new System.Windows.Forms.Padding(8);
            this.btnCloseTream.Name = "btnCloseTream";
            this.btnCloseTream.Size = new System.Drawing.Size(185, 58);
            this.btnCloseTream.TabIndex = 6;
            this.btnCloseTream.Text = "断开视频";
            this.btnCloseTream.UseVisualStyleBackColor = true;
            this.btnCloseTream.Click += new System.EventHandler(this.btnCloseTream_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 402);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(18, 761);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 58);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(195, 761);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(185, 58);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "注 销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNoDecoderCapture
            // 
            this.btnNoDecoderCapture.Enabled = false;
            this.btnNoDecoderCapture.Location = new System.Drawing.Point(18, 1056);
            this.btnNoDecoderCapture.Margin = new System.Windows.Forms.Padding(8);
            this.btnNoDecoderCapture.Name = "btnNoDecoderCapture";
            this.btnNoDecoderCapture.Size = new System.Drawing.Size(362, 58);
            this.btnNoDecoderCapture.TabIndex = 10;
            this.btnNoDecoderCapture.Text = "抓图（不解码）";
            this.btnNoDecoderCapture.UseVisualStyleBackColor = true;
            this.btnNoDecoderCapture.Visible = false;
            this.btnNoDecoderCapture.Click += new System.EventHandler(this.btnNoDecoderCapture_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(20, 1009);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 30);
            this.label11.TabIndex = 5;
            this.label11.Text = "彩转黑模式";
            this.label11.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(195, 936);
            this.button3.Margin = new System.Windows.Forms.Padding(8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 58);
            this.button3.TabIndex = 11;
            this.button3.Text = "设置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "自动",
            "彩色",
            "黑白"});
            this.comboBox1.Location = new System.Drawing.Point(190, 1001);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 38);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(18, 936);
            this.button4.Margin = new System.Windows.Forms.Padding(8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 58);
            this.button4.TabIndex = 13;
            this.button4.Text = "获取";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(40, 830);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 30);
            this.label12.TabIndex = 14;
            this.label12.Text = "下面的操作需要先登录";
            this.label12.Visible = false;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(18, 868);
            this.button5.Margin = new System.Windows.Forms.Padding(8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 58);
            this.button5.TabIndex = 15;
            this.button5.Text = "接收报警";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(205, 882);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 30);
            this.label13.TabIndex = 16;
            this.label13.Text = "没有报警";
            this.label13.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 606);
            this.button6.Margin = new System.Windows.Forms.Padding(8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 58);
            this.button6.TabIndex = 4;
            this.button6.Text = "连接多组";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(199, 606);
            this.button7.Margin = new System.Windows.Forms.Padding(8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 58);
            this.button7.TabIndex = 4;
            this.button7.Text = "保存多张";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(729, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 208);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(1011, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 208);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(1293, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 208);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(1575, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 208);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(1857, 8);
            this.panel6.Margin = new System.Windows.Forms.Padding(8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(252, 208);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(2139, 8);
            this.panel7.Margin = new System.Windows.Forms.Padding(8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(252, 208);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(2421, 8);
            this.panel8.Margin = new System.Windows.Forms.Padding(8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(252, 208);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(2703, 17);
            this.panel9.Margin = new System.Windows.Forms.Padding(8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(252, 208);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(392, 232);
            this.panel10.Margin = new System.Windows.Forms.Padding(8);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(256, 208);
            this.panel10.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(659, 232);
            this.panel11.Margin = new System.Windows.Forms.Padding(8);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(252, 208);
            this.panel11.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(922, 232);
            this.panel12.Margin = new System.Windows.Forms.Padding(8);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(252, 208);
            this.panel12.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Location = new System.Drawing.Point(1185, 234);
            this.panel13.Margin = new System.Windows.Forms.Padding(8);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(252, 208);
            this.panel13.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(1448, 232);
            this.panel14.Margin = new System.Windows.Forms.Padding(8);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(252, 208);
            this.panel14.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Location = new System.Drawing.Point(1711, 232);
            this.panel15.Margin = new System.Windows.Forms.Padding(8);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(252, 208);
            this.panel15.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Location = new System.Drawing.Point(1974, 234);
            this.panel16.Margin = new System.Windows.Forms.Padding(8);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(252, 208);
            this.panel16.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Location = new System.Drawing.Point(2237, 232);
            this.panel17.Margin = new System.Windows.Forms.Padding(8);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(252, 208);
            this.panel17.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Location = new System.Drawing.Point(2500, 234);
            this.panel18.Margin = new System.Windows.Forms.Padding(8);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(252, 208);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Location = new System.Drawing.Point(2763, 232);
            this.panel19.Margin = new System.Windows.Forms.Padding(8);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(252, 208);
            this.panel19.TabIndex = 2;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Location = new System.Drawing.Point(443, 456);
            this.panel20.Margin = new System.Windows.Forms.Padding(8);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(256, 208);
            this.panel20.TabIndex = 2;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Location = new System.Drawing.Point(392, 680);
            this.panel21.Margin = new System.Windows.Forms.Padding(8);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(256, 208);
            this.panel21.TabIndex = 2;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Location = new System.Drawing.Point(729, 456);
            this.panel22.Margin = new System.Windows.Forms.Padding(8);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(252, 208);
            this.panel22.TabIndex = 2;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Location = new System.Drawing.Point(659, 680);
            this.panel23.Margin = new System.Windows.Forms.Padding(8);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(252, 208);
            this.panel23.TabIndex = 2;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.White;
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel24.Location = new System.Drawing.Point(1011, 456);
            this.panel24.Margin = new System.Windows.Forms.Padding(8);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(252, 208);
            this.panel24.TabIndex = 2;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.White;
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Location = new System.Drawing.Point(922, 680);
            this.panel25.Margin = new System.Windows.Forms.Padding(8);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(252, 208);
            this.panel25.TabIndex = 2;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.White;
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel26.Location = new System.Drawing.Point(1293, 456);
            this.panel26.Margin = new System.Windows.Forms.Padding(8);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(252, 208);
            this.panel26.TabIndex = 2;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.White;
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Location = new System.Drawing.Point(1185, 682);
            this.panel27.Margin = new System.Windows.Forms.Padding(8);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(252, 208);
            this.panel27.TabIndex = 2;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.White;
            this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel28.Location = new System.Drawing.Point(1575, 456);
            this.panel28.Margin = new System.Windows.Forms.Padding(8);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(252, 208);
            this.panel28.TabIndex = 2;
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.White;
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel29.Location = new System.Drawing.Point(1448, 680);
            this.panel29.Margin = new System.Windows.Forms.Padding(8);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(252, 208);
            this.panel29.TabIndex = 2;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.White;
            this.panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel30.Location = new System.Drawing.Point(1857, 456);
            this.panel30.Margin = new System.Windows.Forms.Padding(8);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(252, 208);
            this.panel30.TabIndex = 2;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.White;
            this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel31.Location = new System.Drawing.Point(1711, 680);
            this.panel31.Margin = new System.Windows.Forms.Padding(8);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(252, 208);
            this.panel31.TabIndex = 2;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.White;
            this.panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel32.Location = new System.Drawing.Point(2139, 456);
            this.panel32.Margin = new System.Windows.Forms.Padding(8);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(252, 208);
            this.panel32.TabIndex = 2;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.White;
            this.panel33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel33.Location = new System.Drawing.Point(1974, 682);
            this.panel33.Margin = new System.Windows.Forms.Padding(8);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(252, 208);
            this.panel33.TabIndex = 2;
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.White;
            this.panel34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel34.Location = new System.Drawing.Point(2421, 456);
            this.panel34.Margin = new System.Windows.Forms.Padding(8);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(252, 208);
            this.panel34.TabIndex = 2;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.White;
            this.panel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel35.Location = new System.Drawing.Point(2237, 680);
            this.panel35.Margin = new System.Windows.Forms.Padding(8);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(252, 208);
            this.panel35.TabIndex = 2;
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.White;
            this.panel36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel36.Location = new System.Drawing.Point(2703, 465);
            this.panel36.Margin = new System.Windows.Forms.Padding(8);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(252, 208);
            this.panel36.TabIndex = 2;
            // 
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.Color.White;
            this.panel37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel37.Location = new System.Drawing.Point(2500, 682);
            this.panel37.Margin = new System.Windows.Forms.Padding(8);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(252, 208);
            this.panel37.TabIndex = 2;
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.White;
            this.panel38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel38.Location = new System.Drawing.Point(2763, 680);
            this.panel38.Margin = new System.Windows.Forms.Padding(8);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(252, 208);
            this.panel38.TabIndex = 2;
            // 
            // button_NVR
            // 
            this.button_NVR.Location = new System.Drawing.Point(14, 680);
            this.button_NVR.Margin = new System.Windows.Forms.Padding(8);
            this.button_NVR.Name = "button_NVR";
            this.button_NVR.Size = new System.Drawing.Size(362, 58);
            this.button_NVR.TabIndex = 4;
            this.button_NVR.Text = "连接NVR";
            this.button_NVR.UseVisualStyleBackColor = true;
            this.button_NVR.Click += new System.EventHandler(this.button_NVR_Click);
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3030, 1288);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnNoDecoderCapture);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCloseTream);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_NVR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel38);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel37);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel36);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel35);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel34);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel33);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel32);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel31);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel30);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel29);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txBufferTime);
            this.Controls.Add(this.txChannelNum);
            this.Controls.Add(this.txStream);
            this.Controls.Add(this.txPswd);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.txPort);
            this.Controls.Add(this.txtIP);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "frmVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDemo C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txPort;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.TextBox txPswd;
        private System.Windows.Forms.TextBox txStream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txChannelNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txBufferTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCloseTream;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNoDecoderCapture;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Button button_NVR;

    }
}

