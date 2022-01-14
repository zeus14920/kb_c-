using iot_myself.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace iot_myself.Network
{
    class Serial_nw
    {
        SerialPort sp;

        public void connect(string port, string baud, string databits, string parity, string stop)
        {
            try
            {
                sp.PortName = port;
                sp.BaudRate = Convert.ToInt32(baud);
                sp.DataBits = Convert.ToInt32(databits);
                sp.Parity = getParityIndex(parity);
                sp.StopBits = getStopBitsIndex(stop);
                sp.Handshake = Handshake.None;
                sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                sp.Open();
                string str = sp.PortName + "에 연결이 되었습니다.";
            }
            catch (Exception e)
            {
                Console.WriteLine("접속 에러: " + e.Message);
                // 로그 처리
            }
        }

        public static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = new SerialPort();
            int intRecSize = sp.BytesToRead;
            string RecvStr = string.Empty;

            // Recv Data가 있는 경우...
            if (intRecSize != 0)
            {
                byte[] buff = new byte[intRecSize];

                // Size 만큼 Read...
                sp.Read(buff, 0, intRecSize);
                for (int i = 0; i < intRecSize; i++)
                {
                    // Hex 변환...
                    foreach (byte bData in buff)
                        RecvStr += " " + buff[i].ToString("X2");
                }                
            }
        }

        private Parity getParityIndex(string parity)
        {
            int res = 0;
            if (parity.Equals("None"))
            {
                res = (int)Parity.None;
            }
            else if (parity.Equals("Odd"))
            {
                res = (int)Parity.Odd;
            }
            else if (parity.Equals("Even"))
            {
                res = (int)Parity.Even;
            }
            else if (parity.Equals("Mark"))
            {
                res = (int)Parity.Mark;
            }
            else if (parity.Equals("Space"))
            {
                res = (int)Parity.Space;
            }
            return (Parity)res;
        }

        private StopBits getStopBitsIndex(string stop)
        {
            int res = 0;
            if (stop.Equals("1"))
            {
                res = (int)StopBits.One;
            }
            else if (stop.Equals("1.5"))
            {
                res = (int)StopBits.OnePointFive;
            }
            else if (stop.Equals("2"))
            {
                res = (int)StopBits.Two;
            }
            return (StopBits)res;
        }
    }
}
