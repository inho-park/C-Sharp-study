using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceEx
{
    public partial class Form1 : Form
    {
        COneCycle _COC;
        CCycle _CC;
        CCar _Car;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _COC = new COneCycle("외발 자전거");
            _CC = new CCycle("자전거");
            _Car = new CCar("자동차");
        }


        private void btnOnecycle_Click(object sender, EventArgs e)
        {
            cleanPanel();
            OneCyleDraw();
        }
        /// <summary>
        /// OneCycle 에 대한 그림 그리기
        /// </summary>
        private void OneCyleDraw()
        {
            lblName.Text = _COC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _COC.fPenInfo();
            g.DrawRectangle(p, _COC._rtSquare1);
            g.DrawEllipse(p, _COC._rtCircle1);
        }
        

        private void btnCycle_Click(object sender, EventArgs e)
        {
            cleanPanel();
            CycleDraw();
        }
        /// <summary>
        /// Cycle 에 대한 그림 그리기
        /// </summary>
        private void CycleDraw()
        {
            lblName.Text = _CC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _CC.fPenInfo();
            g.DrawRectangle(p, _CC._rtSquare1);
            g.DrawEllipse(p, _CC._rtCircle1);
            g.DrawEllipse(p, _CC._rtCircle2);
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            cleanPanel();
            CarDraw();
        }
        /// <summary>
        /// Car 에 대한 그림 그리기
        /// </summary>
        private void CarDraw()
        {
            lblName.Text = _Car.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _Car.fPenInfo();
            g.DrawRectangle(p, _Car._rtSquare1);
            g.DrawRectangle(p, _Car._rtSquare2);
            g.DrawEllipse(p, _Car._rtCircle1);
            g.DrawEllipse(p, _Car._rtCircle2);
        }

        private void cleanPanel()
        {
            pMain.Invalidate();
            Refresh();
        }
    }
}
