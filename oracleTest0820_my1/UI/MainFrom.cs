using oracleTest0820_my1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oracleTest0820_my1
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();

            //Console.WriteLine("----------------------");
            //Console.WriteLine("DB 연습 프로그램 V1.0");
            //Console.WriteLine("----------------------");
            //Console.WriteLine("1. 테이블 생성");
            //Console.WriteLine("2. 테이블 삭제");
            //Console.WriteLine("3. 프로그램 종료");
            //Console.WriteLine("----------------------");
            //Console.Write("메뉴를 선택하세요: ");
            //string num = Console.ReadLine();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            OraMgr.Instance.connectDB();
        }

        private void ProExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createTabel_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.createTable();
        }

        private void dropTable_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.dropTable();
        }

        private void addRandomDB_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5000; i++)
            {
                if (OraMgr.Instance.addRandomDB() == false)
                {
                    break;
                }
            }
            MessageBox.Show("데이터 삽입 성공");
        }

        private void allDataDB_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.allDateDB();
        }
    }
}
