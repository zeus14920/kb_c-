using MaterialSkin.Controls;
using MESDesign_code.Adapter;
using MESDesign_code.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESDesign_code.UI
{
    partial class EmployeeManagementUI : MaterialForm
    {
        EmployAdapter employAda;
        public EmployeeManagementUI()
        {
            InitializeComponent();
        }

        public EmployeeManagementUI(EmployAdapter employAda)
        {
            InitializeComponent();
            this.employAda = employAda;
        }

        private void custAddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employAdd_Click(object sender, EventArgs e)
        {
            new EmployAddUI(employAda).ShowDialog();
        }

        void initListView(List<Employee> empList)
        {
            employeeListView.Items.Clear();
            for (int i = 0; i < empList.Count; i++)
            {
                employeeListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        empList[i].Name,
                        empList[i].Gender,
                        empList[i].Tel,
                        empList[i].Depart,
                        empList[i].Position,
                        empList[i].Work
                    }
                    ));
            }
        }

        private void EmployeeManagementUI_Load(object sender, EventArgs e)
        {
            show();
        }

        private void EmployeeManagementUI_Activated(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            List<Employee> empList = employAda.getEmployeeDB();
            initListView(empList);
        }
    }
}
