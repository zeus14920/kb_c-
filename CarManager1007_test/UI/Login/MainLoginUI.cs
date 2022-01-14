using CarManager0811.Handler;
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
    public partial class MainLoginUI : Form
    {
        public delegate void eventMainLogin(string userName);
        public event eventMainLogin eventLogin;

        public MainLoginUI()
        {
            InitializeComponent();

            // 원래는 디자인에서 form load 이벤트를 연결할 수 있으나,
            // 코드에서 직접 이벤트를 연결
            this.Load += onMainLogin;
        }

        void onMainLogin(object obj, EventArgs ev)
        {
            Console.WriteLine("로그인 폼 로드");
            mainLoginOK.Click += (sender, args) =>
             {
                 MainLoginHandler loginHandler = new MainLoginHandler();
                 if (emptyCheck())
                 {
                     if(loginHandler.loginCheck(mainUser.Text, mainPasswd.Text))
                     {
                         string userName = mainUser.Text;
                         eventLogin(userName);
                         DialogResult = DialogResult.OK;
                     }
                     else
                     {
                         MessageBox.Show("로그인 정보가 일치하지 않습니다.", "알림",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         mainUser.Clear();
                         mainPasswd.Clear();
                     }
                 }
             };
            mainLoginCancel.Click += (sender, args) =>
            {
                Console.WriteLine("취소 버튼 클릭");
                DialogResult dialogResult = MessageBox.Show("프로그램을 종료하시겠습니까?",
                    "프로그램 종료", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
            };
            mainLoginCancel.Click += testBtnClick;
        }

        void testBtnClick(object o, EventArgs arg)
        {
            MessageBox.Show("취소를 선택했습니다.");
        }

        private bool emptyCheck()
        {
            if (string.IsNullOrEmpty(mainUser.Text))
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mainUser.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(mainPasswd.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mainPasswd.Focus();
                return false;
            }
            return true;
        }
    }
}
