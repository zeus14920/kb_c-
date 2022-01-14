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

        void initListView(List<Material> matList, List<MaterialAddSub> addSubList)
        {
            materialListView.Items.Clear();
            List<string> strInven = sumInvertory(matList, addSubList);
            for (int i = 0; i < matList.Count; i++)
            {
                materialListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        matList[i].Code,
                        matList[i].Name,
                        matList[i].Price,
                        addSubList[i].Receiving,
                        addSubList[i].Shipping,
                        strInven[i],
                        addSubList[i].Time
                    }
                    ));
            }
        }

        private List<string> sumInvertory(List<Material> matList, List<MaterialAddSub> addSubList)
        {
            List<string> code = new List<string>();
            List<string> name = new List<string>();
            List<string> price = new List<string>();
            List<int> receiving = new List<int>();
            List<int> shipping = new List<int>();
            List<int> invertory = new List<int>();
            List<string> time = new List<string>();

            for (int i = 0; i < addSubList.Count; i++)
            {
                code.Add(matList[i].Code);
                name.Add(matList[i].Name);
                price.Add(matList[i].Price);
                receiving.Add(int.Parse(addSubList[i].Receiving));
                shipping.Add(int.Parse(addSubList[i].Shipping));
                time.Add(addSubList[i].Time);
            }
            for(int j = 0; j < addSubList.Count; j++)
            {
                if(receiving[j]==0 && shipping[j] ==0)
                {
                    invertory.Add(0);
                }
                else if (receiving[j] > 0 && shipping[j] == 0)
                {
                    for(int k = j-1; k >= 0; k--)
                    {
                        if (code[j] == code[k])
                        {
                            invertory.Add(invertory[k]+receiving[j]);
                            break;
                        }
                    }
                }
                else if (receiving[j] == 0 && shipping[j] > 0)
                {
                    for (int k = j-1; k >= 0; k--)
                    {
                        if (code[j] == code[k])
                        {
                            invertory.Add(invertory[k] - shipping[j]);
                            break;
                        }
                    }
                }
            }

            List<string> newInvertory = new List<string>();
            for (int l = 0; l < invertory.Count; l++)
            {
                newInvertory.Add(Convert.ToString(invertory[l]));
            }
            return newInvertory;
        }
        

        private void MaterialManagementUI_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
            List<Material> list = null;
            List<MaterialAddSub> addSubList = null;
            matAda.getMaterialDB(out list, out addSubList);
            initListView(list, addSubList);

        }

        private void MaterialManagementUI_Activated(object sender, EventArgs e)
        {
            List<Material> list = null;
            List<MaterialAddSub> addSubList = null;
            matAda.getMaterialDB(out list, out addSubList);
            initListView(list, addSubList);
        }

        private void matterialPlus_Click(object sender, EventArgs e)
        {
            new MaterialPlusUI(matAda).ShowDialog();
        }

        private void materialSub_Click(object sender, EventArgs e)
        {
            new MaterialSubUI(matAda).ShowDialog();
        }
    }
}
