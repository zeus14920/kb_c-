using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thread0924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 작업(work) 쓰레드 정의
            Thread threadA = new Thread(() =>
            {
                for(int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("A");
                    Thread.Sleep(1000); // 1000ms
                }
            });
            // 작업 쓰레드 시작
            threadA.Start();

            // 작업(work) 쓰레드 정의
            Thread threadB = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("work threadB");
                    Thread.Sleep(1000); // 1000ms
                }
            });
            // 작업 쓰레드 시작
            threadB.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("UI threadB");
                Thread.Sleep(1000); // 1000ms
            }
        }
    }
}
