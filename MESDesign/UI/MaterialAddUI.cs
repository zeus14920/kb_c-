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
    partial class MaterialAddUI : MaterialForm
    {
        MaterialAdapter matAda;
        public MaterialAddUI()
        {
            InitializeComponent();
        }

        public MaterialAddUI(MaterialAdapter matAda)
        {
            InitializeComponent();
            this.matAda = matAda;
        }

        private void custAddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaterialAddUI_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
            List<Material> mat = matAda.getMaterialPlusDB();

            for(int i = 0; i < mat.Count; i++)
            {
                materialCode.Items.Add(mat[i].Code);
            }
        }

        private void materialAddOK_Click(object sender, EventArgs e)
        {
            string code = materialCode.SelectedText;
            string wearing = materialWearing.Text;
            int iWear = int.Parse(wearing);
            string invertory = "0";
            int iInv = int.Parse(invertory);
            iInv += iWear;
            invertory = Convert.ToString(iInv);

            //-----------------------------------------
            // 사용자가 입력한 정상적인 데이터를 처리
            //-----------------------------------------
            Material mat = new Material(code,wearing, invertory);
            matAda.addToMatList(mat);
            MessageBox.Show("입고 등록이 되었습니다.");
            Close();
        }

        private void materialCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Material> mat = matAda.getMaterialPlusDB();
            for (int i = 0; i < mat.Count; i++)
            {
                if(materialCode.SelectedItem.ToString()==mat[i].Code)
                {
                    materialName.Text = mat[i].Name;
                    materialPrice.Text = mat[i].Price;
                }
            }
        }
    }
}
