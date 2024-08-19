namespace WinFormForTD
{
    partial class MainMenuForm
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
            this.btnMenuLvl1 = new System.Windows.Forms.Button();
            this.btnMenuLvl2 = new System.Windows.Forms.Button();
            this.btnMenuExit = new System.Windows.Forms.Button();
            this.btnMenuSandbox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenuStressTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuLvl1
            // 
            this.btnMenuLvl1.Font = new System.Drawing.Font("Roboto Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnMenuLvl1.Location = new System.Drawing.Point(316, 138);
            this.btnMenuLvl1.Name = "btnMenuLvl1";
            this.btnMenuLvl1.Size = new System.Drawing.Size(172, 43);
            this.btnMenuLvl1.TabIndex = 1;
            this.btnMenuLvl1.Text = "Level 1";
            this.btnMenuLvl1.UseVisualStyleBackColor = true;
            this.btnMenuLvl1.Click += new System.EventHandler(this.btnMenuLvl1_Click);
            // 
            // btnMenuLvl2
            // 
            this.btnMenuLvl2.Font = new System.Drawing.Font("Roboto Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnMenuLvl2.Location = new System.Drawing.Point(316, 201);
            this.btnMenuLvl2.Name = "btnMenuLvl2";
            this.btnMenuLvl2.Size = new System.Drawing.Size(172, 43);
            this.btnMenuLvl2.TabIndex = 2;
            this.btnMenuLvl2.Text = "Level 2";
            this.btnMenuLvl2.UseVisualStyleBackColor = true;
            this.btnMenuLvl2.Click += new System.EventHandler(this.btnMenuLvl2_Click);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Font = new System.Drawing.Font("Roboto Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnMenuExit.Location = new System.Drawing.Point(316, 383);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(172, 43);
            this.btnMenuExit.TabIndex = 3;
            this.btnMenuExit.Text = "Exit Game";
            this.btnMenuExit.UseVisualStyleBackColor = true;
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // btnMenuSandbox
            // 
            this.btnMenuSandbox.Font = new System.Drawing.Font("Roboto Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnMenuSandbox.Location = new System.Drawing.Point(316, 266);
            this.btnMenuSandbox.Name = "btnMenuSandbox";
            this.btnMenuSandbox.Size = new System.Drawing.Size(172, 43);
            this.btnMenuSandbox.TabIndex = 4;
            this.btnMenuSandbox.Text = "Sandbox";
            this.btnMenuSandbox.UseVisualStyleBackColor = true;
            this.btnMenuSandbox.Click += new System.EventHandler(this.btnMenuSandbox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 35F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(156, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "A Tower Defence Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(329, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "By Love Olsson";
            // 
            // btnMenuStressTest
            // 
            this.btnMenuStressTest.Font = new System.Drawing.Font("Roboto Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnMenuStressTest.Location = new System.Drawing.Point(316, 325);
            this.btnMenuStressTest.Name = "btnMenuStressTest";
            this.btnMenuStressTest.Size = new System.Drawing.Size(172, 43);
            this.btnMenuStressTest.TabIndex = 7;
            this.btnMenuStressTest.Text = "Stress Test";
            this.btnMenuStressTest.UseVisualStyleBackColor = true;
            this.btnMenuStressTest.Click += new System.EventHandler(this.btnMenuStressTest_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnMenuStressTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuSandbox);
            this.Controls.Add(this.btnMenuExit);
            this.Controls.Add(this.btnMenuLvl2);
            this.Controls.Add(this.btnMenuLvl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainMenuForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMenuLvl1;
        private System.Windows.Forms.Button btnMenuLvl2;
        private System.Windows.Forms.Button btnMenuExit;
        private System.Windows.Forms.Button btnMenuSandbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenuStressTest;
    }
}