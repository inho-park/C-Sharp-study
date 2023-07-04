using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forEachEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int [] arr = new int [int.Parse(tboxNum.Text)];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i + 1;
                }
                foreach (int i in arr) {
                    cboxResult.Items.Add(i.ToString() + "번쨰 아이템");
                }
                cboxResult.SelectedIndex = 0;
            } catch(Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lboxResult.Items.Add(cboxResult.SelectedItem.ToString());
            cboxResult.Items.RemoveAt(cboxResult.SelectedIndex);
            cboxResult.SelectedIndex = 0;
        }
    }
}
