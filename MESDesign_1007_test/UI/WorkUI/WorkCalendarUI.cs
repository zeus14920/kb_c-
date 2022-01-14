using MaterialSkin.Controls;
using MESDesign_code.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESDesign_code.UI
{
    public partial class WorkCalendarUI : MaterialForm
    {
        public WorkCalendarUI()
        {
            InitializeComponent();
        }

        private void WorkCalendarUI_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
        }

        private void productionExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productionOneTeam_Click(object sender, EventArgs e)
        {
            new productionOneTeamUI().ShowDialog();
        }

        private void productionTwoTeam_Click(object sender, EventArgs e)
        {
            new productionTwoTeamUI().ShowDialog();
        }
    }
}
