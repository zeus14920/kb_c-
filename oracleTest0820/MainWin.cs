using oracleTest0820.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oracleTest0820
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            OraMgr.Instance.connectDB();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createTable_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.createTable();
        }

        private void dropTable_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.dropTable();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 1000; i++)
            {
                OraMgr.Instance.insertDB();
            }            
        }

        private void select_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.showDB();
        }
    }
}
