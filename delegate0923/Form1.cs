using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate0923
{
    // delegate 선언 가능
    public delegate void testDelegateA(int arg);

    public partial class Form1 : Form
    {
        // 대리자
        // 1. 사용자 정의 메세지 전달로 활용
        // 2. 이벤트 핸들러 활용
        // C/C++ 함수 포인터 역활
        public delegate void testDelegate(int arg);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // delegateA가 testMethod() 역활을 대리로 수행
            delegate0923.testDelegateA delegateA = testMethod;
            delegateA(100);
            // 일반 메소드 생성
            testMethod(100);

            // delegate 익명 메소드
            testDelegate delegateB = delegate (int b)
            {
                Console.WriteLine($"delegateB 사용:{b}");
            };
            delegateB(200);

            // 람다식
            testDelegate delegateC = (int c) =>
            {
                Console.WriteLine("delegateC 사용:{0}", c);
            };
            delegateC(300);
        }

        void testMethod(int a)
        {
            // 표현식 3가지
            Console.WriteLine($"delegateA 사용:{a}");
            Console.WriteLine("delegateA 사용:{0}", a);
            Console.WriteLine("delegateA 사용:" + a);
        }
    }
}
