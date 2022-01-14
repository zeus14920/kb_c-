using CarManager0811.Handler;
using CarManager0811.Model;
using oracleTest0827.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0827
{
    partial class SalesUI : UserControl
    {
        List<Customer> list;
        BaseAdapter adapter;
        public SalesUI()
        {
            InitializeComponent();
        }

        public SalesUI(List<Customer> list)
        {
            InitializeComponent();
            this.list = list;
            
            initListView2();
            //initGridView();
        }

        public SalesUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;

            //initListView3();
        }

        private void SalesUI_Load(object sender, EventArgs e)
        {
            List<SalesVo> list = adapter.getSalesDB();
            initListView3();
        }

        private void salesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (salesListView.SelectedItems.Count != 0)
            {
                int n = salesListView.SelectedItems[0].Index;
                string name = salesListView.Items[n].SubItems[4].Text;

                List<HobbyVo> hbList = adapter.getHobbyVo(name);
                List<string> strList = new List<string>();
                Console.WriteLine("취미1" + hbList[0].Hb1);
                strList.Add(hbList[0].Hb1);
                Console.WriteLine("취미2" + hbList[0].Hb2);
                strList.Add(hbList[0].Hb2);
                Console.WriteLine("취미3" + hbList[0].Hb3);
                strList.Add(hbList[0].Hb3);
                Console.WriteLine("취미4" + hbList[0].Hb4);
                strList.Add(hbList[0].Hb4);
                Console.WriteLine("취미5" + hbList[0].Hb5);
                strList.Add(hbList[0].Hb5);
                Console.WriteLine("취미6" + hbList[0].Hb6);
                strList.Add(hbList[0].Hb6);
                custGridView.Rows.Clear();
                initGridView(strList);
            }
        }

        void initListView2()
        {
            for (int i = 0; i < list.Count; i++)
            {
                salesListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        list[i].Name,
                        list[i].Tel,
                        list[i].Addr,
                        list[i].Date,
                        list[i].Birth,
                        list[i].Gender
                    }));
                Console.WriteLine("이름: " + list[i].Name);
                Console.WriteLine("전화: " + list[i].Tel);
                Console.WriteLine("주소: " + list[i].Addr);
            }
        }

        void initListView3()
        {
            List<SalesVo> list = adapter.getSalesDB();
            for (int i = 0; i < list.Count; i++)
            {
                salesListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        list[i].CarName,
                        list[i].Price.ToString(),
                        list[i].InsuDate,
                        list[i].CustName,
                        list[i].CustTel,
                        list[i].JupsuDate,
                        list[i].Manager
                    }));
            }
        }

        void initGridView()
        {
            string[] gridData =
            {
                "1", "잠자기"
            };
            custGridView.Rows.Add(gridData);

            for (int i = 0; i < 3; i++)
            {
                custGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(), "게임하기"
                });
            }
        }

        void initGridView(List<string> strList)
        {
            for (int i = 0; i < strList.Count; i++)
            {
                custGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(), strList[i]
                });
            }
        }
    }
}
