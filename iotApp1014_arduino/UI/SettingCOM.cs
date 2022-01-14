using iotApp1005.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iotApp1005.UI
{
    public partial class SettingCOM : MaterialForm
    {
        INIData ini;

        public SettingCOM()
        {
            InitializeComponent();
            initComSetting();
        }

        private void comSetOK_Click(object sender, EventArgs e)
        {
            ini.setIniVal(INIData.SECTION, INIData.KEY_PORT, portSet.Text);
            ini.setIniVal(INIData.SECTION, INIData.KEY_BAUDRATE, baudSet.Text);
            ini.setIniVal(INIData.SECTION, INIData.KEY_DATABITS, databitSet.Text);
            ini.setIniVal(INIData.SECTION, INIData.KEY_PARITY, paritySet.Text);
            ini.setIniVal(INIData.SECTION, INIData.KEY_STOPBITS, stopbitSet.Text);
            Close();
        }

        private void comSetCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void initComSetting()
        {
            FileInfo fileInfo = new FileInfo(Application.ExecutablePath);
            string path = fileInfo.Directory.FullName.ToString();
            string fileName = INIData.INI_FILE_NAME;
            string filePath = path + fileName;
            Console.WriteLine("filePath : " + filePath);
            ini = new INIData(filePath);

            // portbits
            string str = ini.getIniVal(INIData.SECTION, INIData.KEY_PORT);
            portSet.SelectedIndex = int.Parse(getIniValIndex(INIData.KEY_PORT, str));

            // databits
            str = ini.getIniVal(INIData.SECTION, INIData.KEY_BAUDRATE);
            baudSet.SelectedIndex = int.Parse(getIniValIndex(INIData.KEY_BAUDRATE, str));

            // databits
            str = ini.getIniVal(INIData.SECTION, INIData.KEY_DATABITS);
            databitSet.SelectedIndex = int.Parse(getIniValIndex(INIData.KEY_DATABITS, str));


            // paritybits
            str = ini.getIniVal(INIData.SECTION, INIData.KEY_PARITY);
            paritySet.SelectedIndex = int.Parse(getIniValIndex(INIData.KEY_PARITY, str));

            // stopbits
            str = ini.getIniVal(INIData.SECTION, INIData.KEY_STOPBITS);
            stopbitSet.SelectedIndex = int.Parse(getIniValIndex(INIData.KEY_STOPBITS, str));
        }

        private string getIniValIndex(string key, string value)
        {
            string ret = string.Empty;
            if (key.Equals(INIData.KEY_PORT))
            {
                if (value.Equals("COM1")) ret = "0";
                else if (value.Equals("COM2")) ret = "1";
                else if (value.Equals("COM3")) ret = "2";
                else if (value.Equals("COM4")) ret = "3";
                else if (value.Equals("COM5")) ret = "4";
                else if (value.Equals("COM6")) ret = "5";
                else if (value.Equals("COM7")) ret = "6";
                else if (value.Equals("COM8")) ret = "7";
                else if (value.Equals("COM9")) ret = "8";
                else if (value.Equals("COM10")) ret = "9";
                else if (value.Equals("COM11")) ret = "10";
                else if (value.Equals("COM12")) ret = "11";
                else if (value.Equals("COM13")) ret = "12";
                else if (value.Equals("COM14")) ret = "13";
                else if (value.Equals("COM15")) ret = "14";
            }
            else if (key.Equals(INIData.KEY_BAUDRATE))
            {
                if (value.Equals("2400")) ret = "0";
                else if (value.Equals("4800")) ret = "1";
                else if (value.Equals("9600")) ret = "2";
                else if (value.Equals("14400")) ret = "3";
                else if (value.Equals("19200")) ret = "4";
                else if (value.Equals("28800")) ret = "5";
                else if (value.Equals("38400")) ret = "6";
                else if (value.Equals("57600")) ret = "7";
                else if (value.Equals("115200")) ret = "7";
            }
            else if (key.Equals(INIData.KEY_DATABITS))
            {
                if (value.Equals("5")) ret = "0";
                else if (value.Equals("6")) ret = "1";
                else if (value.Equals("7")) ret = "2";
                else if (value.Equals("8")) ret = "3";
                else if (value.Equals("9")) ret = "4";
            }
            else if (key.Equals(INIData.KEY_PARITY))
            {
                if (value.Equals("None")) ret = "0";
                else if (value.Equals("Even")) ret = "1";
                else if (value.Equals("Odd")) ret = "2";
                else if (value.Equals("Mark")) ret = "3";
                else if (value.Equals("Space")) ret = "4";
            }
            else if (key.Equals(INIData.KEY_STOPBITS))
            {
                if (value.Equals("1")) ret = "0";
                else if (value.Equals("1.5")) ret = "1";
                else if (value.Equals("2")) ret = "2";
            }
            return ret;
        }
    }
}
