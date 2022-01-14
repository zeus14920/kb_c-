using MaterialSkin;
using MaterialSkin.Controls;
using MESDesign_code.Adapter;
using MESDesign_code.DBO;
using MESDesign_code.UI;
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

namespace MESDesign_code
{
    public partial class MainUI : MaterialForm
    {
        EmployAdapter employAda = new EmployAdapter();
        MaterialAdapter matAda = new MaterialAdapter();
        ThingSpeakTimer sTimer;
        InfoWriteAdapter infoAdapter = new InfoWriteAdapter();

        public MainUI()
        {
            InitializeComponent();
            OraMgr.Instance.connectDB();
            // 온도, 습도, 미세먼지, 양품, 불량품 데이터 쓰기
            sTimer = new ThingSpeakTimer(new Timer(new TimerCallback(infoAdapter.writeHandler), null, 0, 20000));
        }

        private void employManag_Click(object sender, EventArgs e)
        {
            new EmployeeManagementUI(employAda).ShowDialog();
        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialManag_Click(object sender, EventArgs e)
        {
            new MaterialManagementUI(matAda).ShowDialog();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
        }

        private void workCalenButton2_Click(object sender, EventArgs e)
        {
            new WorkCalendarUI().ShowDialog();
        }

        private void productionEnvInfo_Click(object sender, EventArgs e)
        {
            productionEnvInfo sen = new productionEnvInfo();
            sen.ShowDialog();
        }

        private void productionManagInfo_Click(object sender, EventArgs e)
        {
            ProductionManagInfoUI manag = new ProductionManagInfoUI();
            manag.ShowDialog();
        }
    }
}
