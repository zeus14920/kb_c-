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
    partial class ProductionManagInfoUI : MaterialForm
    {
        ThingSpeak ts = new ThingSpeak();
        ThingSpeakTimer rTimer;
        Random r = new Random();

        public ProductionManagInfoUI()
        {
            InitializeComponent();
            rTimer = new ThingSpeakTimer(new Timer(new TimerCallback(readProManagHandler), null, 2000, 60000));
        }

        public void readProManagHandler(object args)
        {
            List<LineProduce> list = ts.readLineDateThingSpeak();
            for (int i = 0; i < list.Count; i++)
            {
                // work 스레드에서 UI스레드 사용
                Invoke(new Action(delegate ()
                {
                    productionTime.Text = list[i].Time;
                    productionFinished.Text = list[i].Finished;
                    productiondeFective.Text = list[i].Defective;
                    Console.WriteLine("#### 생산관리정보에서 출력 ####");
                }));
                Console.WriteLine("시간: " + list[i].Time);
                Console.WriteLine("부품 1라인 양품: " + list[i].Finished + " ");
                Console.WriteLine("부품 1라인 불량품: " + list[i].Defective + " ");
            }
        }

        private void prodManagInfoClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void prodManagInfoClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        void initListView(List<LineProduce> lineProdList)
        {
            lineProdListView.Items.Clear();
            for (int i = 0; i < lineProdList.Count; i++)
            {
                lineProdListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        lineProdList[i].Time,
                        "자재1",
                        lineProdList[i].Finished,
                        lineProdList[i].Defective,
                        "알수 없음"
                    }
                    ));
            }
        }

        private void ProductionManagInfoUI_Load(object sender, EventArgs e)
        {
            List<LineProduce> lineProdList = OraMgr.Instance.getLineProduceVo();
            initListView(lineProdList);
        }
    }
}
