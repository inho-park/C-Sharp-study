
namespace ClassEx
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxCat = new System.Windows.Forms.TextBox();
            this.lboxKitties = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblMom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(297, 81);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "새끼 고양이 리스트";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "엄마 고양이";
            // 
            // tboxCat
            // 
            this.tboxCat.Location = new System.Drawing.Point(515, 81);
            this.tboxCat.Name = "tboxCat";
            this.tboxCat.Size = new System.Drawing.Size(100, 21);
            this.tboxCat.TabIndex = 5;
            this.tboxCat.Text = "이름 나이";
            // 
            // lboxKitties
            // 
            this.lboxKitties.FormattingEnabled = true;
            this.lboxKitties.ItemHeight = 12;
            this.lboxKitties.Location = new System.Drawing.Point(515, 142);
            this.lboxKitties.Name = "lboxKitties";
            this.lboxKitties.Size = new System.Drawing.Size(163, 232);
            this.lboxKitties.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Exception";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(230, 250);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(11, 12);
            this.lblException.TabIndex = 8;
            this.lblException.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "현재 새끼 수";
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(538, 116);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 10;
            this.lblCnt.Text = "0";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(297, 111);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "새끼 낳기";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lblMom
            // 
            this.lblMom.AutoSize = true;
            this.lblMom.Location = new System.Drawing.Point(474, 49);
            this.lblMom.Name = "lblMom";
            this.lblMom.Size = new System.Drawing.Size(11, 12);
            this.lblMom.TabIndex = 12;
            this.lblMom.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMom);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxKitties);
            this.Controls.Add(this.tboxCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxCat;
        private System.Windows.Forms.ListBox lboxKitties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblMom;
    }
}

