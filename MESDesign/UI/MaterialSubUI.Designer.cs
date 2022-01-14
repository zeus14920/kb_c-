
namespace MESDesign.UI
{
    partial class MaterialSubUI
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
            this.materialPrice = new Sunny.UI.UILabel();
            this.materialName = new Sunny.UI.UILabel();
            this.materialCode = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.materialrelease = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.materialSubClose = new Sunny.UI.UISymbolButton();
            this.materialSubOK = new Sunny.UI.UISymbolButton();
            this.materialSub = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // materialPrice
            // 
            this.materialPrice.BackColor = System.Drawing.Color.White;
            this.materialPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialPrice.Location = new System.Drawing.Point(372, 246);
            this.materialPrice.Name = "materialPrice";
            this.materialPrice.Size = new System.Drawing.Size(318, 51);
            this.materialPrice.TabIndex = 55;
            this.materialPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialName
            // 
            this.materialName.BackColor = System.Drawing.Color.White;
            this.materialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialName.Location = new System.Drawing.Point(372, 180);
            this.materialName.Name = "materialName";
            this.materialName.Size = new System.Drawing.Size(318, 51);
            this.materialName.TabIndex = 54;
            this.materialName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCode
            // 
            this.materialCode.DataSource = null;
            this.materialCode.FillColor = System.Drawing.Color.White;
            this.materialCode.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.materialCode.Location = new System.Drawing.Point(372, 114);
            this.materialCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialCode.MinimumSize = new System.Drawing.Size(63, 0);
            this.materialCode.Name = "materialCode";
            this.materialCode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.materialCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialCode.Size = new System.Drawing.Size(318, 51);
            this.materialCode.Style = Sunny.UI.UIStyle.Custom;
            this.materialCode.TabIndex = 53;
            this.materialCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(195, 237);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(131, 60);
            this.uiSymbolLabel1.Symbol = 61785;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 38;
            this.uiSymbolLabel1.TabIndex = 52;
            this.uiSymbolLabel1.Text = "가격";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(195, 171);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(131, 60);
            this.uiSymbolLabel5.Symbol = 61483;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.SymbolSize = 32;
            this.uiSymbolLabel5.TabIndex = 51;
            this.uiSymbolLabel5.Text = "제품명";
            // 
            // materialrelease
            // 
            this.materialrelease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialrelease.FillColor = System.Drawing.Color.White;
            this.materialrelease.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.materialrelease.Location = new System.Drawing.Point(372, 312);
            this.materialrelease.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialrelease.Maximum = 2147483647D;
            this.materialrelease.Minimum = -2147483648D;
            this.materialrelease.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialrelease.Name = "materialrelease";
            this.materialrelease.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialrelease.Size = new System.Drawing.Size(318, 51);
            this.materialrelease.Style = Sunny.UI.UIStyle.Custom;
            this.materialrelease.TabIndex = 50;
            this.materialrelease.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(195, 303);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(131, 60);
            this.uiSymbolLabel3.Symbol = 61649;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.SymbolSize = 32;
            this.uiSymbolLabel3.TabIndex = 49;
            this.uiSymbolLabel3.Text = "출고수량";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(195, 105);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(131, 60);
            this.uiSymbolLabel2.Symbol = 162087;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.SymbolSize = 32;
            this.uiSymbolLabel2.TabIndex = 48;
            this.uiSymbolLabel2.Text = "코  드";
            // 
            // materialSubClose
            // 
            this.materialSubClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialSubClose.FillColor = System.Drawing.Color.Tomato;
            this.materialSubClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSubClose.Location = new System.Drawing.Point(483, 460);
            this.materialSubClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialSubClose.Name = "materialSubClose";
            this.materialSubClose.Size = new System.Drawing.Size(164, 72);
            this.materialSubClose.Style = Sunny.UI.UIStyle.Custom;
            this.materialSubClose.Symbol = 61453;
            this.materialSubClose.SymbolSize = 36;
            this.materialSubClose.TabIndex = 47;
            this.materialSubClose.Text = "닫기";
            this.materialSubClose.Click += new System.EventHandler(this.materialSubClose_Click);
            // 
            // materialSubOK
            // 
            this.materialSubOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialSubOK.FillColor = System.Drawing.Color.DarkGreen;
            this.materialSubOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSubOK.Location = new System.Drawing.Point(250, 460);
            this.materialSubOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialSubOK.Name = "materialSubOK";
            this.materialSubOK.Size = new System.Drawing.Size(164, 72);
            this.materialSubOK.Style = Sunny.UI.UIStyle.Custom;
            this.materialSubOK.Symbol = 61508;
            this.materialSubOK.SymbolSize = 36;
            this.materialSubOK.TabIndex = 46;
            this.materialSubOK.Text = "등록";
            // 
            // materialSub
            // 
            this.materialSub.BackColor = System.Drawing.Color.Transparent;
            this.materialSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialSub.FillColor = System.Drawing.Color.Transparent;
            this.materialSub.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.materialSub.Location = new System.Drawing.Point(195, 12);
            this.materialSub.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialSub.Name = "materialSub";
            this.materialSub.RectColor = System.Drawing.Color.Transparent;
            this.materialSub.RectDisableColor = System.Drawing.Color.Transparent;
            this.materialSub.RectHoverColor = System.Drawing.Color.Transparent;
            this.materialSub.RectPressColor = System.Drawing.Color.Transparent;
            this.materialSub.RectSelectedColor = System.Drawing.Color.Transparent;
            this.materialSub.Size = new System.Drawing.Size(475, 44);
            this.materialSub.Style = Sunny.UI.UIStyle.Custom;
            this.materialSub.Symbol = 61875;
            this.materialSub.SymbolSize = 50;
            this.materialSub.TabIndex = 45;
            this.materialSub.Text = "자재 출고";
            // 
            // MaterialSubUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 595);
            this.ControlBox = false;
            this.Controls.Add(this.materialPrice);
            this.Controls.Add(this.materialName);
            this.Controls.Add(this.materialCode);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.materialrelease);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.materialSubClose);
            this.Controls.Add(this.materialSubOK);
            this.Controls.Add(this.materialSub);
            this.Name = "MaterialSubUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel materialPrice;
        private Sunny.UI.UILabel materialName;
        private Sunny.UI.UIComboBox materialCode;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UITextBox materialrelease;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton materialSubClose;
        private Sunny.UI.UISymbolButton materialSubOK;
        private Sunny.UI.UISymbolButton materialSub;
    }
}