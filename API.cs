using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace ClientDemo
{
    public sealed class TMCC
    {
        public const int TMCC_ERR_SUCCESS               = 0;
        public const int TMCC_MAJOR_CMD_SERVERCONTROL   = 0x111;		/*远程服务器控制*/
        public const int TMCC_MINOR_CMD_MANUALCAPTURE   = 0x10;		    /*远程手动抓图传到本地*/
        public const int TMCC_MAJOR_CMD_VIDEOINCFG      = 0x116;		/*视频输入配置*/
        public const int TMCC_MINOR_CMD_VIDEOIN         = 0x00;		    /*输入配置*/
        public const int TMCC_MAJOR_CMD_SERVERMESSAGE   = 0x10F;	    /*服务器消息*/
        public const int TMCC_MINOR_CMD_SERVERALARM     = 0x04;		    /*报警上传管理中心具体信息看tmToManagerAlarmInfo_t*/

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TMCC_Init(UInt32 flag);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_SetAutoReConnect(IntPtr ptr, bool bShow);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_SetDisplayShow(IntPtr ptr, bool bShow);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_SetStreamBufferTime(IntPtr ptr, UInt32 dwTime);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_Connect(IntPtr ptr, ref tmConnectInfo_t connectInfo, bool bSync);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_GetConfig(IntPtr ptr, ref tmCommandInfo_t cmdInfo);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_SetConfig(IntPtr ptr, ref tmCommandInfo_t cmdInfo);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_SaveConfig(IntPtr ptr);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_ConnectStream(IntPtr ptr, ref tmPlayRealStreamCfg_t info, IntPtr playHandler);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_CloseStream(IntPtr ptr);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_ClearDisplay(IntPtr ptr);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_DisConnect(IntPtr flag);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_Done(IntPtr flag);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_CapturePictureToFile(IntPtr hTmCC, string pFileName, string pFmt);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_SetOtherParam(IntPtr hTmCC, uint dwFlags, IntPtr buf, ref int iLen);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_RegisterStreamCallBack(IntPtr ptr, StreamCallback back, IntPtr context);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_RegisterDataReadCallBack(IntPtr ptr, DeviceDataCallback back, IntPtr context);
        
        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_RegisterAVFrameCallBack(IntPtr ptr, AvFrameCallback back, IntPtr context);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_SetImageOutFmt(IntPtr ptr, uint iOutFmt);

        [DllImport("tmControlClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TMCC_GetLastError();

        //实时流回调
        public delegate void StreamCallback(IntPtr hTmCC, ref tmRealStreamInfo_t pStreamInfo, IntPtr context);
        //解码输出回调
        public delegate void AvFrameCallback(IntPtr hTmCC, ref tmAvImageInfo_t pStreamInfo, IntPtr context);
        //报警信息等设备数据回调
        public delegate void DeviceDataCallback(IntPtr hTmCC, ref tmCommandInfo_t pCommandInfo, IntPtr context);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tmConnectInfo_t
        {
            public uint dwSize;				//该结构的大小，必须填写
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] pIp;			//连接服务器的IP地址
            public int iPort;				//服务器连接的端口
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szUser;			//登录用户名
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szPass;			//登录用户口令
            public int iUserLevel;			//登录用户级别，主要用户DVS的一些互斥访问资源
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] pUserContext;//用户自定义数据

            public void Init()
            {
                pUserContext = new byte[32];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tmPlayRealStreamCfg_t
        {
            public UInt32 dwSize;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szAddress;	//连接服务器的IP地址
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szTurnAddress;//转发器地址
            public int iPort;		//服务器连接的端口
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szUser;	//登录用户名
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szPass;	//登录用户口令
            public byte byChannel;	//通道
            public byte byStream;	//码流号
            public byte byTranstType;	//传输类型
            public byte byReConnectNum;	//从连次数	
            public int iTranstPackSize;//传输包大小
            public int iReConnectTime;	//重连的时间间隔
            public byte byTransProtocol;//传输协议0-内部自定,1-SONY,2-RTSP	
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public char[] ok;	//登录用户口令
            public void Init()
            {
                ok = new char[128];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tmRealStreamInfo_t
        {
            public uint dwSize;		//本结构大小
            public byte byFrameType;	//帧类型0-视频，1-音频，2-数据流头
            public byte byNeedReset;	//是否需要复位解码器
            public byte byKeyFrame;	//是否关键帧
            public byte byTemp;
            public uint dwFactoryId;	//厂家ID	
            public uint dwStreamTag;	//流类型Tag
            public uint dwStreamId;	//流ID
            //union
            //{
            //int	iWidth;		//视频宽
            public int iSamplesPerSec;	//音频采样率
            //int	iHeight;	//视频高
            public int iBitsPerSample;	//音频采样位数
            //};
            //union
            //{
            //    int	iFrameRate;	//帧率*1000
            public int iChannels;	//音频的声道数
            //};
            //add by 2009-0429
            //union
            //{
            public uint nDisplayScale;	//显示比例*1000
            //};
            public uint dwTimeStamp;	//时间戳(单位毫秒)
            public uint dwPlayTime;		//此帧播放时间(单位毫秒)
            public uint dwBitRate;		//此数据流的码流大小	
            public IntPtr pBuffer;		//数据缓冲
            public int iBufferSize;		//数据大小
        }

        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tmAvImageInfo_t
        {
            public byte video;
            public byte face;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] temp;
            public IntPtr buffer0;
            public IntPtr buffer1;
            public IntPtr buffer2;
            public IntPtr buffer3;
            public int bufsize0;
            public int bufsize1;
            public int bufsize2;
            public int bufsize3;
            _stuVideo videoInfo;
            public int key_frame;
            public uint timestamp;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct _stuVideo
        {
            public short width;
            public short height;
            public int framerate;
            public byte format;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] temp;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tmCommandInfo_t
        {
            public uint dwSize;		        //该结构的大小，必须填写为sizeof(tmCommandInfo_t)	
            public uint dwMajorCommand;		//主消息数据命令即数据类型
            public uint dwMinorCommand;		//次消息数据命令即数据类型	
            public ushort iChannel;         //通道号，该通道号要根据dwMajorCommand来判断是否有效
            public ushort iStream;          //子通道号，该通道号要根据dwMajorCommand来判断是否有效
            public IntPtr pCommandBuffer;   //消息数据缓冲
            public int iCommandBufferLen;   //消息数据缓冲大小
            public int iCommandDataLen;     //消息数据实际大小
            public uint dwResult;           //消息控制返回结果
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tmToManagerImageInfo_t
        {
             public uint dwSize;
             public _stuImage image;             
             [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
             public byte[] byTemp; 
             [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
             public byte[] byMACAddr; 
             [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
             public byte[] byTemp2; 
             [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
             public byte[] szServerIP; 
             public byte   byImageFmt;

             public byte   byCount;
             public byte   byIndex;
             public byte   byImageMode;
             public byte   byAlarmId;
             public byte   byChannelId;
             [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
             public byte[] byOtherInfo;                         
             public _stuTime time;   
             public uint    dwImageSize;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct _stuImage
        {
            public short nWidth;
            public short nHeight;
            public byte byBitCount;
            public byte byRevolving;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byTemp;
        };     
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct _stuTime
        {
            public short nYear;
            public byte nMonth;
            public byte nDay;
            public byte nDayOfWeek;
            public byte nHour;
            public byte nMinute;
            public byte nSecond;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tmVideoInCfg_t
        {
            public uint dwSize;
            public byte byAntiFlickerMode;
            public byte byVideoColorStyle;
            public byte byRotaeAngle180;
            public byte byColorTransMode; /*彩转黑模式0-自动，1-彩色，2-黑白*/
            public byte byShutterSpeed;
            public byte byAgc;
            public byte byIRShutMode;
            public byte byExposure;
            public byte byIRStartHour;
            public byte byIRStartMin;
            public byte byIRStopHour;
            public byte byIRStopMin;
            public byte byModeSwitch;
            public byte byWhiteBalance;
            public byte byWdr;
            public byte byBlc;
            public ushort nWhiteBalanceR;
            public ushort nWhiteBalanceB;
            public byte byMctfStrength;
            public byte byIRType;
            public byte byIRCutTriggerAlarmOut;
            public byte byIRCutTime;
            public byte byExposureLevel;
            public byte byColorTransMin;
            public byte byColorTransMax;
            public byte byNoiseFilter;
            public byte byForceNoiseFilter;
            public byte byAeMeteringMode;
            public byte byWdrMode;
            public byte byIRShutAlarmIn;
            public byte byAutoContrast;
            public byte byLightInhibitionEn;
            public byte byVinFrameRate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte [] byTemp;
            public byte byAgcTransMin;
            public byte byAgcTransMax;
            public ushort nMaxShutterSpeed;
            public ushort nMaxAgc;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
            public byte []byAeMeteringData;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte []byExposureLevelHdr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public ushort []nMinShutterSpeedHdr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public ushort []nMaxShutterSpeedHdr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte []byMaxAgcHdr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4*96)]
            public byte[] byAeMeteringDataHdr;         
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tmAlaramInfo_t
        {
            public uint dwSize;
            public ushort wAlarmType;     /*0-信号量报警,	1-硬盘满, 2-信号丢失，3－移动侦测，
											4－硬盘未格式化,5-读写硬盘出错,6-遮挡报警,7-制式不匹配,
											8-非法访问 9-无存储计划 10-磁盘异常 11-通道未录像
											12-前端信号量报警 13-跨线报警 14-非法闯入 15-物品遗留/丢失*/
            public ushort wAlarmState;
            public uint dwAlarmChannel;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public uint []dwAlarmOutputNumber;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public uint []dwAlarmRelateChannel;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public uint []dwDiskNumber;
        }
    }

    public class IniFile
    {
        public string path;             //INI文件名  

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key,
                    string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def,
                    StringBuilder retVal, int size, string filePath);

        //声明读写INI文件的API函数  
        public IniFile(string INIPath)
        {
            path = INIPath;
        }

        //类的构造函数，传递INI文件名  
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        //写INI文件  
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }

        //读取INI文件指定  
    }

}
