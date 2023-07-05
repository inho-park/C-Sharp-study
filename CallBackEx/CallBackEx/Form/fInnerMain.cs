using CallBackEx.Class;
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

namespace CallBackEx
{
    public partial class fInnerMain : Form, iCommon, iCallBack
    {
        
        public fInnerMain()
        {
            InitializeComponent();
        }

        #region Interface 구현
        public string strfrmName
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        public void fColorChange(Color color)
        {
            lblInnerMain.BackColor = color;
        }

        public void fInit()
        {
            lblInnerMain.Text = $"{this.Text} Call";
        }
        #endregion

        private void fInnerMain_Load(object sender, EventArgs e)
        {
            fInit();
        }

        #region Loop Check
        bool flag = false;
        Thread _thread;
        cClassCallBack _fClassMain;
        private void btnStatusLoopCheck_Click(object sender, EventArgs e)
        {
            _fClassMain = new cClassCallBack();
            _fClassMain.fStart(); // 비동기로 요청 (내부에서 Thread 별도 동작)

            fProgressCheck(); // 상태를 체크할 로직 (별도 THread)
        }

        private void fProgressCheck()
        {
            _thread = new Thread(pCheck);
            _thread.Start();
        }

        private void pCheck()
        {
            int iCheck = 0;
            while (_fClassMain._iProgressLog <= 100) 
            {
                Invoke(new Action(delegate ()
                {
                    iCheck = _fClassMain._iProgressLog;
                    tsCount.Text = $"{iCheck}%";
                    tsProgress.Value = iCheck;

                    btnStatusLoopCheck.Text = (iCheck < 100) ? "Playing" : "Status Loop Check Start";
                }));
                Thread.Sleep(300);
            }
            _thread.Join();
        }
        #endregion

        // Interface CallBack
        private void btnInterfaceCallback_Click(object sender, EventArgs e)
        {
            cInterCallBack fMain = new cInterCallBack(this);
            fMain.fStart();
        }

        public string fCallBackMessage(string strMsg)
        {
            int iMsg = int.Parse(strMsg);
            Invoke(new Action(delegate ()
            {
                // 인터페이스로 콜백 응답 받음
                tsCount.Text = "{iMsg}";
                tsProgress.Value = iMsg;

                btnInterfaceCallback.Text = (iMsg < 100) ? "Playing" : "Interface CallBack Start";
            }));
            return iMsg.ToString();
        }
    }
}
