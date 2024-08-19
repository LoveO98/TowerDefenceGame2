namespace WinFormForTD
{
    partial class BaseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMenu));
            this.labelTurretName = new System.Windows.Forms.Label();
            this.gbBaseResources = new System.Windows.Forms.GroupBox();
            this.lblBaseHealthValue = new System.Windows.Forms.Label();
            this.lblBaseEnemiesKilledValue = new System.Windows.Forms.Label();
            this.lblBaseAlienScrapValue = new System.Windows.Forms.Label();
            this.lblBaseScrapValue = new System.Windows.Forms.Label();
            this.lblBaseEnemiesKilled = new System.Windows.Forms.Label();
            this.lblBaseHealth = new System.Windows.Forms.Label();
            this.lblBaseAlienScrap = new System.Windows.Forms.Label();
            this.lblBaseScrap = new System.Windows.Forms.Label();
            this.gbBaseBuildTurret = new System.Windows.Forms.GroupBox();
            this.gbBaseTower = new System.Windows.Forms.GroupBox();
            this.pbBaseTower = new System.Windows.Forms.PictureBox();
            this.lblBaseBuyTowerCost = new System.Windows.Forms.Label();
            this.btnBaseBuyTower = new System.Windows.Forms.Button();
            this.lblBaseBuyTowerCostValue = new System.Windows.Forms.Label();
            this.gbBaseLong = new System.Windows.Forms.GroupBox();
            this.pbBaseLong = new System.Windows.Forms.PictureBox();
            this.lblBaseBuyLongCost = new System.Windows.Forms.Label();
            this.btnBaseBuyLong = new System.Windows.Forms.Button();
            this.lblBaseBuyLongCostValue = new System.Windows.Forms.Label();
            this.gbBaseMedium = new System.Windows.Forms.GroupBox();
            this.pbBaseMedium = new System.Windows.Forms.PictureBox();
            this.lblBaseBuyMediumCost = new System.Windows.Forms.Label();
            this.btnBaseBuyMedium = new System.Windows.Forms.Button();
            this.lblBaseBuyMediumCostValue = new System.Windows.Forms.Label();
            this.gbBaseShort = new System.Windows.Forms.GroupBox();
            this.pbBaseShort = new System.Windows.Forms.PictureBox();
            this.lblBaseBuyShortCost = new System.Windows.Forms.Label();
            this.btnBaseBuyShort = new System.Windows.Forms.Button();
            this.lblBaseBuyShortCostValue = new System.Windows.Forms.Label();
            this.btnBaseExit = new System.Windows.Forms.Button();
            this.gbBaseGlobalRules = new System.Windows.Forms.GroupBox();
            this.btnBaseUnlockAll = new System.Windows.Forms.Button();
            this.btnBaseApplyRules = new System.Windows.Forms.Button();
            this.cbBaseTargetingModes = new System.Windows.Forms.ComboBox();
            this.gbBaseResources.SuspendLayout();
            this.gbBaseBuildTurret.SuspendLayout();
            this.gbBaseTower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseTower)).BeginInit();
            this.gbBaseLong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseLong)).BeginInit();
            this.gbBaseMedium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseMedium)).BeginInit();
            this.gbBaseShort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseShort)).BeginInit();
            this.gbBaseGlobalRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTurretName
            // 
            this.labelTurretName.AutoSize = true;
            this.labelTurretName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTurretName.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold);
            this.labelTurretName.Location = new System.Drawing.Point(73, 9);
            this.labelTurretName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTurretName.Name = "labelTurretName";
            this.labelTurretName.Size = new System.Drawing.Size(146, 29);
            this.labelTurretName.TabIndex = 1;
            this.labelTurretName.Text = "Home Base";
            // 
            // gbBaseResources
            // 
            this.gbBaseResources.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbBaseResources.Controls.Add(this.lblBaseHealthValue);
            this.gbBaseResources.Controls.Add(this.lblBaseEnemiesKilledValue);
            this.gbBaseResources.Controls.Add(this.lblBaseAlienScrapValue);
            this.gbBaseResources.Controls.Add(this.lblBaseScrapValue);
            this.gbBaseResources.Controls.Add(this.lblBaseEnemiesKilled);
            this.gbBaseResources.Controls.Add(this.lblBaseHealth);
            this.gbBaseResources.Controls.Add(this.lblBaseAlienScrap);
            this.gbBaseResources.Controls.Add(this.lblBaseScrap);
            this.gbBaseResources.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbBaseResources.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbBaseResources.Location = new System.Drawing.Point(13, 50);
            this.gbBaseResources.Margin = new System.Windows.Forms.Padding(4);
            this.gbBaseResources.Name = "gbBaseResources";
            this.gbBaseResources.Padding = new System.Windows.Forms.Padding(4);
            this.gbBaseResources.Size = new System.Drawing.Size(283, 91);
            this.gbBaseResources.TabIndex = 5;
            this.gbBaseResources.TabStop = false;
            this.gbBaseResources.Text = "Resources";
            // 
            // lblBaseHealthValue
            // 
            this.lblBaseHealthValue.AutoSize = true;
            this.lblBaseHealthValue.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblBaseHealthValue.Location = new System.Drawing.Point(122, 24);
            this.lblBaseHealthValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseHealthValue.Name = "lblBaseHealthValue";
            this.lblBaseHealthValue.Size = new System.Drawing.Size(70, 19);
            this.lblBaseHealthValue.TabIndex = 20;
            this.lblBaseHealthValue.Text = "000/000";
            // 
            // lblBaseEnemiesKilledValue
            // 
            this.lblBaseEnemiesKilledValue.AutoSize = true;
            this.lblBaseEnemiesKilledValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblBaseEnemiesKilledValue.Location = new System.Drawing.Point(115, 68);
            this.lblBaseEnemiesKilledValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseEnemiesKilledValue.Name = "lblBaseEnemiesKilledValue";
            this.lblBaseEnemiesKilledValue.Size = new System.Drawing.Size(32, 17);
            this.lblBaseEnemiesKilledValue.TabIndex = 19;
            this.lblBaseEnemiesKilledValue.Text = "000";
            // 
            // lblBaseAlienScrapValue
            // 
            this.lblBaseAlienScrapValue.AutoSize = true;
            this.lblBaseAlienScrapValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblBaseAlienScrapValue.Location = new System.Drawing.Point(218, 50);
            this.lblBaseAlienScrapValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseAlienScrapValue.Name = "lblBaseAlienScrapValue";
            this.lblBaseAlienScrapValue.Size = new System.Drawing.Size(32, 17);
            this.lblBaseAlienScrapValue.TabIndex = 18;
            this.lblBaseAlienScrapValue.Text = "000";
            // 
            // lblBaseScrapValue
            // 
            this.lblBaseScrapValue.AutoSize = true;
            this.lblBaseScrapValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblBaseScrapValue.Location = new System.Drawing.Point(57, 50);
            this.lblBaseScrapValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseScrapValue.Name = "lblBaseScrapValue";
            this.lblBaseScrapValue.Size = new System.Drawing.Size(32, 17);
            this.lblBaseScrapValue.TabIndex = 17;
            this.lblBaseScrapValue.Text = "000";
            // 
            // lblBaseEnemiesKilled
            // 
            this.lblBaseEnemiesKilled.AutoSize = true;
            this.lblBaseEnemiesKilled.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseEnemiesKilled.Location = new System.Drawing.Point(12, 68);
            this.lblBaseEnemiesKilled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseEnemiesKilled.Name = "lblBaseEnemiesKilled";
            this.lblBaseEnemiesKilled.Size = new System.Drawing.Size(108, 15);
            this.lblBaseEnemiesKilled.TabIndex = 7;
            this.lblBaseEnemiesKilled.Text = "Enemies Killed:";
            // 
            // lblBaseHealth
            // 
            this.lblBaseHealth.AutoSize = true;
            this.lblBaseHealth.Font = new System.Drawing.Font("Roboto Medium", 11.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBaseHealth.Location = new System.Drawing.Point(11, 24);
            this.lblBaseHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseHealth.Name = "lblBaseHealth";
            this.lblBaseHealth.Size = new System.Drawing.Size(108, 19);
            this.lblBaseHealth.TabIndex = 6;
            this.lblBaseHealth.Text = "Base Health:";
            // 
            // lblBaseAlienScrap
            // 
            this.lblBaseAlienScrap.AutoSize = true;
            this.lblBaseAlienScrap.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseAlienScrap.Location = new System.Drawing.Point(134, 50);
            this.lblBaseAlienScrap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseAlienScrap.Name = "lblBaseAlienScrap";
            this.lblBaseAlienScrap.Size = new System.Drawing.Size(87, 15);
            this.lblBaseAlienScrap.TabIndex = 5;
            this.lblBaseAlienScrap.Text = "Alien Scrap:";
            // 
            // lblBaseScrap
            // 
            this.lblBaseScrap.AutoSize = true;
            this.lblBaseScrap.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseScrap.Location = new System.Drawing.Point(11, 50);
            this.lblBaseScrap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseScrap.Name = "lblBaseScrap";
            this.lblBaseScrap.Size = new System.Drawing.Size(50, 15);
            this.lblBaseScrap.TabIndex = 4;
            this.lblBaseScrap.Text = "Scrap:";
            // 
            // gbBaseBuildTurret
            // 
            this.gbBaseBuildTurret.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbBaseBuildTurret.Controls.Add(this.gbBaseTower);
            this.gbBaseBuildTurret.Controls.Add(this.gbBaseLong);
            this.gbBaseBuildTurret.Controls.Add(this.gbBaseMedium);
            this.gbBaseBuildTurret.Controls.Add(this.gbBaseShort);
            this.gbBaseBuildTurret.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbBaseBuildTurret.Location = new System.Drawing.Point(13, 153);
            this.gbBaseBuildTurret.Margin = new System.Windows.Forms.Padding(4);
            this.gbBaseBuildTurret.Name = "gbBaseBuildTurret";
            this.gbBaseBuildTurret.Padding = new System.Windows.Forms.Padding(4);
            this.gbBaseBuildTurret.Size = new System.Drawing.Size(283, 358);
            this.gbBaseBuildTurret.TabIndex = 7;
            this.gbBaseBuildTurret.TabStop = false;
            this.gbBaseBuildTurret.Text = "Buy Structure";
            // 
            // gbBaseTower
            // 
            this.gbBaseTower.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbBaseTower.Controls.Add(this.pbBaseTower);
            this.gbBaseTower.Controls.Add(this.lblBaseBuyTowerCost);
            this.gbBaseTower.Controls.Add(this.btnBaseBuyTower);
            this.gbBaseTower.Controls.Add(this.lblBaseBuyTowerCostValue);
            this.gbBaseTower.Location = new System.Drawing.Point(11, 275);
            this.gbBaseTower.Name = "gbBaseTower";
            this.gbBaseTower.Size = new System.Drawing.Size(264, 75);
            this.gbBaseTower.TabIndex = 19;
            this.gbBaseTower.TabStop = false;
            this.gbBaseTower.Text = "Tower";
            // 
            // pbBaseTower
            // 
            this.pbBaseTower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBaseTower.BackgroundImage")));
            this.pbBaseTower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBaseTower.InitialImage = null;
            this.pbBaseTower.Location = new System.Drawing.Point(205, 17);
            this.pbBaseTower.Name = "pbBaseTower";
            this.pbBaseTower.Size = new System.Drawing.Size(50, 50);
            this.pbBaseTower.TabIndex = 16;
            this.pbBaseTower.TabStop = false;
            // 
            // lblBaseBuyTowerCost
            // 
            this.lblBaseBuyTowerCost.AutoSize = true;
            this.lblBaseBuyTowerCost.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBaseBuyTowerCost.Location = new System.Drawing.Point(7, 21);
            this.lblBaseBuyTowerCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseBuyTowerCost.Name = "lblBaseBuyTowerCost";
            this.lblBaseBuyTowerCost.Size = new System.Drawing.Size(84, 15);
            this.lblBaseBuyTowerCost.TabIndex = 4;
            this.lblBaseBuyTowerCost.Text = "Scrap Cost:";
            // 
            // btnBaseBuyTower
            // 
            this.btnBaseBuyTower.BackColor = System.Drawing.Color.OldLace;
            this.btnBaseBuyTower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseBuyTower.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaseBuyTower.ForeColor = System.Drawing.Color.Black;
            this.btnBaseBuyTower.Location = new System.Drawing.Point(9, 38);
            this.btnBaseBuyTower.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaseBuyTower.Name = "btnBaseBuyTower";
            this.btnBaseBuyTower.Size = new System.Drawing.Size(186, 29);
            this.btnBaseBuyTower.TabIndex = 3;
            this.btnBaseBuyTower.Text = "BUY TURRET";
            this.btnBaseBuyTower.UseVisualStyleBackColor = false;
            this.btnBaseBuyTower.Click += new System.EventHandler(this.btnBaseBuyTower_Click);
            // 
            // lblBaseBuyTowerCostValue
            // 
            this.lblBaseBuyTowerCostValue.AutoSize = true;
            this.lblBaseBuyTowerCostValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblBaseBuyTowerCostValue.Location = new System.Drawing.Point(94, 21);
            this.lblBaseBuyTowerCostValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseBuyTowerCostValue.Name = "lblBaseBuyTowerCostValue";
            this.lblBaseBuyTowerCostValue.Size = new System.Drawing.Size(32, 17);
            this.lblBaseBuyTowerCostValue.TabIndex = 15;
            this.lblBaseBuyTowerCostValue.Text = "000";
            // 
            // gbBaseLong
            // 
            this.gbBaseLong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbBaseLong.Controls.Add(this.pbBaseLong);
            this.gbBaseLong.Controls.Add(this.lblBaseBuyLongCost);
            this.gbBaseLong.Controls.Add(this.btnBaseBuyLong);
            this.gbBaseLong.Controls.Add(this.lblBaseBuyLongCostValue);
            this.gbBaseLong.Location = new System.Drawing.Point(10, 191);
            this.gbBaseLong.Name = "gbBaseLong";
            this.gbBaseLong.Size = new System.Drawing.Size(264, 75);
            this.gbBaseLong.TabIndex = 18;
            this.gbBaseLong.TabStop = false;
            this.gbBaseLong.Text = "Long Range Turret";
            // 
            // pbBaseLong
            // 
            this.pbBaseLong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBaseLong.BackgroundImage")));
            this.pbBaseLong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBaseLong.InitialImage = null;
            this.pbBaseLong.Location = new System.Drawing.Point(205, 17);
            this.pbBaseLong.Name = "pbBaseLong";
            this.pbBaseLong.Size = new System.Drawing.Size(50, 50);
            this.pbBaseLong.TabIndex = 16;
            this.pbBaseLong.TabStop = false;
            // 
            // lblBaseBuyLongCost
            // 
            this.lblBaseBuyLongCost.AutoSize = true;
            this.lblBaseBuyLongCost.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBaseBuyLongCost.Location = new System.Drawing.Point(7, 21);
            this.lblBaseBuyLongCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseBuyLongCost.Name = "lblBaseBuyLongCost";
            this.lblBaseBuyLongCost.Size = new System.Drawing.Size(84, 15);
            this.lblBaseBuyLongCost.TabIndex = 4;
            this.lblBaseBuyLongCost.Text = "Scrap Cost:";
            // 
            // btnBaseBuyLong
            // 
            this.btnBaseBuyLong.BackColor = System.Drawing.Color.OldLace;
            this.btnBaseBuyLong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseBuyLong.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaseBuyLong.ForeColor = System.Drawing.Color.Black;
            this.btnBaseBuyLong.Location = new System.Drawing.Point(9, 38);
            this.btnBaseBuyLong.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaseBuyLong.Name = "btnBaseBuyLong";
            this.btnBaseBuyLong.Size = new System.Drawing.Size(186, 29);
            this.btnBaseBuyLong.TabIndex = 3;
            this.btnBaseBuyLong.Text = "BUY TURRET";
            this.btnBaseBuyLong.UseVisualStyleBackColor = false;
            this.btnBaseBuyLong.Click += new System.EventHandler(this.btnBaseBuyLong_Click);
            // 
            // lblBaseBuyLongCostValue
            // 
            this.lblBaseBuyLongCostValue.AutoSize = true;
            this.lblBaseBuyLongCostValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblBaseBuyLongCostValue.Location = new System.Drawing.Point(94, 21);
            this.lblBaseBuyLongCostValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseBuyLongCostValue.Name = "lblBaseBuyLongCostValue";
            this.lblBaseBuyLongCostValue.Size = new System.Drawing.Size(32, 17);
            this.lblBaseBuyLongCostValue.TabIndex = 15;
            this.lblBaseBuyLongCostValue.Text = "000";
            // 
            // gbBaseMedium
            // 
            this.gbBaseMedium.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbBaseMedium.Controls.Add(this.pbBaseMedium);
            this.gbBaseMedium.Controls.Add(this.lblBaseBuyMediumCost);
            this.gbBaseMedium.Controls.Add(this.btnBaseBuyMedium);
            this.gbBaseMedium.Controls.Add(this.lblBaseBuyMediumCostValue);
            this.gbBaseMedium.Location = new System.Drawing.Point(10, 107);
            this.gbBaseMedium.Name = "gbBaseMedium";
            this.gbBaseMedium.Size = new System.Drawing.Size(264, 75);
            this.gbBaseMedium.TabIndex = 17;
            this.gbBaseMedium.TabStop = false;
            this.gbBaseMedium.Text = "Medium Range Turret";
            // 
            // pbBaseMedium
            // 
            this.pbBaseMedium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBaseMedium.BackgroundImage")));
            this.pbBaseMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBaseMedium.InitialImage = null;
            this.pbBaseMedium.Location = new System.Drawing.Point(205, 17);
            this.pbBaseMedium.Name = "pbBaseMedium";
            this.pbBaseMedium.Size = new System.Drawing.Size(50, 50);
            this.pbBaseMedium.TabIndex = 16;
            this.pbBaseMedium.TabStop = false;
            // 
            // lblBaseBuyMediumCost
            // 
            this.lblBaseBuyMediumCost.AutoSize = true;
            this.lblBaseBuyMediumCost.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBaseBuyMediumCost.Location = new System.Drawing.Point(7, 21);
            this.lblBaseBuyMediumCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseBuyMediumCost.Name = "lblBaseBuyMediumCost";
            this.lblBaseBuyMediumCost.Size = new System.Drawing.Size(84, 15);
            this.lblBaseBuyMediumCost.TabIndex = 4;
            this.lblBaseBuyMediumCost.Text = "Scrap Cost:";
            // 
            // btnBaseBuyMedium
            // 
            this.btnBaseBuyMedium.BackColor = System.Drawing.Color.OldLace;
            this.btnBaseBuyMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseBuyMedium.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaseBuyMedium.ForeColor = System.Drawing.Color.Black;
            this.btnBaseBuyMedium.Location = new System.Drawing.Point(9, 38);
            this.btnBaseBuyMedium.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaseBuyMedium.Name = "btnBaseBuyMedium";
            this.btnBaseBuyMedium.Size = new System.Drawing.Size(186, 29);
            this.btnBaseBuyMedium.TabIndex = 3;
            this.btnBaseBuyMedium.Text = "BUY TURRET";
            this.btnBaseBuyMedium.UseVisualStyleBackColor = false;
            this.btnBaseBuyMedium.Click += new System.EventHandler(this.btnBaseBuyMedium_Click);
            // 
            // lblBaseBuyMediumCostValue
            // 
            this.lblBaseBuyMediumCostValue.AutoSize = true;
            this.lblBaseBuyMediumCostValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblBaseBuyMediumCostValue.Location = new System.Drawing.Point(94, 21);
            this.lblBaseBuyMediumCostValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseBuyMediumCostValue.Name = "lblBaseBuyMediumCostValue";
            this.lblBaseBuyMediumCostValue.Size = new System.Drawing.Size(32, 17);
            this.lblBaseBuyMediumCostValue.TabIndex = 15;
            this.lblBaseBuyMediumCostValue.Text = "000";
            // 
            // gbBaseShort
            // 
            this.gbBaseShort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbBaseShort.Controls.Add(this.pbBaseShort);
            this.gbBaseShort.Controls.Add(this.lblBaseBuyShortCost);
            this.gbBaseShort.Controls.Add(this.btnBaseBuyShort);
            this.gbBaseShort.Controls.Add(this.lblBaseBuyShortCostValue);
            this.gbBaseShort.Location = new System.Drawing.Point(10, 24);
            this.gbBaseShort.Name = "gbBaseShort";
            this.gbBaseShort.Size = new System.Drawing.Size(264, 75);
            this.gbBaseShort.TabIndex = 16;
            this.gbBaseShort.TabStop = false;
            this.gbBaseShort.Text = "Short Range Turret";
            // 
            // pbBaseShort
            // 
            this.pbBaseShort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBaseShort.BackgroundImage")));
            this.pbBaseShort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBaseShort.InitialImage = null;
            this.pbBaseShort.Location = new System.Drawing.Point(205, 17);
            this.pbBaseShort.Name = "pbBaseShort";
            this.pbBaseShort.Size = new System.Drawing.Size(50, 50);
            this.pbBaseShort.TabIndex = 16;
            this.pbBaseShort.TabStop = false;
            // 
            // lblBaseBuyShortCost
            // 
            this.lblBaseBuyShortCost.AutoSize = true;
            this.lblBaseBuyShortCost.Font = new System.Drawing.Font("Roboto Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBaseBuyShortCost.Location = new System.Drawing.Point(7, 21);
            this.lblBaseBuyShortCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseBuyShortCost.Name = "lblBaseBuyShortCost";
            this.lblBaseBuyShortCost.Size = new System.Drawing.Size(84, 15);
            this.lblBaseBuyShortCost.TabIndex = 4;
            this.lblBaseBuyShortCost.Text = "Scrap Cost:";
            // 
            // btnBaseBuyShort
            // 
            this.btnBaseBuyShort.BackColor = System.Drawing.Color.OldLace;
            this.btnBaseBuyShort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseBuyShort.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaseBuyShort.ForeColor = System.Drawing.Color.Black;
            this.btnBaseBuyShort.Location = new System.Drawing.Point(9, 38);
            this.btnBaseBuyShort.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaseBuyShort.Name = "btnBaseBuyShort";
            this.btnBaseBuyShort.Size = new System.Drawing.Size(186, 29);
            this.btnBaseBuyShort.TabIndex = 3;
            this.btnBaseBuyShort.Text = "BUY TURRET";
            this.btnBaseBuyShort.UseVisualStyleBackColor = false;
            this.btnBaseBuyShort.Click += new System.EventHandler(this.btnBaseBuyShort_Click);
            // 
            // lblBaseBuyShortCostValue
            // 
            this.lblBaseBuyShortCostValue.AutoSize = true;
            this.lblBaseBuyShortCostValue.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblBaseBuyShortCostValue.Location = new System.Drawing.Point(94, 21);
            this.lblBaseBuyShortCostValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseBuyShortCostValue.Name = "lblBaseBuyShortCostValue";
            this.lblBaseBuyShortCostValue.Size = new System.Drawing.Size(32, 17);
            this.lblBaseBuyShortCostValue.TabIndex = 15;
            this.lblBaseBuyShortCostValue.Text = "000";
            // 
            // btnBaseExit
            // 
            this.btnBaseExit.BackColor = System.Drawing.Color.Red;
            this.btnBaseExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseExit.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaseExit.ForeColor = System.Drawing.Color.Black;
            this.btnBaseExit.Location = new System.Drawing.Point(13, 643);
            this.btnBaseExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaseExit.Name = "btnBaseExit";
            this.btnBaseExit.Size = new System.Drawing.Size(283, 43);
            this.btnBaseExit.TabIndex = 17;
            this.btnBaseExit.Text = "EXIT LEVEL";
            this.btnBaseExit.UseVisualStyleBackColor = false;
            this.btnBaseExit.Click += new System.EventHandler(this.btnBaseExit_Click);
            // 
            // gbBaseGlobalRules
            // 
            this.gbBaseGlobalRules.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbBaseGlobalRules.Controls.Add(this.btnBaseUnlockAll);
            this.gbBaseGlobalRules.Controls.Add(this.btnBaseApplyRules);
            this.gbBaseGlobalRules.Controls.Add(this.cbBaseTargetingModes);
            this.gbBaseGlobalRules.Font = new System.Drawing.Font("Roboto Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbBaseGlobalRules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbBaseGlobalRules.Location = new System.Drawing.Point(13, 521);
            this.gbBaseGlobalRules.Margin = new System.Windows.Forms.Padding(4);
            this.gbBaseGlobalRules.Name = "gbBaseGlobalRules";
            this.gbBaseGlobalRules.Padding = new System.Windows.Forms.Padding(4);
            this.gbBaseGlobalRules.Size = new System.Drawing.Size(283, 115);
            this.gbBaseGlobalRules.TabIndex = 7;
            this.gbBaseGlobalRules.TabStop = false;
            this.gbBaseGlobalRules.Text = "Global Targeting Rules";
            // 
            // btnBaseUnlockAll
            // 
            this.btnBaseUnlockAll.BackColor = System.Drawing.Color.OldLace;
            this.btnBaseUnlockAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseUnlockAll.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaseUnlockAll.ForeColor = System.Drawing.Color.Black;
            this.btnBaseUnlockAll.Location = new System.Drawing.Point(146, 25);
            this.btnBaseUnlockAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaseUnlockAll.Name = "btnBaseUnlockAll";
            this.btnBaseUnlockAll.Size = new System.Drawing.Size(120, 43);
            this.btnBaseUnlockAll.TabIndex = 18;
            this.btnBaseUnlockAll.Text = "UNLOCK ALL TURRETS";
            this.btnBaseUnlockAll.UseVisualStyleBackColor = false;
            this.btnBaseUnlockAll.Click += new System.EventHandler(this.btnBaseUnlockAll_Click);
            // 
            // btnBaseApplyRules
            // 
            this.btnBaseApplyRules.BackColor = System.Drawing.Color.OldLace;
            this.btnBaseApplyRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseApplyRules.Font = new System.Drawing.Font("Roboto Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaseApplyRules.ForeColor = System.Drawing.Color.Black;
            this.btnBaseApplyRules.Location = new System.Drawing.Point(11, 25);
            this.btnBaseApplyRules.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaseApplyRules.Name = "btnBaseApplyRules";
            this.btnBaseApplyRules.Size = new System.Drawing.Size(120, 43);
            this.btnBaseApplyRules.TabIndex = 17;
            this.btnBaseApplyRules.Text = "APPLY RULES";
            this.btnBaseApplyRules.UseVisualStyleBackColor = false;
            this.btnBaseApplyRules.Click += new System.EventHandler(this.btnBaseApplyRules_Click);
            // 
            // cbBaseTargetingModes
            // 
            this.cbBaseTargetingModes.DropDownHeight = 133;
            this.cbBaseTargetingModes.FormattingEnabled = true;
            this.cbBaseTargetingModes.IntegralHeight = false;
            this.cbBaseTargetingModes.ItemHeight = 19;
            this.cbBaseTargetingModes.Items.AddRange(new object[] {
            "closest",
            "furthest",
            "mostHealth",
            "leastHealth",
            "mostTotHealth",
            "mostValue",
            "leastValue"});
            this.cbBaseTargetingModes.Location = new System.Drawing.Point(11, 77);
            this.cbBaseTargetingModes.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaseTargetingModes.MaxDropDownItems = 7;
            this.cbBaseTargetingModes.Name = "cbBaseTargetingModes";
            this.cbBaseTargetingModes.Size = new System.Drawing.Size(181, 27);
            this.cbBaseTargetingModes.TabIndex = 6;
            // 
            // BaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(309, 696);
            this.ControlBox = false;
            this.Controls.Add(this.gbBaseGlobalRules);
            this.Controls.Add(this.btnBaseExit);
            this.Controls.Add(this.gbBaseBuildTurret);
            this.Controls.Add(this.gbBaseResources);
            this.Controls.Add(this.labelTurretName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 735);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 735);
            this.Name = "BaseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BaseMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BaseMenu_Load);
            this.gbBaseResources.ResumeLayout(false);
            this.gbBaseResources.PerformLayout();
            this.gbBaseBuildTurret.ResumeLayout(false);
            this.gbBaseTower.ResumeLayout(false);
            this.gbBaseTower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseTower)).EndInit();
            this.gbBaseLong.ResumeLayout(false);
            this.gbBaseLong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseLong)).EndInit();
            this.gbBaseMedium.ResumeLayout(false);
            this.gbBaseMedium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseMedium)).EndInit();
            this.gbBaseShort.ResumeLayout(false);
            this.gbBaseShort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseShort)).EndInit();
            this.gbBaseGlobalRules.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTurretName;
        private System.Windows.Forms.GroupBox gbBaseResources;
        private System.Windows.Forms.Label lblBaseScrap;
        private System.Windows.Forms.Label lblBaseAlienScrap;
        private System.Windows.Forms.Label lblBaseHealth;
        private System.Windows.Forms.GroupBox gbBaseBuildTurret;
        private System.Windows.Forms.Label lblBaseBuyShortCost;
        private System.Windows.Forms.Button btnBaseBuyShort;
        private System.Windows.Forms.GroupBox gbBaseShort;
        private System.Windows.Forms.GroupBox gbBaseMedium;
        private System.Windows.Forms.PictureBox pbBaseMedium;
        private System.Windows.Forms.Label lblBaseBuyMediumCost;
        private System.Windows.Forms.Button btnBaseBuyMedium;
        private System.Windows.Forms.PictureBox pbBaseShort;
        private System.Windows.Forms.GroupBox gbBaseLong;
        private System.Windows.Forms.PictureBox pbBaseLong;
        private System.Windows.Forms.Label lblBaseBuyLongCost;
        private System.Windows.Forms.Button btnBaseBuyLong;
        private System.Windows.Forms.Button btnBaseExit;
        private System.Windows.Forms.GroupBox gbBaseGlobalRules;
        private System.Windows.Forms.Button btnBaseUnlockAll;
        private System.Windows.Forms.Button btnBaseApplyRules;
        private System.Windows.Forms.Label lblBaseEnemiesKilled;
        public System.Windows.Forms.Label lblBaseEnemiesKilledValue;
        public System.Windows.Forms.Label lblBaseAlienScrapValue;
        public System.Windows.Forms.Label lblBaseScrapValue;
        private System.Windows.Forms.GroupBox gbBaseTower;
        private System.Windows.Forms.PictureBox pbBaseTower;
        private System.Windows.Forms.Label lblBaseBuyTowerCost;
        private System.Windows.Forms.Button btnBaseBuyTower;
        public System.Windows.Forms.ComboBox cbBaseTargetingModes;
        public System.Windows.Forms.Label lblBaseHealthValue;
        public System.Windows.Forms.Label lblBaseBuyShortCostValue;
        public System.Windows.Forms.Label lblBaseBuyMediumCostValue;
        public System.Windows.Forms.Label lblBaseBuyLongCostValue;
        public System.Windows.Forms.Label lblBaseBuyTowerCostValue;
    }
}