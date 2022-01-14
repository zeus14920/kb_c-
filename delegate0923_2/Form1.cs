using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate0923_2
{
    public partial class Form1 : Form
    {
        delegate int TestDele(int a, int b);
        delegate void TestDele2();
        delegate void myFunc(int a, int b);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestDele addDelegate = new TestDele(add);
            Console.WriteLine("덧셈: {0}", addDelegate(100, 200));

            // 다수의 메소드를 한번에 실행하는 delegate
            TestDele2 dele2 = new TestDele2(print1);
            dele2 += new TestDele2(print2);
            dele2 += new TestDele2(print3);
            dele2();

            // 매개변수가 없고 실행문이 1줄인 경우의 기본 람다식
            Action action1 = () => Console.WriteLine("1줄 실행문 사용");
            action1();

            // 하나의 매개변수와 실행문이 1줄인 람다식
            int res = 0;
            Action<int> action2 = (x) => res = x + 100;
            action2(100);
            Console.WriteLine("res:{0}", res);

            Action<int, int> action3 = (x, y) =>
            {
                int sum = x + y;
                Console.WriteLine($"{sum} = {x} + {y}");
                Console.WriteLine("{0} = {1} + {2}", sum, x, y);
            };
            action3(100, 200);

            myFunc testFunc = (n1, n2) =>
            {
                if (n1 > n2)
                {
                    Console.WriteLine("{0}이 {1}보다 크다", n1, n2);
                }
                else
                {
                    Console.WriteLine("{0}이 {1}보다 크다", n2, n1);
                }
            };
            testFunc(100, 200);
        }

        int add(int a, int b)
        {
            return a + b;
        }

        void print1()
        {
            Console.WriteLine("print1");
        }
        void print2()
        {
            Console.WriteLine("print2");
        }
        void print3()
        {
            Console.WriteLine("print3");
        }
    }
}
