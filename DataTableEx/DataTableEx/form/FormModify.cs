using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableEx
{
    public partial class FormModify : Form
    {
        private DataRow row = null;
        public DataRow Row
        {
            get
            {
                return row;
            }
            set
            {
                this.row = value;
            }
        }

        public FormModify()
        {
            InitializeComponent();
        }
        public FormModify(DataRow row) : this()
        {
            this.row = row;
            tboxModName.Text = row["NAME"].ToString();
            if (row["SEX"].Equals("남자"))
            {
                rdoModSexMale.Checked = true;
            }
            else
            {
                rdoModSexFemale.Checked = true;
            }
            tboxModRef.Text = row["REF"].ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            row["NAME"] = tboxModName.Text;
            if (rdoModSexMale.Checked)
            {
                row["SEX"] = "남자";
            }
            else
            {
                row["SEX"] = "여자";
            }
            row["REF"] = tboxModRef.Text;

            this.Close();
        }
    }
}
