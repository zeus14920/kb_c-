using MaterialSkin.Controls;
using MESDesign.Adapter;
using MESDesign.Model;
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
    partial class MaterialSubUI : MaterialForm
    {
        MaterialAdapter matAda;
        public MaterialSubUI()
        {
            InitializeComponent();
        }

        public MaterialSubUI(MaterialAdapter matAda)
        {
            InitializeComponent();
            this.matAda = matAda;
        }

        private void materialSubClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaterialSubUI_Load(object sender, EventArgs e)
        {
            List<Material> mat = matAda.getMaterialPlusDB();

            for (int i = 0; i < mat.Count; i++)
            {
                materialCode.Items.Add(mat[i].Code);
            }
        }

        private void materialCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Material> mat = matAda.getMaterialPlusDB();
            for (int i = 0; i < mat.Count; i++)
            {
                if (materialCode.SelectedItem.ToString() == mat[i].Code)
                {
                    materialName.Text = mat[i].Name;
                    materialPrice.Text = mat[i].Price;
                }
            }
        }

        private void materialSubOK_Click(object sender, EventArgs e)
        {
            string code = materialCode.SelectedText;
            string shipping = materialShipping.Text;
            int iShipping = int.Parse(shipping);
            string invertory = "0";
            int iInv = int.Parse(invertory);
            iInv -= iShipping;
            invertory = Convert.ToString(iInv);

            //-----------------------------------------
            // 사용자가 입력한 정상적인 데이터를 처리
            //-----------------------------------------
            Material mat = new Material(code);
            MaterialAddSub matAddSub = new MaterialAddSub(null, shipping, invertory);
            matAda.subToMatList(mat, matAddSub);
            MessageBox.Show("출고 등록이 되었습니다.");
            Close();
        }
    }
}
