using CarManager0811.Handler;
using CarManager0811.Model;
using CarManager0811.Util;
using CarManager0902.Model;
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

namespace CarManager0902
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
        }

        public SalesUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void SalesUI_Load(object sender, EventArgs e)
        {
            CommouUtil.colorListHeader(salesListView, Color.Indigo, Color.White);
            // S1117 오류
            // 사용자 매개변수임으로 예외 처리
            // S1481 오류
            // list를 사용함으로 예외 처리
            List<SalesVo> list = adapter.getSalesDB();
            initListView3();
        }

        private void salesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (salesListView.SelectedItems.Count != 0)
            {
                int n = salesListView.SelectedItems[0].Index;
                // S1117 오류
                // 사용자 매개변수임으로 예외 처리
                string carName = salesListView.Items[n].SubItems[1].Text;
                string name = salesListView.Items[n].SubItems[4].Text;
                string tel = salesListView.Items[n].SubItems[5].Text;

                List<HobbyVo> hbList = adapter.getHobbyVo(name);
                List<string> hobList = new List<string>();
                List<Customer> cusList = adapter.getCustomerVo(name, tel);
                List<Car> carList = adapter.getCarVo(carName);
                Console.WriteLine("취미1" + hbList[0].Hb1);
                hobList.Add(hbList[0].Hb1);
                Console.WriteLine("취미2" + hbList[0].Hb2);
                hobList.Add(hbList[0].Hb2);
                Console.WriteLine("취미3" + hbList[0].Hb3);
                hobList.Add(hbList[0].Hb3);
                Console.WriteLine("취미4" + hbList[0].Hb4);
                hobList.Add(hbList[0].Hb4);
                Console.WriteLine("취미5" + hbList[0].Hb5);
                hobList.Add(hbList[0].Hb5);
                Console.WriteLine("취미6" + hbList[0].Hb6);
                hobList.Add(hbList[0].Hb6);
                custGridView.Rows.Clear();
                initGridView(hobList);

                custListView.Items.Clear();
                initListView4(cusList);

                carListView.Items.Clear();
                initListView5(carList);

                
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
            // S1117 오류
            // 사용자 매개변수임으로 예외 처리
            List<SalesVo> list = adapter.getSalesDB();
            salesListViewAdd(list);

            CommouUtil.setRowColor(salesListView, Color.Yellow, Color.Red);
        }

        void initListView4(List<Customer> cusList)
        {
            for (int i = 0; i < cusList.Count; i++)
            {
                custListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        cusList[i].Name,
                        cusList[i].Tel,
                        cusList[i].Addr,
                        cusList[i].Date,
                        cusList[i].Birth,
                        cusList[i].Gender
                    }));
            }
        }

        void initListView5(List<Car> carList)
        {
            for (int i = 0; i < carList.Count; i++)
            {
                carListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        carList[i].Name,
                        carList[i].Color,
                        carList[i].Price.ToString(),
                        carList[i].InsuDate,
                        carList[i].Manager
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

        void initGridView(List<string> hobList)
        {
            for (int i = 0; i < hobList.Count; i++)
            {
                custGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(), hobList[i]
                });
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            salesListView.Items.Clear();
            custListView.Items.Clear();
            carListView.Items.Clear();
            string searchcombo = selectSearchComboBox.SelectedText;
            string searchtext = searchTextBox.Text;

            if(searchcombo == "차종")
            {
                // S1117 오류
                // 사용자 매개변수임으로 예외 처리
                List<SalesVo> list = adapter.getSearchCarNameVo(searchtext);
                salesListViewAdd(list);
            }
            else
            {
                // S1117 오류
                // 사용자 매개변수임으로 예외 처리
                List<SalesVo> list = adapter.getSearchCusNameVo(searchtext);
                salesListViewAdd(list);
            }
        }

        void salesListViewAdd(List<SalesVo> list)
        {
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

        private void searchUnion_Click(object sender, EventArgs e)
        {
            // S1117 오류
            // 사용자 매개변수임으로 예외 처리
            string carName = searchCar.Text;
            string custName = searchCust.Text;
            string jupsuDate = searchJupsu.Text;
            string manager = searchManager.Text;

            string[] searchArr = new string[]
            {
                carName,custName,jupsuDate,manager
            };

            // S1117 오류
            // 사용자 매개변수임으로 예외 처리
            List<SalesVo> list = adapter.getSearchUnionDB(searchArr);
            searchListView(list);
        }
        void searchListView(List<SalesVo> list)
        {
            salesListView.Items.Clear();
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
    }
}
