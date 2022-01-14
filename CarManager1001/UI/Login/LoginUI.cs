using CarManager0902;
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

namespace CarManager0811.UI
{
    public partial class LoginUI : Form
    {
        // Main을 객체화 시켜 메소드 사용
        MainUI mainUi;
        public LoginUI()
        {
            InitializeComponent();
            passwd.PasswordChar = '■';
        }

        public LoginUI(object sender)
        {
            InitializeComponent();
            mainUi = sender as MainUI;
            passwd.PasswordChar = '■';
        }

        private void loginOK_Click(object sender, EventArgs e)
        {
            if(OraMgr.Instance.login(passwd.Text) == "성공")
            {
                MessageBox.Show("성공");
                // 관리자 모드 진입
                mainUi.controllView(new AdminUI(), MainUI.UC_NAME_ADMIN);
                Close();
            }
            else
            {
                MessageBox.Show("비밀번호를 다시 입력하세요.");
            }
        }

        private void loginCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
