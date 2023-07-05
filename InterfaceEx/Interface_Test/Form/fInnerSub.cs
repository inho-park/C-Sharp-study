using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Test
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
    }
}
