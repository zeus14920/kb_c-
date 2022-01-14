
namespace MESDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.mainMin = new Sunny.UI.UISymbolButton();
            this.employManag = new Sunny.UI.UISymbolButton();
            this.worCalen = new Sunny.UI.UISymbolButton();
            this.materialManag = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productionEnvInfo = new Sunny.UI.UISymbolButton();
            this.productionManagInfo = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(212, 40);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 162076;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "MES";
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.Location = new System.Drawing.Point(736, 17);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mainExit.RectPressColor = System.Drawing.Color.Red;
            this.mainExit.Size = new System.Drawing.Size(52, 35);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.SymbolSize = 32;
            this.mainExit.TabIndex = 10;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // mainMin
            // 
            this.mainMin.BackColor = System.Drawing.Color.Transparent;
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.Location = new System.Drawing.Point(678, 17);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mainMin.RectPressColor = System.Drawing.Color.Red;
            this.mainMin.Size = new System.Drawing.Size(52, 35);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 61544;
            this.mainMin.SymbolSize = 32;
            this.mainMin.TabIndex = 9;
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // employManag
            // 
            this.employManag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employManag.FillColor = System.Drawing.Color.White;
            this.employManag.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.employManag.FillPressColor = System.Drawing.Color.MediumOrchid;
            this.employManag.FillSelectedColor = System.Drawing.Color.MediumOrchid;
            this.employManag.Font = new System.Drawing.Font("Microsoft YaHei", 25F);
            this.employManag.ForeColor = System.Drawing.Color.Black;
            this.employManag.ForeHoverColor = System.Drawing.Color.Black;
            this.employManag.Location = new System.Drawing.Point(495, 98);
            this.employManag.MinimumSize = new System.Drawing.Size(1, 1);
            this.employManag.Name = "employManag";
            this.employManag.RectColor = System.Drawing.Color.Blue;
            this.employManag.Size = new System.Drawing.Size(315, 72);
            this.employManag.Style = Sunny.UI.UIStyle.Custom;
            this.employManag.Symbol = 62144;
            this.employManag.SymbolSize = 35;
            this.employManag.TabIndex = 11;
            this.employManag.Text = "사원 관리";
            this.employManag.Click += new System.EventHandler(this.employManag_Click);
            // 
            // worCalen
            // 
            this.worCalen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.worCalen.FillColor = System.Drawing.Color.White;
            this.worCalen.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.worCalen.FillPressColor = System.Drawing.Color.MediumOrchid;
            this.worCalen.FillSelectedColor = System.Drawing.Color.MediumOrchid;
            this.worCalen.Font = new System.Drawing.Font("Microsoft YaHei", 25F);
            this.worCalen.ForeColor = System.Drawing.Color.Black;
            this.worCalen.ForeHoverColor = System.Drawing.Color.Black;
            this.worCalen.Location = new System.Drawing.Point(495, 469);
            this.worCalen.MinimumSize = new System.Drawing.Size(1, 1);
            this.worCalen.Name = "worCalen";
            this.worCalen.RectColor = System.Drawing.Color.Blue;
            this.worCalen.Size = new System.Drawing.Size(315, 72);
            this.worCalen.Style = Sunny.UI.UIStyle.Custom;
            this.worCalen.Symbol = 61555;
            this.worCalen.SymbolSize = 40;
            this.worCalen.TabIndex = 12;
            this.worCalen.Text = "작업 일정";
            this.worCalen.Click += new System.EventHandler(this.workCalenButton2_Click);
            // 
            // materialManag
            // 
            this.materialManag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialManag.FillColor = System.Drawing.Color.White;
            this.materialManag.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.materialManag.FillPressColor = System.Drawing.Color.MediumOrchid;
            this.materialManag.FillSelectedColor = System.Drawing.Color.MediumOrchid;
            this.materialManag.Font = new System.Drawing.Font("Microsoft YaHei", 25F);
            this.materialManag.ForeColor = System.Drawing.Color.Black;
            this.materialManag.ForeHoverColor = System.Drawing.Color.Black;
            this.materialManag.Location = new System.Drawing.Point(495, 193);
            this.materialManag.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialManag.Name = "materialManag";
            this.materialManag.RectColor = System.Drawing.Color.Blue;
            this.materialManag.Size = new System.Drawing.Size(315, 72);
            this.materialManag.Style = Sunny.UI.UIStyle.Custom;
            this.materialManag.Symbol = 61875;
            this.materialManag.SymbolSize = 50;
            this.materialManag.TabIndex = 13;
            this.materialManag.Text = "자재 관리";
            this.materialManag.Click += new System.EventHandler(this.materialManag_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // productionEnvInfo
            // 
            this.productionEnvInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productionEnvInfo.FillColor = System.Drawing.Color.White;
            this.productionEnvInfo.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productionEnvInfo.FillPressColor = System.Drawing.Color.MediumOrchid;
            this.productionEnvInfo.FillSelectedColor = System.Drawing.Color.MediumOrchid;
            this.productionEnvInfo.Font = new System.Drawing.Font("Microsoft YaHei", 25F);
            this.productionEnvInfo.ForeColor = System.Drawing.Color.Black;
            this.productionEnvInfo.ForeHoverColor = System.Drawing.Color.Black;
            this.productionEnvInfo.Location = new System.Drawing.Point(495, 284);
            this.productionEnvInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.productionEnvInfo.Name = "productionEnvInfo";
            this.productionEnvInfo.RectColor = System.Drawing.Color.Blue;
            this.productionEnvInfo.Size = new System.Drawing.Size(315, 72);
            this.productionEnvInfo.Style = Sunny.UI.UIStyle.Custom;
            this.productionEnvInfo.Symbol = 61573;
            this.productionEnvInfo.SymbolSize = 50;
            this.productionEnvInfo.TabIndex = 15;
            this.productionEnvInfo.Text = "생산 환경 정보";
            this.productionEnvInfo.Click += new System.EventHandler(this.productionEnvInfo_Click);
            // 
            // productionManagInfo
            // 
            this.productionManagInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productionManagInfo.FillColor = System.Drawing.Color.White;
            this.productionManagInfo.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.productionManagInfo.FillPressColor = System.Drawing.Color.MediumOrchid;
            this.productionManagInfo.FillSelectedColor = System.Drawing.Color.MediumOrchid;
            this.productionManagInfo.Font = new System.Drawing.Font("Microsoft YaHei", 25F);
            this.productionManagInfo.ForeColor = System.Drawing.Color.Black;
            this.productionManagInfo.ForeHoverColor = System.Drawing.Color.Black;
            this.productionManagInfo.Location = new System.Drawing.Point(495, 372);
            this.productionManagInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.productionManagInfo.Name = "productionManagInfo";
            this.productionManagInfo.RectColor = System.Drawing.Color.Blue;
            this.productionManagInfo.Size = new System.Drawing.Size(315, 72);
            this.productionManagInfo.Style = Sunny.UI.UIStyle.Custom;
            this.productionManagInfo.Symbol = 61573;
            this.productionManagInfo.SymbolSize = 50;
            this.productionManagInfo.TabIndex = 16;
            this.productionManagInfo.Text = "생산 관리 정보";
            this.productionManagInfo.Click += new System.EventHandler(this.productionManagInfo_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 614);
            this.ControlBox = false;
            this.Controls.Add(this.productionManagInfo);
            this.Controls.Add(this.productionEnvInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialManag);
            this.Controls.Add(this.worCalen);
            this.Controls.Add(this.employManag);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.mainMin);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton mainMin;
        private Sunny.UI.UISymbolButton employManag;
        private Sunny.UI.UISymbolButton worCalen;
        private Sunny.UI.UISymbolButton materialManag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton productionEnvInfo;
        private Sunny.UI.UISymbolButton productionManagInfo;
    }
}

