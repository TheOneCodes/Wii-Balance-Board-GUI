namespace WiiBalanceWalker
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label_rwWT = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_brX = new System.Windows.Forms.Label();
            this.label_brY = new System.Windows.Forms.Label();
            this.label_brDL = new System.Windows.Forms.Label();
            this.label_brDR = new System.Windows.Forms.Label();
            this.groupBox_RawWeight = new System.Windows.Forms.GroupBox();
            this.label_rwBR = new System.Windows.Forms.Label();
            this.label_rwBL = new System.Windows.Forms.Label();
            this.label_rwTR = new System.Windows.Forms.Label();
            this.label_rwTL = new System.Windows.Forms.Label();
            this.groupBox_OffsetWeight = new System.Windows.Forms.GroupBox();
            this.label_owWT = new System.Windows.Forms.Label();
            this.label_owTL = new System.Windows.Forms.Label();
            this.label_owTR = new System.Windows.Forms.Label();
            this.label_owBL = new System.Windows.Forms.Label();
            this.label_owBR = new System.Windows.Forms.Label();
            this.groupBox_OffsetWeightRatio = new System.Windows.Forms.GroupBox();
            this.label_owrTL = new System.Windows.Forms.Label();
            this.label_owrTR = new System.Windows.Forms.Label();
            this.label_owrBL = new System.Windows.Forms.Label();
            this.label_owrBR = new System.Windows.Forms.Label();
            this.button_SetCenterOffset = new System.Windows.Forms.Button();
            this.button_ResetDefaults = new System.Windows.Forms.Button();
            this.button_BluetoothAddDevice = new System.Windows.Forms.Button();
            this.groupBox_BalanceRatio = new System.Windows.Forms.GroupBox();
            this.label_brDF = new System.Windows.Forms.Label();
            this.groupBox_BalanceRatioTriggers = new System.Windows.Forms.GroupBox();
            this.numericUpDown_TMFB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TMLR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TFB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TLR = new System.Windows.Forms.NumericUpDown();
            this.label_TMFB = new System.Windows.Forms.Label();
            this.label_TMLR = new System.Windows.Forms.Label();
            this.label_TFB = new System.Windows.Forms.Label();
            this.label_TLR = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.checkBox_EnableJoystick = new System.Windows.Forms.CheckBox();
            this.checkBox_DisableActions = new System.Windows.Forms.CheckBox();
            this.numericUpDown_ADR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ADL = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AJ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AF = new System.Windows.Forms.NumericUpDown();
            this.comboBox_ADR = new System.Windows.Forms.ComboBox();
            this.comboBox_AJ = new System.Windows.Forms.ComboBox();
            this.comboBox_ADL = new System.Windows.Forms.ComboBox();
            this.label_ActionJump = new System.Windows.Forms.Label();
            this.label_ActionDiagonalRight = new System.Windows.Forms.Label();
            this.label_ActionDiagonalLeft = new System.Windows.Forms.Label();
            this.label_ActionModifier = new System.Windows.Forms.Label();
            this.label_ActionBackward = new System.Windows.Forms.Label();
            this.label_ActionForward = new System.Windows.Forms.Label();
            this.label_ActionRight = new System.Windows.Forms.Label();
            this.label_ActionLeft = new System.Windows.Forms.Label();
            this.numericUpDown_AR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AL = new System.Windows.Forms.NumericUpDown();
            this.comboBox_AM = new System.Windows.Forms.ComboBox();
            this.comboBox_AF = new System.Windows.Forms.ComboBox();
            this.comboBox_AB = new System.Windows.Forms.ComboBox();
            this.comboBox_AR = new System.Windows.Forms.ComboBox();
            this.comboBox_AL = new System.Windows.Forms.ComboBox();
            this.panel_Config = new System.Windows.Forms.Panel();
            this.linkLabel_Show = new System.Windows.Forms.LinkLabel();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pairBluetoothDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.centerBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.joystickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_RawWeight.SuspendLayout();
            this.groupBox_OffsetWeight.SuspendLayout();
            this.groupBox_OffsetWeightRatio.SuspendLayout();
            this.groupBox_BalanceRatio.SuspendLayout();
            this.groupBox_BalanceRatioTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TMFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TMLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ADR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ADL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AL)).BeginInit();
            this.panel_Config.SuspendLayout();
            this.trayContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_rwWT
            // 
            this.label_rwWT.AutoSize = true;
            this.label_rwWT.Location = new System.Drawing.Point(53, 66);
            this.label_rwWT.Name = "label_rwWT";
            this.label_rwWT.Size = new System.Drawing.Size(24, 13);
            this.label_rwWT.TabIndex = 0;
            this.label_rwWT.Text = "WT";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(12, 80);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(272, 48);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect Paired Board";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_brX
            // 
            this.label_brX.AutoSize = true;
            this.label_brX.Location = new System.Drawing.Point(6, 16);
            this.label_brX.Name = "label_brX";
            this.label_brX.Size = new System.Drawing.Size(14, 13);
            this.label_brX.TabIndex = 0;
            this.label_brX.Text = "X";
            // 
            // label_brY
            // 
            this.label_brY.AutoSize = true;
            this.label_brY.Location = new System.Drawing.Point(102, 20);
            this.label_brY.Name = "label_brY";
            this.label_brY.Size = new System.Drawing.Size(13, 13);
            this.label_brY.TabIndex = 0;
            this.label_brY.Text = "Y";
            // 
            // label_brDL
            // 
            this.label_brDL.AutoSize = true;
            this.label_brDL.Location = new System.Drawing.Point(6, 112);
            this.label_brDL.Name = "label_brDL";
            this.label_brDL.Size = new System.Drawing.Size(20, 13);
            this.label_brDL.TabIndex = 0;
            this.label_brDL.Text = "DL";
            // 
            // label_brDR
            // 
            this.label_brDR.AutoSize = true;
            this.label_brDR.Location = new System.Drawing.Point(100, 112);
            this.label_brDR.Name = "label_brDR";
            this.label_brDR.Size = new System.Drawing.Size(22, 13);
            this.label_brDR.TabIndex = 0;
            this.label_brDR.Text = "DR";
            // 
            // groupBox_RawWeight
            // 
            this.groupBox_RawWeight.Controls.Add(this.label_rwBR);
            this.groupBox_RawWeight.Controls.Add(this.label_rwBL);
            this.groupBox_RawWeight.Controls.Add(this.label_rwTR);
            this.groupBox_RawWeight.Controls.Add(this.label_rwTL);
            this.groupBox_RawWeight.Controls.Add(this.label_rwWT);
            this.groupBox_RawWeight.Location = new System.Drawing.Point(278, 2);
            this.groupBox_RawWeight.Name = "groupBox_RawWeight";
            this.groupBox_RawWeight.Size = new System.Drawing.Size(128, 128);
            this.groupBox_RawWeight.TabIndex = 3;
            this.groupBox_RawWeight.TabStop = false;
            this.groupBox_RawWeight.Text = "Raw Weight";
            // 
            // label_rwBR
            // 
            this.label_rwBR.AutoSize = true;
            this.label_rwBR.Location = new System.Drawing.Point(101, 112);
            this.label_rwBR.Name = "label_rwBR";
            this.label_rwBR.Size = new System.Drawing.Size(21, 13);
            this.label_rwBR.TabIndex = 0;
            this.label_rwBR.Text = "BR";
            // 
            // label_rwBL
            // 
            this.label_rwBL.AutoSize = true;
            this.label_rwBL.Location = new System.Drawing.Point(6, 112);
            this.label_rwBL.Name = "label_rwBL";
            this.label_rwBL.Size = new System.Drawing.Size(19, 13);
            this.label_rwBL.TabIndex = 0;
            this.label_rwBL.Text = "BL";
            // 
            // label_rwTR
            // 
            this.label_rwTR.AutoSize = true;
            this.label_rwTR.Location = new System.Drawing.Point(102, 18);
            this.label_rwTR.Name = "label_rwTR";
            this.label_rwTR.Size = new System.Drawing.Size(20, 13);
            this.label_rwTR.TabIndex = 0;
            this.label_rwTR.Text = "TR";
            // 
            // label_rwTL
            // 
            this.label_rwTL.AutoSize = true;
            this.label_rwTL.Location = new System.Drawing.Point(6, 18);
            this.label_rwTL.Name = "label_rwTL";
            this.label_rwTL.Size = new System.Drawing.Size(18, 13);
            this.label_rwTL.TabIndex = 0;
            this.label_rwTL.Text = "TL";
            // 
            // groupBox_OffsetWeight
            // 
            this.groupBox_OffsetWeight.Controls.Add(this.label_owWT);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owTL);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owTR);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owBL);
            this.groupBox_OffsetWeight.Controls.Add(this.label_owBR);
            this.groupBox_OffsetWeight.Location = new System.Drawing.Point(412, 2);
            this.groupBox_OffsetWeight.Name = "groupBox_OffsetWeight";
            this.groupBox_OffsetWeight.Size = new System.Drawing.Size(128, 128);
            this.groupBox_OffsetWeight.TabIndex = 4;
            this.groupBox_OffsetWeight.TabStop = false;
            this.groupBox_OffsetWeight.Text = "Offset Weight";
            // 
            // label_owWT
            // 
            this.label_owWT.AutoSize = true;
            this.label_owWT.Location = new System.Drawing.Point(55, 66);
            this.label_owWT.Name = "label_owWT";
            this.label_owWT.Size = new System.Drawing.Size(24, 13);
            this.label_owWT.TabIndex = 1;
            this.label_owWT.Text = "WT";
            // 
            // label_owTL
            // 
            this.label_owTL.AutoSize = true;
            this.label_owTL.Location = new System.Drawing.Point(6, 18);
            this.label_owTL.Name = "label_owTL";
            this.label_owTL.Size = new System.Drawing.Size(18, 13);
            this.label_owTL.TabIndex = 0;
            this.label_owTL.Text = "TL";
            // 
            // label_owTR
            // 
            this.label_owTR.AutoSize = true;
            this.label_owTR.Location = new System.Drawing.Point(102, 18);
            this.label_owTR.Name = "label_owTR";
            this.label_owTR.Size = new System.Drawing.Size(20, 13);
            this.label_owTR.TabIndex = 0;
            this.label_owTR.Text = "TR";
            // 
            // label_owBL
            // 
            this.label_owBL.AutoSize = true;
            this.label_owBL.Location = new System.Drawing.Point(5, 102);
            this.label_owBL.Name = "label_owBL";
            this.label_owBL.Size = new System.Drawing.Size(19, 13);
            this.label_owBL.TabIndex = 0;
            this.label_owBL.Text = "BL";
            // 
            // label_owBR
            // 
            this.label_owBR.AutoSize = true;
            this.label_owBR.Location = new System.Drawing.Point(102, 102);
            this.label_owBR.Name = "label_owBR";
            this.label_owBR.Size = new System.Drawing.Size(21, 13);
            this.label_owBR.TabIndex = 0;
            this.label_owBR.Text = "BR";
            // 
            // groupBox_OffsetWeightRatio
            // 
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrTL);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrTR);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrBL);
            this.groupBox_OffsetWeightRatio.Controls.Add(this.label_owrBR);
            this.groupBox_OffsetWeightRatio.Location = new System.Drawing.Point(278, 136);
            this.groupBox_OffsetWeightRatio.Name = "groupBox_OffsetWeightRatio";
            this.groupBox_OffsetWeightRatio.Size = new System.Drawing.Size(128, 128);
            this.groupBox_OffsetWeightRatio.TabIndex = 4;
            this.groupBox_OffsetWeightRatio.TabStop = false;
            this.groupBox_OffsetWeightRatio.Text = "Offset Ratio";
            // 
            // label_owrTL
            // 
            this.label_owrTL.AutoSize = true;
            this.label_owrTL.Location = new System.Drawing.Point(6, 18);
            this.label_owrTL.Name = "label_owrTL";
            this.label_owrTL.Size = new System.Drawing.Size(18, 13);
            this.label_owrTL.TabIndex = 0;
            this.label_owrTL.Text = "TL";
            // 
            // label_owrTR
            // 
            this.label_owrTR.AutoSize = true;
            this.label_owrTR.Location = new System.Drawing.Point(102, 18);
            this.label_owrTR.Name = "label_owrTR";
            this.label_owrTR.Size = new System.Drawing.Size(20, 13);
            this.label_owrTR.TabIndex = 0;
            this.label_owrTR.Text = "TR";
            // 
            // label_owrBL
            // 
            this.label_owrBL.AutoSize = true;
            this.label_owrBL.Location = new System.Drawing.Point(5, 112);
            this.label_owrBL.Name = "label_owrBL";
            this.label_owrBL.Size = new System.Drawing.Size(19, 13);
            this.label_owrBL.TabIndex = 0;
            this.label_owrBL.Text = "BL";
            // 
            // label_owrBR
            // 
            this.label_owrBR.AutoSize = true;
            this.label_owrBR.Location = new System.Drawing.Point(101, 112);
            this.label_owrBR.Name = "label_owrBR";
            this.label_owrBR.Size = new System.Drawing.Size(21, 13);
            this.label_owrBR.TabIndex = 0;
            this.label_owrBR.Text = "BR";
            // 
            // button_SetCenterOffset
            // 
            this.button_SetCenterOffset.Location = new System.Drawing.Point(12, 12);
            this.button_SetCenterOffset.Name = "button_SetCenterOffset";
            this.button_SetCenterOffset.Size = new System.Drawing.Size(138, 62);
            this.button_SetCenterOffset.TabIndex = 2;
            this.button_SetCenterOffset.Text = "Center Balance";
            this.button_SetCenterOffset.UseVisualStyleBackColor = true;
            this.button_SetCenterOffset.Click += new System.EventHandler(this.button_SetCenterOffset_Click);
            // 
            // button_ResetDefaults
            // 
            this.button_ResetDefaults.Location = new System.Drawing.Point(144, 142);
            this.button_ResetDefaults.Name = "button_ResetDefaults";
            this.button_ResetDefaults.Size = new System.Drawing.Size(128, 23);
            this.button_ResetDefaults.TabIndex = 3;
            this.button_ResetDefaults.Text = "Reset and Close";
            this.button_ResetDefaults.UseVisualStyleBackColor = true;
            this.button_ResetDefaults.Click += new System.EventHandler(this.button_ResetDefaults_Click);
            // 
            // button_BluetoothAddDevice
            // 
            this.button_BluetoothAddDevice.Location = new System.Drawing.Point(156, 12);
            this.button_BluetoothAddDevice.Name = "button_BluetoothAddDevice";
            this.button_BluetoothAddDevice.Size = new System.Drawing.Size(128, 62);
            this.button_BluetoothAddDevice.TabIndex = 1;
            this.button_BluetoothAddDevice.Text = "Pair Device(s)";
            this.button_BluetoothAddDevice.UseVisualStyleBackColor = true;
            this.button_BluetoothAddDevice.Click += new System.EventHandler(this.button_BluetoothAddDevice_Click);
            // 
            // groupBox_BalanceRatio
            // 
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDF);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brX);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDR);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brDL);
            this.groupBox_BalanceRatio.Controls.Add(this.label_brY);
            this.groupBox_BalanceRatio.Location = new System.Drawing.Point(412, 136);
            this.groupBox_BalanceRatio.Name = "groupBox_BalanceRatio";
            this.groupBox_BalanceRatio.Size = new System.Drawing.Size(128, 128);
            this.groupBox_BalanceRatio.TabIndex = 5;
            this.groupBox_BalanceRatio.TabStop = false;
            this.groupBox_BalanceRatio.Text = "Balance Ratio";
            // 
            // label_brDF
            // 
            this.label_brDF.AutoSize = true;
            this.label_brDF.Location = new System.Drawing.Point(58, 65);
            this.label_brDF.Name = "label_brDF";
            this.label_brDF.Size = new System.Drawing.Size(21, 13);
            this.label_brDF.TabIndex = 0;
            this.label_brDF.Text = "DF";
            // 
            // groupBox_BalanceRatioTriggers
            // 
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.numericUpDown_TMFB);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.numericUpDown_TMLR);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.numericUpDown_TFB);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.numericUpDown_TLR);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.label_TMFB);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.label_TMLR);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.label_TFB);
            this.groupBox_BalanceRatioTriggers.Controls.Add(this.label_TLR);
            this.groupBox_BalanceRatioTriggers.Location = new System.Drawing.Point(278, 270);
            this.groupBox_BalanceRatioTriggers.Name = "groupBox_BalanceRatioTriggers";
            this.groupBox_BalanceRatioTriggers.Size = new System.Drawing.Size(262, 136);
            this.groupBox_BalanceRatioTriggers.TabIndex = 1;
            this.groupBox_BalanceRatioTriggers.TabStop = false;
            this.groupBox_BalanceRatioTriggers.Text = "Balance Ratio Triggers";
            // 
            // numericUpDown_TMFB
            // 
            this.numericUpDown_TMFB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_TMFB.Location = new System.Drawing.Point(207, 104);
            this.numericUpDown_TMFB.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_TMFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TMFB.Name = "numericUpDown_TMFB";
            this.numericUpDown_TMFB.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown_TMFB.TabIndex = 3;
            this.numericUpDown_TMFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TMFB.ValueChanged += new System.EventHandler(this.numericUpDown_TMFB_ValueChanged);
            // 
            // numericUpDown_TMLR
            // 
            this.numericUpDown_TMLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_TMLR.Location = new System.Drawing.Point(207, 78);
            this.numericUpDown_TMLR.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_TMLR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TMLR.Name = "numericUpDown_TMLR";
            this.numericUpDown_TMLR.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown_TMLR.TabIndex = 2;
            this.numericUpDown_TMLR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TMLR.ValueChanged += new System.EventHandler(this.numericUpDown_TMLR_ValueChanged);
            // 
            // numericUpDown_TFB
            // 
            this.numericUpDown_TFB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_TFB.Location = new System.Drawing.Point(207, 52);
            this.numericUpDown_TFB.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_TFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TFB.Name = "numericUpDown_TFB";
            this.numericUpDown_TFB.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown_TFB.TabIndex = 1;
            this.numericUpDown_TFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TFB.ValueChanged += new System.EventHandler(this.numericUpDown_TFB_ValueChanged);
            // 
            // numericUpDown_TLR
            // 
            this.numericUpDown_TLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_TLR.Location = new System.Drawing.Point(207, 26);
            this.numericUpDown_TLR.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDown_TLR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TLR.Name = "numericUpDown_TLR";
            this.numericUpDown_TLR.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown_TLR.TabIndex = 0;
            this.numericUpDown_TLR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TLR.ValueChanged += new System.EventHandler(this.numericUpDown_TLR_ValueChanged);
            // 
            // label_TMFB
            // 
            this.label_TMFB.AutoSize = true;
            this.label_TMFB.Location = new System.Drawing.Point(6, 106);
            this.label_TMFB.Name = "label_TMFB";
            this.label_TMFB.Size = new System.Drawing.Size(170, 13);
            this.label_TMFB.TabIndex = 0;
            this.label_TMFB.Text = "- Modifier + Foward / Backward";
            // 
            // label_TMLR
            // 
            this.label_TMLR.AutoSize = true;
            this.label_TMLR.Location = new System.Drawing.Point(6, 80);
            this.label_TMLR.Name = "label_TMLR";
            this.label_TMLR.Size = new System.Drawing.Size(129, 13);
            this.label_TMLR.TabIndex = 0;
            this.label_TMLR.Text = "- Modifier + Left / Right";
            // 
            // label_TFB
            // 
            this.label_TFB.AutoSize = true;
            this.label_TFB.Location = new System.Drawing.Point(6, 54);
            this.label_TFB.Name = "label_TFB";
            this.label_TFB.Size = new System.Drawing.Size(116, 13);
            this.label_TFB.TabIndex = 0;
            this.label_TFB.Text = "- Forward / Backward";
            // 
            // label_TLR
            // 
            this.label_TLR.AutoSize = true;
            this.label_TLR.Location = new System.Drawing.Point(6, 28);
            this.label_TLR.Name = "label_TLR";
            this.label_TLR.Size = new System.Drawing.Size(71, 13);
            this.label_TLR.TabIndex = 0;
            this.label_TLR.Text = "- Left / Right";
            // 
            // label_Status
            // 
            this.label_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Status.Location = new System.Drawing.Point(0, 385);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(272, 20);
            this.label_Status.TabIndex = 4;
            this.label_Status.Text = "STATUS";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox_EnableJoystick
            // 
            this.checkBox_EnableJoystick.AutoSize = true;
            this.checkBox_EnableJoystick.Location = new System.Drawing.Point(156, 134);
            this.checkBox_EnableJoystick.Name = "checkBox_EnableJoystick";
            this.checkBox_EnableJoystick.Size = new System.Drawing.Size(103, 17);
            this.checkBox_EnableJoystick.TabIndex = 1;
            this.checkBox_EnableJoystick.Text = "Enable Joystick";
            this.checkBox_EnableJoystick.UseVisualStyleBackColor = true;
            this.checkBox_EnableJoystick.CheckedChanged += new System.EventHandler(this.checkBox_EnableJoystick_CheckedChanged);
            // 
            // checkBox_DisableActions
            // 
            this.checkBox_DisableActions.AutoSize = true;
            this.checkBox_DisableActions.Location = new System.Drawing.Point(12, 134);
            this.checkBox_DisableActions.Name = "checkBox_DisableActions";
            this.checkBox_DisableActions.Size = new System.Drawing.Size(71, 17);
            this.checkBox_DisableActions.TabIndex = 0;
            this.checkBox_DisableActions.Text = "Disabled";
            this.checkBox_DisableActions.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_ADR
            // 
            this.numericUpDown_ADR.Location = new System.Drawing.Point(220, 360);
            this.numericUpDown_ADR.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_ADR.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_ADR.Name = "numericUpDown_ADR";
            this.numericUpDown_ADR.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown_ADR.TabIndex = 17;
            // 
            // numericUpDown_ADL
            // 
            this.numericUpDown_ADL.Location = new System.Drawing.Point(220, 333);
            this.numericUpDown_ADL.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_ADL.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_ADL.Name = "numericUpDown_ADL";
            this.numericUpDown_ADL.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown_ADL.TabIndex = 15;
            // 
            // numericUpDown_AJ
            // 
            this.numericUpDown_AJ.Location = new System.Drawing.Point(220, 306);
            this.numericUpDown_AJ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AJ.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AJ.Name = "numericUpDown_AJ";
            this.numericUpDown_AJ.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown_AJ.TabIndex = 13;
            // 
            // numericUpDown_AM
            // 
            this.numericUpDown_AM.Location = new System.Drawing.Point(220, 279);
            this.numericUpDown_AM.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AM.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AM.Name = "numericUpDown_AM";
            this.numericUpDown_AM.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown_AM.TabIndex = 11;
            // 
            // numericUpDown_AB
            // 
            this.numericUpDown_AB.Location = new System.Drawing.Point(220, 252);
            this.numericUpDown_AB.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AB.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AB.Name = "numericUpDown_AB";
            this.numericUpDown_AB.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown_AB.TabIndex = 9;
            // 
            // numericUpDown_AF
            // 
            this.numericUpDown_AF.Location = new System.Drawing.Point(220, 225);
            this.numericUpDown_AF.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AF.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AF.Name = "numericUpDown_AF";
            this.numericUpDown_AF.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown_AF.TabIndex = 7;
            // 
            // comboBox_ADR
            // 
            this.comboBox_ADR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ADR.FormattingEnabled = true;
            this.comboBox_ADR.Location = new System.Drawing.Point(89, 360);
            this.comboBox_ADR.Name = "comboBox_ADR";
            this.comboBox_ADR.Size = new System.Drawing.Size(125, 21);
            this.comboBox_ADR.TabIndex = 16;
            // 
            // comboBox_AJ
            // 
            this.comboBox_AJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AJ.FormattingEnabled = true;
            this.comboBox_AJ.Location = new System.Drawing.Point(89, 306);
            this.comboBox_AJ.Name = "comboBox_AJ";
            this.comboBox_AJ.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AJ.TabIndex = 12;
            // 
            // comboBox_ADL
            // 
            this.comboBox_ADL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ADL.FormattingEnabled = true;
            this.comboBox_ADL.Location = new System.Drawing.Point(89, 333);
            this.comboBox_ADL.Name = "comboBox_ADL";
            this.comboBox_ADL.Size = new System.Drawing.Size(125, 21);
            this.comboBox_ADL.TabIndex = 14;
            // 
            // label_ActionJump
            // 
            this.label_ActionJump.AutoSize = true;
            this.label_ActionJump.Location = new System.Drawing.Point(0, 309);
            this.label_ActionJump.Name = "label_ActionJump";
            this.label_ActionJump.Size = new System.Drawing.Size(41, 13);
            this.label_ActionJump.TabIndex = 0;
            this.label_ActionJump.Text = "- Jump";
            // 
            // label_ActionDiagonalRight
            // 
            this.label_ActionDiagonalRight.AutoSize = true;
            this.label_ActionDiagonalRight.Location = new System.Drawing.Point(0, 363);
            this.label_ActionDiagonalRight.Name = "label_ActionDiagonalRight";
            this.label_ActionDiagonalRight.Size = new System.Drawing.Size(90, 13);
            this.label_ActionDiagonalRight.TabIndex = 0;
            this.label_ActionDiagonalRight.Text = "- Diagonal Right";
            // 
            // label_ActionDiagonalLeft
            // 
            this.label_ActionDiagonalLeft.AutoSize = true;
            this.label_ActionDiagonalLeft.Location = new System.Drawing.Point(0, 336);
            this.label_ActionDiagonalLeft.Name = "label_ActionDiagonalLeft";
            this.label_ActionDiagonalLeft.Size = new System.Drawing.Size(82, 13);
            this.label_ActionDiagonalLeft.TabIndex = 0;
            this.label_ActionDiagonalLeft.Text = "- Diagonal Left";
            // 
            // label_ActionModifier
            // 
            this.label_ActionModifier.AutoSize = true;
            this.label_ActionModifier.Location = new System.Drawing.Point(0, 282);
            this.label_ActionModifier.Name = "label_ActionModifier";
            this.label_ActionModifier.Size = new System.Drawing.Size(58, 13);
            this.label_ActionModifier.TabIndex = 0;
            this.label_ActionModifier.Text = "- Modifier";
            // 
            // label_ActionBackward
            // 
            this.label_ActionBackward.AutoSize = true;
            this.label_ActionBackward.Location = new System.Drawing.Point(0, 255);
            this.label_ActionBackward.Name = "label_ActionBackward";
            this.label_ActionBackward.Size = new System.Drawing.Size(63, 13);
            this.label_ActionBackward.TabIndex = 0;
            this.label_ActionBackward.Text = "- Backward";
            // 
            // label_ActionForward
            // 
            this.label_ActionForward.AutoSize = true;
            this.label_ActionForward.Location = new System.Drawing.Point(0, 228);
            this.label_ActionForward.Name = "label_ActionForward";
            this.label_ActionForward.Size = new System.Drawing.Size(56, 13);
            this.label_ActionForward.TabIndex = 0;
            this.label_ActionForward.Text = "- Forward";
            // 
            // label_ActionRight
            // 
            this.label_ActionRight.AutoSize = true;
            this.label_ActionRight.Location = new System.Drawing.Point(0, 201);
            this.label_ActionRight.Name = "label_ActionRight";
            this.label_ActionRight.Size = new System.Drawing.Size(41, 13);
            this.label_ActionRight.TabIndex = 0;
            this.label_ActionRight.Text = "- Right";
            // 
            // label_ActionLeft
            // 
            this.label_ActionLeft.AutoSize = true;
            this.label_ActionLeft.Location = new System.Drawing.Point(0, 174);
            this.label_ActionLeft.Name = "label_ActionLeft";
            this.label_ActionLeft.Size = new System.Drawing.Size(33, 13);
            this.label_ActionLeft.TabIndex = 0;
            this.label_ActionLeft.Text = "- Left";
            // 
            // numericUpDown_AR
            // 
            this.numericUpDown_AR.Location = new System.Drawing.Point(220, 198);
            this.numericUpDown_AR.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AR.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AR.Name = "numericUpDown_AR";
            this.numericUpDown_AR.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown_AR.TabIndex = 5;
            // 
            // numericUpDown_AL
            // 
            this.numericUpDown_AL.Location = new System.Drawing.Point(220, 171);
            this.numericUpDown_AL.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_AL.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numericUpDown_AL.Name = "numericUpDown_AL";
            this.numericUpDown_AL.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown_AL.TabIndex = 3;
            // 
            // comboBox_AM
            // 
            this.comboBox_AM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AM.FormattingEnabled = true;
            this.comboBox_AM.Location = new System.Drawing.Point(89, 279);
            this.comboBox_AM.Name = "comboBox_AM";
            this.comboBox_AM.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AM.TabIndex = 10;
            // 
            // comboBox_AF
            // 
            this.comboBox_AF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AF.FormattingEnabled = true;
            this.comboBox_AF.Location = new System.Drawing.Point(89, 225);
            this.comboBox_AF.Name = "comboBox_AF";
            this.comboBox_AF.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AF.TabIndex = 6;
            // 
            // comboBox_AB
            // 
            this.comboBox_AB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AB.FormattingEnabled = true;
            this.comboBox_AB.Location = new System.Drawing.Point(89, 252);
            this.comboBox_AB.Name = "comboBox_AB";
            this.comboBox_AB.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AB.TabIndex = 8;
            // 
            // comboBox_AR
            // 
            this.comboBox_AR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AR.FormattingEnabled = true;
            this.comboBox_AR.Location = new System.Drawing.Point(89, 198);
            this.comboBox_AR.Name = "comboBox_AR";
            this.comboBox_AR.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AR.TabIndex = 4;
            // 
            // comboBox_AL
            // 
            this.comboBox_AL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AL.FormattingEnabled = true;
            this.comboBox_AL.Location = new System.Drawing.Point(89, 171);
            this.comboBox_AL.Name = "comboBox_AL";
            this.comboBox_AL.Size = new System.Drawing.Size(125, 21);
            this.comboBox_AL.TabIndex = 2;
            // 
            // panel_Config
            // 
            this.panel_Config.Controls.Add(this.numericUpDown_AR);
            this.panel_Config.Controls.Add(this.numericUpDown_AL);
            this.panel_Config.Controls.Add(this.label_ActionRight);
            this.panel_Config.Controls.Add(this.button_ResetDefaults);
            this.panel_Config.Controls.Add(this.groupBox_BalanceRatioTriggers);
            this.panel_Config.Controls.Add(this.comboBox_AM);
            this.panel_Config.Controls.Add(this.groupBox_BalanceRatio);
            this.panel_Config.Controls.Add(this.numericUpDown_ADR);
            this.panel_Config.Controls.Add(this.groupBox_OffsetWeightRatio);
            this.panel_Config.Controls.Add(this.label_ActionForward);
            this.panel_Config.Controls.Add(this.groupBox_OffsetWeight);
            this.panel_Config.Controls.Add(this.comboBox_AF);
            this.panel_Config.Controls.Add(this.groupBox_RawWeight);
            this.panel_Config.Controls.Add(this.numericUpDown_ADL);
            this.panel_Config.Controls.Add(this.label_ActionBackward);
            this.panel_Config.Controls.Add(this.comboBox_AB);
            this.panel_Config.Controls.Add(this.label_Status);
            this.panel_Config.Controls.Add(this.label_ActionModifier);
            this.panel_Config.Controls.Add(this.numericUpDown_AJ);
            this.panel_Config.Controls.Add(this.comboBox_AR);
            this.panel_Config.Controls.Add(this.numericUpDown_AM);
            this.panel_Config.Controls.Add(this.label_ActionDiagonalLeft);
            this.panel_Config.Controls.Add(this.numericUpDown_AB);
            this.panel_Config.Controls.Add(this.comboBox_AL);
            this.panel_Config.Controls.Add(this.label_ActionDiagonalRight);
            this.panel_Config.Controls.Add(this.numericUpDown_AF);
            this.panel_Config.Controls.Add(this.label_ActionLeft);
            this.panel_Config.Controls.Add(this.label_ActionJump);
            this.panel_Config.Controls.Add(this.comboBox_ADR);
            this.panel_Config.Controls.Add(this.comboBox_ADL);
            this.panel_Config.Controls.Add(this.comboBox_AJ);
            this.panel_Config.Location = new System.Drawing.Point(12, 12);
            this.panel_Config.Name = "panel_Config";
            this.panel_Config.Size = new System.Drawing.Size(540, 406);
            this.panel_Config.TabIndex = 18;
            this.panel_Config.Visible = false;
            // 
            // linkLabel_Show
            // 
            this.linkLabel_Show.Location = new System.Drawing.Point(14, 154);
            this.linkLabel_Show.Name = "linkLabel_Show";
            this.linkLabel_Show.Size = new System.Drawing.Size(138, 23);
            this.linkLabel_Show.TabIndex = 19;
            this.linkLabel_Show.TabStop = true;
            this.linkLabel_Show.Text = "Configure";
            this.linkLabel_Show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_Show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Show_LinkClicked);
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.trayContext;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Wii Balance Board";
            this.tray.Visible = true;
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_MouseDoubleClick);
            // 
            // trayContext
            // 
            this.trayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator4,
            this.pairBluetoothDevicesToolStripMenuItem,
            this.connectBoardToolStripMenuItem,
            this.toolStripSeparator1,
            this.centerBalanceToolStripMenuItem,
            this.toolStripSeparator2,
            this.joystickToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitToolStripMenuItem});
            this.trayContext.Name = "trayContext";
            this.trayContext.Size = new System.Drawing.Size(192, 210);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.Tray_MouseDoubleClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // pairBluetoothDevicesToolStripMenuItem
            // 
            this.pairBluetoothDevicesToolStripMenuItem.Name = "pairBluetoothDevicesToolStripMenuItem";
            this.pairBluetoothDevicesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pairBluetoothDevicesToolStripMenuItem.Text = "Pair Bluetooth devices";
            this.pairBluetoothDevicesToolStripMenuItem.Click += new System.EventHandler(this.button_BluetoothAddDevice_Click);
            // 
            // connectBoardToolStripMenuItem
            // 
            this.connectBoardToolStripMenuItem.Name = "connectBoardToolStripMenuItem";
            this.connectBoardToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.connectBoardToolStripMenuItem.Text = "Connect Board";
            this.connectBoardToolStripMenuItem.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // centerBalanceToolStripMenuItem
            // 
            this.centerBalanceToolStripMenuItem.Name = "centerBalanceToolStripMenuItem";
            this.centerBalanceToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.centerBalanceToolStripMenuItem.Text = "Center Balance";
            this.centerBalanceToolStripMenuItem.Click += new System.EventHandler(this.button_SetCenterOffset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // joystickToolStripMenuItem
            // 
            this.joystickToolStripMenuItem.Name = "joystickToolStripMenuItem";
            this.joystickToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.joystickToolStripMenuItem.Text = "Joystick";
            this.joystickToolStripMenuItem.Click += new System.EventHandler(this.JoystickToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.CheckBox_DisableActions_CheckedChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(188, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.showAboutDialog);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.quitToolStripMenuItem.Text = "Exit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 183);
            this.Controls.Add(this.button_SetCenterOffset);
            this.Controls.Add(this.checkBox_EnableJoystick);
            this.Controls.Add(this.linkLabel_Show);
            this.Controls.Add(this.checkBox_DisableActions);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_BluetoothAddDevice);
            this.Controls.Add(this.panel_Config);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wii Balance Board GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.checkLicense);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.groupBox_RawWeight.ResumeLayout(false);
            this.groupBox_RawWeight.PerformLayout();
            this.groupBox_OffsetWeight.ResumeLayout(false);
            this.groupBox_OffsetWeight.PerformLayout();
            this.groupBox_OffsetWeightRatio.ResumeLayout(false);
            this.groupBox_OffsetWeightRatio.PerformLayout();
            this.groupBox_BalanceRatio.ResumeLayout(false);
            this.groupBox_BalanceRatio.PerformLayout();
            this.groupBox_BalanceRatioTriggers.ResumeLayout(false);
            this.groupBox_BalanceRatioTriggers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TMFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TMLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ADR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ADL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AL)).EndInit();
            this.panel_Config.ResumeLayout(false);
            this.panel_Config.PerformLayout();
            this.trayContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_rwWT;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_brX;
        private System.Windows.Forms.Label label_brY;
        private System.Windows.Forms.Label label_brDL;
        private System.Windows.Forms.Label label_brDR;
        private System.Windows.Forms.GroupBox groupBox_RawWeight;
        private System.Windows.Forms.Label label_rwBR;
        private System.Windows.Forms.Label label_rwBL;
        private System.Windows.Forms.Label label_rwTR;
        private System.Windows.Forms.Label label_rwTL;
        private System.Windows.Forms.GroupBox groupBox_OffsetWeight;
        private System.Windows.Forms.GroupBox groupBox_OffsetWeightRatio;
        private System.Windows.Forms.Label label_owTL;
        private System.Windows.Forms.Label label_owTR;
        private System.Windows.Forms.Label label_owBL;
        private System.Windows.Forms.Label label_owBR;
        private System.Windows.Forms.Label label_owrTL;
        private System.Windows.Forms.Label label_owrTR;
        private System.Windows.Forms.Label label_owrBL;
        private System.Windows.Forms.Label label_owrBR;
        private System.Windows.Forms.GroupBox groupBox_BalanceRatio;
        private System.Windows.Forms.Label label_brDF;
        private System.Windows.Forms.GroupBox groupBox_BalanceRatioTriggers;
        private System.Windows.Forms.NumericUpDown numericUpDown_TMFB;
        private System.Windows.Forms.NumericUpDown numericUpDown_TMLR;
        private System.Windows.Forms.NumericUpDown numericUpDown_TFB;
        private System.Windows.Forms.NumericUpDown numericUpDown_TLR;
        private System.Windows.Forms.Label label_TMFB;
        private System.Windows.Forms.Label label_TMLR;
        private System.Windows.Forms.Label label_TFB;
        private System.Windows.Forms.Label label_TLR;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_BluetoothAddDevice;
        private System.Windows.Forms.ComboBox comboBox_AM;
        private System.Windows.Forms.ComboBox comboBox_AF;
        private System.Windows.Forms.ComboBox comboBox_AB;
        private System.Windows.Forms.ComboBox comboBox_AR;
        private System.Windows.Forms.ComboBox comboBox_AL;
        private System.Windows.Forms.Label label_ActionJump;
        private System.Windows.Forms.Label label_ActionDiagonalRight;
        private System.Windows.Forms.Label label_ActionDiagonalLeft;
        private System.Windows.Forms.Label label_ActionModifier;
        private System.Windows.Forms.Label label_ActionBackward;
        private System.Windows.Forms.Label label_ActionForward;
        private System.Windows.Forms.Label label_ActionRight;
        private System.Windows.Forms.Label label_ActionLeft;
        private System.Windows.Forms.NumericUpDown numericUpDown_AR;
        private System.Windows.Forms.NumericUpDown numericUpDown_AL;
        private System.Windows.Forms.NumericUpDown numericUpDown_ADR;
        private System.Windows.Forms.NumericUpDown numericUpDown_ADL;
        private System.Windows.Forms.NumericUpDown numericUpDown_AJ;
        private System.Windows.Forms.NumericUpDown numericUpDown_AM;
        private System.Windows.Forms.NumericUpDown numericUpDown_AB;
        private System.Windows.Forms.NumericUpDown numericUpDown_AF;
        private System.Windows.Forms.ComboBox comboBox_ADR;
        private System.Windows.Forms.ComboBox comboBox_AJ;
        private System.Windows.Forms.ComboBox comboBox_ADL;
        private System.Windows.Forms.Button button_SetCenterOffset;
        private System.Windows.Forms.Button button_ResetDefaults;
        private System.Windows.Forms.CheckBox checkBox_DisableActions;
        private System.Windows.Forms.Label label_owWT;
        private System.Windows.Forms.CheckBox checkBox_EnableJoystick;
        private System.Windows.Forms.Panel panel_Config;
        private System.Windows.Forms.LinkLabel linkLabel_Show;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayContext;
        private System.Windows.Forms.ToolStripMenuItem pairBluetoothDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem centerBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joystickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

