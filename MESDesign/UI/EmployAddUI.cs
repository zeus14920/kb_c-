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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESDesign.UI
{
    partial class EmployAddUI : MaterialForm
    {
        EmployAdapter employeeAda;
        public EmployAddUI()
        {
            InitializeComponent();
        }

        public EmployAddUI(EmployAdapter employeeAda)
        {
            InitializeComponent();
            this.employeeAda = employeeAda;
        }

        private void custAddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployAddUI_Load(object sender, EventArgs e)
        {
            CommUtil.initTheme(this);
        }

        private void employAddOK_Click(object sender, EventArgs e)
        {
            string name = employName.Text;
            string tel = employTel.Text;
            string depart = employDepart.Text;
            string position = employPosition.Text;
            string work = employWork.Text;

            string gender = "";
            if (employMan.Checked == true)
            {
                gender = "남";
            }
            else if (employWoman.Checked == true)
            {
                gender = "여";
            }

            string[] dataArr = new string[]
            {
                name, tel, depart, position, work, gender
            };

            string[] errMsg = new string[]
            {
                "이름 정보가 누락되었습니다.",
                "성별 정보가 누락되었습니다.",
                "전화번호 정보가 누락되었습니다.",
                "부서 정보가 누락되었습니다.",
                "직급 정보가 누락되었습니다.",
                "업무 정보가 누락되었습니다."
            };

            // 정보 누락 체크
            for (int i = 0; i < dataArr.Length; i++)
            {
                if (dataArr[i] == "")
                {
                    MessageBox.Show(errMsg[i]);
                    // void 메쏘드에서는 메쏘드를 탈출
                    return;
                }
            }

            // 한글 이름 체크
            Regex regex = new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                MessageBox.Show("잘못된 이름 정보입니다.");
                ActiveControl = employName;
                employName.Focus();
                //custName.Text = "";
                return;
            }

            // 전화번호 체크
            Regex regexTel = new Regex(@"^01{1}[01]{1}[0-9]{7,8}$");
            Match m2 = regexTel.Match(tel);
            if (m2.Success == false)
            {
                MessageBox.Show("잘못된 전화번호 정보입니다.");
                return;
            }

            Employee employ = new Employee(name, gender, tel,
                depart, position, work);
            MessageBox.Show("고객정보가 등록되었습니다.");
            employeeAda.addToList(employ);
            Close();
        }
    }
}
