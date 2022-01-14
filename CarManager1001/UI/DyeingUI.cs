using CarManager0902;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0811.UI
{
    enum dyeingProcess
    {
        방직,
        제직,
        염색,
        후가공,
        봉제
    }

    public partial class DyeingUI : UserControl
    {
        int locationX;
        int locationY;
        List<processUI> workList = new List<processUI>();
        MainUI mainUI;

        public DyeingUI()
        {
            InitializeComponent();
            locationX = this.Location.X;
            locationY = this.Location.Y;
        }

        public DyeingUI(MainUI mainUI)
        {
            InitializeComponent();
            locationX = this.Location.X;
            locationY = this.Location.Y;
            this.mainUI = mainUI;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            locationX = mainUI.Location.X + mainUI.Size.Width;
            locationY = mainUI.Location.Y;

            for(int i = 0; i < numWorkCount.Value; i++)
            {
                // processUI 객체가 생성
                // numWorkCount의 갯수 만큼 생성
                processUI workUI = new processUI(((dyeingProcess)i).ToString());
                //workUI.Location = new Point(locationX, locationY + workUI.Height * i);
                workUI.eventDelMessage += onEventDelMessage;
                workUI.Show();
                workUI.Location = new Point(locationX, locationY + workUI.Height * i);
                workUI.threadStart();
                workList.Add(workUI);
            }
            locationX = 0;
        }

        private void removeAllThread()
        {
            foreach(processUI ui in workList)
            {
                ui.threadAbort();
            }
        }

        private int onEventDelMessage(object sender, string strResult)
        {
            //if (this.InvokeRequired)
            //{
                this.Invoke(new Action(() =>
                {
                    processUI ui = sender as processUI;
                    lboxResult.Items.Add(string.Format("{0} {1}", ui.StrWorkName, strResult));

                    switch (strResult)
                    {
                        case "작업 중지!":
                            Console.WriteLine("{0} 작업 중지 요청", ui.StrWorkName);
                            ui.threadPause();
                            break;
                        case "작업 완료!":
                            Console.WriteLine("{0} 작업 완료 요청", ui.StrWorkName);
                            ui.threadAbort();
                            ui.Close();
                            break;
                        case "작업 재시작!":
                            Console.WriteLine("{0} 작업 재시작 요청중입니다.", ui.StrWorkName);
                            ui.threadResume();
                            break;
                    }

                }));
            //}
            return 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            removeAllThread();
        }
    }
}
