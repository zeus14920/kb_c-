
namespace MESDesign.UI
{
    partial class productionOneTeamUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productionOneTeamUI));
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.productionOneTeamClose = new Sunny.UI.UISymbolButton();
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
            this.uiSymbolButton2.Location = new System.Drawing.Point(187, 12);
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
            this.uiSymbolButton2.Text = "생산1팀 일정";
            // 
            // productionOneTeamClose
            // 
            this.productionOneTeamClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productionOneTeamClose.FillColor = System.Drawing.Color.Tomato;
            this.productionOneTeamClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionOneTeamClose.Location = new System.Drawing.Point(322, 431);
            this.productionOneTeamClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.productionOneTeamClose.Name = "productionOneTeamClose";
            this.productionOneTeamClose.Size = new System.Drawing.Size(164, 72);
            this.productionOneTeamClose.Style = Sunny.UI.UIStyle.Custom;
            this.productionOneTeamClose.Symbol = 61453;
            this.productionOneTeamClose.SymbolSize = 36;
            this.productionOneTeamClose.TabIndex = 32;
            this.productionOneTeamClose.Text = "닫기";
            this.productionOneTeamClose.Click += new System.EventHandler(this.productionOneTeamClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // productionOneTeamUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 534);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.productionOneTeamClose);
            this.Controls.Add(this.uiSymbolButton2);
            this.Name = "productionOneTeamUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.productionOneTeamUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton productionOneTeamClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}