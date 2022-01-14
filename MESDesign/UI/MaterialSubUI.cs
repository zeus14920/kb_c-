using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESDesign.UI
{
    public partial class MaterialSubUI : MaterialForm
    {
        public MaterialSubUI()
        {
            InitializeComponent();
        }

        private void materialSubClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
