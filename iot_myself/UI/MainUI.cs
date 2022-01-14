using iot_myself;
using iot_myself.Network;
using iot_myself.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace iot_myself
{
    public partial class MainUI : MaterialForm
    {
        mTime sTimer;
        string[] temp = { "11", "22", "33", "44", "55", "66", "77", "88", "99" };
        string[] humi = { "11", "22", "33", "44", "55", "66", "77", "88", "99" };

        Random r = new Random();

        public MainUI()
        {
            InitializeComponent();
            sTimer = new mTime(new Timer(new TimerCallback(sensorInfo), null, 1000, 5000));
            Serial_nw serial_nw = new Serial_nw();
        }

        void sensorInfo(object args)
        {
            Invoke(new Action(delegate ()
            {
                try
                {
                    string time = string.Empty;
                    string temp1 = string.Empty;
                    string humi1 = string.Empty;
                    time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    temp1 = temp[r.Next(9)];
                    humi1 = humi[r.Next(9)];

                    timeLabel.Text = time;
                    tempLabel.Text = temp1;
                    tempAnalogMeter.Value = Convert.ToDouble(temp1);
                    humiLabel.Text = humi1;
                    humiAnalogMeter.Value = Convert.ToDouble(humi1);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("잘못된 정보");
                }
            }));
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            com_portComboBox.DataSource = SerialPort.GetPortNames();
        }
    }
}
