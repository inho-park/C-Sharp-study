
namespace CallBackEx
{
    partial class fInnerMain
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
            this.lblInnerMain = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnInterfaceCallback = new System.Windows.Forms.Button();
            this.btnStatusLoopCheck = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInnerMain
            // 
            this.lblInnerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInnerMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblInnerMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInnerMain.Location = new System.Drawing.Point(55, 80);
            this.lblInnerMain.Name = "lblInnerMain";
            this.lblInnerMain.Size = new System.Drawing.Size(335, 131);
            this.lblInnerMain.TabIndex = 0;
            this.lblInnerMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 224);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(443, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tsCount
            // 
            this.tsCount.Name = "tsCount";
            this.tsCount.Size = new System.Drawing.Size(24, 17);
            this.tsCount.Text = "0%";
            // 
            // btnInterfaceCallback
            // 
            this.btnInterfaceCallback.Location = new System.Drawing.Point(57, 12);
            this.btnInterfaceCallback.Name = "btnInterfaceCallback";
            this.btnInterfaceCallback.Size = new System.Drawing.Size(160, 52);
            this.btnInterfaceCallback.TabIndex = 2;
            this.btnInterfaceCallback.Text = "Interface CallBack Start";
            this.btnInterfaceCallback.UseVisualStyleBackColor = true;
            this.btnInterfaceCallback.Click += new System.EventHandler(this.btnInterfaceCallback_Click);
            // 
            // btnStatusLoopCheck
            // 
            this.btnStatusLoopCheck.Location = new System.Drawing.Point(230, 12);
            this.btnStatusLoopCheck.Name = "btnStatusLoopCheck";
            this.btnStatusLoopCheck.Size = new System.Drawing.Size(160, 52);
            this.btnStatusLoopCheck.TabIndex = 3;
            this.btnStatusLoopCheck.Text = "Status Loop Check Start";
            this.btnStatusLoopCheck.UseVisualStyleBackColor = true;
            this.btnStatusLoopCheck.Click += new System.EventHandler(this.btnStatusLoopCheck_Click);
            // 
            // fInnerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 246);
            this.Controls.Add(this.btnStatusLoopCheck);
            this.Controls.Add(this.btnInterfaceCallback);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblInnerMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fInnerMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.fInnerMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInnerMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsCount;
        private System.Windows.Forms.Button btnInterfaceCallback;
        private System.Windows.Forms.Button btnStatusLoopCheck;
    }
}