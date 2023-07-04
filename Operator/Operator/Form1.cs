using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator
{
    public partial class Form1 : Form
    {
        enum Animal { mouse, cat, bird, dog = 100, koala, pig = 200, lion };

        public Form1()
        {
            InitializeComponent();
            
        }
        private void tboxResult_TextChanged(object sender, EventArgs e)
        {
            tboxResultBit.Text = Convert.ToString(int.Parse(tboxResult.Text), 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            int temp = int.Parse(tboxResult.Text);
            int number = int.Parse(tboxNumber.Text);

            result = temp << number;
            tboxResult.Text = result.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int result = 0;
            int temp = int.Parse(tboxResult.Text);
            int number = int.Parse(tboxNumber.Text);

            result = temp >> number;
            tboxResult.Text = result.ToString();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(tboxResult.Text);
            int number = int.Parse(tboxNumber.Text);

            temp *= number;
            tboxResult.Text = temp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(tboxResult.Text);
            int number = int.Parse(tboxNumber.Text);

            temp -= number;
            tboxResult.Text = temp.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(tboxResult.Text);
            tboxResult.Text = (++temp).ToString();
            tboxResultAfter.Text = (temp).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(tboxResult.Text);
            tboxResult.Text = (temp++).ToString();
            tboxResultAfter.Text = (temp).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int temp1 = int.Parse(tboxResult.Text);
            int temp2 = int.Parse(tboxResultAfter.Text);
            int number = int.Parse(tboxNumber.Text);

            bool result = (temp1 > number && temp2 > number);
            tboxAndOr.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int temp1 = int.Parse(tboxResult.Text);
            int temp2 = int.Parse(tboxResultAfter.Text);
            int number = int.Parse(tboxNumber.Text);

            bool result = (temp1 > number || temp2 > number);
            tboxAndOr.Text = result.ToString();
        }
    }
}
