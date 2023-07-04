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
using System.Xml;

namespace UsingXML
{
    public partial class Form1 : Form
    {
        CXMLControl _XML = new CXMLControl();
        Dictionary<string, string> _DData = new Dictionary<string, string>();

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

            _DData.Clear();
            _DData.Add(CXMLControl._TEXT_DATA, strText);
            _DData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _DData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.xml |All files (*.*)|*.*";

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                _XML.fxmlWriter(SFDialog.FileName, _DData);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            OFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            OFDialog.FileName = "*.xml";
            OFDialog.Filter = "xml files (*.xml)|*.xml |All files (*.*)|*.*";

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                
                sb.Append(File.ReadAllText(OFDialog.FileName));
                tboxConfigData.Text = sb.ToString();

                _DData.Clear();
                _DData = _XML.fxmlReader(OFDialog.FileName);
            }
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            tboxData.Text = _DData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_DData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_DData[CXMLControl._NUMBER_DATA]);

        }
    }
}
