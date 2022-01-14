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

namespace CarManager0811.UI
{
    public partial class ValeoOrder : Form
    {
        int totalCount = 0;
        public delegate int delOrderComplete(string strResult, int count);
        public event delOrderComplete eventOrderComplete;
        public ValeoOrder()
        {
            InitializeComponent();
        }

        public void orderCheck(Dictionary<string, int> orderDic)
        {
            foreach(KeyValuePair<string, int> order in orderDic)
            {
                string strType = string.Empty;
                int count = order.Value;
                switch (order.Key)
                {
                    // DDC
                    case "더블 클러치":
                    case "클러치 헥츄에이터":
                    case "External Damper":
                        strType = "[DDC]";
                        break;

                    // HP
                    case "CSC":
                    case "DAMPER":
                    case "CMC":
                    case "CRC":
                        strType = "[HP]";
                        break;

                    // DMF
                    case "C-DMF":
                    case "Pendulum DMF":
                    case "Dual Mass Dumper":
                        strType = "[DMF]";
                        break;
                }
                totalCount += count;
                lboxMake.Items.Add(string.Format("{0} {1} {2}개가 주문되었습니다.", strType, order.Key, count));
                Refresh();
                Thread.Sleep(500);
            }// end foreach
            lboxMake.Items.Add("============================");
            lboxMake.Items.Add("주문 검사 완료되었습니다.");
            btnClose.Text = "검사완료";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int ret = eventOrderComplete("발주 주문이 완료 되었습니다.", totalCount);
            if(ret == 0)
            {
                Console.WriteLine("주문 완료 확인되었습니다.");
            }
            else
            {
                Console.WriteLine("주문 오류가 발생하였습니다.");
            }
            Close();
        }
    }
}
