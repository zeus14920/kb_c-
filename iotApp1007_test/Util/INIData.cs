using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace iotApp1005.Util
{
    // S101 오류
    // 사용자 클래스 변수명 예외처리
    class INIData
    {
        public static readonly string INI_FILE_NAME = @"\setting.ini";
        public static readonly string SECTION = "serial";
        public static readonly string KEY_PORT = "port";
        public static readonly string KEY_BAUDRATE = "baudrate";
        public static readonly string KEY_DATABITS = "databits";
        public static readonly string KEY_PARITY = "parity";
        public static readonly string KEY_STOPBITS = "stopbits";

        public static readonly string DEFAULT_PORT = "COM3";
        public static readonly string DEFAULT_BAUDRATE = "9600";
        public static readonly string DEFAULT_DATABITS = "8";
        public static readonly string DEFAULT_PARITY = "None";
        public static readonly string DEFAULT_STOPBITS = "1";

        readonly string iniPath;

        public INIData(string iniPath)
        {
            this.iniPath = iniPath;
        }

        // win32 API ini 파일 읽기
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string section, string key, string def, StringBuilder reVal, int size, string filePath);

        // win32 API ini 파일 쓰기
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
            string section, string key, string val, string filePath);

        public string getIniVal(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            return temp.ToString();
        }

        public void setIniVal(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, iniPath);
        }
    }
}
