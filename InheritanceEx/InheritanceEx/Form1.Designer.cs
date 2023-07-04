
namespace InheritanceEx
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
            this.pMain = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOnecycle = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(707, 301);
            this.pMain.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(12, 326);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "-";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOnecycle
            // 
            this.btnOnecycle.Location = new System.Drawing.Point(130, 329);
            this.btnOnecycle.Name = "btnOnecycle";
            this.btnOnecycle.Size = new System.Drawing.Size(152, 23);
            this.btnOnecycle.TabIndex = 2;
            this.btnOnecycle.Text = "1단계 : 외발 자전거";
            this.btnOnecycle.UseVisualStyleBackColor = true;
            this.btnOnecycle.Click += new System.EventHandler(this.btnOnecycle_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(476, 329);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(152, 23);
            this.btnCar.TabIndex = 3;
            this.btnCar.Text = "3단계 : 자동차";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(302, 329);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(152, 23);
            this.btnCycle.TabIndex = 4;
            this.btnCycle.Text = "2단계 : 자전거";
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 418);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnOnecycle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOnecycle;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnCycle;
    }
}

