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
            this.SerialConnectBtn.Location = new System.Drawing.Point(186, 117);
            this.SerialConnectBtn.Name = "SerialConnectBtn";
            this.SerialConnectBtn.Size = new System.Drawing.Size(80, 25);
            this.SerialConnectBtn.TabIndex = 4;
            this.SerialConnectBtn.Text = "CONNECT";
            this.SerialConnectBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SerialConnectBtn.UseSelectable = true;
            // 
            // zeroingPosTrans
            // 
            this.zeroingPosTrans.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zeroingPosTrans.Location = new System.Drawing.Point(375, 132);
            this.zeroingPosTrans.Name = "zeroingPosTrans";
            this.zeroingPosTrans.Size = new System.Drawing.Size(80, 25);
            this.zeroingPosTrans.TabIndex = 5;
            this.zeroingPosTrans.Text = "+1 mm";
            this.zeroingPosTrans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.zeroingPosTrans.UseSelectable = true;
            // 
            // zeroingNegTrans
            // 
            this.zeroingNegTrans.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zeroingNegTrans.Location = new System.Drawing.Point(461, 132);
            this.zeroingNegTrans.Name = "zeroingNegTrans";
            this.zeroingNegTrans.Size = new System.Drawing.Size(80, 25);
            this.zeroingNegTrans.TabIndex = 6;
            this.zeroingNegTrans.Text = "-1 mm";
            this.zeroingNegTrans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.zeroingNegTrans.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(375, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Zeroing";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // zeroingPosRot
            // 
            this.zeroingPosRot.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zeroingPosRot.Location = new System.Drawing.Point(375, 163);
            this.zeroingPosRot.Name = "zeroingPosRot";
            this.zeroingPosRot.Size = new System.Drawing.Size(80, 25);
            this.zeroingPosRot.TabIndex = 5;
            this.zeroingPosRot.Text = "+1 deg";
            this.zeroingPosRot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.zeroingPosRot.UseSelectable = true;
            // 
            // zeroingNegRot
            // 
            this.zeroingNegRot.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zeroingNegRot.Location = new System.Drawing.Point(461, 163);
            this.zeroingNegRot.Name = "zeroingNegRot";
            this.zeroingNegRot.Size = new System.Drawing.Size(80, 25);
            this.zeroingNegRot.TabIndex = 6;
            this.zeroingNegRot.Text = "-1 deg";
            this.zeroingNegRot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.zeroingNegRot.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(193, 228);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 25);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Monitor";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(287, 253);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 25);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Zeroing";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(287, 287);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 25);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Zeroing";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.zeroingNegRot);
            this.Controls.Add(this.zeroingNegTrans);
            this.Controls.Add(this.zeroingPosRot);
            this.Controls.Add(this.zeroingPosTrans);
            this.Controls.Add(this.SerialConnectBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.serialListCBox);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "StepDriver";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

