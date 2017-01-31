using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace ClientDemo
{
    public partial class frmVideo : Form
    {
        delegate void SetTextCallback(string text);

        System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();

        public void OnTimer(object sender, System.EventArgs e)
        {
            this.Text = strTitle;
        }

        IntPtr hPreView = IntPtr.Zero;
        IntPtr hLogin = IntPtr.Zero;
        IntPtr pCmdBuffer = Marshal.AllocHGlobal(1920 * 1080);
        String strTitle;
        int alarmCount = 0;
        ClientDemo.TMCC.tmVideoInCfg_t videoIn = new TMCC.tmVideoInCfg_t();
        ClientDemo.TMCC.tmAlaramInfo_t alarmInfo = new TMCC.tmAlaramInfo_t();

        public frmVideo()
        {
            time.Interval = 100;
            time.Tick += new EventHandler(OnTimer);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hLogin = TMCC.TMCC_Init(0); //控制连接句柄
            hPreView = TMCC.TMCC_Init(5); //实时流句柄

            //button7.Enabled = false;
        }

        ClientDemo.TMCC.StreamCallback streamback = null;
        ClientDemo.TMCC.AvFrameCallback frameback = null;
        ClientDemo.TMCC.DeviceDataCallback datareadback = null;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var ret = 0;
            ret = TMCC.TMCC_SetAutoReConnect(hPreView, true);
            ret = TMCC.TMCC_SetDisplayShow(hPreView, true);
            ret = TMCC.TMCC_SetStreamBufferTime(hPreView, uint.Parse(txBufferTime.Text));
            streamback = StreamDataCallBack;
            ret = TMCC.TMCC_RegisterStreamCallBack(hPreView, streamback, hPreView);
            frameback = AvFrameCallBack;
            ret = TMCC.TMCC_RegisterAVFrameCallBack(hPreView, frameback, hPreView);
            ret = TMCC.TMCC_SetImageOutFmt(hPreView, 3);
            ClientDemo.TMCC.tmPlayRealStreamCfg_t stream = new TMCC.tmPlayRealStreamCfg_t();
            stream.Init();
            stream.dwSize = (UInt32)Marshal.SizeOf(stream);
            stream.szAddress = Get(32, txtIP.Text.ToCharArray());
            stream.szTurnAddress = Get(32, txtIP.Text.ToCharArray());
            stream.szUser = Get(32, txUser.Text.ToCharArray());
            stream.szPass = Get(32, txPswd.Text.ToCharArray());
            stream.iPort = Convert.ToInt32(txPort.Text);
            stream.byChannel = byte.Parse(txChannelNum.Text);
            stream.byStream = byte.Parse(txStream.Text);

            ret = TMCC.TMCC_ConnectStream(hPreView, ref stream, panel1.Handle);
            var error = TMCC.TMCC_GetLastError();

            if (ret != TMCC.TMCC_ERR_SUCCESS)
            {
                tip("预览视频失败");
            }

            time.Start();

            button6.Enabled = false;
        }

        int iTemp = 0;
        public void StreamDataCallBack(IntPtr hTmCC, ref ClientDemo.TMCC.tmRealStreamInfo_t pStreamInfo, IntPtr context)
        {
            if (pStreamInfo.byFrameType == 0)//视频
            {
                iTemp++;
                String str = "[" + Convert.ToString(pStreamInfo.iSamplesPerSec) + "x" + Convert.ToString(pStreamInfo.iBitsPerSample) + "] ";
                strTitle = "ClientDemo C# " + str;
                for (int i = 0; i < iTemp; i++)
                {
                    strTitle += ">";
                }

                if (iTemp == 22)
                {
                    iTemp = 0;
                }
            }
        }

        public void AvFrameCallBack(IntPtr hTmCC, ref ClientDemo.TMCC.tmAvImageInfo_t pFrame, IntPtr context)
        {
            if (pFrame.video == 1)//视频
            {
                //MessageBox.Show(hTmCC.ToString());
                // string str = "解码输出:" + Convert.ToString(pFrame.bufsize0);
                // tip(str);
            }
        }

        char[] Get(int size, char[] arr)
        {
            char[] total = new char[size];
            Array.Copy(arr, total, arr.Length);
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //原始
            var ret = TMCC.TMCC_CapturePictureToFile(hPreView, "./testCapture.jpeg", "JPEG");
        }

        void tip(string str)
        {
            MessageBox.Show(str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseTream_Click(object sender, EventArgs e)
        {
            time.Stop();
            TMCC.TMCC_CloseStream(hPreView);
            TMCC.TMCC_ClearDisplay(hPreView);
            this.Text = "ClientDemo C# ";

            button6.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TMCC.TMCC_SetStreamBufferTime(hPreView, uint.Parse(txBufferTime.Text));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TMCC.tmConnectInfo_t Info = new TMCC.tmConnectInfo_t();
            Info.Init();
            Info.dwSize = (UInt32)Marshal.SizeOf(Info);
            Info.pIp = Get(32, txtIP.Text.ToCharArray());
            Info.szPass = Get(32, txPswd.Text.ToCharArray());
            Info.szUser = Get(32, txUser.Text.ToCharArray());
            Info.iPort = Convert.ToInt32(txPort.Text);

            var ret = TMCC.TMCC_Connect(hLogin, ref Info, true);
            if (ret != TMCC.TMCC_ERR_SUCCESS)
            {
                tip("登陆设备失败");
            }
            else
            {
                button4.Enabled = true;
                button3.Enabled = true;
                btnNoDecoderCapture.Enabled = true;
                comboBox1.Enabled = true;
                label11.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button3.Enabled = false;
            btnNoDecoderCapture.Enabled = false;
            comboBox1.Enabled = false;
            label11.Enabled = false;
            button5.Enabled = false;
            label13.ForeColor = Color.Gray;
            label13.Text = "没有报警";
            alarmCount = 0;
            TMCC.TMCC_DisConnect(hLogin);
        }

        private void btnNoDecoderCapture_Click(object sender, EventArgs e)
        {
            ClientDemo.TMCC.tmCommandInfo_t cmdInfo = new TMCC.tmCommandInfo_t();
            cmdInfo.dwSize = (UInt32)Marshal.SizeOf(cmdInfo);
            cmdInfo.iChannel = ushort.Parse(txChannelNum.Text);
            cmdInfo.iStream = ushort.Parse(txStream.Text);
            cmdInfo.dwMajorCommand = TMCC.TMCC_MAJOR_CMD_SERVERCONTROL;
            cmdInfo.dwMinorCommand = TMCC.TMCC_MINOR_CMD_MANUALCAPTURE;
            cmdInfo.pCommandBuffer = pCmdBuffer;
            cmdInfo.iCommandBufferLen = 1920 * 1080;
            cmdInfo.iCommandDataLen = 1920 * 1080;
            cmdInfo.dwResult = 0;
            var ret = TMCC.TMCC_GetConfig(hLogin, ref cmdInfo);
            if (ret != TMCC.TMCC_ERR_SUCCESS)
            {
                tip("抓图失败 是否已登陆设备？");
            }
            else
            {
                TMCC.tmToManagerImageInfo_t pImageInfo = new TMCC.tmToManagerImageInfo_t();

                byte[] pByte = new byte[1920 * 1080];
                Marshal.Copy(pCmdBuffer, pByte, 0, 1920 * 1080);
                pImageInfo = (TMCC.tmToManagerImageInfo_t)BytesToStruct(pByte, pImageInfo.GetType());
                String str = "Imgsize:" + Convert.ToString(pImageInfo.dwImageSize) + "  [" + Convert.ToString(pImageInfo.image.nWidth) + "x" + Convert.ToString(pImageInfo.image.nHeight) + "]";

                //写文件
                if (0 == pImageInfo.byImageFmt /*JPEG*/ && pImageInfo.dwImageSize > 0)
                {
                    String fileName = "./"
                        + Convert.ToString(pImageInfo.time.nYear)
                        + "-"
                        + Convert.ToString(pImageInfo.time.nMonth)
                        + "-"
                        + Convert.ToString(pImageInfo.time.nDay)
                        + " "
                        + Convert.ToString(pImageInfo.time.nHour)
                        + "-"
                        + Convert.ToString(pImageInfo.time.nMinute)
                        + "-"
                        + Convert.ToString(pImageInfo.time.nSecond)
                        + ".jpg";

                    FileStream fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite);
                    BinaryWriter writer = new BinaryWriter(fs);
                    writer.Write(pByte, Convert.ToInt32(pImageInfo.dwSize), Convert.ToInt32(pImageInfo.dwImageSize));
                }
                else
                {
                    tip("抓图失败 请设置码流格式为MJPEG");
                }
            }
        }

        public static object BytesToStruct(byte[] bytes, Type strcutType)
        {
            int size = Marshal.SizeOf(strcutType);
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(bytes, 0, buffer, size);
                return Marshal.PtrToStructure(buffer, strcutType);
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /**
         * TMCC_GetConfig、TMCC_SetConfig必须先调用TMCC_Connect登陆设备
         * button4_Click和button3_Click中的代码展示了TMCC_GetConfig、TMCC_SetConfig、TMCC_SaveConfig的使用
         * 摄像机所有的参数都可以通过TMCC_GetConfig、TMCC_SetConfig进行获取与设置
         * 要设置不同的参数请修改下面示例中cmdInfo.dwMajorCommand、cmdInfo.dwMinorCommand以及cmdInfo.pCommandBuffer、cmdInfo.iCommandBufferLen
         * TMCC_GetConfig执行完成后将cmdInfo.pCommandBuffer转换成cmdInfo.dwMajorCommand、cmdInfo.dwMinorCommand对应的结构体
         * 中搜索根据主从命令查找对应结构体方法，如命令TMCC_MAJOR_CMD_VIDEOINCFG，可以ctrl+f在tmTransDefine.h中搜索VIDEOINCFG
         * TMCC_SetConfig最好在调用TMCC_GetConfig填充对应结构体后执行，只修改对应结构体中感兴趣值调用TMCC_SetConfig进行设置
         * */
        private void button4_Click(object sender, EventArgs e)
        {
            ClientDemo.TMCC.tmCommandInfo_t cmdInfo = new TMCC.tmCommandInfo_t();
            cmdInfo.dwSize = (UInt32)Marshal.SizeOf(cmdInfo);
            cmdInfo.iChannel = ushort.Parse(txChannelNum.Text);
            cmdInfo.iStream = ushort.Parse(txStream.Text);
            cmdInfo.dwMajorCommand = TMCC.TMCC_MAJOR_CMD_VIDEOINCFG;
            cmdInfo.dwMinorCommand = TMCC.TMCC_MINOR_CMD_VIDEOIN;
            cmdInfo.pCommandBuffer = pCmdBuffer;
            cmdInfo.iCommandBufferLen = Marshal.SizeOf(videoIn);
            cmdInfo.iCommandDataLen = Marshal.SizeOf(videoIn);
            cmdInfo.dwResult = 0;
            var ret = TMCC.TMCC_GetConfig(hLogin, ref cmdInfo);
            if (ret != TMCC.TMCC_ERR_SUCCESS)
            {
                tip("获取视频参数失败");
            }
            else
            {
                byte[] pByte = new byte[Marshal.SizeOf(videoIn)];
                Marshal.Copy(pCmdBuffer, pByte, 0, Marshal.SizeOf(videoIn));
                videoIn = (TMCC.tmVideoInCfg_t)BytesToStruct(pByte, videoIn.GetType());
                comboBox1.SelectedIndex = videoIn.byColorTransMode;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            videoIn.byColorTransMode = Convert.ToByte(comboBox1.SelectedIndex);

            IntPtr spVideoIn = Marshal.AllocCoTaskMem(Marshal.SizeOf(videoIn));
            Marshal.StructureToPtr(videoIn, spVideoIn, false);

            ClientDemo.TMCC.tmCommandInfo_t cmdInfo = new TMCC.tmCommandInfo_t();
            cmdInfo.dwSize = (UInt32)Marshal.SizeOf(cmdInfo);
            cmdInfo.iChannel = ushort.Parse(txChannelNum.Text);
            cmdInfo.iStream = ushort.Parse(txStream.Text);
            cmdInfo.dwMajorCommand = TMCC.TMCC_MAJOR_CMD_VIDEOINCFG;
            cmdInfo.dwMinorCommand = TMCC.TMCC_MINOR_CMD_VIDEOIN;
            cmdInfo.pCommandBuffer = spVideoIn;
            cmdInfo.iCommandBufferLen = Marshal.SizeOf(videoIn);
            cmdInfo.iCommandDataLen = Marshal.SizeOf(videoIn);
            cmdInfo.dwResult = 0;
            //设置参数
            var ret = TMCC.TMCC_SetConfig(hLogin, ref cmdInfo);
            if (ret != TMCC.TMCC_ERR_SUCCESS)
            {
                tip("设置视频参数失败");
            }
            //保存设置
            TMCC.TMCC_SaveConfig(hLogin);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoIn.byColorTransMode = Convert.ToByte(comboBox1.SelectedIndex);
        }

        public void DeviceDataCallBack(IntPtr hTmCC, ref ClientDemo.TMCC.tmCommandInfo_t pCommandInfo, IntPtr context)
        {
            if (pCommandInfo.dwMajorCommand == TMCC.TMCC_MAJOR_CMD_SERVERMESSAGE
                && pCommandInfo.dwMinorCommand == TMCC.TMCC_MINOR_CMD_SERVERALARM)
            {
                alarmCount++;
                byte[] pByte = new byte[Marshal.SizeOf(alarmInfo)];
                Marshal.Copy(pCommandInfo.pCommandBuffer, pByte, 0, Marshal.SizeOf(alarmInfo));
                alarmInfo = (TMCC.tmAlaramInfo_t)BytesToStruct(pByte, alarmInfo.GetType());
                if (alarmInfo.wAlarmState == 1)
                {
                    label13.ForeColor = Color.Red;
                    label13.Text = "收到报警:" + Convert.ToString(alarmCount);
                }
                else
                {
                    label13.ForeColor = Color.Gray;
                    label13.Text = "报警停止";
                }
            }
        }

        //打开报警接收
        private void button5_Click(object sender, EventArgs e)
        {
            datareadback = DeviceDataCallBack;
            TMCC.TMCC_RegisterDataReadCallBack(hLogin, datareadback, hLogin);
        }

        IntPtr[] hPreViews,hControlPreViews;
        int nCameraCount = 0;
        ClientDemo.TMCC.tmCommandInfo_t tmCMDInfo;
        ClientDemo.TMCC.tmPlayRealStreamCfg_t[] MultiStreams;
        IniFile netConfigFile;

        //连续抓取图片
        private void button6_Click(object sender, EventArgs e)
        {
            //读取Ini文件
            OpenFileDialog iniFileDlg = new OpenFileDialog();
            iniFileDlg.DefaultExt = "ini";
            iniFileDlg.Filter = "配置文件（*.ini）|*.ini";
            iniFileDlg.InitialDirectory = Application.StartupPath;
            if (DialogResult.OK == iniFileDlg.ShowDialog())
            {
                netConfigFile = new IniFile(iniFileDlg.FileName);
            }
            else
            {
                MessageBox.Show("配置文件读取失败，无法采集图片！");
                return;
            }

            //初始化
            tmCMDInfo = new TMCC.tmCommandInfo_t();
            nCameraCount = System.Int32.Parse(netConfigFile.IniReadValue("Camera", "Count")); ;
            hPreViews = new IntPtr[nCameraCount];
            MultiStreams = new TMCC.tmPlayRealStreamCfg_t[nCameraCount];
            var ret = 0;
            IntPtr[] displayHandles = 
            { panel1.Handle, panel2.Handle, panel3.Handle, panel4.Handle,panel5.Handle,
                panel6.Handle,panel7.Handle,panel8.Handle,panel9.Handle,panel10.Handle
            ,panel11.Handle,panel12.Handle,panel13.Handle,panel14.Handle,panel15.Handle
            ,panel16.Handle,panel17.Handle,panel18.Handle,panel19.Handle,panel20.Handle
            ,panel21.Handle,panel22.Handle,panel23.Handle,panel24.Handle,panel25.Handle
            ,panel26.Handle,panel27.Handle,panel28.Handle,panel29.Handle,panel30.Handle
            ,panel31.Handle,panel32.Handle,panel33.Handle,panel34.Handle,panel35.Handle
            ,panel36.Handle,panel37.Handle,panel38.Handle};
            //ClientDemo.TMCC.AvFrameCallback avFrameback = null;

            //循环打开相机并保存数据
            for (int i = 0; i < nCameraCount; i++)
            {
                hPreViews[i] = TMCC.TMCC_Init(5); //实时流句柄
                hControlPreViews[i] = TMCC.TMCC_Init(5);    //设备控制句柄

                ret = TMCC.TMCC_SetImageOutFmt(hPreViews[i], 3);
                MultiStreams[i] = new TMCC.tmPlayRealStreamCfg_t();
                MultiStreams[i].Init();
                MultiStreams[i].dwSize = (UInt32)Marshal.SizeOf(MultiStreams[i]);
                MultiStreams[i].szAddress = Get(32, netConfigFile.IniReadValue("Net",
                    "ip" + (i + 1).ToString() + "_address").ToCharArray());
                MultiStreams[i].szTurnAddress = Get(32, netConfigFile.IniReadValue("Net",
                    "ip" + (i + 1).ToString() + "_address").ToCharArray());
                MultiStreams[i].szUser = Get(32, netConfigFile.IniReadValue("Net",
                    "ip" + (i + 1).ToString() + "_user").ToCharArray());
                MultiStreams[i].szPass = Get(32, netConfigFile.IniReadValue("Net",
                    "ip" + (i + 1).ToString() + "_password").ToCharArray());
                MultiStreams[i].iPort = System.Int32.Parse(netConfigFile.IniReadValue("Net",
                    "ip" + (i + 1).ToString() + "_port"));
                MultiStreams[i].byChannel = byte.Parse(txChannelNum.Text);
                MultiStreams[i].byStream = byte.Parse(txStream.Text);


                //连接视频并显示
                //ret = TMCC.TMCC_ConnectStream(hPreViews[i], ref MultiStream, panel1.Handle);
                ret = TMCC.TMCC_ConnectStream(hPreViews[i], ref MultiStreams[i], displayHandles[i]);
                var error = TMCC.TMCC_GetLastError();
                if (ret != TMCC.TMCC_ERR_SUCCESS)
                {
                    tip("预览视频失败");
                    return;
                }
                tmCMDInfo.dwMajorCommand = TMCC.TMCC_MAJOR_CMD_VIDEOINCFG;
                ret = TMCC.TMCC_GetConfig(hControlPreViews[i], ref tmCMDInfo);

                //button6.Enabled = false;
                //button7.Enabled = true;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var ret = 0;
            string fileName = "";
            //循环打开相机并保存数据
            for (int i = 0; i < nCameraCount; i++)
            {
                //采集图像并保存
                fileName = "./image/" + (i + 1).ToString() + "_" + MultiStreams[i].byStream.ToString() +
                    "(IP=" + netConfigFile.IniReadValue("Net", "ip" + (i + 1).ToString() + "_address").Substring(netConfigFile.IniReadValue("Net", "ip" + (i + 1).ToString() + "_address").LastIndexOf(".") + 1,
                    netConfigFile.IniReadValue("Net", "ip" + (i + 1).ToString() + "_address").Length - netConfigFile.IniReadValue("Net", "ip" + (i + 1).ToString() + "_address").LastIndexOf(".") - 1) + ")" + ".jpg";
                ret = TMCC.TMCC_CapturePictureToFile(hPreViews[i], fileName, "JPEG");

                //////释放资源
                //TMCC.TMCC_CloseStream(hPreViews[i]);
                //TMCC.TMCC_ClearDisplay(hPreViews[i]);
                //TMCC.TMCC_Done(hPreViews[i]);
                //hPreViews[i] = IntPtr.Zero; ;
            }

            //button6.Enabled = true;
            //button7.Enabled = false;

            MessageBox.Show("图片保存完毕");
        }


        IntPtr hNVRPreview = IntPtr.Zero;
        //连接NVR，并显示图像
        private void button_NVR_Click(object sender, EventArgs e)
        {
            hNVRPreview = TMCC.TMCC_Init(5);

            var ret = 0;
            //ret = TMCC.TMCC_SetAutoReConnect(hNVRPreview, true);
            //ret = TMCC.TMCC_SetDisplayShow(hNVRPreview, true);
            //ret = TMCC.TMCC_SetStreamBufferTime(hNVRPreview, uint.Parse(txBufferTime.Text));
            //streamback = StreamDataCallBack;
            //ret = TMCC.TMCC_RegisterStreamCallBack(hNVRPreview, streamback, hNVRPreview);
            frameback = AvFrameCallBack;
            ret = TMCC.TMCC_RegisterAVFrameCallBack(hNVRPreview, frameback, hNVRPreview);
            ret = TMCC.TMCC_SetImageOutFmt(hNVRPreview, 3);
            ClientDemo.TMCC.tmPlayRealStreamCfg_t stream = new TMCC.tmPlayRealStreamCfg_t();
            stream.Init();
            stream.dwSize = (UInt32)Marshal.SizeOf(stream);
            stream.szAddress = Get(32, txtIP.Text.ToCharArray());
            stream.szTurnAddress = Get(32, txtIP.Text.ToCharArray());
            stream.szUser = Get(32, txUser.Text.ToCharArray());
            stream.szPass = Get(32, txPswd.Text.ToCharArray());
            stream.iPort = Convert.ToInt32(txPort.Text);
            stream.byChannel = byte.Parse(txChannelNum.Text);
            stream.byStream = byte.Parse(txStream.Text);

            ret = TMCC.TMCC_ConnectStream(hNVRPreview, ref stream, panel1.Handle);
            var error = TMCC.TMCC_GetLastError();

            if (ret != TMCC.TMCC_ERR_SUCCESS)
            {
                tip("预览视频失败");
            }

            time.Start();
        }
    }
}
