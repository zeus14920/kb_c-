using iotApp0907.DAO;
using iotApp0907.Model;
using iotApp0907.Util;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Timer = System.Threading.Timer;

namespace iotApp0907
{
    public partial class MainUI : MaterialForm
    {
        ThingSpeak ts = new ThingSpeak();
        ThingSpeakTimer sTimer, rTimer;

        string[] temp = { "15", "22", "38", "41", "57", "63", "77", "84", "92", "104" };
        string[] humi = { "15", "22", "38", "41", "57", "63", "77", "84", "92", "104" };

        Random r = new Random();

        public MainUI()
        {
            InitializeComponent();
            OraMgr.Instance.connectDB();
            sTimer = new ThingSpeakTimer(new Timer(new TimerCallback(writeHandler), null, 1000, 20000));
            rTimer = new ThingSpeakTimer(new Timer(new TimerCallback(readHandler), null, 2000, 20000));
        }

        void writeHandler(object args)
        {
            string time = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:ss");
            string temp1 = temp[r.Next(10)];
            string humi1 = humi[r.Next(10)];
            string temp2 = temp[r.Next(10)];
            string humi2 = humi[r.Next(10)];
            bool chk = ts.sendDateToThingSpeak(temp1, humi1,
                    temp2, humi2, null, null, null, null);
            if (chk == true)
            {
                Console.WriteLine("데이터 전송 성공!");
            }
            else
            {
                Console.WriteLine("데이터 전송 실패!");
            }
            OraMgr.Instance.insertDB(new LineEnvData(time, temp1, humi1, temp2, humi2));
        }

        void readHandler(object args)
        {
            List<LineEnvData> list = ts.readThingSpeak();
            for (int i = 0; i < list.Count; i++)
            {
                Invoke(new Action(delegate ()
                {
                    lineAddTime.Text = list[i].Time;
                    lineOneTemp.Text = list[i].Temp1;
                    lineOnehumi.Text = list[i].Humi1;
                    lineTwoTempAnalogMeter.Value = Convert.ToDouble(list[i].Temp2);
                    lineTwoHumiAnalogMeter.Value = Convert.ToDouble(list[i].Humi2);
                }));

                Console.WriteLine("시간: " + list[i].Time);
                Console.WriteLine("부품 1라인 온도: " + list[i].Temp1 + " ℃");
                Console.WriteLine("부품 1라인 습도: " + list[i].Humi1 + " %");
                Console.WriteLine("부품 2라인 온도: " + list[i].Temp2 + " ℃");
                Console.WriteLine("부품 2라인 습도: " + list[i].Humi2 + " %");

                Console.WriteLine("[부품 라인 모니터링 정보]");
                int nTemp1 = Convert.ToInt32(list[i].Temp1);
                if (nTemp1 < 20)
                {
                    lineOneTempBulb.Color = Color.Red;
                    Console.WriteLine("[온도 낮음]부품 1라인 히터 가동중입니다.");
                    new SoundPlayer(Properties.Resources.siren).Play();
                }
                else if (nTemp1 > 21 && nTemp1 < 70)
                {
                    lineOneTempBulb.Color = Color.Green;
                    Console.WriteLine("부품 1라인 정상 가동중입니다.");
                }
                else
                {
                    lineOneTempBulb.Color = Color.Red;
                    Console.WriteLine("[온도 높음]부품 1라인 에어컨 가동중입니다.");
                    new SoundPlayer(Properties.Resources.siren).Play();
                }
                Console.WriteLine("==================================");
                initCommChart(list);
                OraMgr.Instance.showDB();
            }
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            initBarChart();
        }

        static int count = 0;
        void initCommChart(List<LineEnvData> list)
        {
            if (chart1.Series[0].Points.Count >2)
            {
                foreach (var series in chart1.Series)
                {
                    Invoke(new Action(delegate ()
                    {
                        //series.Points.Clear();
                        series.Points.RemoveAt(0);
                    }));
                }
                Console.WriteLine("count 초기화");
                count = 0;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Invoke(new Action(delegate ()
                {
                    chart1.Series["chartTemp1"].Points.Add(int.Parse(list[i].Temp1));
                    chart1.Series["chartTemp1"].LegendText = "1라인 온도";
                    chart1.Series["chartHumi1"].Points.Add(int.Parse(list[i].Humi1));
                    chart1.Series["chartHumi1"].LegendText = "1라인 습도";
                    chart1.Series["chartTemp2"].Points.Add(int.Parse(list[i].Temp2));
                    chart1.Series["chartTemp2"].LegendText = "2라인 온도";
                    chart1.Series["chartHumi2"].Points.Add(int.Parse(list[i].Humi2));
                    chart1.Series["chartHumi2"].LegendText = "2라인 습도";
                }));
            }
            Console.WriteLine("count 1 증가");
            count++;
        }

        void initCommChart2(List<LineEnvData> list)
        {
            foreach (var series in chart1.Series)
            {
                Invoke(new Action(delegate ()
                {
                    series.Points.Clear();
                }));
            }
            for (int i = 0; i < list.Count; i++)
            {
                Invoke(new Action(delegate ()
                {
                    chart1.Series[i].Points.AddXY("1라인 온도",int.Parse(list[i].Temp1));
                    chart1.Series[i].Points[0].Color = Color.Red;
                    chart1.Series[i].Points[0].Label = list[i].Temp1;
                    chart1.Series[i].Points[0].BackGradientStyle =
                        GradientStyle.LeftRight;

                    chart1.Series[i].Points.AddXY("1라인 습도",int.Parse(list[i].Humi1));
                    chart1.Series[i].Points[1].Color = Color.Blue;
                    chart1.Series[i].Points[1].Label = list[i].Humi1;
                    chart1.Series[i].Points[1].BackGradientStyle =
                        GradientStyle.LeftRight;

                    chart1.Series[i].Points.AddXY("2라인 온도",int.Parse(list[i].Temp2));
                    chart1.Series[i].Points[2].Color = Color.Pink;
                    chart1.Series[i].Points[2].Label = list[i].Temp2;
                    chart1.Series[i].Points[2].BackGradientStyle =
                        GradientStyle.LeftRight;

                    chart1.Series[i].Points.AddXY("2라인 습도",int.Parse(list[i].Humi2));
                    chart1.Series[i].Points[3].Color = Color.Green;
                    chart1.Series[i].Points[3].Label = list[i].Humi2;
                    chart1.Series[i].Points[3].BackGradientStyle =
                        GradientStyle.LeftRight;
                }));
            }
        }

        void initBarChart()
        {
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "생산1라인";
            option.Title.SubText = "온도 상태";

            // 범례(Legend)
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("온도");
            option.Legend.AddData("습도");

            option.ToolTip = new UIBarToolTip();
            var series = new UIBarSeries();
            series.Name = "Temp";
            series.AddData(11);
            series.AddData(15);
            series.AddData(28);
            series.AddData(37);
            option.Series.Add(series);

            option.XAxis.Data.Add("21년9월3일");
            option.XAxis.Data.Add("21년9월4일");
            option.XAxis.Data.Add("21년9월5일");
            option.XAxis.Data.Add("21년9월6일");
            option.YAxis.Scale = true;

            option.XAxis.Name = "시간";
            option.YAxis.Name = "온도";
            uiBarChart1.SetOption(option);
        }

        void initPieChart()
        {
            var option = new UIPieOption();
            option.Title = new UITitle();
            option.Title.Text = "생산2라인";
            option.Title.SubText = "습도 상태";
            option.Title.Left = UILeftAlignment.Center;
            option.ToolTip = new UIPieToolTip();

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("온도");
            option.Legend.AddData("습도");
            option.Legend.AddData("미세먼지");

            var series = new UIPieSeries();
            series.Name = "Humi";
            series.Center = new UICenter(50, 50);
            series.Radius = 70;
            series.AddData("온도", 38);
            series.AddData("습도", 40);
            series.AddData("미세먼지", 32);
            option.Series.Add(series);
            uiPieChart1.SetOption(option);
        }
    }
}
