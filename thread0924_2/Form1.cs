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

namespace thread0924_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("UI 쓰레드");
                Thread.Sleep(1000);
            }
            Task task1 = new Task(new Action(showAction));
            task1.Start();

            Task task2 = new Task(delegate { showDelegate(); });
            task2.Start();

            Task task3 = new Task(() => showLamda());
            task3.Start();

            Task task4 = new Task(() =>
            {
                showLamdaEx();
                Console.WriteLine("##############");
            });
            task4.Start();

            Task.Run(() => doWork());

            Task.Run(async () => await doWork2());
        }

        async Task doWork()
        {
            await Task.Run(() => showDoWork());
        }

        int getSum(int a, int b)
        {
            return a + b;
        }

        async Task doWork2()
        {
            int sum = await Task.FromResult(getSum(100, 200));
            Console.WriteLine("결과: " + sum);
        }

        void showDoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("showDoWork 동작");
                Thread.Sleep(1000);
            }
        }

        void showAction()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("task1 동작");
                Thread.Sleep(1000);
            }
        }

        void showDelegate()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("task2 동작");
                Thread.Sleep(1000);
            }
        }

        void showLamda()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("task3 동작");
                Thread.Sleep(1000);
            }
        }

        void showLamdaEx()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("task4 동작");
                Thread.Sleep(1000);
            }
        }
    }
}
