using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SImpleClicker
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        CXMLControl _xml = new CXMLControl();
        string strPath = Application.StartupPath + "\\Save.xml";

        private double tick = 0;
        private double total = 0;

        private int add1 = 1;
        private int level1 = 1;

        private int add3 = 0;
        private int level3 = 0;

        private int add50 = 0;
        private int level50 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(strPath))
            {
                _dData = _xml.fxmlReader(strPath);

                tick = double.Parse(_dData[CXMLControl._TICK]);
                total = double.Parse(_dData[CXMLControl._TOTAL]);
                level1 = int.Parse(_dData[CXMLControl._LEVEL_1]);
                level3 = int.Parse(_dData[CXMLControl._LEVEL_3]);
                level50 = int.Parse(_dData[CXMLControl._LEVEL_50]);
            }

            // Timer : UI Timer 이기 때문에 바로 사용 가능 Threading, Timers 의 TImer 같은 경우 
            // 직접 호출이 안되고 Invoke 대리자를 통해 호출
            // 별도의 Thread 를 사용하지 않고 Form  자체의 Single Thread 를 사용, 시간에 맞춰서 함수만 호출해 주는 역할을 하기 때문에
            // 함수 호출 중에는 프로그램이 멈춤

            // form 의 타이머 객체 생성
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            // 타이머 실행
            timer.Enabled = true;
            // 타이머 틱 단위 설정
            timer.Interval = 100; // 100 = 0.1sec
            timer.Tick += Timer_Tick;
            timer.Start();

            //timer.Stop();
        }

        /// <summary>
        /// 타이머에서 호출할 이벤트 ( Interval 간격 기준 )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // 폼은 씽글 스레드로 시간을 점유하기 때문에 시간을 가질 수 없음
            // 아래 코드 주석 해제 시 5초에 한번씩 카운트가 오른다
            //for (int i = 0; i < 5; i++)
            //{
            //    Thread.Sleep(1000);
            //}
            tick = add1 + add3 + add50;
            total += tick;
            lblPoint.Text = string.Format("{0} (1 : {1}),   (3 : {2}),   (50 : {3})", tick.ToString(), level1.ToString(), level3.ToString(), level50.ToString());
            lblTotal.Text = total.ToString();
        }

        private void Click_Button(object sender, EventArgs e)
        {
            string tag = (sender as Button).Tag.ToString();
            switch (tag)
            {
                case "1":
                    if (total >= 100)
                    {
                        total -= 100;
                        level1++;
                        add1 += 1 * level1;
                    }
                    break;
                case "5":
                    if (total >= 500)
                    {
                        total -= 500;
                        level3++;
                        add3 += 3 * level3;
                    }
                    break;
                case "50":
                    if (total >= 5000)
                    {
                        total -= 5000;
                        level50++;
                        add50 += 50 * level50;
                    }
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dData.Clear();
            _dData.Add(CXMLControl._TICK, tick.ToString());
            _dData.Add(CXMLControl._TOTAL, total.ToString());
            _dData.Add(CXMLControl._LEVEL_1, level1.ToString());
            _dData.Add(CXMLControl._LEVEL_3, level3.ToString());
            _dData.Add(CXMLControl._LEVEL_50, level50.ToString());

            _xml.fxmlWriter(strPath, _dData);
        }
    }
}
