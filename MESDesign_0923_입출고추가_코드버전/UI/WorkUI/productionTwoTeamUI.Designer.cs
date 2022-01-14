
namespace MESDesign_code.UI
{
    partial class productionTwoTeamUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productionTwoTeamUI));
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.productionTwoTeamClose = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.MediumOrchid;
            this.uiSymbolButton2.FillSelectedColor = System.Drawing.Color.MediumOrchid;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(186, 12);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Size = new System.Drawing.Size(429, 40);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61555;
            this.uiSymbolButton2.SymbolSize = 40;
            this.uiSymbolButton2.TabIndex = 14;
            this.uiSymbolButton2.Text = "생산2팀 일정";
            // 
            // productionTwoTeamClose
            // 
            this.productionTwoTeamClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productionTwoTeamClose.FillColor = System.Drawing.Color.Tomato;
            this.productionTwoTeamClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionTwoTeamClose.Location = new System.Drawing.Point(335, 437);
            this.productionTwoTeamClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.productionTwoTeamClose.Name = "productionTwoTeamClose";
            this.productionTwoTeamClose.Size = new System.Drawing.Size(164, 72);
            this.productionTwoTeamClose.Style = Sunny.UI.UIStyle.Custom;
            this.productionTwoTeamClose.Symbol = 61453;
            this.productionTwoTeamClose.SymbolSize = 36;
            this.productionTwoTeamClose.TabIndex = 33;
            this.productionTwoTeamClose.Text = "닫기";
            this.productionTwoTeamClose.Click += new System.EventHandler(this.productionTwoTeamClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // productionTwoTeamUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 534);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.productionTwoTeamClose);
            this.Controls.Add(this.uiSymbolButton2);
            this.Name = "productionTwoTeamUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.productionTwoTeamUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton productionTwoTeamClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}