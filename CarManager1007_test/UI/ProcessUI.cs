#define THREAD_PAUSE

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

namespace CarManager0811.UI
{
    public partial class processUI : Form
    {
        public delegate int delMessage(object sender, string strResult);
        public event delMessage eventDelMessage;
        // true: 신호받음, false: 신호 없음
#if THREAD_PAUSE
        ManualResetEvent pauseEvent = new ManualResetEvent(true);
#endif
        string strWorkName;
        Thread thread;

        // CS0414 오류
        // 변수 사용 예외 처리
        bool threadStop = false; // flag

        // S2292 오류
        // 비쥬얼 스튜디오에서 만들어준 코드 예외 처리
        public string StrWorkName { get => strWorkName; set => strWorkName = value; }

        public processUI()
        {
            InitializeComponent();
        }

        public processUI(string str)
        {
            InitializeComponent();
            workName.Text = StrWorkName = str;
        }

        public void threadStart()
        {
            thread = new Thread(new ThreadStart(Run));
            thread.Start(); // 작업 쓰레드 시작
        }

        public void threadPause()
        {
            // 이벤트 상태를 신호 없음으로 설정하여 스레드 차단
            pauseEvent.Reset();
        }

        public void threadResume()
        {
            // 대기중인 스레드를 진행할 수 있도록 이벤트 상태를 신호받음으로 설정
            pauseEvent.Set();
        }

        private void Run()
        {
            try
            {
                int cnt = 0;
                Random r = new Random();
#if THREAD_PAUSE
                while(pauseEvent.WaitOne())
#else
                // 작업 쓰레드 영역
                while(workProgress.Value < 100 && !threadStop)
#endif
                {
                    // 작업 쓰레드에서 UI 쓰레드로 접근 가능한지 체크
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() =>
                        {
                            cnt = r.Next(1, 11);
                            if(workProgress.Value + cnt > 100)
                            {
                                workProgress.Value = 100;
#if THREAD_PAUSE
                                threadStop = true;
                                eventDelMessage(this, "작업 완료!");
#endif
                            }
                            else
                            {
                                workProgress.Value += cnt;
                            }
                            processView.Text = string.Format("진행 상황 표시 : {0}%",
                                workProgress.Value);
                        }));
                        Thread.Sleep(500);
                    }
                }

#if !THREAD_PAUSE
                if(threadStop == true)
                {
                    eventDelMessage(this, "작업 중지!");
                }
                else
                {
                    eventDelMessage(this, "작업 완료!");
                }
                //Close();
                //threadAbort();
#endif
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine("인트럽트 오류: " + e.Message);
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("쓰레드 취소 : " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("알수없는 오류: " + e.Message);
            }
        }

        public void threadAbort()
        {
            // 쓰레드 실행 상태 확인 - 동작 중일때 if문 진입
            if (thread.IsAlive)
            {
                threadStop = true;
                thread.Abort();
                thread.Join();
            }
        }

        public void theadInterrupt()
        {
            if (thread.IsAlive)
            {
                thread.Interrupt();
            }
        }

        private void workStop_Click(object sender, EventArgs e)
        {
#if !THREAD_PAUSE
            if (thread.IsAlive)
            {
                threadStop = true;
            }
#else
            if(workStop.Text.Equals("작업 중지"))
            {
                workStop.Text = "작업 재시작";
                workName2.Text = "공정이 중지 되었습니다.";
                eventDelMessage(this, "작업 중지!");
            }
            else if(workStop.Text.Equals("작업 재시작"))
            {
                workStop.Text = "작업 중지";
                workName2.Text = "공정이 진행중입니다.";
                eventDelMessage(this, "작업 재시작!");
            }
#endif
        }
    }
}
