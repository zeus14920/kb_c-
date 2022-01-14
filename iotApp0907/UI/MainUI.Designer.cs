
namespace iotApp0907
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.lineOneTemp = new Sunny.UI.UISymbolLabel();
            this.lineOnehumi = new Sunny.UI.UISymbolLabel();
            this.lineAddTime = new Sunny.UI.UISymbolLabel();
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            this.uiDoughnutChart1 = new Sunny.UI.UIDoughnutChart();
            this.uiLineChart1 = new Sunny.UI.UILineChart();
            this.uiPieChart1 = new Sunny.UI.UIPieChart();
            this.uiLine1 = new Sunny.UI.UILine();
            this.lineOneTempBulb = new Sunny.UI.UILedBulb();
            this.lineTwoTempAnalogMeter = new Sunny.UI.UIAnalogMeter();
            this.lineTwoHumiAnalogMeter = new Sunny.UI.UIAnalogMeter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiLine3 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 22F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(46, 79);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(54, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(360, 65);
            this.uiSymbolLabel1.Symbol = 61573;
            this.uiSymbolLabel1.SymbolSize = 50;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "부품 1라인 정보";
            // 
            // lineOneTemp
            // 
            this.lineOneTemp.Font = new System.Drawing.Font("Microsoft YaHei", 22F);
            this.lineOneTemp.Location = new System.Drawing.Point(46, 158);
            this.lineOneTemp.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineOneTemp.Name = "lineOneTemp";
            this.lineOneTemp.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.lineOneTemp.Size = new System.Drawing.Size(273, 65);
            this.lineOneTemp.Symbol = 62152;
            this.lineOneTemp.SymbolColor = System.Drawing.Color.Red;
            this.lineOneTemp.SymbolSize = 40;
            this.lineOneTemp.TabIndex = 1;
            this.lineOneTemp.Text = "0℃";
            this.lineOneTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineOnehumi
            // 
            this.lineOnehumi.Font = new System.Drawing.Font("Microsoft YaHei", 22F);
            this.lineOnehumi.Location = new System.Drawing.Point(46, 229);
            this.lineOnehumi.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineOnehumi.Name = "lineOnehumi";
            this.lineOnehumi.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.lineOnehumi.Size = new System.Drawing.Size(273, 65);
            this.lineOnehumi.Symbol = 61507;
            this.lineOnehumi.SymbolColor = System.Drawing.Color.Blue;
            this.lineOnehumi.SymbolSize = 40;
            this.lineOnehumi.TabIndex = 2;
            this.lineOnehumi.Text = "0%";
            this.lineOnehumi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineAddTime
            // 
            this.lineAddTime.Font = new System.Drawing.Font("Microsoft YaHei", 22F);
            this.lineAddTime.Location = new System.Drawing.Point(46, 300);
            this.lineAddTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineAddTime.Name = "lineAddTime";
            this.lineAddTime.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.lineAddTime.Size = new System.Drawing.Size(360, 65);
            this.lineAddTime.Symbol = 61463;
            this.lineAddTime.SymbolColor = System.Drawing.Color.Green;
            this.lineAddTime.SymbolSize = 40;
            this.lineAddTime.TabIndex = 3;
            this.lineAddTime.Text = "등록 시간";
            this.lineAddTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.FillColor = System.Drawing.Color.White;
            this.uiBarChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiBarChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiBarChart1.Location = new System.Drawing.Point(61, 371);
            this.uiBarChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.RectColor = System.Drawing.Color.White;
            this.uiBarChart1.Size = new System.Drawing.Size(273, 223);
            this.uiBarChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiBarChart1.TabIndex = 4;
            this.uiBarChart1.Text = "uiBarChart1";
            // 
            // uiDoughnutChart1
            // 
            this.uiDoughnutChart1.FillColor = System.Drawing.Color.White;
            this.uiDoughnutChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDoughnutChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiDoughnutChart1.Location = new System.Drawing.Point(340, 371);
            this.uiDoughnutChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDoughnutChart1.Name = "uiDoughnutChart1";
            this.uiDoughnutChart1.RectColor = System.Drawing.Color.White;
            this.uiDoughnutChart1.Size = new System.Drawing.Size(273, 223);
            this.uiDoughnutChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiDoughnutChart1.TabIndex = 5;
            this.uiDoughnutChart1.Text = "uiDoughnutChart1";
            // 
            // uiLineChart1
            // 
            this.uiLineChart1.FillColor = System.Drawing.Color.White;
            this.uiLineChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLineChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiLineChart1.Location = new System.Drawing.Point(619, 371);
            this.uiLineChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart1.Name = "uiLineChart1";
            this.uiLineChart1.RectColor = System.Drawing.Color.White;
            this.uiLineChart1.Size = new System.Drawing.Size(273, 223);
            this.uiLineChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLineChart1.TabIndex = 6;
            this.uiLineChart1.Text = "uiLineChart1";
            // 
            // uiPieChart1
            // 
            this.uiPieChart1.FillColor = System.Drawing.Color.White;
            this.uiPieChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPieChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiPieChart1.Location = new System.Drawing.Point(898, 371);
            this.uiPieChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPieChart1.Name = "uiPieChart1";
            this.uiPieChart1.RectColor = System.Drawing.Color.White;
            this.uiPieChart1.Size = new System.Drawing.Size(273, 223);
            this.uiPieChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPieChart1.TabIndex = 7;
            this.uiPieChart1.Text = "uiPieChart1";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(46, 150);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(360, 2);
            this.uiLine1.TabIndex = 8;
            // 
            // lineOneTempBulb
            // 
            this.lineOneTempBulb.Color = System.Drawing.Color.Red;
            this.lineOneTempBulb.Location = new System.Drawing.Point(443, 158);
            this.lineOneTempBulb.Name = "lineOneTempBulb";
            this.lineOneTempBulb.Size = new System.Drawing.Size(183, 184);
            this.lineOneTempBulb.TabIndex = 9;
            this.lineOneTempBulb.Text = "uiLedBulb1";
            // 
            // lineTwoTempAnalogMeter
            // 
            this.lineTwoTempAnalogMeter.BackColor = System.Drawing.Color.White;
            this.lineTwoTempAnalogMeter.BodyColor = System.Drawing.Color.Silver;
            this.lineTwoTempAnalogMeter.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lineTwoTempAnalogMeter.Location = new System.Drawing.Point(683, 158);
            this.lineTwoTempAnalogMeter.MaxValue = 100D;
            this.lineTwoTempAnalogMeter.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineTwoTempAnalogMeter.MinValue = 0D;
            this.lineTwoTempAnalogMeter.Name = "lineTwoTempAnalogMeter";
            this.lineTwoTempAnalogMeter.NeedleColor = System.Drawing.Color.Red;
            this.lineTwoTempAnalogMeter.Renderer = null;
            this.lineTwoTempAnalogMeter.Size = new System.Drawing.Size(183, 184);
            this.lineTwoTempAnalogMeter.Style = Sunny.UI.UIStyle.Custom;
            this.lineTwoTempAnalogMeter.TabIndex = 10;
            this.lineTwoTempAnalogMeter.Text = "uiAnalogMeter1";
            this.lineTwoTempAnalogMeter.Value = 50D;
            // 
            // lineTwoHumiAnalogMeter
            // 
            this.lineTwoHumiAnalogMeter.BackColor = System.Drawing.Color.White;
            this.lineTwoHumiAnalogMeter.BodyColor = System.Drawing.Color.Silver;
            this.lineTwoHumiAnalogMeter.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lineTwoHumiAnalogMeter.Location = new System.Drawing.Point(925, 158);
            this.lineTwoHumiAnalogMeter.MaxValue = 100D;
            this.lineTwoHumiAnalogMeter.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineTwoHumiAnalogMeter.MinValue = 0D;
            this.lineTwoHumiAnalogMeter.Name = "lineTwoHumiAnalogMeter";
            this.lineTwoHumiAnalogMeter.NeedleColor = System.Drawing.Color.Blue;
            this.lineTwoHumiAnalogMeter.Renderer = null;
            this.lineTwoHumiAnalogMeter.Size = new System.Drawing.Size(183, 184);
            this.lineTwoHumiAnalogMeter.Style = Sunny.UI.UIStyle.Custom;
            this.lineTwoHumiAnalogMeter.TabIndex = 11;
            this.lineTwoHumiAnalogMeter.Text = "uiAnalogMeter2";
            this.lineTwoHumiAnalogMeter.Value = 50D;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(61, 608);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "chartTemp1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "chartHumi1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "chartTemp2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "chartHumi2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1110, 266);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "헤드램프 생산라인 환경";
            this.chart1.Titles.Add(title1);
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.Location = new System.Drawing.Point(46, 363);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(1139, 2);
            this.uiLine2.TabIndex = 13;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(426, 79);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(218, 65);
            this.uiSymbolLabel5.Symbol = 62152;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel5.SymbolSize = 40;
            this.uiSymbolLabel5.TabIndex = 14;
            this.uiSymbolLabel5.Text = "부품 1라인 온도";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.uiSymbolLabel6.Location = new System.Drawing.Point(667, 79);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(210, 65);
            this.uiSymbolLabel6.Symbol = 62152;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel6.SymbolSize = 40;
            this.uiSymbolLabel6.TabIndex = 15;
            this.uiSymbolLabel6.Text = "부품 2라인 온도";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.uiSymbolLabel7.Location = new System.Drawing.Point(898, 79);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(210, 65);
            this.uiSymbolLabel7.Symbol = 61507;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.Blue;
            this.uiSymbolLabel7.SymbolSize = 40;
            this.uiSymbolLabel7.TabIndex = 16;
            this.uiSymbolLabel7.Text = "부품 2라인 습도";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine3
            // 
            this.uiLine3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine3.Location = new System.Drawing.Point(46, 600);
            this.uiLine3.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(1139, 2);
            this.uiLine3.TabIndex = 17;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 978);
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lineTwoHumiAnalogMeter);
            this.Controls.Add(this.lineTwoTempAnalogMeter);
            this.Controls.Add(this.lineOneTempBulb);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiPieChart1);
            this.Controls.Add(this.uiLineChart1);
            this.Controls.Add(this.uiDoughnutChart1);
            this.Controls.Add(this.uiBarChart1);
            this.Controls.Add(this.lineAddTime);
            this.Controls.Add(this.lineOnehumi);
            this.Controls.Add(this.lineOneTemp);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "MainUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel lineOneTemp;
        private Sunny.UI.UISymbolLabel lineOnehumi;
        private Sunny.UI.UISymbolLabel lineAddTime;
        private Sunny.UI.UIBarChart uiBarChart1;
        private Sunny.UI.UIDoughnutChart uiDoughnutChart1;
        private Sunny.UI.UILineChart uiLineChart1;
        private Sunny.UI.UIPieChart uiPieChart1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILedBulb lineOneTempBulb;
        private Sunny.UI.UIAnalogMeter lineTwoTempAnalogMeter;
        private Sunny.UI.UIAnalogMeter lineTwoHumiAnalogMeter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UILine uiLine3;
    }
}

