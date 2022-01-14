
namespace iot_myself.UI
{
    partial class SettingCOM
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
            this.baudSet = new Sunny.UI.UIComboBox();
            this.databitSet = new Sunny.UI.UIComboBox();
            this.paritySet = new Sunny.UI.UIComboBox();
            this.stopbitSet = new Sunny.UI.UIComboBox();
            this.portSet = new Sunny.UI.UIComboBox();
            this.comSetCancel = new Sunny.UI.UISymbolButton();
            this.comSetOK = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // baudSet
            // 
            this.baudSet.DataSource = null;
            this.baudSet.FillColor = System.Drawing.Color.White;
            this.baudSet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.baudSet.IsScaled = false;
            this.baudSet.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.baudSet.Location = new System.Drawing.Point(441, 189);
            this.baudSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baudSet.MinimumSize = new System.Drawing.Size(63, 0);
            this.baudSet.Name = "baudSet";
            this.baudSet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.baudSet.Size = new System.Drawing.Size(170, 35);
            this.baudSet.TabIndex = 17;
            this.baudSet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // databitSet
            // 
            this.databitSet.DataSource = null;
            this.databitSet.FillColor = System.Drawing.Color.White;
            this.databitSet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.databitSet.IsScaled = false;
            this.databitSet.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.databitSet.Location = new System.Drawing.Point(441, 253);
            this.databitSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.databitSet.MinimumSize = new System.Drawing.Size(63, 0);
            this.databitSet.Name = "databitSet";
            this.databitSet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.databitSet.Size = new System.Drawing.Size(170, 35);
            this.databitSet.TabIndex = 18;
            this.databitSet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paritySet
            // 
            this.paritySet.DataSource = null;
            this.paritySet.FillColor = System.Drawing.Color.White;
            this.paritySet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.paritySet.IsScaled = false;
            this.paritySet.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.paritySet.Location = new System.Drawing.Point(441, 315);
            this.paritySet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paritySet.MinimumSize = new System.Drawing.Size(63, 0);
            this.paritySet.Name = "paritySet";
            this.paritySet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.paritySet.Size = new System.Drawing.Size(170, 35);
            this.paritySet.TabIndex = 19;
            this.paritySet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stopbitSet
            // 
            this.stopbitSet.DataSource = null;
            this.stopbitSet.FillColor = System.Drawing.Color.White;
            this.stopbitSet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.stopbitSet.IsScaled = false;
            this.stopbitSet.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbitSet.Location = new System.Drawing.Point(441, 371);
            this.stopbitSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopbitSet.MinimumSize = new System.Drawing.Size(63, 0);
            this.stopbitSet.Name = "stopbitSet";
            this.stopbitSet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.stopbitSet.Size = new System.Drawing.Size(170, 35);
            this.stopbitSet.TabIndex = 20;
            this.stopbitSet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // portSet
            // 
            this.portSet.DataSource = null;
            this.portSet.FillColor = System.Drawing.Color.White;
            this.portSet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.portSet.IsScaled = false;
            this.portSet.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.portSet.Location = new System.Drawing.Point(441, 133);
            this.portSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portSet.MinimumSize = new System.Drawing.Size(63, 0);
            this.portSet.Name = "portSet";
            this.portSet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.portSet.Size = new System.Drawing.Size(170, 35);
            this.portSet.TabIndex = 16;
            this.portSet.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comSetCancel
            // 
            this.comSetCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comSetCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comSetCancel.IsScaled = false;
            this.comSetCancel.Location = new System.Drawing.Point(441, 485);
            this.comSetCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.comSetCancel.Name = "comSetCancel";
            this.comSetCancel.Size = new System.Drawing.Size(197, 55);
            this.comSetCancel.TabIndex = 15;
            this.comSetCancel.Text = "취소";
            // 
            // comSetOK
            // 
            this.comSetOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comSetOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comSetOK.IsScaled = false;
            this.comSetOK.Location = new System.Drawing.Point(162, 485);
            this.comSetOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.comSetOK.Name = "comSetOK";
            this.comSetOK.Size = new System.Drawing.Size(197, 55);
            this.comSetOK.TabIndex = 14;
            this.comSetOK.Text = "확인";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.IsScaled = false;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(162, 371);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel5.Symbol = 61573;
            this.uiSymbolLabel5.TabIndex = 13;
            this.uiSymbolLabel5.Text = "Stop 비트";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.IsScaled = false;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(162, 315);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel4.Symbol = 61573;
            this.uiSymbolLabel4.TabIndex = 12;
            this.uiSymbolLabel4.Text = "Parity 비트";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.IsScaled = false;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(162, 253);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel3.Symbol = 61573;
            this.uiSymbolLabel3.TabIndex = 11;
            this.uiSymbolLabel3.Text = "Date 비트";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.IsScaled = false;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(162, 189);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 61573;
            this.uiSymbolLabel2.TabIndex = 10;
            this.uiSymbolLabel2.Text = "통신 속도";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.IsScaled = false;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(162, 133);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 61573;
            this.uiSymbolLabel1.TabIndex = 9;
            this.uiSymbolLabel1.Text = "통신 포트";
            // 
            // SettingCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.baudSet);
            this.Controls.Add(this.databitSet);
            this.Controls.Add(this.paritySet);
            this.Controls.Add(this.stopbitSet);
            this.Controls.Add(this.portSet);
            this.Controls.Add(this.comSetCancel);
            this.Controls.Add(this.comSetOK);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "SettingCOM";
            this.Text = "SettingCOM";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox baudSet;
        private Sunny.UI.UIComboBox databitSet;
        private Sunny.UI.UIComboBox paritySet;
        private Sunny.UI.UIComboBox stopbitSet;
        private Sunny.UI.UIComboBox portSet;
        private Sunny.UI.UISymbolButton comSetCancel;
        private Sunny.UI.UISymbolButton comSetOK;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}