using MaterialSkin.Controls;
using MESDesign_code.DBO;
using MESDesign_code.Model;
using MESDesign_code.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace MESDesign_code.UI
{
    partial class productionEnvInfo : MaterialForm
    {
        ThingSpeak ts = new ThingSpeak();
        ThingSpeakTimer rTimer;
        static int count = 0;

        public productionEnvInfo()
        {
            InitializeComponent();
            rTimer = new ThingSpeakTimer(new Timer(new TimerCallback(readHandler), null, 2000, 20000));
        }
                
        public void readHandler(object args)
        {
            List<LineEnvData> list = ts.readThingSpeak();
            for (int i = 0; i < list.Count; )
            {
                // work 스레드에서 UI스레드 사용
                Invoke(new Action(delegate ()
                {
                    lineAddTime.Text = list[i].Time;
                    lineOneTemp.Text = list[i].Temp1;
                    lineOnehumi.Text = list[i].Humi1;
                    lineOneDust.Text = list[i].Dust1;
                    lineOneTempAnalogMeter.Value = Convert.ToDouble(list[i].Temp1);
                    lineOneHumiAnalogMeter.Value = Convert.ToDouble(list[i].Humi1);
                    lineOneDustAnalogMeter.Value = Convert.ToDouble(list[i].Dust1);
                    Console.WriteLine("#### 생산환경정보에서 출력 ####");
                }));
                initCommChart(list);
                OraMgr.Instance.showDB();
                i++;
                return;
            }
        }
        void initCommChart(List<LineEnvData> list)
        {
            if (count == 4)
            {
                foreach (var series in chart1.Series)
                {
                    Invoke(new Action(delegate ()
                    {
                        series.Points.Clear();
                    }));
                }
                count = 0;
            }
            for (int i = 0; i < list.Count; i++)
            {
                chart1.Series["Temp1"].Points.Add(int.Parse(list[i].Temp1));
                chart1.Series["Humi1"].Points.Add(int.Parse(list[i].Humi1));
                chart1.Series["Dust1"].Points.Add(int.Parse(list[i].Dust1));
            }
            count++;
        }

        private void prodEnvInfoClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
