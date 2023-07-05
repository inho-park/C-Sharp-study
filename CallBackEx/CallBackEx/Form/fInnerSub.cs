using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallBackEx
{
    public partial class fInnerSub : Form, iCommon
    {
        public fInnerSub()
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
            lblInnerSub.BackColor = color;
        }

        public void fInit()
        {
            lblInnerSub.Text = String.Format("{0} Call", this.Text);
        }
        #endregion

        private void fInnerSub_Load(object sender, EventArgs e)
        {
            fInit();
        }

        private void btnDelCallback_Click(object sender, EventArgs e)
        {
            cDelCallBack fSub = new cDelCallBack();
            fSub.dCall = fDelCall;
            fSub.fStart();
        }
        private string fDelCall(string strMsg)
        {
            int iMsg = int.Parse(strMsg);
            Invoke(new Action(delegate ()
            {
                tsCount.Text = $"{iMsg}%";
                tsProgress.Value = iMsg;
                btnDelCallback.Text = (iMsg < 100) ? "Playing" : "Delegate CallBack Start";
            }));

            return iMsg.ToString();
        }
    }
}
