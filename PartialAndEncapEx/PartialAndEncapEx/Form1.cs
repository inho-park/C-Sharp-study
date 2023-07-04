using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartialAndEncapEx
{
    public partial class Form1 : Form
    {
        CData _Data = new CData();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnumItem[] ei = (EnumItem [])Enum.GetValues(typeof(EnumItem));

            foreach(EnumItem oitem in ei)
            {
                cboxItem.Items.Add(oitem.ToString());
            }

            foreach(EnumRate oitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(oitem.ToString());
            }
        }
    }
}
