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
    public partial class productionTwoTeamUI : MaterialForm
    {
        public productionTwoTeamUI()
        {
            InitializeComponent();
        }

        private void productionTwoTeamUI_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
        }

        private void productionTwoTeamClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
