
namespace MESDesign_code.UI
{
    partial class EmployAddUI
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
            this.employAdd = new Sunny.UI.UISymbolButton();
            this.employAddClose = new Sunny.UI.UISymbolButton();
            this.employAddOK = new Sunny.UI.UISymbolButton();
            this.employWork = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.employPosition = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.employName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.employDepart = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.employTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.employWoman = new Sunny.UI.UIRadioButton();
            this.employMan = new Sunny.UI.UIRadioButton();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // employAdd
            // 
            this.employAdd.BackColor = System.Drawing.Color.Transparent;
            this.employAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employAdd.FillColor = System.Drawing.Color.Transparent;
            this.employAdd.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.employAdd.Location = new System.Drawing.Point(212, 12);
            this.employAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.employAdd.Name = "employAdd";
            this.employAdd.RectColor = System.Drawing.Color.Transparent;
            this.employAdd.RectDisableColor = System.Drawing.Color.Transparent;
            this.employAdd.RectHoverColor = System.Drawing.Color.Transparent;
            this.employAdd.RectPressColor = System.Drawing.Color.Transparent;
            this.employAdd.RectSelectedColor = System.Drawing.Color.Transparent;
            this.employAdd.Size = new System.Drawing.Size(387, 44);
            this.employAdd.Style = Sunny.UI.UIStyle.Custom;
            this.employAdd.Symbol = 62144;
            this.employAdd.SymbolSize = 40;
            this.employAdd.TabIndex = 13;
            this.employAdd.Text = "사원 추가";
            // 
            // employAddClose
            // 
            this.employAddClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employAddClose.FillColor = System.Drawing.Color.Tomato;
            this.employAddClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employAddClose.Location = new System.Drawing.Point(445, 410);
            this.employAddClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.employAddClose.Name = "employAddClose";
            this.employAddClose.Size = new System.Drawing.Size(164, 72);
            this.employAddClose.Style = Sunny.UI.UIStyle.Custom;
            this.employAddClose.Symbol = 61453;
            this.employAddClose.SymbolSize = 36;
            this.employAddClose.TabIndex = 15;
            this.employAddClose.Text = "닫기";
            this.employAddClose.Click += new System.EventHandler(this.custAddClose_Click);
            // 
            // employAddOK
            // 
            this.employAddOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employAddOK.FillColor = System.Drawing.Color.DarkGreen;
            this.employAddOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employAddOK.Location = new System.Drawing.Point(212, 410);
            this.employAddOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.employAddOK.Name = "employAddOK";
            this.employAddOK.Size = new System.Drawing.Size(164, 72);
            this.employAddOK.Style = Sunny.UI.UIStyle.Custom;
            this.employAddOK.Symbol = 61508;
            this.employAddOK.SymbolSize = 36;
            this.employAddOK.TabIndex = 14;
            this.employAddOK.Text = "등록";
            this.employAddOK.Click += new System.EventHandler(this.employAddOK_Click);
            // 
            // employWork
            // 
            this.employWork.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employWork.FillColor = System.Drawing.Color.White;
            this.employWork.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.employWork.Location = new System.Drawing.Point(334, 330);
            this.employWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employWork.Maximum = 2147483647D;
            this.employWork.Minimum = -2147483648D;
            this.employWork.MinimumSize = new System.Drawing.Size(1, 1);
            this.employWork.Name = "employWork";
            this.employWork.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employWork.Size = new System.Drawing.Size(318, 35);
            this.employWork.Style = Sunny.UI.UIStyle.Custom;
            this.employWork.TabIndex = 21;
            this.employWork.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(157, 330);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel4.StyleCustomMode = true;
            this.uiSymbolLabel4.Symbol = 61667;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.SymbolSize = 30;
            this.uiSymbolLabel4.TabIndex = 20;
            this.uiSymbolLabel4.Text = "업  무";
            // 
            // employPosition
            // 
            this.employPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employPosition.FillColor = System.Drawing.Color.White;
            this.employPosition.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.employPosition.Location = new System.Drawing.Point(334, 285);
            this.employPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employPosition.Maximum = 2147483647D;
            this.employPosition.Minimum = -2147483648D;
            this.employPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.employPosition.Name = "employPosition";
            this.employPosition.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employPosition.Size = new System.Drawing.Size(318, 35);
            this.employPosition.Style = Sunny.UI.UIStyle.Custom;
            this.employPosition.TabIndex = 19;
            this.employPosition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(157, 285);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel3.Symbol = 62139;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.SymbolSize = 32;
            this.uiSymbolLabel3.TabIndex = 18;
            this.uiSymbolLabel3.Text = "직  급";
            // 
            // employName
            // 
            this.employName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employName.FillColor = System.Drawing.Color.White;
            this.employName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.employName.Location = new System.Drawing.Point(334, 115);
            this.employName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employName.Maximum = 2147483647D;
            this.employName.Minimum = -2147483648D;
            this.employName.MinimumSize = new System.Drawing.Size(1, 1);
            this.employName.Name = "employName";
            this.employName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employName.Size = new System.Drawing.Size(318, 35);
            this.employName.Style = Sunny.UI.UIStyle.Custom;
            this.employName.TabIndex = 17;
            this.employName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(157, 115);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel2.Symbol = 62141;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.SymbolSize = 32;
            this.uiSymbolLabel2.TabIndex = 16;
            this.uiSymbolLabel2.Text = "사원명";
            // 
            // employDepart
            // 
            this.employDepart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employDepart.FillColor = System.Drawing.Color.White;
            this.employDepart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.employDepart.Location = new System.Drawing.Point(334, 240);
            this.employDepart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employDepart.Maximum = 2147483647D;
            this.employDepart.Minimum = -2147483648D;
            this.employDepart.MinimumSize = new System.Drawing.Size(1, 1);
            this.employDepart.Name = "employDepart";
            this.employDepart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employDepart.Size = new System.Drawing.Size(318, 35);
            this.employDepart.Style = Sunny.UI.UIStyle.Custom;
            this.employDepart.TabIndex = 25;
            this.employDepart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(157, 240);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel1.Symbol = 62060;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 38;
            this.uiSymbolLabel1.TabIndex = 24;
            this.uiSymbolLabel1.Text = "부  서";
            // 
            // employTel
            // 
            this.employTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employTel.FillColor = System.Drawing.Color.White;
            this.employTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.employTel.Location = new System.Drawing.Point(334, 195);
            this.employTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employTel.Maximum = 2147483647D;
            this.employTel.Minimum = -2147483648D;
            this.employTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.employTel.Name = "employTel";
            this.employTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employTel.Size = new System.Drawing.Size(318, 35);
            this.employTel.Style = Sunny.UI.UIStyle.Custom;
            this.employTel.TabIndex = 23;
            this.employTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(157, 195);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel5.Symbol = 62112;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.SymbolSize = 32;
            this.uiSymbolLabel5.TabIndex = 22;
            this.uiSymbolLabel5.Text = "전  화";
            // 
            // employWoman
            // 
            this.employWoman.BackColor = System.Drawing.Color.Transparent;
            this.employWoman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employWoman.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.employWoman.Location = new System.Drawing.Point(502, 158);
            this.employWoman.MinimumSize = new System.Drawing.Size(1, 1);
            this.employWoman.Name = "employWoman";
            this.employWoman.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.employWoman.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employWoman.Size = new System.Drawing.Size(150, 29);
            this.employWoman.Style = Sunny.UI.UIStyle.Custom;
            this.employWoman.TabIndex = 28;
            this.employWoman.Text = "여";
            // 
            // employMan
            // 
            this.employMan.BackColor = System.Drawing.Color.Transparent;
            this.employMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employMan.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.employMan.Location = new System.Drawing.Point(334, 158);
            this.employMan.MinimumSize = new System.Drawing.Size(1, 1);
            this.employMan.Name = "employMan";
            this.employMan.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.employMan.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employMan.Size = new System.Drawing.Size(150, 29);
            this.employMan.Style = Sunny.UI.UIStyle.Custom;
            this.employMan.TabIndex = 27;
            this.employMan.Text = "남";
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel7.Location = new System.Drawing.Point(157, 156);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(131, 35);
            this.uiSymbolLabel7.Symbol = 57483;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel7.SymbolSize = 32;
            this.uiSymbolLabel7.TabIndex = 26;
            this.uiSymbolLabel7.Text = "성  별";
            // 
            // EmployAddUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.ControlBox = false;
            this.Controls.Add(this.employWoman);
            this.Controls.Add(this.employMan);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.employDepart);
            this.Controls.Add(this.employWork);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.employTel);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.employPosition);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.employName);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.employAddClose);
            this.Controls.Add(this.employAddOK);
            this.Controls.Add(this.employAdd);
            this.Name = "EmployAddUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.EmployAddUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton employAdd;
        private Sunny.UI.UISymbolButton employAddClose;
        private Sunny.UI.UISymbolButton employAddOK;
        private Sunny.UI.UITextBox employWork;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox employPosition;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox employName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox employDepart;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox employTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UIRadioButton employWoman;
        private Sunny.UI.UIRadioButton employMan;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
    }
}