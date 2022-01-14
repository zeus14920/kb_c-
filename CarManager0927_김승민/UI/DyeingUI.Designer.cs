
namespace CarManager0811.UI
{
    partial class DyeingUI
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.numWorkCount = new System.Windows.Forms.NumericUpDown();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btnStart = new Sunny.UI.UIButton();
            this.lboxResult = new Sunny.UI.UIListBox();
            this.btnClose = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkCount)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(298, 74);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(290, 35);
            this.uiSymbolLabel1.Symbol = 61687;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "염색 작업 공정";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(123, 57);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(200, 38);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 61573;
            this.uiSymbolLabel2.TabIndex = 1;
            this.uiSymbolLabel2.Text = "작업 시작 개수";
            // 
            // numWorkCount
            // 
            this.numWorkCount.Font = new System.Drawing.Font("굴림", 20F);
            this.numWorkCount.Location = new System.Drawing.Point(340, 57);
            this.numWorkCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWorkCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWorkCount.Name = "numWorkCount";
            this.numWorkCount.Size = new System.Drawing.Size(120, 38);
            this.numWorkCount.TabIndex = 2;
            this.numWorkCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(137, 158);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(361, 47);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "작업 내용: 방직 - 제직 - 염색 - 후가공 - 봉재";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.uiSymbolLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.numWorkCount);
            this.uiGroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(114, 150);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.RoyalBlue;
            this.uiGroupBox1.Size = new System.Drawing.Size(646, 259);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnStart.Location = new System.Drawing.Point(185, 437);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(219, 61);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "작업 시작";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lboxResult
            // 
            this.lboxResult.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lboxResult.FormatString = "";
            this.lboxResult.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lboxResult.Location = new System.Drawing.Point(114, 521);
            this.lboxResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lboxResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Padding = new System.Windows.Forms.Padding(2);
            this.lboxResult.Size = new System.Drawing.Size(646, 198);
            this.lboxResult.TabIndex = 6;
            this.lboxResult.Text = "uiListBox1";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnClose.Location = new System.Drawing.Point(454, 437);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(219, 61);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "작업 종료";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DyeingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "DyeingUI";
            this.Size = new System.Drawing.Size(886, 768);
            ((System.ComponentModel.ISupportInitialize)(this.numWorkCount)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private System.Windows.Forms.NumericUpDown numWorkCount;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UIListBox lboxResult;
        private Sunny.UI.UIButton btnClose;
    }
}
