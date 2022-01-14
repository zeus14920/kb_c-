using CarManager0811.Handler;
using CarManager0902.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0902.UI
{
    partial class AddCarUI : UserControl
    {
        List<Car> list;
        BaseAdapter adapter;
        public AddCarUI()
        {
            InitializeComponent();
        }

        public AddCarUI(List<Car> list)
        {
            InitializeComponent();
            this.list = list;
        }

        public AddCarUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void carAddOK_Click(object sender, EventArgs e)
        {
            string name = carName.Text;
            string color = carColor.Text;
            int price = int.Parse(carPrice.Text);
            string manager = carManager.Text;

            // 인수 날짜
            // DatePicker box
            DateTime date = carInDate.Value;
            string strDate = string.Format("{0}년 {1}월 {2}일",
                date.Year, date.Month, date.Day);

            Car car = new Car(name, color, price, strDate, manager);
            adapter.addToList(car);
            MessageBox.Show("차량정보가 등록되었습니다.");
        }
    } 
}
