
namespace CarManager0811.UI
{
    partial class OrderUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddc3 = new Sunny.UI.UIRadioButton();
            this.ddc2 = new Sunny.UI.UIRadioButton();
            this.ddc1 = new Sunny.UI.UIRadioButton();
            this.ddcNum = new System.Windows.Forms.NumericUpDown();
            this.hpNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hp4 = new Sunny.UI.UIRadioButton();
            this.hp3 = new Sunny.UI.UIRadioButton();
            this.hp2 = new Sunny.UI.UIRadioButton();
            this.hp1 = new Sunny.UI.UIRadioButton();
            this.dmfNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dmd = new Sunny.UI.UICheckBox();
            this.p_dmf = new Sunny.UI.UICheckBox();
            this.c_dmf = new Sunny.UI.UICheckBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.detailOrder = new Sunny.UI.UIListBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.oderDel = new Sunny.UI.UIButton();
            this.btnOrder = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddcNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmfNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddc3);
            this.groupBox1.Controls.Add(this.ddc2);
            this.groupBox1.Controls.Add(this.ddc1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox1.Location = new System.Drawing.Point(32, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dry Double Cluthch(DDC)";
            // 
            // ddc3
            // 
            this.ddc3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddc3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.ddc3.Location = new System.Drawing.Point(417, 48);
            this.ddc3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ddc3.Name = "ddc3";
            this.ddc3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ddc3.Size = new System.Drawing.Size(219, 29);
            this.ddc3.TabIndex = 5;
            this.ddc3.Text = "External Damper(120,000원)";
            // 
            // ddc2
            // 
            this.ddc2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddc2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.ddc2.Location = new System.Drawing.Point(192, 48);
            this.ddc2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ddc2.Name = "ddc2";
            this.ddc2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ddc2.Size = new System.Drawing.Size(219, 29);
            this.ddc2.TabIndex = 4;
            this.ddc2.Text = "클러치 엑츄에이터(110,000원)";
            // 
            // ddc1
            // 
            this.ddc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddc1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.ddc1.Location = new System.Drawing.Point(6, 48);
            this.ddc1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ddc1.Name = "ddc1";
            this.ddc1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ddc1.Size = new System.Drawing.Size(180, 29);
            this.ddc1.TabIndex = 3;
            this.ddc1.Text = "더블 클러치(100,000원)";
            // 
            // ddcNum
            // 
            this.ddcNum.Font = new System.Drawing.Font("굴림", 15F);
            this.ddcNum.Location = new System.Drawing.Point(749, 142);
            this.ddcNum.Name = "ddcNum";
            this.ddcNum.Size = new System.Drawing.Size(85, 30);
            this.ddcNum.TabIndex = 1;
            // 
            // hpNum
            // 
            this.hpNum.Font = new System.Drawing.Font("굴림", 15F);
            this.hpNum.Location = new System.Drawing.Point(749, 271);
            this.hpNum.Name = "hpNum";
            this.hpNum.Size = new System.Drawing.Size(85, 30);
            this.hpNum.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hp4);
            this.groupBox2.Controls.Add(this.hp3);
            this.groupBox2.Controls.Add(this.hp2);
            this.groupBox2.Controls.Add(this.hp1);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox2.Location = new System.Drawing.Point(32, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hydraulic Products";
            // 
            // hp4
            // 
            this.hp4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp4.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.hp4.Location = new System.Drawing.Point(455, 50);
            this.hp4.MinimumSize = new System.Drawing.Size(1, 1);
            this.hp4.Name = "hp4";
            this.hp4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.hp4.Size = new System.Drawing.Size(124, 29);
            this.hp4.TabIndex = 9;
            this.hp4.Text = "CRC(90,000원)";
            // 
            // hp3
            // 
            this.hp3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.hp3.Location = new System.Drawing.Point(304, 50);
            this.hp3.MinimumSize = new System.Drawing.Size(1, 1);
            this.hp3.Name = "hp3";
            this.hp3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.hp3.Size = new System.Drawing.Size(124, 29);
            this.hp3.TabIndex = 8;
            this.hp3.Text = "CMC(80,000원)";
            // 
            // hp2
            // 
            this.hp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.hp2.Location = new System.Drawing.Point(136, 50);
            this.hp2.MinimumSize = new System.Drawing.Size(1, 1);
            this.hp2.Name = "hp2";
            this.hp2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.hp2.Size = new System.Drawing.Size(162, 29);
            this.hp2.TabIndex = 7;
            this.hp2.Text = "DAMPER(70,000원)";
            // 
            // hp1
            // 
            this.hp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.hp1.Location = new System.Drawing.Point(6, 50);
            this.hp1.MinimumSize = new System.Drawing.Size(1, 1);
            this.hp1.Name = "hp1";
            this.hp1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.hp1.Size = new System.Drawing.Size(124, 29);
            this.hp1.TabIndex = 6;
            this.hp1.Text = "CSC(60,000원)";
            // 
            // dmfNum
            // 
            this.dmfNum.Font = new System.Drawing.Font("굴림", 15F);
            this.dmfNum.Location = new System.Drawing.Point(749, 393);
            this.dmfNum.Name = "dmfNum";
            this.dmfNum.Size = new System.Drawing.Size(85, 30);
            this.dmfNum.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dmd);
            this.groupBox3.Controls.Add(this.p_dmf);
            this.groupBox3.Controls.Add(this.c_dmf);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox3.Location = new System.Drawing.Point(32, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 168);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DMF 시스템";
            // 
            // dmd
            // 
            this.dmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmd.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.dmd.Location = new System.Drawing.Point(6, 99);
            this.dmd.MinimumSize = new System.Drawing.Size(1, 1);
            this.dmd.Name = "dmd";
            this.dmd.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.dmd.Size = new System.Drawing.Size(219, 29);
            this.dmd.TabIndex = 2;
            this.dmd.Text = "Dual Mass Damper(70,000원)";
            // 
            // p_dmf
            // 
            this.p_dmf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_dmf.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.p_dmf.Location = new System.Drawing.Point(6, 64);
            this.p_dmf.MinimumSize = new System.Drawing.Size(1, 1);
            this.p_dmf.Name = "p_dmf";
            this.p_dmf.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.p_dmf.Size = new System.Drawing.Size(219, 29);
            this.p_dmf.TabIndex = 1;
            this.p_dmf.Text = "Pendulum DMF(60,000원)";
            // 
            // c_dmf
            // 
            this.c_dmf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c_dmf.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.c_dmf.Location = new System.Drawing.Point(6, 29);
            this.c_dmf.MinimumSize = new System.Drawing.Size(1, 1);
            this.c_dmf.Name = "c_dmf";
            this.c_dmf.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.c_dmf.Size = new System.Drawing.Size(180, 29);
            this.c_dmf.TabIndex = 0;
            this.c_dmf.Text = "C-DMF(50,000원)";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 25F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(207, 16);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(449, 61);
            this.uiSymbolLabel1.Symbol = 61687;
            this.uiSymbolLabel1.SymbolSize = 30;
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "평화발레오 제품 발주";
            // 
            // detailOrder
            // 
            this.detailOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.detailOrder.FormatString = "";
            this.detailOrder.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.detailOrder.Location = new System.Drawing.Point(32, 581);
            this.detailOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.detailOrder.Name = "detailOrder";
            this.detailOrder.Padding = new System.Windows.Forms.Padding(2);
            this.detailOrder.Size = new System.Drawing.Size(690, 160);
            this.detailOrder.TabIndex = 7;
            this.detailOrder.Text = "uiListBox1";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(32, 512);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(449, 61);
            this.uiSymbolLabel2.Symbol = 61462;
            this.uiSymbolLabel2.SymbolSize = 30;
            this.uiSymbolLabel2.TabIndex = 8;
            this.uiSymbolLabel2.Text = "주문 상세 내역";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oderDel
            // 
            this.oderDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oderDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.oderDel.Location = new System.Drawing.Point(729, 638);
            this.oderDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.oderDel.Name = "oderDel";
            this.oderDel.Size = new System.Drawing.Size(131, 46);
            this.oderDel.TabIndex = 10;
            this.oderDel.Text = "내역 삭제";
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnOrder.Location = new System.Drawing.Point(729, 581);
            this.btnOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(131, 46);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCancel.Location = new System.Drawing.Point(729, 695);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 46);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "닫 기";
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.oderDel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.detailOrder);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.dmfNum);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.hpNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ddcNum);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderUI";
            this.Size = new System.Drawing.Size(886, 768);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddcNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dmfNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ddcNum;
        private System.Windows.Forms.NumericUpDown hpNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown dmfNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunny.UI.UICheckBox dmd;
        private Sunny.UI.UICheckBox p_dmf;
        private Sunny.UI.UICheckBox c_dmf;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIListBox detailOrder;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIButton oderDel;
        private Sunny.UI.UIButton btnOrder;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIRadioButton ddc3;
        private Sunny.UI.UIRadioButton ddc2;
        private Sunny.UI.UIRadioButton ddc1;
        private Sunny.UI.UIRadioButton hp4;
        private Sunny.UI.UIRadioButton hp3;
        private Sunny.UI.UIRadioButton hp2;
        private Sunny.UI.UIRadioButton hp1;
    }
}
