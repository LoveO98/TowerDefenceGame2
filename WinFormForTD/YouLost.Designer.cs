namespace WinFormForTD
{
    partial class YouLost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalKillsValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(224, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR CITY WAS DESTROYED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(279, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "GAME OVER";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(287, 305);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(224, 60);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return to menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(236, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total enemies killed:";
            // 
            // lblTotalKillsValue
            // 
            this.lblTotalKillsValue.AutoSize = true;
            this.lblTotalKillsValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTotalKillsValue.Location = new System.Drawing.Point(441, 242);
            this.lblTotalKillsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalKillsValue.Name = "lblTotalKillsValue";
            this.lblTotalKillsValue.Size = new System.Drawing.Size(36, 19);
            this.lblTotalKillsValue.TabIndex = 17;
            this.lblTotalKillsValue.Text = "000";
            // 
            // YouLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalKillsValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YouLost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "YouLost";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblTotalKillsValue;
        public System.Windows.Forms.Button btnReturn;
    }
}