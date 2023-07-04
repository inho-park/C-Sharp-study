using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyEx.props;

namespace PropertyEx
{
    public partial class Form1 : Form
    {
        Aroma aroma;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                // this 사용하여 필드 변수 불러오기
                this.aroma = new Aroma();
                string[] str = tboxValue.Text.Split(' ');
                this.aroma.Itteki = double.Parse(str[0]);
                this.aroma[0] = int.Parse(str[1]);
                this.aroma[1] = int.Parse(str[2]);
            }
            catch (Exception ex)
            {
                lblException.Text = ex.StackTrace;
            }
            Aroma aroma = new Aroma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("drop : " + this.aroma.Itteki.ToString() + "\n");
                sb.Append("this[0] : " + this.aroma[0] + "\n");
                sb.Append("this[0] : " + this.aroma[1]);
                lblResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                lblException.Text = ex.StackTrace;
            }
        }
    }
}
