using MaterialSkin.Controls;
using MESDesign.Adapter;
using MESDesign.Model;
using MESDesign.Util;
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
    partial class MaterialManagementUI : MaterialForm
    {
        MaterialAdapter matAda;
        public MaterialManagementUI()
        {
            InitializeComponent();
        }

        public MaterialManagementUI(MaterialAdapter matAda)
        {
            InitializeComponent();
            this.matAda = matAda;
        }

        private void materialAddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialAdd_Click(object sender, EventArgs e)
        {
            new MaterialAddUI(matAda).ShowDialog();
        }

        void initListView(List<Material> matList)
        {
            materialListView.Items.Clear();
            for (int i = 0; i < matList.Count; i++)
            {
                materialListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        matList[i].Code,
                        matList[i].Name,
                        matList[i].Price,
                        matList[i].Wearing,
                        matList[i].Invertory,
                        matList[i].Time
                    }
                    ));
            }
        }

        

        private void MaterialManagementUI_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
            List<Material> matList = matAda.getMaterialDB();
            initListView(matList);

        }

        private void MaterialManagementUI_Activated(object sender, EventArgs e)
        {
            List<Material> matList = matAda.getMaterialDB();
            initListView(matList);
        }

        private void matterialPlus_Click(object sender, EventArgs e)
        {
            new MaterialPlusUI(matAda).ShowDialog();
        }

        private void materialSub_Click(object sender, EventArgs e)
        {

        }
    }
}
