
namespace MESDesign_code.UI
{
    partial class MaterialAddUI
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.materialAddClose = new Sunny.UI.UISymbolButton();
            this.materialAddOK = new Sunny.UI.UISymbolButton();
            this.materialAdd = new Sunny.UI.UISymbolButton();
            this.materialCode = new Sunny.UI.UIComboBox();
            this.materialName = new Sunny.UI.UILabel();
            this.materialPrice = new Sunny.UI.UILabel();
            this.materialReceiving = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(206, 237);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(131, 60);
            this.uiSymbolLabel1.Symbol = 61785;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 38;
            this.uiSymbolLabel1.TabIndex = 40;
            this.uiSymbolLabel1.Text = "가격";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(206, 171);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(131, 60);
            this.uiSymbolLabel5.Symbol = 61483;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.SymbolSize = 32;
            this.uiSymbolLabel5.TabIndex = 38;
            this.uiSymbolLabel5.Text = "제품명";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(206, 303);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(131, 60);
            this.uiSymbolLabel3.Symbol = 61649;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.SymbolSize = 32;
            this.uiSymbolLabel3.TabIndex = 34;
            this.uiSymbolLabel3.Text = "입고수량";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(206, 105);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(131, 60);
            this.uiSymbolLabel2.Symbol = 162087;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.SymbolSize = 32;
            this.uiSymbolLabel2.TabIndex = 32;
            this.uiSymbolLabel2.Text = "코  드";
            // 
            // materialAddClose
            // 
            this.materialAddClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialAddClose.FillColor = System.Drawing.Color.Tomato;
            this.materialAddClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialAddClose.Location = new System.Drawing.Point(494, 460);
            this.materialAddClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialAddClose.Name = "materialAddClose";
            this.materialAddClose.Size = new System.Drawing.Size(164, 72);
            this.materialAddClose.Style = Sunny.UI.UIStyle.Custom;
            this.materialAddClose.Symbol = 61453;
            this.materialAddClose.SymbolSize = 36;
            this.materialAddClose.TabIndex = 31;
            this.materialAddClose.Text = "닫기";
            this.materialAddClose.Click += new System.EventHandler(this.custAddClose_Click);
            // 
            // materialAddOK
            // 
            this.materialAddOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialAddOK.FillColor = System.Drawing.Color.DarkGreen;
            this.materialAddOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialAddOK.Location = new System.Drawing.Point(261, 460);
            this.materialAddOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialAddOK.Name = "materialAddOK";
            this.materialAddOK.Size = new System.Drawing.Size(164, 72);
            this.materialAddOK.Style = Sunny.UI.UIStyle.Custom;
            this.materialAddOK.Symbol = 61508;
            this.materialAddOK.SymbolSize = 36;
            this.materialAddOK.TabIndex = 30;
            this.materialAddOK.Text = "등록";
            this.materialAddOK.Click += new System.EventHandler(this.materialAddOK_Click);
            // 
            // materialAdd
            // 
            this.materialAdd.BackColor = System.Drawing.Color.Transparent;
            this.materialAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialAdd.FillColor = System.Drawing.Color.Transparent;
            this.materialAdd.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.materialAdd.Location = new System.Drawing.Point(206, 12);
            this.materialAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialAdd.Name = "materialAdd";
            this.materialAdd.RectColor = System.Drawing.Color.Transparent;
            this.materialAdd.RectDisableColor = System.Drawing.Color.Transparent;
            this.materialAdd.RectHoverColor = System.Drawing.Color.Transparent;
            this.materialAdd.RectPressColor = System.Drawing.Color.Transparent;
            this.materialAdd.RectSelectedColor = System.Drawing.Color.Transparent;
            this.materialAdd.Size = new System.Drawing.Size(475, 44);
            this.materialAdd.Style = Sunny.UI.UIStyle.Custom;
            this.materialAdd.Symbol = 61875;
            this.materialAdd.SymbolSize = 50;
            this.materialAdd.TabIndex = 29;
            this.materialAdd.Text = "자재 입고";
            // 
            // materialCode
            // 
            this.materialCode.DataSource = null;
            this.materialCode.FillColor = System.Drawing.Color.White;
            this.materialCode.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.materialCode.Location = new System.Drawing.Point(383, 114);
            this.materialCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialCode.MinimumSize = new System.Drawing.Size(63, 0);
            this.materialCode.Name = "materialCode";
            this.materialCode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.materialCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialCode.Size = new System.Drawing.Size(318, 51);
            this.materialCode.Style = Sunny.UI.UIStyle.Custom;
            this.materialCode.TabIndex = 42;
            this.materialCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialCode.SelectedIndexChanged += new System.EventHandler(this.materialCode_SelectedIndexChanged);
            // 
            // materialName
            // 
            this.materialName.BackColor = System.Drawing.Color.White;
            this.materialName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialName.Location = new System.Drawing.Point(383, 180);
            this.materialName.Name = "materialName";
            this.materialName.Size = new System.Drawing.Size(318, 51);
            this.materialName.TabIndex = 43;
            this.materialName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialPrice
            // 
            this.materialPrice.BackColor = System.Drawing.Color.White;
            this.materialPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.materialPrice.Location = new System.Drawing.Point(383, 246);
            this.materialPrice.Name = "materialPrice";
            this.materialPrice.Size = new System.Drawing.Size(318, 51);
            this.materialPrice.TabIndex = 44;
            this.materialPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialReceiving
            // 
            this.materialReceiving.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialReceiving.FillColor = System.Drawing.Color.White;
            this.materialReceiving.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.materialReceiving.Location = new System.Drawing.Point(383, 312);
            this.materialReceiving.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialReceiving.Maximum = 2147483647D;
            this.materialReceiving.Minimum = -2147483648D;
            this.materialReceiving.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialReceiving.Name = "materialReceiving";
            this.materialReceiving.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.materialReceiving.Size = new System.Drawing.Size(318, 51);
            this.materialReceiving.Style = Sunny.UI.UIStyle.Custom;
            this.materialReceiving.TabIndex = 35;
            this.materialReceiving.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaterialAddUI
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
            this.Controls.Add(this.materialReceiving);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.materialAddClose);
            this.Controls.Add(this.materialAddOK);
            this.Controls.Add(this.materialAdd);
            this.Name = "MaterialAddUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MaterialAddUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton materialAddClose;
        private Sunny.UI.UISymbolButton materialAddOK;
        private Sunny.UI.UISymbolButton materialAdd;
        private Sunny.UI.UIComboBox materialCode;
        private Sunny.UI.UILabel materialName;
        private Sunny.UI.UILabel materialPrice;
        private Sunny.UI.UITextBox materialReceiving;
    }
}