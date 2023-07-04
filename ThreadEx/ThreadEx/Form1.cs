using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadEx
{
    enum EnumPlayer
    {
        aaa,
        bbb,
        ccc,
        ddd,
        eee
    }

    public partial class Form1 : Form
    {

        int _locationX = 0;
        int _locationY = 0;

        public Form1()
        {
            InitializeComponent();

            _locationX = this.Location.X;
            _locationY = this.Location.Y;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;

            for (int i = 0; i < numPlayerCount.Value; i++)
            {
                Play play = new Play(((EnumPlayer)i).ToString());
                play.Location = new Point(_locationX, _locationY + play.Height * i);

                play.eventdelMessage += Play_eventdelMessage;
                play.Show();
                play.ThreadStart();


            }
        }

        private int Play_eventdelMessage(object sender, string result)
        {
            // 요청한 스레드가 현재 Main Thread 에 있는 Control 을 엑세스할 수 있는 지 확인
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    Play playerForm = sender as Play;
                    lboxResult.Items.Add(string.Format("Player : {0}, Text : {1}", playerForm.PlayerName, result));
            
                }));
            }
            return 0;
        }
    }
}
