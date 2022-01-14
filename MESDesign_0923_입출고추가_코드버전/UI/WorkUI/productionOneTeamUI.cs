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
    public partial class productionOneTeamUI : MaterialForm
    {
        public productionOneTeamUI()
        {
            InitializeComponent();
        }

        private void productionOneTeamUI_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
        }

        private void productionOneTeamClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
