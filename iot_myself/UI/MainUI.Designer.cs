
namespace iot_myself
{
    partial class MainUI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.exit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.tempLabel = new Sunny.UI.UISymbolLabel();
            this.humiLabel = new Sunny.UI.UISymbolLabel();
            this.tempAnalogMeter = new Sunny.UI.UIAnalogMeter();
            this.humiAnalogMeter = new Sunny.UI.UIAnalogMeter();
            this.timeLabel = new Sunny.UI.UISymbolLabel();
            this.comStatus = new Sunny.UI.UILabel();
            this.comDisconnet = new Sunny.UI.UISymbolButton();
            this.comConnet = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.com_portComboBox = new Sunny.UI.UIComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.IsScaled = false;
            this.uiSymbolButton1.Location = new System.Drawing.Point(797, 12);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.White;
            this.uiSymbolButton1.RectDisableColor = System.Drawing.Color.White;
            this.uiSymbolButton1.Size = new System.Drawing.Size(54, 36);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 62161;
            this.uiSymbolButton1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FillColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exit.IsScaled = false;
            this.exit.Location = new System.Drawing.Point(857, 12);
            this.exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.exit.Name = "exit";
            this.exit.RectColor = System.Drawing.Color.White;
            this.exit.RectDisableColor = System.Drawing.Color.White;
            this.exit.Size = new System.Drawing.Size(54, 36);
            this.exit.Style = Sunny.UI.UIStyle.Custom;
            this.exit.Symbol = 61453;
            this.exit.TabIndex = 1;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.IsScaled = false;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(265, 36);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62160;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 2;
            this.uiSymbolLabel1.Text = "온습도 표시창";
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.tempLabel.IsScaled = false;
            this.tempLabel.Location = new System.Drawing.Point(463, 135);
            this.tempLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.tempLabel.Size = new System.Drawing.Size(170, 45);
            this.tempLabel.Symbol = 62151;
            this.tempLabel.SymbolColor = System.Drawing.Color.Red;
            this.tempLabel.SymbolSize = 35;
            this.tempLabel.TabIndex = 3;
            this.tempLabel.Text = "0℃";
            // 
            // humiLabel
            // 
            this.humiLabel.BackColor = System.Drawing.Color.Transparent;
            this.humiLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.humiLabel.IsScaled = false;
            this.humiLabel.Location = new System.Drawing.Point(639, 135);
            this.humiLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.humiLabel.Name = "humiLabel";
            this.humiLabel.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.humiLabel.Size = new System.Drawing.Size(170, 45);
            this.humiLabel.Symbol = 61507;
            this.humiLabel.SymbolColor = System.Drawing.Color.Blue;
            this.humiLabel.SymbolSize = 35;
            this.humiLabel.TabIndex = 4;
            this.humiLabel.Text = "0％";
            // 
            // tempAnalogMeter
            // 
            this.tempAnalogMeter.BackColor = System.Drawing.Color.White;
            this.tempAnalogMeter.BodyColor = System.Drawing.Color.Black;
            this.tempAnalogMeter.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tempAnalogMeter.IsScaled = false;
            this.tempAnalogMeter.Location = new System.Drawing.Point(463, 186);
            this.tempAnalogMeter.MaxValue = 100D;
            this.tempAnalogMeter.MinimumSize = new System.Drawing.Size(1, 1);
            this.tempAnalogMeter.MinValue = 0D;
            this.tempAnalogMeter.Name = "tempAnalogMeter";
            this.tempAnalogMeter.NeedleColor = System.Drawing.Color.Red;
            this.tempAnalogMeter.Renderer = null;
            this.tempAnalogMeter.Size = new System.Drawing.Size(170, 173);
            this.tempAnalogMeter.Style = Sunny.UI.UIStyle.Custom;
            this.tempAnalogMeter.TabIndex = 5;
            this.tempAnalogMeter.Text = "uiAnalogMeter1";
            this.tempAnalogMeter.Value = 0D;
            // 
            // humiAnalogMeter
            // 
            this.humiAnalogMeter.BackColor = System.Drawing.Color.White;
            this.humiAnalogMeter.BodyColor = System.Drawing.Color.Black;
            this.humiAnalogMeter.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.humiAnalogMeter.IsScaled = false;
            this.humiAnalogMeter.Location = new System.Drawing.Point(639, 186);
            this.humiAnalogMeter.MaxValue = 100D;
            this.humiAnalogMeter.MinimumSize = new System.Drawing.Size(1, 1);
            this.humiAnalogMeter.MinValue = 0D;
            this.humiAnalogMeter.Name = "humiAnalogMeter";
            this.humiAnalogMeter.NeedleColor = System.Drawing.Color.Blue;
            this.humiAnalogMeter.Renderer = null;
            this.humiAnalogMeter.Size = new System.Drawing.Size(170, 173);
            this.humiAnalogMeter.Style = Sunny.UI.UIStyle.Custom;
            this.humiAnalogMeter.TabIndex = 6;
            this.humiAnalogMeter.Text = "uiAnalogMeter2";
            this.humiAnalogMeter.Value = 0D;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 25F);
            this.timeLabel.IsScaled = false;
            this.timeLabel.Location = new System.Drawing.Point(377, 83);
            this.timeLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.timeLabel.Size = new System.Drawing.Size(516, 46);
            this.timeLabel.Symbol = 61463;
            this.timeLabel.SymbolSize = 45;
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "표시 시간";
            // 
            // comStatus
            // 
            this.comStatus.BackColor = System.Drawing.Color.Transparent;
            this.comStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comStatus.ForeColor = System.Drawing.Color.Black;
            this.comStatus.Location = new System.Drawing.Point(66, 324);
            this.comStatus.Name = "comStatus";
            this.comStatus.Size = new System.Drawing.Size(292, 35);
            this.comStatus.TabIndex = 28;
            this.comStatus.Text = "포트 상태 정보";
            this.comStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comDisconnet
            // 
            this.comDisconnet.BackColor = System.Drawing.Color.Transparent;
            this.comDisconnet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comDisconnet.FillColor = System.Drawing.Color.Transparent;
            this.comDisconnet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comDisconnet.ForeColor = System.Drawing.Color.Black;
            this.comDisconnet.IsScaled = false;
            this.comDisconnet.Location = new System.Drawing.Point(264, 245);
            this.comDisconnet.MinimumSize = new System.Drawing.Size(1, 1);
            this.comDisconnet.Name = "comDisconnet";
            this.comDisconnet.Radius = 30;
            this.comDisconnet.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.comDisconnet.Size = new System.Drawing.Size(146, 35);
            this.comDisconnet.Style = Sunny.UI.UIStyle.Custom;
            this.comDisconnet.Symbol = 61735;
            this.comDisconnet.TabIndex = 27;
            this.comDisconnet.Text = "COM 해체";
            // 
            // comConnet
            // 
            this.comConnet.BackColor = System.Drawing.Color.Transparent;
            this.comConnet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comConnet.FillColor = System.Drawing.Color.Transparent;
            this.comConnet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comConnet.ForeColor = System.Drawing.Color.Black;
            this.comConnet.IsScaled = false;
            this.comConnet.Location = new System.Drawing.Point(70, 245);
            this.comConnet.MinimumSize = new System.Drawing.Size(1, 1);
            this.comConnet.Name = "comConnet";
            this.comConnet.Radius = 30;
            this.comConnet.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.comConnet.Size = new System.Drawing.Size(146, 35);
            this.comConnet.Style = Sunny.UI.UIStyle.Custom;
            this.comConnet.Symbol = 61633;
            this.comConnet.TabIndex = 26;
            this.comConnet.Text = "COM 연결";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(66, 102);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(146, 23);
            this.uiLabel1.TabIndex = 29;
            this.uiLabel1.Text = "COM 포트 설정";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // com_portComboBox
            // 
            this.com_portComboBox.DataSource = null;
            this.com_portComboBox.FillColor = System.Drawing.Color.White;
            this.com_portComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.com_portComboBox.IsScaled = false;
            this.com_portComboBox.Location = new System.Drawing.Point(70, 135);
            this.com_portComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_portComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.com_portComboBox.Name = "com_portComboBox";
            this.com_portComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.com_portComboBox.Size = new System.Drawing.Size(270, 29);
            this.com_portComboBox.TabIndex = 30;
            this.com_portComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 403);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 227);
            this.textBox1.TabIndex = 31;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(67, 365);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(292, 35);
            this.uiLabel2.TabIndex = 32;
            this.uiLabel2.Text = "수신";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 656);
            this.ControlBox = false;
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.com_portComboBox);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.comStatus);
            this.Controls.Add(this.comDisconnet);
            this.Controls.Add(this.comConnet);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.humiAnalogMeter);
            this.Controls.Add(this.tempAnalogMeter);
            this.Controls.Add(this.humiLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.uiSymbolButton1);
            this.Name = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton exit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel tempLabel;
        private Sunny.UI.UISymbolLabel humiLabel;
        private Sunny.UI.UIAnalogMeter tempAnalogMeter;
        private Sunny.UI.UIAnalogMeter humiAnalogMeter;
        private Sunny.UI.UISymbolLabel timeLabel;
        private Sunny.UI.UILabel comStatus;
        private Sunny.UI.UISymbolButton comDisconnet;
        private Sunny.UI.UISymbolButton comConnet;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox com_portComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private Sunny.UI.UILabel uiLabel2;
    }
}

