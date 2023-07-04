using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassEx
{
    public partial class Form1 : Form
    {
        Cat cat;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property 를 사용할 때는 반드시 Property 로만 호출해야함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = tboxCat.Text.Split(' ');
                cat = new Cat(str[0], int.Parse(str[1]));
                lblMom.Text = "엄마 고양이 이름 : " + cat.Name;
            }
            catch(Exception ex)
            {
                lblException.Text = ex.StackTrace;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                lblCnt.Text = (Cat.cnt++).ToString();
                Cat kitty = new Cat(cat);
                lboxKitties.Items.Add((kitty.Name + kitty.Age));
            }
            catch(Exception ex)
            {
                lblException.Text = ex.StackTrace;
            }
        }
    }
}
