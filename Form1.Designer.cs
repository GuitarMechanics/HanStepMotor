namespace HanStepMotor
{
    partial class Form1
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
            this.serialListCBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SerialConnectBtn = new MetroFramework.Controls.MetroButton();
            this.zeroingPosTrans = new MetroFramework.Controls.MetroButton();
            this.zeroingNegTrans = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.zeroingPosRot = new MetroFramework.Controls.MetroButton();
            this.zeroingNegRot = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.transStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.rotStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.directTransTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.directRotTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.directCalcBtn = new MetroFramework.Controls.MetroButton();
            this.depthCalcBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.kinDepthTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.kinHoffTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.kinAngTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.hoffCalcBtn = new MetroFramework.Controls.MetroButton();
            this.angCalcBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.calcValidLabel = new MetroFramework.Controls.MetroLabel();
            this.mtRunBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtZeroBtn = new MetroFramework.Controls.MetroButton();
            this.mtAvailLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialListCBox
            // 
            this.serialListCBox.FormattingEnabled = true;
            this.serialListCBox.ItemHeight = 23;
            this.serialListCBox.Location = new System.Drawing.Point(23, 113);
            this.serialListCBox.Name = "serialListCBox";
            this.serialListCBox.Size = new System.Drawing.Size(121, 29);
            this.serialListCBox.TabIndex = 0;
            this.serialListCBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.serialListCBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Port No.";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "BaudRate = 9600";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 164);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(288, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Connects automatically if only 1 port is available";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SerialConnectBtn
            // 
            this.SerialConnectBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SerialConnectBtn.Location = new System.Drawing.Point(170, 113);
            this.SerialConnectBtn.Name = "SerialConnectBtn";
            this.SerialConnectBtn.Size = new System.Drawing.Size(80, 25);
            this.SerialConnectBtn.TabIndex = 4;
            this.SerialConnectBtn.Text = "CONNECT";
            this.SerialConnectBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SerialConnectBtn.UseSelectable = true;
            this.SerialConnectBtn.Click += new System.EventHandler(this.SerialConnectBtn_Click);
            // 
            // zeroingPosTrans
            // 
            this.zeroingPosTrans.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zeroingPosTrans.Location = new System.Drawing.Point(23, 256);
            this.zeroingPosTrans.Name = "zeroingPosTrans";
            this.zeroingPosTrans.Size = new System.Drawing.Size(80, 25);
            this.zeroingPosTrans.TabIndex = 5;
            this.zeroingPosTrans.Text = "+1 mm";
            this.zeroingPosTrans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.zeroingPosTrans.UseSelectable = true;
            this.zeroingPosTrans.Click += new System.EventHandler(this.zeroingPosTrans_Click);
            // 
            // zeroingNegTrans
            // 
            this.zeroingNegTrans.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zeroingNegTrans.Location = new System.Drawing.Point(109, 256);
            this.zeroingNegTrans.Name = "zeroingNegTrans";
            this.zeroingNegTrans.Size = new System.Drawing.Size(80, 25);
            this.zeroingNegTrans.TabIndex = 6;
            this.zeroingNegTrans.Text = "-1 mm";
            this.zeroingNegTrans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.zeroingNegTrans.UseSelectable = true;
            this.zeroingNegTrans.Click += new System.EventHandler(this.zeroingNegTrans_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 228);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(145, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Zero Adjustment";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // zeroingPosRot
            // 
            this.zeroingPosRot.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zeroingPosRot.Location = new System.Drawing.Point(23, 287);
            this.zeroingPosRot.Name = "zeroingPosRot";
            this.zeroingPosRot.Size = new System.Drawing.Size(80, 25);
            this.zeroingPosRot.TabIndex = 5;
            this.zeroingPosRot.Text = "+1 deg";
            this.zeroingPosRot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.zeroingPosRot.UseSelectable = true;
            this.zeroingPosRot.Click += new System.EventHandler(this.zeroingPosRot_Click);
            // 
            // zeroingNegRot
            // 
            this.zeroingNegRot.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zeroingNegRot.Location = new System.Drawing.Point(109, 287);
            this.zeroingNegRot.Name = "zeroingNegRot";
            this.zeroingNegRot.Size = new System.Drawing.Size(80, 25);
            this.zeroingNegRot.TabIndex = 6;
            this.zeroingNegRot.Text = "-1 deg";
            this.zeroingNegRot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.zeroingNegRot.UseSelectable = true;
            this.zeroingNegRot.Click += new System.EventHandler(this.zeroingNegRot_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(319, 91);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(123, 25);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Current Status";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(317, 119);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(143, 25);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Translation (mm)";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(317, 151);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(125, 25);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Rotation (deg)";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // transStatusLabel
            // 
            this.transStatusLabel.AutoSize = true;
            this.transStatusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.transStatusLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.transStatusLabel.Location = new System.Drawing.Point(466, 122);
            this.transStatusLabel.Name = "transStatusLabel";
            this.transStatusLabel.Size = new System.Drawing.Size(22, 25);
            this.transStatusLabel.TabIndex = 8;
            this.transStatusLabel.Text = "0";
            this.transStatusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // rotStatusLabel
            // 
            this.rotStatusLabel.AutoSize = true;
            this.rotStatusLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.rotStatusLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.rotStatusLabel.Location = new System.Drawing.Point(466, 154);
            this.rotStatusLabel.Name = "rotStatusLabel";
            this.rotStatusLabel.Size = new System.Drawing.Size(22, 25);
            this.rotStatusLabel.TabIndex = 8;
            this.rotStatusLabel.Text = "0";
            this.rotStatusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(253, 228);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(58, 25);
            this.metroLabel10.TabIndex = 8;
            this.metroLabel10.Text = "Direct";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(218, 255);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(143, 25);
            this.metroLabel11.TabIndex = 8;
            this.metroLabel11.Text = "Translation (mm)";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(218, 287);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(125, 25);
            this.metroLabel12.TabIndex = 8;
            this.metroLabel12.Text = "Rotation (deg)";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // directTransTxtBox
            // 
            // 
            // 
            // 
            this.directTransTxtBox.CustomButton.Image = null;
            this.directTransTxtBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.directTransTxtBox.CustomButton.Name = "";
            this.directTransTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.directTransTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.directTransTxtBox.CustomButton.TabIndex = 1;
            this.directTransTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.directTransTxtBox.CustomButton.UseSelectable = true;
            this.directTransTxtBox.CustomButton.Visible = false;
            this.directTransTxtBox.Lines = new string[] {
        "0"};
            this.directTransTxtBox.Location = new System.Drawing.Point(363, 255);
            this.directTransTxtBox.MaxLength = 32767;
            this.directTransTxtBox.Name = "directTransTxtBox";
            this.directTransTxtBox.PasswordChar = '\0';
            this.directTransTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.directTransTxtBox.SelectedText = "";
            this.directTransTxtBox.SelectionLength = 0;
            this.directTransTxtBox.SelectionStart = 0;
            this.directTransTxtBox.ShortcutsEnabled = true;
            this.directTransTxtBox.Size = new System.Drawing.Size(75, 23);
            this.directTransTxtBox.TabIndex = 9;
            this.directTransTxtBox.Text = "0";
            this.directTransTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.directTransTxtBox.UseSelectable = true;
            this.directTransTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.directTransTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // directRotTxtBox
            // 
            // 
            // 
            // 
            this.directRotTxtBox.CustomButton.Image = null;
            this.directRotTxtBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.directRotTxtBox.CustomButton.Name = "";
            this.directRotTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.directRotTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.directRotTxtBox.CustomButton.TabIndex = 1;
            this.directRotTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.directRotTxtBox.CustomButton.UseSelectable = true;
            this.directRotTxtBox.CustomButton.Visible = false;
            this.directRotTxtBox.Lines = new string[] {
        "0"};
            this.directRotTxtBox.Location = new System.Drawing.Point(363, 289);
            this.directRotTxtBox.MaxLength = 32767;
            this.directRotTxtBox.Name = "directRotTxtBox";
            this.directRotTxtBox.PasswordChar = '\0';
            this.directRotTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.directRotTxtBox.SelectedText = "";
            this.directRotTxtBox.SelectionLength = 0;
            this.directRotTxtBox.SelectionStart = 0;
            this.directRotTxtBox.ShortcutsEnabled = true;
            this.directRotTxtBox.Size = new System.Drawing.Size(75, 23);
            this.directRotTxtBox.TabIndex = 9;
            this.directRotTxtBox.Text = "0";
            this.directRotTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.directRotTxtBox.UseSelectable = true;
            this.directRotTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.directRotTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // directCalcBtn
            // 
            this.directCalcBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.directCalcBtn.Location = new System.Drawing.Point(360, 318);
            this.directCalcBtn.Name = "directCalcBtn";
            this.directCalcBtn.Size = new System.Drawing.Size(80, 25);
            this.directCalcBtn.TabIndex = 4;
            this.directCalcBtn.Text = "CALCULATE";
            this.directCalcBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.directCalcBtn.UseSelectable = true;
            this.directCalcBtn.Click += new System.EventHandler(this.DirectCalcBtn_Click);
            // 
            // depthCalcBtn
            // 
            this.depthCalcBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.depthCalcBtn.Location = new System.Drawing.Point(685, 255);
            this.depthCalcBtn.Name = "depthCalcBtn";
            this.depthCalcBtn.Size = new System.Drawing.Size(80, 25);
            this.depthCalcBtn.TabIndex = 4;
            this.depthCalcBtn.Text = "CALCULATE";
            this.depthCalcBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.depthCalcBtn.UseSelectable = true;
            this.depthCalcBtn.Click += new System.EventHandler(this.DepthCalcBtn_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(459, 228);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(242, 25);
            this.metroLabel13.TabIndex = 8;
            this.metroLabel13.Text = "Kinematic Assistant (Approx.)";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(459, 255);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(108, 25);
            this.metroLabel14.TabIndex = 8;
            this.metroLabel14.Text = "Depth (mm)";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(459, 287);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(125, 25);
            this.metroLabel15.TabIndex = 8;
            this.metroLabel15.Text = "H-offset (mm)";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // kinDepthTxtBox
            // 
            // 
            // 
            // 
            this.kinDepthTxtBox.CustomButton.Image = null;
            this.kinDepthTxtBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.kinDepthTxtBox.CustomButton.Name = "";
            this.kinDepthTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kinDepthTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kinDepthTxtBox.CustomButton.TabIndex = 1;
            this.kinDepthTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kinDepthTxtBox.CustomButton.UseSelectable = true;
            this.kinDepthTxtBox.CustomButton.Visible = false;
            this.kinDepthTxtBox.Lines = new string[] {
        "0"};
            this.kinDepthTxtBox.Location = new System.Drawing.Point(604, 255);
            this.kinDepthTxtBox.MaxLength = 32767;
            this.kinDepthTxtBox.Name = "kinDepthTxtBox";
            this.kinDepthTxtBox.PasswordChar = '\0';
            this.kinDepthTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kinDepthTxtBox.SelectedText = "";
            this.kinDepthTxtBox.SelectionLength = 0;
            this.kinDepthTxtBox.SelectionStart = 0;
            this.kinDepthTxtBox.ShortcutsEnabled = true;
            this.kinDepthTxtBox.Size = new System.Drawing.Size(75, 23);
            this.kinDepthTxtBox.TabIndex = 9;
            this.kinDepthTxtBox.Text = "0";
            this.kinDepthTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.kinDepthTxtBox.UseSelectable = true;
            this.kinDepthTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kinDepthTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kinHoffTxtBox
            // 
            // 
            // 
            // 
            this.kinHoffTxtBox.CustomButton.Image = null;
            this.kinHoffTxtBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.kinHoffTxtBox.CustomButton.Name = "";
            this.kinHoffTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kinHoffTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kinHoffTxtBox.CustomButton.TabIndex = 1;
            this.kinHoffTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kinHoffTxtBox.CustomButton.UseSelectable = true;
            this.kinHoffTxtBox.CustomButton.Visible = false;
            this.kinHoffTxtBox.Lines = new string[] {
        "0"};
            this.kinHoffTxtBox.Location = new System.Drawing.Point(604, 289);
            this.kinHoffTxtBox.MaxLength = 32767;
            this.kinHoffTxtBox.Name = "kinHoffTxtBox";
            this.kinHoffTxtBox.PasswordChar = '\0';
            this.kinHoffTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kinHoffTxtBox.SelectedText = "";
            this.kinHoffTxtBox.SelectionLength = 0;
            this.kinHoffTxtBox.SelectionStart = 0;
            this.kinHoffTxtBox.ShortcutsEnabled = true;
            this.kinHoffTxtBox.Size = new System.Drawing.Size(75, 23);
            this.kinHoffTxtBox.TabIndex = 9;
            this.kinHoffTxtBox.Text = "0";
            this.kinHoffTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.kinHoffTxtBox.UseSelectable = true;
            this.kinHoffTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kinHoffTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(459, 318);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(130, 25);
            this.metroLabel16.TabIndex = 8;
            this.metroLabel16.Text = "Tip angle (deg)";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // kinAngTxtBox
            // 
            // 
            // 
            // 
            this.kinAngTxtBox.CustomButton.Image = null;
            this.kinAngTxtBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.kinAngTxtBox.CustomButton.Name = "";
            this.kinAngTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kinAngTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kinAngTxtBox.CustomButton.TabIndex = 1;
            this.kinAngTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kinAngTxtBox.CustomButton.UseSelectable = true;
            this.kinAngTxtBox.CustomButton.Visible = false;
            this.kinAngTxtBox.Lines = new string[] {
        "0"};
            this.kinAngTxtBox.Location = new System.Drawing.Point(604, 320);
            this.kinAngTxtBox.MaxLength = 32767;
            this.kinAngTxtBox.Name = "kinAngTxtBox";
            this.kinAngTxtBox.PasswordChar = '\0';
            this.kinAngTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kinAngTxtBox.SelectedText = "";
            this.kinAngTxtBox.SelectionLength = 0;
            this.kinAngTxtBox.SelectionStart = 0;
            this.kinAngTxtBox.ShortcutsEnabled = true;
            this.kinAngTxtBox.Size = new System.Drawing.Size(75, 23);
            this.kinAngTxtBox.TabIndex = 9;
            this.kinAngTxtBox.Text = "0";
            this.kinAngTxtBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.kinAngTxtBox.UseSelectable = true;
            this.kinAngTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kinAngTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // hoffCalcBtn
            // 
            this.hoffCalcBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.hoffCalcBtn.Location = new System.Drawing.Point(685, 287);
            this.hoffCalcBtn.Name = "hoffCalcBtn";
            this.hoffCalcBtn.Size = new System.Drawing.Size(80, 25);
            this.hoffCalcBtn.TabIndex = 4;
            this.hoffCalcBtn.Text = "CALCULATE";
            this.hoffCalcBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hoffCalcBtn.UseSelectable = true;
            this.hoffCalcBtn.Click += new System.EventHandler(this.HoffCalcBtn_Click);
            // 
            // angCalcBtn
            // 
            this.angCalcBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.angCalcBtn.Location = new System.Drawing.Point(685, 320);
            this.angCalcBtn.Name = "angCalcBtn";
            this.angCalcBtn.Size = new System.Drawing.Size(80, 25);
            this.angCalcBtn.TabIndex = 4;
            this.angCalcBtn.Text = "CALCULATE";
            this.angCalcBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.angCalcBtn.UseSelectable = true;
            this.angCalcBtn.Click += new System.EventHandler(this.AngCalcBtn_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(604, 348);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(145, 19);
            this.metroLabel17.TabIndex = 3;
            this.metroLabel17.Text = "Only 1 entry is required";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(23, 355);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(150, 25);
            this.metroLabel18.TabIndex = 8;
            this.metroLabel18.Text = "Calculation Result";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // calcValidLabel
            // 
            this.calcValidLabel.AutoSize = true;
            this.calcValidLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.calcValidLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.calcValidLabel.ForeColor = System.Drawing.Color.Green;
            this.calcValidLabel.Location = new System.Drawing.Point(186, 355);
            this.calcValidLabel.Name = "calcValidLabel";
            this.calcValidLabel.Size = new System.Drawing.Size(64, 25);
            this.calcValidLabel.TabIndex = 8;
            this.calcValidLabel.Text = "VALID";
            this.calcValidLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.calcValidLabel.UseCustomForeColor = true;
            // 
            // mtRunBtn
            // 
            this.mtRunBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtRunBtn.Location = new System.Drawing.Point(281, 355);
            this.mtRunBtn.Name = "mtRunBtn";
            this.mtRunBtn.Size = new System.Drawing.Size(80, 25);
            this.mtRunBtn.TabIndex = 4;
            this.mtRunBtn.Text = "RUN";
            this.mtRunBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtRunBtn.UseSelectable = true;
            this.mtRunBtn.Click += new System.EventHandler(this.mtRunBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HanStepMotor.Properties.Resources.han_legend;
            this.pictureBox1.Location = new System.Drawing.Point(545, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // mtZeroBtn
            // 
            this.mtZeroBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtZeroBtn.Location = new System.Drawing.Point(367, 355);
            this.mtZeroBtn.Name = "mtZeroBtn";
            this.mtZeroBtn.Size = new System.Drawing.Size(80, 25);
            this.mtZeroBtn.TabIndex = 4;
            this.mtZeroBtn.Text = "ZERO POS";
            this.mtZeroBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtZeroBtn.UseSelectable = true;
            this.mtZeroBtn.Click += new System.EventHandler(this.mtZeroBtn_Click);
            // 
            // mtAvailLabel
            // 
            this.mtAvailLabel.AutoSize = true;
            this.mtAvailLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtAvailLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtAvailLabel.ForeColor = System.Drawing.Color.Green;
            this.mtAvailLabel.Location = new System.Drawing.Point(425, 200);
            this.mtAvailLabel.Name = "mtAvailLabel";
            this.mtAvailLabel.Size = new System.Drawing.Size(63, 25);
            this.mtAvailLabel.TabIndex = 8;
            this.mtAvailLabel.Text = "AVAIL";
            this.mtAvailLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtAvailLabel.UseCustomForeColor = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(304, 200);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(115, 25);
            this.metroLabel19.TabIndex = 8;
            this.metroLabel19.Text = "Motor Status";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.directRotTxtBox);
            this.Controls.Add(this.kinAngTxtBox);
            this.Controls.Add(this.kinHoffTxtBox);
            this.Controls.Add(this.kinDepthTxtBox);
            this.Controls.Add(this.directTransTxtBox);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.rotStatusLabel);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.mtAvailLabel);
            this.Controls.Add(this.calcValidLabel);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.transStatusLabel);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.zeroingNegRot);
            this.Controls.Add(this.zeroingNegTrans);
            this.Controls.Add(this.zeroingPosRot);
            this.Controls.Add(this.angCalcBtn);
            this.Controls.Add(this.hoffCalcBtn);
            this.Controls.Add(this.depthCalcBtn);
            this.Controls.Add(this.zeroingPosTrans);
            this.Controls.Add(this.mtZeroBtn);
            this.Controls.Add(this.mtRunBtn);
            this.Controls.Add(this.directCalcBtn);
            this.Controls.Add(this.SerialConnectBtn);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.serialListCBox);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "StepDriver";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox serialListCBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton SerialConnectBtn;
        private MetroFramework.Controls.MetroButton zeroingPosTrans;
        private MetroFramework.Controls.MetroButton zeroingNegTrans;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton zeroingPosRot;
        private MetroFramework.Controls.MetroButton zeroingNegRot;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel transStatusLabel;
        private MetroFramework.Controls.MetroLabel rotStatusLabel;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox directTransTxtBox;
        private MetroFramework.Controls.MetroTextBox directRotTxtBox;
        private MetroFramework.Controls.MetroButton directCalcBtn;
        private MetroFramework.Controls.MetroButton depthCalcBtn;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox kinDepthTxtBox;
        private MetroFramework.Controls.MetroTextBox kinHoffTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox kinAngTxtBox;
        private MetroFramework.Controls.MetroButton hoffCalcBtn;
        private MetroFramework.Controls.MetroButton angCalcBtn;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel calcValidLabel;
        private MetroFramework.Controls.MetroButton mtRunBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton mtZeroBtn;
        private MetroFramework.Controls.MetroLabel mtAvailLabel;
        private MetroFramework.Controls.MetroLabel metroLabel19;
    }
}

