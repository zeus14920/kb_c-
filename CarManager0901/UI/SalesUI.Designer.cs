
namespace CarManager0827
{
    partial class SalesUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salesListView = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insuDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jupsuDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custGridView = new Sunny.UI.UIDataGridView();
            this.hbNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custHobby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.custGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesListView
            // 
            this.salesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.carName,
            this.carPrice,
            this.insuDate,
            this.custName,
            this.custTel,
            this.jupsuDate,
            this.manager});
            this.salesListView.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.salesListView.FullRowSelect = true;
            this.salesListView.HideSelection = false;
            this.salesListView.Location = new System.Drawing.Point(3, 59);
            this.salesListView.Name = "salesListView";
            this.salesListView.Size = new System.Drawing.Size(664, 249);
            this.salesListView.TabIndex = 4;
            this.salesListView.UseCompatibleStateImageBehavior = false;
            this.salesListView.View = System.Windows.Forms.View.Details;
            this.salesListView.SelectedIndexChanged += new System.EventHandler(this.salesListView_SelectedIndexChanged);
            // 
            // number
            // 
            this.number.Text = "번호";
            this.number.Width = 49;
            // 
            // carName
            // 
            this.carName.Text = "차량명";
            // 
            // carPrice
            // 
            this.carPrice.Text = "가격";
            this.carPrice.Width = 73;
            // 
            // insuDate
            // 
            this.insuDate.Text = "인수날짜";
            this.insuDate.Width = 103;
            // 
            // custName
            // 
            this.custName.Text = "고객명";
            this.custName.Width = 81;
            // 
            // custTel
            // 
            this.custTel.Text = "연락처";
            this.custTel.Width = 100;
            // 
            // jupsuDate
            // 
            this.jupsuDate.Text = "접수날짜";
            this.jupsuDate.Width = 100;
            // 
            // manager
            // 
            this.manager.Text = "담당자";
            // 
            // custGridView
            // 
            this.custGridView.AllowUserToAddRows = false;
            this.custGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.custGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.custGridView.BackgroundColor = System.Drawing.Color.White;
            this.custGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.custGridView.ColumnHeadersHeight = 32;
            this.custGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.custGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hbNum,
            this.custHobby});
            this.custGridView.EnableHeadersVisualStyles = false;
            this.custGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.custGridView.Location = new System.Drawing.Point(673, 59);
            this.custGridView.Name = "custGridView";
            this.custGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.custGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.custGridView.RowTemplate.Height = 23;
            this.custGridView.SelectedIndex = -1;
            this.custGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custGridView.ShowGridLine = true;
            this.custGridView.Size = new System.Drawing.Size(190, 249);
            this.custGridView.TabIndex = 5;
            // 
            // hbNum
            // 
            this.hbNum.HeaderText = "번 호";
            this.hbNum.Name = "hbNum";
            this.hbNum.ReadOnly = true;
            this.hbNum.Width = 60;
            // 
            // custHobby
            // 
            this.custHobby.HeaderText = "취 미";
            this.custHobby.Name = "custHobby";
            this.custHobby.ReadOnly = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 380);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(860, 79);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(3, 18);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(172, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61508;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 60;
            this.uiSymbolLabel1.Text = "접수 현황";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(3, 339);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(172, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 62139;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.SymbolSize = 40;
            this.uiSymbolLabel2.TabIndex = 61;
            this.uiSymbolLabel2.Text = "고객 상세 정보";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(3, 495);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(172, 35);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61881;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.SymbolSize = 40;
            this.uiSymbolLabel3.TabIndex = 63;
            this.uiSymbolLabel3.Text = "차량 상세 정보";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 536);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(860, 79);
            this.listView2.TabIndex = 62;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // SalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.salesListView);
            this.Controls.Add(this.custGridView);
            this.DoubleBuffered = true;
            this.Name = "SalesUI";
            this.Size = new System.Drawing.Size(886, 683);
            this.Load += new System.EventHandler(this.SalesUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView salesListView;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader carName;
        private System.Windows.Forms.ColumnHeader carPrice;
        private System.Windows.Forms.ColumnHeader insuDate;
        private System.Windows.Forms.ColumnHeader custName;
        private System.Windows.Forms.ColumnHeader custTel;
        private System.Windows.Forms.ColumnHeader jupsuDate;
        private Sunny.UI.UIDataGridView custGridView;
        private System.Windows.Forms.ColumnHeader manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn hbNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn custHobby;
        private System.Windows.Forms.ListView listView1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private System.Windows.Forms.ListView listView2;
    }
}
