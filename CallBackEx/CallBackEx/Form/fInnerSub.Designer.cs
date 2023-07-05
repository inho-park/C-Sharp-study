
namespace CallBackEx
{
    partial class fInnerSub
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
            this.lblInnerSub = new System.Windows.Forms.Label();
            this.btnDelCallback = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInnerSub
            // 
            this.lblInnerSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInnerSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInnerSub.Location = new System.Drawing.Point(50, 79);
            this.lblInnerSub.Name = "lblInnerSub";
            this.lblInnerSub.Size = new System.Drawing.Size(213, 64);
            this.lblInnerSub.TabIndex = 0;
            this.lblInnerSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelCallback
            // 
            this.btnDelCallback.Location = new System.Drawing.Point(52, 25);
            this.btnDelCallback.Name = "btnDelCallback";
            this.btnDelCallback.Size = new System.Drawing.Size(211, 40);
            this.btnDelCallback.TabIndex = 1;
            this.btnDelCallback.Text = "Delegate Callback Start";
            this.btnDelCallback.UseVisualStyleBackColor = true;
            this.btnDelCallback.Click += new System.EventHandler(this.btnDelCallback_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 168);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(308, 22);
            this.statusStrip1.TabIndex = 2;
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
            // fInnerSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 190);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelCallback);
            this.Controls.Add(this.lblInnerSub);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fInnerSub";
            this.Text = "fInnerSub";
            this.Load += new System.EventHandler(this.fInnerSub_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInnerSub;
        private System.Windows.Forms.Button btnDelCallback;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsCount;
    }
}