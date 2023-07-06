
namespace DataTableEx
{
    partial class FormModify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxModName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoModSexFemale = new System.Windows.Forms.RadioButton();
            this.rdoModSexMale = new System.Windows.Forms.RadioButton();
            this.tboxModRef = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(265, 131);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "변경";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxModName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboxModRef, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(30, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "성별 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "특기 : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxModName
            // 
            this.tboxModName.Location = new System.Drawing.Point(73, 3);
            this.tboxModName.Name = "tboxModName";
            this.tboxModName.Size = new System.Drawing.Size(100, 21);
            this.tboxModName.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoModSexFemale);
            this.panel1.Controls.Add(this.rdoModSexMale);
            this.panel1.Location = new System.Drawing.Point(73, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 6;
            // 
            // rdoModSexFemale
            // 
            this.rdoModSexFemale.AutoSize = true;
            this.rdoModSexFemale.Location = new System.Drawing.Point(98, 0);
            this.rdoModSexFemale.Name = "rdoModSexFemale";
            this.rdoModSexFemale.Size = new System.Drawing.Size(47, 16);
            this.rdoModSexFemale.TabIndex = 1;
            this.rdoModSexFemale.TabStop = true;
            this.rdoModSexFemale.Text = "여자";
            this.rdoModSexFemale.UseVisualStyleBackColor = true;
            // 
            // rdoModSexMale
            // 
            this.rdoModSexMale.AutoSize = true;
            this.rdoModSexMale.Location = new System.Drawing.Point(0, 0);
            this.rdoModSexMale.Name = "rdoModSexMale";
            this.rdoModSexMale.Size = new System.Drawing.Size(47, 16);
            this.rdoModSexMale.TabIndex = 0;
            this.rdoModSexMale.TabStop = true;
            this.rdoModSexMale.Text = "남자";
            this.rdoModSexMale.UseVisualStyleBackColor = true;
            // 
            // tboxModRef
            // 
            this.tboxModRef.Location = new System.Drawing.Point(73, 71);
            this.tboxModRef.Name = "tboxModRef";
            this.tboxModRef.Size = new System.Drawing.Size(258, 21);
            this.tboxModRef.TabIndex = 7;
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 187);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormModify";
            this.Text = "FormModify";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxModName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoModSexFemale;
        private System.Windows.Forms.RadioButton rdoModSexMale;
        private System.Windows.Forms.TextBox tboxModRef;
    }
}