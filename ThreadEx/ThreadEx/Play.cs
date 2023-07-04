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

namespace ThreadEx
{
    public partial class Play : Form
    {
        public delegate int delMessage(object sender, string result);
        public event delMessage eventdelMessage;
        Thread _thread = null;
        string _playerName = string.Empty;
        public string PlayerName { get { return _playerName; } set { _playerName = value; }}

        public ManualResetEvent ManualResetEvent;


        ThreadClass tc = new ThreadClass();


        public Play()
        {
            InitializeComponent();

        }
        
        public Play(string playerName)
        {
            InitializeComponent();

            lblPlayerName.Text = PlayerName = playerName;
        }

        public void ThreadStart()
        {
            //// Thread 시작하기 1 : ThreadStart delegate 타입 객체 생성 후 함수를 넘김
            ////_thread = new Thread(new System.Threading.ThreadStart(Run));

            //// Thread 시작하기 2 : 컴파일러에서 delegate 객체를 추론해서 생성 후 함수를 넘김
            ////_thread = new Thread(Run);

            //// Thread 시작하기 3 : 
            //_thread = new Thread(Run);
            //_thread.IsBackground = true;
            //_thread.Start();

            //ManualResetEvent.Set();

            //ManualResetEvent.Reset();
            tc.ThreadStart();
         


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tc.ThreadStop();
            //ThreadJoin();

            //ManualResetEvent.Set();

        }

        /// <summary>
        /// 스레드가 동작 중일 경우 종료시킴
        /// 창 닫기 버튼을 눌렀을 때도 프로그레스 바를 채우던 Thread 들이 종료를 해야함 => public
        /// </summary>
        public void ThreadAbort()
        {
            // Thread 동작 유무 판별
            if (_thread.IsAlive)
            {
                _thread.Abort(); // 강제 종료
            }
        }

        public void ThreadJoin()
        {
            if (_thread.IsAlive)
            {
                bool threadEnd = _thread.Join(3000);
            }
        }

        public void ThreadInterrupt()
        {
            if (_thread.IsAlive)
            {
                _thread.Interrupt();
            }
        }

        private void Play_Load(object sender, EventArgs e)
        {
            tc.eventdelMessage += Tc_eventdelMessage;
        }

        private void Tc_eventdelMessage(int Value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    pbarPlayer.Value = Value;
                    lblProgress.Text = string.Format("{0}%", Value);
                }));
            }

        }
    }
}
