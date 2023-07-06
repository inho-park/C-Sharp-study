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
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet(); // 학급들에 대한 정보를 가지고 있을 DataSet
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckTable = false;
            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckTable = true;
            }
            DataTable dt = null;
            if (!bCheckTable)
            {
                dt = new DataTable(cboxRegClass.Text);
                DataColumn colClass = new DataColumn("Class", typeof(string));
                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colClass);
                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);

            }
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }

            // 추가할 데이터 Row객체 생성
            DataRow row = dt.NewRow();
            row["NAME"] = tboxRegName.Text;
            
            if (rdoRegSexMale.Checked)
            {
                row["SEX"] = "남자";
            }
            else
            {
                row["SEX"] = "여자";
            }
            row["REF"] = tboxRegRef.Text;

            if (bCheckTable)
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }
            cboxViewClass_SelectedIndexChanged(this, null);
        }
        private void btnViewDataMod_Click(object sender, EventArgs e)
        {
            if (dgViewInfo.SelectedRows.Count == 0 || dgViewInfo.SelectedRows.Count > 1)
            {
                return;
            }
            // 바꿀 열 객체 만들기
            DataTable dt = ds.Tables[cboxViewClass.Text];
            int index = dgViewInfo.SelectedRows[0].Index;
            DataRow row = dt.Rows[index];
            FormModify formModify = new FormModify(row);
            formModify.Show();
        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables[cboxViewClass.Text];
            foreach(DataGridViewRow row in dgViewInfo.SelectedRows)
            {
                dt.Rows[row.Index].Delete();
            }
            cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];

            // DatagridView Call 정렬 및 Number 적용
            foreach (DataGridViewRow row in dgViewInfo.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

    }
}
