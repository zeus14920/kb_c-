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
    // 사용자 정의 상수 변수
    enum DDC_ORDER
    {
        DOUBLE_CLUTCH = 1,
        CLUTCH_ACTUATOR,
        EXTERNAL_DAMPER
    }
    
    enum HP_ORDER
    {
        CSC =1,
        DAMPER,
        CMC,
        CRC
    }

    enum DMF_ORDER
    {
        C_DMF = 1,
        P_DMF,
        DMD
    }

    partial class OrderUI : UserControl
    {
        // 리턴 값을 int형으로 가지고 int형의 매개변수를 가진다.
        public delegate int delFuncDDC(int i);
        public delegate int delFuncDMF(string strOrder, int ea);
        int totalPrice;
        ValeoOrder valeoOrder;
        List<string> orderList = new List<string>();
        MainUI mainObj;
        public OrderUI()
        {
            InitializeComponent();
            ddc1.Checked = true;
            hp1.Checked = true;
        }

        public OrderUI(MainUI mainObj)
        {
            InitializeComponent();
            ddc1.Checked = true;
            hp1.Checked = true;
            this.mainObj = mainObj;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // <키, 값>
            Dictionary<string, int> valOrder = new Dictionary<string, int>();
            delFuncDDC delDdc = new delFuncDDC(fDdcOrder);
            delFuncDDC delHp = new delFuncDDC(fHpOrder);
            delFuncDMF delDmf = null;

            int ddcOrder = 0;
            int hpOrder = 0;

            // DDC
            if (ddc1.Checked)
            {
                ddcOrder = (int)DDC_ORDER.DOUBLE_CLUTCH;
                valOrder.Add("더블 클러치", (int)ddcNum.Value);
            }
            else if (ddc2.Checked)
            {
                ddcOrder = (int)DDC_ORDER.CLUTCH_ACTUATOR;
                valOrder.Add("클러치 엑츄에이터", (int)ddcNum.Value);
            }
            else if (ddc3.Checked)
            {
                ddcOrder = (int)DDC_ORDER.EXTERNAL_DAMPER;
                valOrder.Add("External Damper", (int)ddcNum.Value);
            }

            if((int)ddcNum.Value <= 0)
            {
                MessageBox.Show("[DDC] 품목 수량을 입력하세요!");
                return;
            }

            // HP
            if (hp1.Checked)
            {
                hpOrder = (int)HP_ORDER.CSC;
                valOrder.Add("CSC", (int)hpNum.Value);
            }
            else if (hp2.Checked)
            {
                hpOrder = (int)HP_ORDER.DAMPER;
                valOrder.Add("DAMPER", (int)hpNum.Value);
            }
            else if (hp3.Checked)
            {
                hpOrder = (int)HP_ORDER.CMC;
                valOrder.Add("CMC", (int)hpNum.Value);
            }
            else if (hp4.Checked)
            {
                hpOrder = (int)HP_ORDER.CRC;
                valOrder.Add("CRC", (int)hpNum.Value);
            }

            if ((int)hpNum.Value <= 0)
            {
                MessageBox.Show("[HP] 품목 수량을 입력하세요!");
                return;
            }

            int ddcTotalPrice = fCallBackDelegate(ddcOrder, delDdc);
            Console.WriteLine("DDC 합계: " + ddcTotalPrice);
            int hpTotalPrice = fCallBackDelegate(hpOrder, delHp);
            Console.WriteLine("HP 합계: " + hpTotalPrice);
            Console.WriteLine("DDC + HP 합계: " + totalPrice);

            // DMF 체크
            if (c_dmf.Checked)
            {
                if (!dmfValueCheck())
                {
                    return;
                }
                delDmf += c_dmfCheck;
                valOrder.Add("C-DMF", (int)dmfNum.Value);
            }

            if (p_dmf.Checked)
            {
                if ((int)dmfNum.Value <= 0)
                {
                    MessageBox.Show("[DMF] 품목 수량을 입력하세요!");
                    totalPrice = 0;
                    return;
                }
                delDmf += p_dmfCheck;
                valOrder.Add("Pendulum DMF", (int)dmfNum.Value);
            }
            if (dmd.Checked)
            {
                if ((int)dmfNum.Value <= 0)
                {
                    MessageBox.Show("[DMF] 품목 수량을 입력하세요!");
                    totalPrice = 0;
                    return;
                }
                delDmf += dmdCheck;
                valOrder.Add("Dual Mass Damper", (int)dmfNum.Value);
            }
            if(delDmf != null)
            {
                delDmf("DMF 시스템", (int)dmfNum.Value);
            }
            orderList.Add("-------------------------------");
            orderList.Add(string.Format("총 발주 견적은 {0}원 입니다.", totalPrice.ToString("C")));
            
            totalPrice = 0;
            callOrder(valOrder);
        }

        private bool dmfValueCheck()
        {
            if ((int)dmfNum.Value <= 0)
            {
                MessageBox.Show("[DMF] 품목 수량을 입력하세요!");
                totalPrice = 0;
                return false;
            }
            return true;
        }

        private void callOrder(Dictionary<string, int> orderDic)
        {
            if(valeoOrder != null)
            {
                valeoOrder.Dispose();
                valeoOrder = null;
            }

            valeoOrder = new ValeoOrder();
            valeoOrder.eventOrderComplete += onValeoOrderComplete;

            int mainX = mainObj.Location.X;
            int mainY = mainObj.Location.Y;
            int mainW = mainObj.Size.Width;
            int mainH = mainObj.Size.Height;

            int childW = valeoOrder.Size.Width;
            int childH = valeoOrder.Size.Height;

            valeoOrder.Show();
            valeoOrder.Location = new Point(
                mainX + (mainW /2)-(childW /2),
                mainY + (mainH / 2) - (childH / 2));
            valeoOrder.orderCheck(orderDic);
        }

        private int onValeoOrderComplete(string strResult, int count)
        {
            orderList.Add("--------------------------------");
            orderList.Add(string.Format("{0} / 총 주문 제품: {1}", strResult, count));
            foreach(var order in orderList)
            {
                detailOrder.Items.Add(order);
            }

            if (count > 0) return 0;
            else return -1;
        }

        private int dmdCheck(string order, int ea)
        {
            int iPrice = ea * 70000;
            string strOrder =
                string.Format("[DMF 시스템] Dual Mass Damper {0} {1}개를 선택: " +
                "{2}원 (1EA ￦70,000)", order, ea, iPrice.ToString("C"));
            orderList.Add(strOrder);
            totalPrice += iPrice;
            return iPrice;
        }

        private int p_dmfCheck(string order, int ea)
        {
            int iPrice = ea * 60000;
            string strOrder =
                string.Format("[DMF 시스템] Pendulum DMF {0} {1}개를 선택: " +
                "{2}원 (1EA ￦60,000)", order, ea, iPrice.ToString("C"));
            orderList.Add(strOrder);
            totalPrice += iPrice;
            return iPrice;
        }

        private int c_dmfCheck(string order, int ea)
        {
            int iPrice = ea * 50000;
            string strOrder = string.Format("[DMF 시스템] C-DMF {0} {1}개를 선택: " +
                "{2}원 (1EA ￦50,000)", order, ea, iPrice.ToString("C"));
            orderList.Add(strOrder);
            totalPrice += iPrice;
            return iPrice;
        }

        public int fCallBackDelegate(int i, delFuncDDC dFunc)
        {
            return dFunc(i);
        }

        private int fDdcOrder(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;
            if(iOrder == (int)DDC_ORDER.DOUBLE_CLUTCH)
            {
                iPrice = 100000 * (int)ddcNum.Value;
                strOrder = string.Format("[DDC] Double Clutch 선택 : {0}원 {1}개", 
                    iPrice.ToString("C"), ddcNum.Value);
            }
            else if (iOrder == (int)DDC_ORDER.CLUTCH_ACTUATOR)
            {
                iPrice = 110000 * (int)ddcNum.Value;
                strOrder = string.Format("[DDC] Clutch Actuator 선택 : {0}원 {1}개",
                    iPrice.ToString("C"), ddcNum.Value);
            }
            else if (iOrder == (int)DDC_ORDER.EXTERNAL_DAMPER)
            {
                iPrice = 120000 * (int)ddcNum.Value;
                strOrder = string.Format("[DDC] External Damper 선택 : {0}원 {1}개",
                    iPrice.ToString("C"), ddcNum.Value);
            }
            orderList.Add(strOrder);
            totalPrice += iPrice;
            return iPrice;
        }

        private int fHpOrder(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;
            if (iOrder == (int)HP_ORDER.CSC)
            {
                iPrice = 60000 * (int)hpNum.Value;
                strOrder = string.Format("[HP] CSC 선택 : {0}원 {1}개",
                    iPrice.ToString("C"), hpNum.Value);
            }
            else if (iOrder == (int)HP_ORDER.DAMPER)
            {
                iPrice = 70000 * (int)hpNum.Value;
                strOrder = string.Format("[HP] DAMPER 선택 : {0}원 {1}개",
                    iPrice.ToString("C"), hpNum.Value);
            }
            else if (iOrder == (int)HP_ORDER.CMC)
            {
                iPrice = 80000 * (int)hpNum.Value;
                strOrder = string.Format("[HP] CMC 선택 : {0}원 {1}개",
                    iPrice.ToString("C"), hpNum.Value);
            }
            else if (iOrder == (int)HP_ORDER.CRC)
            {
                iPrice = 90000 * (int)hpNum.Value;
                strOrder = string.Format("[HP] CRC 선택 : {0}원 {1}개",
                    iPrice.ToString("C"), hpNum.Value);
            }
            orderList.Add(strOrder);
            totalPrice += iPrice;
            return iPrice;
        }
    }
}
