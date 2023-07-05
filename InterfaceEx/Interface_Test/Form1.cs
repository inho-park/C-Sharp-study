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
    public partial class Form1 : Form
    {
        int iMainFormCount = 1;
        int iSubFormCount = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form생성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInnerMain childForm = new fInnerMain();
            childForm.strfrmName = $"Main Form #{iMainFormCount++}";
            // deefault 최상위 컨트롤로 되어있으므로 false 로 바꿔줌
            childForm.TopLevel = false;
            pMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void subFrom생성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInnerSub childForm = new fInnerSub();
            childForm.strfrmName = $"Sub Form #{iSubFormCount++}";
            childForm.TopLevel = false;
            pMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void 선택Form색상변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();

            if(cDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var oform in pMain.Controls)
                {
                    /*
                            if(oform is fInnerMain)
                            {
                                fInnerMain fMain = oform as fInnerMain;
                                fMain.fColorChange(cDialog.Color);
                            }
                            else if(oform is fInnerMain)
                            {
                                fInnerMain fMain = oform as fInnerMain;
                                fMain.fColorChange(cDialog.Color);
                            }
                    */

                    // interface 구현 (Class 간의 결합도를 낮춰 Interface Function 호출)
                    iCommon icom = oform as iCommon;
                    icom.fColorChange(cDialog.Color);
                }
            }

        }
    }
}
