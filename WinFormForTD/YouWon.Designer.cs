namespace WinFormForTD
{
    partial class YouWon
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
            this.lblTotalKillsValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalKillsValue
            // 
            this.lblTotalKillsValue.AutoSize = true;
            this.lblTotalKillsValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTotalKillsValue.Location = new System.Drawing.Point(452, 231);
            this.lblTotalKillsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalKillsValue.Name = "lblTotalKillsValue";
            this.lblTotalKillsValue.Size = new System.Drawing.Size(36, 19);
            this.lblTotalKillsValue.TabIndex = 22;
            this.lblTotalKillsValue.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(247, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total enemies killed:";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(286, 296);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(224, 60);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return to menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(295, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 46);
            this.label2.TabIndex = 19;
            this.label2.Text = "VICTORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(179, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "YOU SURVIVED ALL WAVES OF ENEMIES";
            // 
            // YouWon
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
            this.Name = "YouWon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "YouWon";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTotalKillsValue;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}