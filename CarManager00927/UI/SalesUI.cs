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

            initListView3();
        }

        private void SalesUI_Load(object sender, EventArgs e)
        {
            List<SalesVo> list = adapter.getSalesDB();
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("번호: " + (i+1).ToString());
                Console.WriteLine("차량명: " + list[i].CarName);
                Console.WriteLine("가격: " + list[i].Price);
                Console.WriteLine("인수날짜: " + list[i].InsuDate);
                Console.WriteLine("고객명: " + list[i].CustName);
                Console.WriteLine("연락처: " + list[i].CustTel);
                Console.WriteLine("접수날짜: " + list[i].JupsuDate);
                Console.WriteLine("담당자: " + list[i].Manager);
                Console.WriteLine("==============================");
            }
        }

        private void salesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (salesListView.SelectedItems.Count != 0)
            {
                int n = salesListView.SelectedItems[0].Index;
                Console.WriteLine("n : " + n);
                string num = salesListView.Items[n].SubItems[0].Text;
                string name = salesListView.Items[n].SubItems[1].Text;
                string tel = salesListView.Items[n].SubItems[2].Text;

                Console.WriteLine("번호: " + num);
                Console.WriteLine("이름: " + name);
                Console.WriteLine("전화: " + tel);

                List<string> hbList = list[n].HobbyList;
                for (int i = 0; i < hbList.Count; i++)
                {
                    Console.WriteLine("취미: " + hbList[i]);
                }
                custGridView.Rows.Clear();
                //initGridView(hbList);
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

        /*void initGridView(List<string> hbList)
        {
            for (int i = 0; i < hbList.Count; i++)
            {
                custGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(), hbList[i]
                });
            }
        }*/
    }
}
