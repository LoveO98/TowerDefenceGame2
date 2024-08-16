namespace WinFormForTD
{
    partial class TurretInfoForm
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
            this.lblTurretName = new System.Windows.Forms.Label();
            this.btnDestroyTurret = new System.Windows.Forms.Button();
            this.gbTurretStats = new System.Windows.Forms.GroupBox();
            this.lblTurretKillsValue = new System.Windows.Forms.Label();
            this.lblTurretKills = new System.Windows.Forms.Label();
            this.lblTurretHealthValue = new System.Windows.Forms.Label();
            this.lblTurretHealth = new System.Windows.Forms.Label();
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
            this.btnUpgradeTurretBasic = new System.Windows.Forms.Button();
            this.gbTurretTargeting = new System.Windows.Forms.GroupBox();
            this.cbTurretTargetingModes = new System.Windows.Forms.ComboBox();
            this.cbTurretIgnoreGlobalTargeting = new System.Windows.Forms.CheckBox();
            this.cbTurretLockOn = new System.Windows.Forms.CheckBox();
            this.lblTurretTargetingMode = new System.Windows.Forms.Label();
            this.gbTurretUpgradeBasic = new System.Windows.Forms.GroupBox();
            this.lblTurretUpgradeScrapValue1 = new System.Windows.Forms.Label();
            this.lblTurretUpgradeScrap1 = new System.Windows.Forms.Label();
            this.btnUpgradeTurretAlien = new System.Windows.Forms.Button();
            this.lblTurretUpgradeScrap2 = new System.Windows.Forms.Label();
            this.lblTurretUpgradeScrapValue2 = new System.Windows.Forms.Label();
            this.lblTurretUpgradeAlienScrap = new System.Windows.Forms.Label();
            this.gbTurretUpgradeSpecial = new System.Windows.Forms.GroupBox();
            this.lblTurretUpgradeAlienScrapValue = new System.Windows.Forms.Label();
            this.gbTurretHideUpg = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTurretStats.SuspendLayout();
            this.gbTurretTargeting.SuspendLayout();
            this.gbTurretUpgradeBasic.SuspendLayout();
            this.gbTurretUpgradeSpecial.SuspendLayout();
            this.gbTurretHideUpg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTurretName
            // 
            this.lblTurretName.AutoSize = true;
            this.lblTurretName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTurretName.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold);
            this.lblTurretName.Location = new System.Drawing.Point(80, 4);
            this.lblTurretName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretName.Name = "lblTurretName";
            this.lblTurretName.Size = new System.Drawing.Size(497, 29);
            this.lblTurretName.TabIndex = 0;
            this.lblTurretName.Text = "[ERROR, COULD NOT GET TURRET NAME]";
            // 
            // btnDestroyTurret
            // 
            this.btnDestroyTurret.BackColor = System.Drawing.Color.Red;
            this.btnDestroyTurret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestroyTurret.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnDestroyTurret.ForeColor = System.Drawing.Color.Black;
            this.btnDestroyTurret.Location = new System.Drawing.Point(470, 268);
            this.btnDestroyTurret.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestroyTurret.Name = "btnDestroyTurret";
            this.btnDestroyTurret.Size = new System.Drawing.Size(195, 35);
            this.btnDestroyTurret.TabIndex = 1;
            this.btnDestroyTurret.Text = "DESTROY TURRET";
            this.btnDestroyTurret.UseVisualStyleBackColor = false;
            this.btnDestroyTurret.Click += new System.EventHandler(this.btnDestroyTurret_Click);
            // 
            // gbTurretStats
            // 
            this.gbTurretStats.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTurretStats.Controls.Add(this.lblTurretKillsValue);
            this.gbTurretStats.Controls.Add(this.lblTurretKills);
            this.gbTurretStats.Controls.Add(this.lblTurretHealthValue);
            this.gbTurretStats.Controls.Add(this.lblTurretHealth);
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
            this.gbTurretStats.Location = new System.Drawing.Point(6, 142);
            this.gbTurretStats.Margin = new System.Windows.Forms.Padding(4);
            this.gbTurretStats.Name = "gbTurretStats";
            this.gbTurretStats.Padding = new System.Windows.Forms.Padding(4);
            this.gbTurretStats.Size = new System.Drawing.Size(461, 159);
            this.gbTurretStats.TabIndex = 2;
            this.gbTurretStats.TabStop = false;
            this.gbTurretStats.Text = "Turret Statistics";
            // 
            // lblTurretKillsValue
            // 
            this.lblTurretKillsValue.AutoSize = true;
            this.lblTurretKillsValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTurretKillsValue.Location = new System.Drawing.Point(329, 30);
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
            this.lblTurretKills.Location = new System.Drawing.Point(287, 30);
            this.lblTurretKills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretKills.Name = "lblTurretKills";
            this.lblTurretKills.Size = new System.Drawing.Size(47, 18);
            this.lblTurretKills.TabIndex = 15;
            this.lblTurretKills.Text = "Kills:";
            // 
            // lblTurretHealthValue
            // 
            this.lblTurretHealthValue.AutoSize = true;
            this.lblTurretHealthValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTurretHealthValue.Location = new System.Drawing.Point(155, 30);
            this.lblTurretHealthValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretHealthValue.Name = "lblTurretHealthValue";
            this.lblTurretHealthValue.Size = new System.Drawing.Size(70, 19);
            this.lblTurretHealthValue.TabIndex = 14;
            this.lblTurretHealthValue.Text = "000/000";
            // 
            // lblTurretHealth
            // 
            this.lblTurretHealth.AutoSize = true;
            this.lblTurretHealth.Font = new System.Drawing.Font("Roboto Medium", 10.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTurretHealth.Location = new System.Drawing.Point(8, 30);
            this.lblTurretHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretHealth.Name = "lblTurretHealth";
            this.lblTurretHealth.Size = new System.Drawing.Size(113, 18);
            this.lblTurretHealth.TabIndex = 13;
            this.lblTurretHealth.Text = "Turret Health:";
            // 
            // lblTurretDamageDealtValue
            // 
            this.lblTurretDamageDealtValue.AutoSize = true;
            this.lblTurretDamageDealtValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTurretDamageDealtValue.Location = new System.Drawing.Point(167, 67);
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
            this.lblTurretDamageDealt.Location = new System.Drawing.Point(8, 66);
            this.lblTurretDamageDealt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretDamageDealt.Name = "lblTurretDamageDealt";
            this.lblTurretDamageDealt.Size = new System.Drawing.Size(161, 18);
            this.lblTurretDamageDealt.TabIndex = 3;
            this.lblTurretDamageDealt.Text = "Total Damage Dealt:";
            // 
            // btnUpgradeTurretBasic
            // 
            this.btnUpgradeTurretBasic.BackColor = System.Drawing.Color.Lime;
            this.btnUpgradeTurretBasic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpgradeTurretBasic.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpgradeTurretBasic.ForeColor = System.Drawing.Color.Black;
            this.btnUpgradeTurretBasic.Location = new System.Drawing.Point(12, 50);
            this.btnUpgradeTurretBasic.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpgradeTurretBasic.Name = "btnUpgradeTurretBasic";
            this.btnUpgradeTurretBasic.Size = new System.Drawing.Size(169, 38);
            this.btnUpgradeTurretBasic.TabIndex = 3;
            this.btnUpgradeTurretBasic.Text = "UPGRADE TURRET";
            this.btnUpgradeTurretBasic.UseVisualStyleBackColor = false;
            this.btnUpgradeTurretBasic.Click += new System.EventHandler(this.btnUpgradeTurretBasic_Click);
            // 
            // gbTurretTargeting
            // 
            this.gbTurretTargeting.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTurretTargeting.Controls.Add(this.cbTurretTargetingModes);
            this.gbTurretTargeting.Controls.Add(this.cbTurretIgnoreGlobalTargeting);
            this.gbTurretTargeting.Controls.Add(this.cbTurretLockOn);
            this.gbTurretTargeting.Controls.Add(this.lblTurretTargetingMode);
            this.gbTurretTargeting.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbTurretTargeting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbTurretTargeting.Location = new System.Drawing.Point(5, 37);
            this.gbTurretTargeting.Margin = new System.Windows.Forms.Padding(4);
            this.gbTurretTargeting.Name = "gbTurretTargeting";
            this.gbTurretTargeting.Padding = new System.Windows.Forms.Padding(4);
            this.gbTurretTargeting.Size = new System.Drawing.Size(461, 97);
            this.gbTurretTargeting.TabIndex = 4;
            this.gbTurretTargeting.TabStop = false;
            this.gbTurretTargeting.Text = "Targetting Options";
            // 
            // cbTurretTargetingModes
            // 
            this.cbTurretTargetingModes.DropDownHeight = 133;
            this.cbTurretTargetingModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurretTargetingModes.FormattingEnabled = true;
            this.cbTurretTargetingModes.IntegralHeight = false;
            this.cbTurretTargetingModes.ItemHeight = 19;
            this.cbTurretTargetingModes.Items.AddRange(new object[] {
            "closest",
            "furthest",
            "mostHealth",
            "leastHealth",
            "mostTotHealth",
            "mostValue",
            "leastValue"});
            this.cbTurretTargetingModes.Location = new System.Drawing.Point(8, 52);
            this.cbTurretTargetingModes.Margin = new System.Windows.Forms.Padding(4);
            this.cbTurretTargetingModes.MaxDropDownItems = 7;
            this.cbTurretTargetingModes.Name = "cbTurretTargetingModes";
            this.cbTurretTargetingModes.Size = new System.Drawing.Size(181, 27);
            this.cbTurretTargetingModes.TabIndex = 16;
            // 
            // cbTurretIgnoreGlobalTargeting
            // 
            this.cbTurretIgnoreGlobalTargeting.AutoSize = true;
            this.cbTurretIgnoreGlobalTargeting.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurretIgnoreGlobalTargeting.Location = new System.Drawing.Point(217, 59);
            this.cbTurretIgnoreGlobalTargeting.Margin = new System.Windows.Forms.Padding(4);
            this.cbTurretIgnoreGlobalTargeting.Name = "cbTurretIgnoreGlobalTargeting";
            this.cbTurretIgnoreGlobalTargeting.Size = new System.Drawing.Size(176, 19);
            this.cbTurretIgnoreGlobalTargeting.TabIndex = 7;
            this.cbTurretIgnoreGlobalTargeting.Text = "Ignore Global Changes";
            this.cbTurretIgnoreGlobalTargeting.UseVisualStyleBackColor = true;
            this.cbTurretIgnoreGlobalTargeting.MouseHover += new System.EventHandler(this.cbTurretIgnoreGlobalTargeting_MouseHover);
            // 
            // cbTurretLockOn
            // 
            this.cbTurretLockOn.AutoSize = true;
            this.cbTurretLockOn.Checked = true;
            this.cbTurretLockOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTurretLockOn.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurretLockOn.Location = new System.Drawing.Point(217, 28);
            this.cbTurretLockOn.Margin = new System.Windows.Forms.Padding(4);
            this.cbTurretLockOn.Name = "cbTurretLockOn";
            this.cbTurretLockOn.Size = new System.Drawing.Size(128, 19);
            this.cbTurretLockOn.TabIndex = 6;
            this.cbTurretLockOn.Text = "Lock-On Target";
            this.cbTurretLockOn.UseVisualStyleBackColor = true;
            this.cbTurretLockOn.CheckedChanged += new System.EventHandler(this.cbTurretLockOn_CheckedChanged);
            // 
            // lblTurretTargetingMode
            // 
            this.lblTurretTargetingMode.AutoSize = true;
            this.lblTurretTargetingMode.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurretTargetingMode.Location = new System.Drawing.Point(8, 29);
            this.lblTurretTargetingMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretTargetingMode.Name = "lblTurretTargetingMode";
            this.lblTurretTargetingMode.Size = new System.Drawing.Size(110, 15);
            this.lblTurretTargetingMode.TabIndex = 4;
            this.lblTurretTargetingMode.Text = "Targeting Mode";
            // 
            // gbTurretUpgradeBasic
            // 
            this.gbTurretUpgradeBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTurretUpgradeBasic.Controls.Add(this.lblTurretUpgradeScrapValue1);
            this.gbTurretUpgradeBasic.Controls.Add(this.lblTurretUpgradeScrap1);
            this.gbTurretUpgradeBasic.Controls.Add(this.btnUpgradeTurretBasic);
            this.gbTurretUpgradeBasic.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbTurretUpgradeBasic.Location = new System.Drawing.Point(471, 37);
            this.gbTurretUpgradeBasic.Margin = new System.Windows.Forms.Padding(4);
            this.gbTurretUpgradeBasic.Name = "gbTurretUpgradeBasic";
            this.gbTurretUpgradeBasic.Padding = new System.Windows.Forms.Padding(4);
            this.gbTurretUpgradeBasic.Size = new System.Drawing.Size(193, 97);
            this.gbTurretUpgradeBasic.TabIndex = 6;
            this.gbTurretUpgradeBasic.TabStop = false;
            this.gbTurretUpgradeBasic.Text = "Basic Upgrade";
            // 
            // lblTurretUpgradeScrapValue1
            // 
            this.lblTurretUpgradeScrapValue1.AutoSize = true;
            this.lblTurretUpgradeScrapValue1.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblTurretUpgradeScrapValue1.Location = new System.Drawing.Point(123, 27);
            this.lblTurretUpgradeScrapValue1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretUpgradeScrapValue1.Name = "lblTurretUpgradeScrapValue1";
            this.lblTurretUpgradeScrapValue1.Size = new System.Drawing.Size(32, 17);
            this.lblTurretUpgradeScrapValue1.TabIndex = 15;
            this.lblTurretUpgradeScrapValue1.Text = "000";
            // 
            // lblTurretUpgradeScrap1
            // 
            this.lblTurretUpgradeScrap1.AutoSize = true;
            this.lblTurretUpgradeScrap1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTurretUpgradeScrap1.Location = new System.Drawing.Point(8, 27);
            this.lblTurretUpgradeScrap1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretUpgradeScrap1.Name = "lblTurretUpgradeScrap1";
            this.lblTurretUpgradeScrap1.Size = new System.Drawing.Size(50, 15);
            this.lblTurretUpgradeScrap1.TabIndex = 4;
            this.lblTurretUpgradeScrap1.Text = "Scrap:";
            // 
            // btnUpgradeTurretAlien
            // 
            this.btnUpgradeTurretAlien.BackColor = System.Drawing.Color.Lime;
            this.btnUpgradeTurretAlien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpgradeTurretAlien.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpgradeTurretAlien.ForeColor = System.Drawing.Color.Black;
            this.btnUpgradeTurretAlien.Location = new System.Drawing.Point(12, 79);
            this.btnUpgradeTurretAlien.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpgradeTurretAlien.Name = "btnUpgradeTurretAlien";
            this.btnUpgradeTurretAlien.Size = new System.Drawing.Size(169, 38);
            this.btnUpgradeTurretAlien.TabIndex = 16;
            this.btnUpgradeTurretAlien.Text = "UPGRADE TURRET";
            this.btnUpgradeTurretAlien.UseVisualStyleBackColor = false;
            this.btnUpgradeTurretAlien.Click += new System.EventHandler(this.btnUpgradeTurretAlien_Click);
            // 
            // lblTurretUpgradeScrap2
            // 
            this.lblTurretUpgradeScrap2.AutoSize = true;
            this.lblTurretUpgradeScrap2.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurretUpgradeScrap2.Location = new System.Drawing.Point(12, 28);
            this.lblTurretUpgradeScrap2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretUpgradeScrap2.Name = "lblTurretUpgradeScrap2";
            this.lblTurretUpgradeScrap2.Size = new System.Drawing.Size(47, 14);
            this.lblTurretUpgradeScrap2.TabIndex = 17;
            this.lblTurretUpgradeScrap2.Text = "Scrap:";
            // 
            // lblTurretUpgradeScrapValue2
            // 
            this.lblTurretUpgradeScrapValue2.AutoSize = true;
            this.lblTurretUpgradeScrapValue2.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblTurretUpgradeScrapValue2.Location = new System.Drawing.Point(123, 27);
            this.lblTurretUpgradeScrapValue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretUpgradeScrapValue2.Name = "lblTurretUpgradeScrapValue2";
            this.lblTurretUpgradeScrapValue2.Size = new System.Drawing.Size(32, 17);
            this.lblTurretUpgradeScrapValue2.TabIndex = 18;
            this.lblTurretUpgradeScrapValue2.Text = "000";
            // 
            // lblTurretUpgradeAlienScrap
            // 
            this.lblTurretUpgradeAlienScrap.AutoSize = true;
            this.lblTurretUpgradeAlienScrap.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurretUpgradeAlienScrap.Location = new System.Drawing.Point(12, 54);
            this.lblTurretUpgradeAlienScrap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretUpgradeAlienScrap.Name = "lblTurretUpgradeAlienScrap";
            this.lblTurretUpgradeAlienScrap.Size = new System.Drawing.Size(83, 14);
            this.lblTurretUpgradeAlienScrap.TabIndex = 19;
            this.lblTurretUpgradeAlienScrap.Text = "Alien Scrap:";
            // 
            // gbTurretUpgradeSpecial
            // 
            this.gbTurretUpgradeSpecial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTurretUpgradeSpecial.Controls.Add(this.lblTurretUpgradeAlienScrapValue);
            this.gbTurretUpgradeSpecial.Controls.Add(this.lblTurretUpgradeAlienScrap);
            this.gbTurretUpgradeSpecial.Controls.Add(this.lblTurretUpgradeScrapValue2);
            this.gbTurretUpgradeSpecial.Controls.Add(this.lblTurretUpgradeScrap2);
            this.gbTurretUpgradeSpecial.Controls.Add(this.btnUpgradeTurretAlien);
            this.gbTurretUpgradeSpecial.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbTurretUpgradeSpecial.Location = new System.Drawing.Point(471, 138);
            this.gbTurretUpgradeSpecial.Margin = new System.Windows.Forms.Padding(4);
            this.gbTurretUpgradeSpecial.Name = "gbTurretUpgradeSpecial";
            this.gbTurretUpgradeSpecial.Padding = new System.Windows.Forms.Padding(4);
            this.gbTurretUpgradeSpecial.Size = new System.Drawing.Size(193, 127);
            this.gbTurretUpgradeSpecial.TabIndex = 16;
            this.gbTurretUpgradeSpecial.TabStop = false;
            this.gbTurretUpgradeSpecial.Text = "Special Upgrade";
            // 
            // lblTurretUpgradeAlienScrapValue
            // 
            this.lblTurretUpgradeAlienScrapValue.AutoSize = true;
            this.lblTurretUpgradeAlienScrapValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblTurretUpgradeAlienScrapValue.Location = new System.Drawing.Point(123, 53);
            this.lblTurretUpgradeAlienScrapValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurretUpgradeAlienScrapValue.Name = "lblTurretUpgradeAlienScrapValue";
            this.lblTurretUpgradeAlienScrapValue.Size = new System.Drawing.Size(32, 17);
            this.lblTurretUpgradeAlienScrapValue.TabIndex = 20;
            this.lblTurretUpgradeAlienScrapValue.Text = "000";
            // 
            // gbTurretHideUpg
            // 
            this.gbTurretHideUpg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTurretHideUpg.Controls.Add(this.label3);
            this.gbTurretHideUpg.Controls.Add(this.label2);
            this.gbTurretHideUpg.Controls.Add(this.label1);
            this.gbTurretHideUpg.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbTurretHideUpg.Location = new System.Drawing.Point(471, 37);
            this.gbTurretHideUpg.Margin = new System.Windows.Forms.Padding(4);
            this.gbTurretHideUpg.MaximumSize = new System.Drawing.Size(193, 231);
            this.gbTurretHideUpg.Name = "gbTurretHideUpg";
            this.gbTurretHideUpg.Padding = new System.Windows.Forms.Padding(4);
            this.gbTurretHideUpg.Size = new System.Drawing.Size(193, 228);
            this.gbTurretHideUpg.TabIndex = 16;
            this.gbTurretHideUpg.TabStop = false;
            this.gbTurretHideUpg.Text = "Upgrade";
            this.gbTurretHideUpg.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 25.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(46, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fully";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 25.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(14, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Upgraded";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 25.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Already";
            // 
            // TurretInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(669, 306);
            this.ControlBox = false;
            this.Controls.Add(this.gbTurretHideUpg);
            this.Controls.Add(this.gbTurretUpgradeSpecial);
            this.Controls.Add(this.gbTurretUpgradeBasic);
            this.Controls.Add(this.gbTurretTargeting);
            this.Controls.Add(this.gbTurretStats);
            this.Controls.Add(this.btnDestroyTurret);
            this.Controls.Add(this.lblTurretName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TurretInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TurretInfoForm";
            this.TopMost = true;
            this.gbTurretStats.ResumeLayout(false);
            this.gbTurretStats.PerformLayout();
            this.gbTurretTargeting.ResumeLayout(false);
            this.gbTurretTargeting.PerformLayout();
            this.gbTurretUpgradeBasic.ResumeLayout(false);
            this.gbTurretUpgradeBasic.PerformLayout();
            this.gbTurretUpgradeSpecial.ResumeLayout(false);
            this.gbTurretUpgradeSpecial.PerformLayout();
            this.gbTurretHideUpg.ResumeLayout(false);
            this.gbTurretHideUpg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDestroyTurret;
        private System.Windows.Forms.GroupBox gbTurretStats;
        private System.Windows.Forms.Label lblTurretDamageDealt;
        private System.Windows.Forms.GroupBox gbTurretTargeting;
        private System.Windows.Forms.Label lblTurretTargetingMode;
        private System.Windows.Forms.Label lblTurretAttackSpeed;
        private System.Windows.Forms.Label lblTurretDamage;
        private System.Windows.Forms.Label lblTurretRange;
        private System.Windows.Forms.Label lblTurretDamageType;
        private System.Windows.Forms.Label lblTurretHealth;
        private System.Windows.Forms.GroupBox gbTurretUpgradeBasic;
        private System.Windows.Forms.Label lblTurretUpgradeScrap1;
        private System.Windows.Forms.Label lblTurretUpgradeScrap2;
        private System.Windows.Forms.Label lblTurretUpgradeAlienScrap;
        private System.Windows.Forms.GroupBox gbTurretUpgradeSpecial;
        public System.Windows.Forms.Label lblTurretName;
        private System.Windows.Forms.ComboBox cbTurretTargetingModes;
        public System.Windows.Forms.Label lblTurretDamageDealtValue;
        public System.Windows.Forms.Button btnUpgradeTurretBasic;
        public System.Windows.Forms.CheckBox cbTurretLockOn;
        public System.Windows.Forms.CheckBox cbTurretIgnoreGlobalTargeting;
        public System.Windows.Forms.Label lblTurretDamageTypeValue;
        public System.Windows.Forms.Label lblTurretRangeValue;
        public System.Windows.Forms.Label lblTurretAttackSpeedValue;
        public System.Windows.Forms.Label lblTurretDamageValue;
        public System.Windows.Forms.Label lblTurretHealthValue;
        public System.Windows.Forms.Label lblTurretUpgradeScrapValue1;
        public System.Windows.Forms.Button btnUpgradeTurretAlien;
        public System.Windows.Forms.Label lblTurretUpgradeScrapValue2;
        public System.Windows.Forms.Label lblTurretUpgradeAlienScrapValue;
        private System.Windows.Forms.Label lblTurretKills;
        public System.Windows.Forms.Label lblTurretKillsValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbTurretHideUpg;
    }
}