using MaterialSkin.Controls;
using MESDesign_code.Adapter;
using MESDesign_code.Model;
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
    partial class MaterialPlusUI : MaterialForm
    {
        MaterialAdapter matAda;
        public MaterialPlusUI()
        {
            InitializeComponent();
        }

        public MaterialPlusUI(MaterialAdapter matAda)
        {
            InitializeComponent();
            this.matAda = matAda;
        }

        private void MaterialPlus_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
        }

        private void materialPlusOK_Click(object sender, EventArgs e)
        {
            string code = materialPlusCode.Text;
            string name = materialPlusName.Text;
            string price = materialPlusPrice.Text;

            Material mat = new Material(code, name, price);
            matAda.addToList(mat);
            Close();
        }

        private void materialPlusClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
