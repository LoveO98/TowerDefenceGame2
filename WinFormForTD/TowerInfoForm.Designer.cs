namespace WinFormForTD
{
    partial class TowerInfoForm
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
            this.lblTowerHealthValue = new System.Windows.Forms.Label();
            this.lblTowerHealth = new System.Windows.Forms.Label();
            this.lblTurretName = new System.Windows.Forms.Label();
            this.gbTowerInfo = new System.Windows.Forms.GroupBox();
            this.btnDestroyTurret = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTowerWarning = new System.Windows.Forms.Label();
            this.lblTowerWrnText1 = new System.Windows.Forms.Label();
            this.lblTowerWrnText2 = new System.Windows.Forms.Label();
            this.lblTowerWrnText3 = new System.Windows.Forms.Label();
            this.gbTurretStats = new System.Windows.Forms.GroupBox();
            this.lblTurretKillsValue = new System.Windows.Forms.Label();
            this.lblTurretKills = new System.Windows.Forms.Label();
            this.lblTurretDamageDealtValue = new System.Windows.Forms.Label();
            this.lblTurretDamageTypeValue = new System.Windows.Forms.Label();
            this.lblTurretRangeValue = new System.Windows.Forms.Label();
            this.lblTurretAttackSpeedValue = new System.Windows.Forms.Label();
            this.lblTurretDamageValue = new System.Windows.Forms.Label();
            this.lblTurretDamageType = new System.Windows.Forms.Label();
            this.lblTurretAttackSpeed = new System.Windows.Forms.Label();
            this.lblTurretDamage = new System.Windows.Forms.Label();
            this.lblTurretRange = new System.Windows.Forms.Label();
            this.lblTurretDamageDealt = new System.Windows.Forms.Label();
            this.gbTowerInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTurretStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTowerHealthValue
            // 
            this.lblTowerHealthValue.AutoSize = true;
            this.lblTowerHealthValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTowerHealthValue.Location = new System.Drawing.Point(135, 34);
            this.lblTowerHealthValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTowerHealthValue.Name = "lblTowerHealthValue";
            this.lblTowerHealthValue.Size = new System.Drawing.Size(70, 19);
            this.lblTowerHealthValue.TabIndex = 14;
            this.lblTowerHealthValue.Text = "000/000";
            // 
            // lblTowerHealth
            // 
            this.lblTowerHealth.AutoSize = true;
            this.lblTowerHealth.Font = new System.Drawing.Font("Roboto Medium", 10.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTowerHealth.Location = new System.Drawing.Point(16, 34);
            this.lblTowerHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTowerHealth.Name = "lblTowerHealth";
            this.lblTowerHealth.Size = new System.Drawing.Size(111, 18);
            this.lblTowerHealth.TabIndex = 13;
            this.lblTowerHealth.Text = "Tower Health:";
            // 
            // lblTurretName
            // 
            this.lblTurretName.AutoSize = true;
            this.lblTurretName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTurretName.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold);
            this.lblTurretName.Location = new System.Drawing.Point(280, 7);
            this.lblTurretName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretName.Name = "lblTurretName";
            this.lblTurretName.Size = new System.Drawing.Size(100, 29);
            this.lblTurretName.TabIndex = 15;
            this.lblTurretName.Text = "TOWER";
            // 
            // gbTowerInfo
            // 
            this.gbTowerInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTowerInfo.Controls.Add(this.lblTowerHealth);
            this.gbTowerInfo.Controls.Add(this.lblTowerHealthValue);
            this.gbTowerInfo.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbTowerInfo.Location = new System.Drawing.Point(15, 43);
            this.gbTowerInfo.Name = "gbTowerInfo";
            this.gbTowerInfo.Size = new System.Drawing.Size(442, 70);
            this.gbTowerInfo.TabIndex = 16;
            this.gbTowerInfo.TabStop = false;
            this.gbTowerInfo.Text = "Tower Info";
            // 
            // btnDestroyTurret
            // 
            this.btnDestroyTurret.BackColor = System.Drawing.Color.Red;
            this.btnDestroyTurret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestroyTurret.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnDestroyTurret.ForeColor = System.Drawing.Color.Black;
            this.btnDestroyTurret.Location = new System.Drawing.Point(6, 185);
            this.btnDestroyTurret.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestroyTurret.Name = "btnDestroyTurret";
            this.btnDestroyTurret.Size = new System.Drawing.Size(169, 53);
            this.btnDestroyTurret.TabIndex = 17;
            this.btnDestroyTurret.Text = "DESTROY TOWER";
            this.btnDestroyTurret.UseVisualStyleBackColor = false;
            this.btnDestroyTurret.Click += new System.EventHandler(this.btnDestroyTurret_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.lblTowerWrnText3);
            this.groupBox1.Controls.Add(this.lblTowerWrnText2);
            this.groupBox1.Controls.Add(this.lblTowerWrnText1);
            this.groupBox1.Controls.Add(this.lblTowerWarning);
            this.groupBox1.Controls.Add(this.btnDestroyTurret);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(473, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 243);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destroy Tower";
            // 
            // lblTowerWarning
            // 
            this.lblTowerWarning.AutoSize = true;
            this.lblTowerWarning.Font = new System.Drawing.Font("Roboto Medium", 20.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTowerWarning.Location = new System.Drawing.Point(10, 38);
            this.lblTowerWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTowerWarning.Name = "lblTowerWarning";
            this.lblTowerWarning.Size = new System.Drawing.Size(153, 34);
            this.lblTowerWarning.TabIndex = 15;
            this.lblTowerWarning.Text = "WARNING:";
            // 
            // lblTowerWrnText1
            // 
            this.lblTowerWrnText1.AutoSize = true;
            this.lblTowerWrnText1.Font = new System.Drawing.Font("Roboto Medium", 10.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTowerWrnText1.Location = new System.Drawing.Point(7, 86);
            this.lblTowerWrnText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTowerWrnText1.Name = "lblTowerWrnText1";
            this.lblTowerWrnText1.Size = new System.Drawing.Size(165, 18);
            this.lblTowerWrnText1.TabIndex = 15;
            this.lblTowerWrnText1.Text = "Destroying the tower";
            // 
            // lblTowerWrnText2
            // 
            this.lblTowerWrnText2.AutoSize = true;
            this.lblTowerWrnText2.Font = new System.Drawing.Font("Roboto Medium", 10.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTowerWrnText2.Location = new System.Drawing.Point(7, 119);
            this.lblTowerWrnText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTowerWrnText2.Name = "lblTowerWrnText2";
            this.lblTowerWrnText2.Size = new System.Drawing.Size(162, 18);
            this.lblTowerWrnText2.TabIndex = 18;
            this.lblTowerWrnText2.Text = "will also destroy the";
            // 
            // lblTowerWrnText3
            // 
            this.lblTowerWrnText3.AutoSize = true;
            this.lblTowerWrnText3.Font = new System.Drawing.Font("Roboto Medium", 10.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTowerWrnText3.Location = new System.Drawing.Point(14, 151);
            this.lblTowerWrnText3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTowerWrnText3.Name = "lblTowerWrnText3";
            this.lblTowerWrnText3.Size = new System.Drawing.Size(144, 18);
            this.lblTowerWrnText3.TabIndex = 19;
            this.lblTowerWrnText3.Text = "turret placed on it";
            // 
            // gbTurretStats
            // 
            this.gbTurretStats.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTurretStats.Controls.Add(this.lblTurretKillsValue);
            this.gbTurretStats.Controls.Add(this.lblTurretKills);
            this.gbTurretStats.Controls.Add(this.lblTurretDamageDealtValue);
            this.gbTurretStats.Controls.Add(this.lblTurretDamageTypeValue);
            this.gbTurretStats.Controls.Add(this.lblTurretRangeValue);
            this.gbTurretStats.Controls.Add(this.lblTurretAttackSpeedValue);
            this.gbTurretStats.Controls.Add(this.lblTurretDamageValue);
            this.gbTurretStats.Controls.Add(this.lblTurretDamageType);
            this.gbTurretStats.Controls.Add(this.lblTurretAttackSpeed);
            this.gbTurretStats.Controls.Add(this.lblTurretDamage);
            this.gbTurretStats.Controls.Add(this.lblTurretRange);
            this.gbTurretStats.Controls.Add(this.lblTurretDamageDealt);
            this.gbTurretStats.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbTurretStats.Location = new System.Drawing.Point(15, 127);
            this.gbTurretStats.Margin = new System.Windows.Forms.Padding(4);
            this.gbTurretStats.Name = "gbTurretStats";
            this.gbTurretStats.Padding = new System.Windows.Forms.Padding(4);
            this.gbTurretStats.Size = new System.Drawing.Size(442, 159);
            this.gbTurretStats.TabIndex = 18;
            this.gbTurretStats.TabStop = false;
            this.gbTurretStats.Text = "Turret On Top Stats";
            // 
            // lblTurretKillsValue
            // 
            this.lblTurretKillsValue.AutoSize = true;
            this.lblTurretKillsValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTurretKillsValue.Location = new System.Drawing.Point(59, 67);
            this.lblTurretKillsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretKillsValue.Name = "lblTurretKillsValue";
            this.lblTurretKillsValue.Size = new System.Drawing.Size(36, 19);
            this.lblTurretKillsValue.TabIndex = 16;
            this.lblTurretKillsValue.Text = "000";
            // 
            // lblTurretKills
            // 
            this.lblTurretKills.AutoSize = true;
            this.lblTurretKills.Font = new System.Drawing.Font("Roboto Medium", 10.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTurretKills.Location = new System.Drawing.Point(10, 67);
            this.lblTurretKills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretKills.Name = "lblTurretKills";
            this.lblTurretKills.Size = new System.Drawing.Size(47, 18);
            this.lblTurretKills.TabIndex = 15;
            this.lblTurretKills.Text = "Kills:";
            // 
            // lblTurretDamageDealtValue
            // 
            this.lblTurretDamageDealtValue.AutoSize = true;
            this.lblTurretDamageDealtValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTurretDamageDealtValue.Location = new System.Drawing.Point(177, 35);
            this.lblTurretDamageDealtValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretDamageDealtValue.Name = "lblTurretDamageDealtValue";
            this.lblTurretDamageDealtValue.Size = new System.Drawing.Size(36, 19);
            this.lblTurretDamageDealtValue.TabIndex = 12;
            this.lblTurretDamageDealtValue.Text = "000";
            // 
            // lblTurretDamageTypeValue
            // 
            this.lblTurretDamageTypeValue.AutoSize = true;
            this.lblTurretDamageTypeValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblTurretDamageTypeValue.Location = new System.Drawing.Point(347, 124);
            this.lblTurretDamageTypeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretDamageTypeValue.Name = "lblTurretDamageTypeValue";
            this.lblTurretDamageTypeValue.Size = new System.Drawing.Size(54, 17);
            this.lblTurretDamageTypeValue.TabIndex = 11;
            this.lblTurretDamageTypeValue.Text = "Normal";
            // 
            // lblTurretRangeValue
            // 
            this.lblTurretRangeValue.AutoSize = true;
            this.lblTurretRangeValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblTurretRangeValue.Location = new System.Drawing.Point(347, 98);
            this.lblTurretRangeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretRangeValue.Name = "lblTurretRangeValue";
            this.lblTurretRangeValue.Size = new System.Drawing.Size(32, 17);
            this.lblTurretRangeValue.TabIndex = 10;
            this.lblTurretRangeValue.Text = "000";
            // 
            // lblTurretAttackSpeedValue
            // 
            this.lblTurretAttackSpeedValue.AutoSize = true;
            this.lblTurretAttackSpeedValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblTurretAttackSpeedValue.Location = new System.Drawing.Point(118, 124);
            this.lblTurretAttackSpeedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretAttackSpeedValue.Name = "lblTurretAttackSpeedValue";
            this.lblTurretAttackSpeedValue.Size = new System.Drawing.Size(32, 17);
            this.lblTurretAttackSpeedValue.TabIndex = 9;
            this.lblTurretAttackSpeedValue.Text = "000";
            // 
            // lblTurretDamageValue
            // 
            this.lblTurretDamageValue.AutoSize = true;
            this.lblTurretDamageValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblTurretDamageValue.Location = new System.Drawing.Point(92, 98);
            this.lblTurretDamageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretDamageValue.Name = "lblTurretDamageValue";
            this.lblTurretDamageValue.Size = new System.Drawing.Size(32, 17);
            this.lblTurretDamageValue.TabIndex = 8;
            this.lblTurretDamageValue.Text = "000";
            // 
            // lblTurretDamageType
            // 
            this.lblTurretDamageType.AutoSize = true;
            this.lblTurretDamageType.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurretDamageType.Location = new System.Drawing.Point(222, 124);
            this.lblTurretDamageType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretDamageType.Name = "lblTurretDamageType";
            this.lblTurretDamageType.Size = new System.Drawing.Size(99, 15);
            this.lblTurretDamageType.TabIndex = 7;
            this.lblTurretDamageType.Text = "Damage Type:";
            // 
            // lblTurretAttackSpeed
            // 
            this.lblTurretAttackSpeed.AutoSize = true;
            this.lblTurretAttackSpeed.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurretAttackSpeed.Location = new System.Drawing.Point(11, 124);
            this.lblTurretAttackSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretAttackSpeed.Name = "lblTurretAttackSpeed";
            this.lblTurretAttackSpeed.Size = new System.Drawing.Size(99, 15);
            this.lblTurretAttackSpeed.TabIndex = 6;
            this.lblTurretAttackSpeed.Text = "Attack Speed:";
            // 
            // lblTurretDamage
            // 
            this.lblTurretDamage.AutoSize = true;
            this.lblTurretDamage.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurretDamage.Location = new System.Drawing.Point(11, 98);
            this.lblTurretDamage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretDamage.Name = "lblTurretDamage";
            this.lblTurretDamage.Size = new System.Drawing.Size(64, 15);
            this.lblTurretDamage.TabIndex = 5;
            this.lblTurretDamage.Text = "Damage:";
            // 
            // lblTurretRange
            // 
            this.lblTurretRange.AutoSize = true;
            this.lblTurretRange.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurretRange.Location = new System.Drawing.Point(222, 98);
            this.lblTurretRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretRange.Name = "lblTurretRange";
            this.lblTurretRange.Size = new System.Drawing.Size(98, 15);
            this.lblTurretRange.TabIndex = 4;
            this.lblTurretRange.Text = "Turret Range:";
            // 
            // lblTurretDamageDealt
            // 
            this.lblTurretDamageDealt.AutoSize = true;
            this.lblTurretDamageDealt.Font = new System.Drawing.Font("Roboto Medium", 10.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTurretDamageDealt.Location = new System.Drawing.Point(8, 35);
            this.lblTurretDamageDealt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretDamageDealt.Name = "lblTurretDamageDealt";
            this.lblTurretDamageDealt.Size = new System.Drawing.Size(161, 18);
            this.lblTurretDamageDealt.TabIndex = 3;
            this.lblTurretDamageDealt.Text = "Total Damage Dealt:";
            // 
            // TowerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(669, 306);
            this.ControlBox = false;
            this.Controls.Add(this.gbTurretStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTowerInfo);
            this.Controls.Add(this.lblTurretName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TowerInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TowerInfoForm";
            this.TopMost = true;
            this.gbTowerInfo.ResumeLayout(false);
            this.gbTowerInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTurretStats.ResumeLayout(false);
            this.gbTurretStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTowerHealthValue;
        private System.Windows.Forms.Label lblTowerHealth;
        public System.Windows.Forms.Label lblTurretName;
        private System.Windows.Forms.GroupBox gbTowerInfo;
        private System.Windows.Forms.Button btnDestroyTurret;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTowerWrnText3;
        private System.Windows.Forms.Label lblTowerWrnText2;
        private System.Windows.Forms.Label lblTowerWrnText1;
        private System.Windows.Forms.Label lblTowerWarning;
        private System.Windows.Forms.GroupBox gbTurretStats;
        public System.Windows.Forms.Label lblTurretKillsValue;
        private System.Windows.Forms.Label lblTurretKills;
        public System.Windows.Forms.Label lblTurretDamageDealtValue;
        public System.Windows.Forms.Label lblTurretDamageTypeValue;
        public System.Windows.Forms.Label lblTurretRangeValue;
        public System.Windows.Forms.Label lblTurretAttackSpeedValue;
        public System.Windows.Forms.Label lblTurretDamageValue;
        private System.Windows.Forms.Label lblTurretDamageType;
        private System.Windows.Forms.Label lblTurretAttackSpeed;
        private System.Windows.Forms.Label lblTurretDamage;
        private System.Windows.Forms.Label lblTurretRange;
        private System.Windows.Forms.Label lblTurretDamageDealt;
    }
}