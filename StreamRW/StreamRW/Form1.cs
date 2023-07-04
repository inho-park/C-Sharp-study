using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamRW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + "\r\n");
            sb.Append(bChecked.ToString() + "\r\n");
            sb.Append(iNumber.ToString());

            tboxConfigData.Text = sb.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;
            SFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files (*.txt)|*.txt |All files (*.*)|*.*";

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                // 파일 쓰는 방법 1
                //strFilePath = SFDialog.FileName;
                //StreamWriter swSFDialog = new StreamWriter(strFilePath);
                //swSFDialog.WriteLine(tboxConfigData.Text);
                //swSFDialog.Close();

                // 파일 쓰는 방법 2
                File.WriteAllText(SFDialog.FileName, tboxConfigData.Text);
                
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            OFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt |All files (*.*)|*.*";

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                // 파일 읽는 방법 1
                //StreamReader srOFDialog = new StreamReader(OFDialog.FileName, Encoding.UTF8, true);
                //while (srOFDialog.EndOfStream == false)
                //{
                //    sb.Append(srOFDialog.ReadLine() + "\r\n");
                //}

                // 파일 읽는 방법 2
                //sb.Append(File.ReadAllText(OFDialog.FileName));

                // 파일 읽는 방법 3
                foreach (string line in File.ReadAllLines(OFDialog.FileName)) 
                    sb.Append(line + "\n");

                tboxConfigData.Text = sb.ToString();
            }

        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            string[] strConfig = tboxConfigData.Text.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            tboxData.Text = strConfig[0];
            cboxData.Checked = bool.Parse(strConfig[1]);
            numData.Value = int.Parse(strConfig[2]);
        }
    }
}
