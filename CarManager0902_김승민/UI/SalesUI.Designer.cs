
namespace CarManager0902
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
            this.custListView = new System.Windows.Forms.ListView();
            this.customerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerInsuDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerBrith = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.carListView = new System.Windows.Forms.ListView();
            this.carName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carColor1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carPrice1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carInsuDate1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manager1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectSearchComboBox = new Sunny.UI.UIComboBox();
            this.searchTextBox = new Sunny.UI.UITextBox();
            this.searchButton = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.searchUnion = new Sunny.UI.UISymbolButton();
            this.searchManager = new Sunny.UI.UITextBox();
            this.searchCust = new Sunny.UI.UITextBox();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.searchJupsu = new Sunny.UI.UITextBox();
            this.searchCar = new Sunny.UI.UITextBox();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
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
            this.carName.Width = 77;
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
            // custListView
            // 
            this.custListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerName,
            this.customerTel,
            this.customerAddr,
            this.customerInsuDate,
            this.customerBrith,
            this.customerGender});
            this.custListView.HideSelection = false;
            this.custListView.Location = new System.Drawing.Point(3, 437);
            this.custListView.Name = "custListView";
            this.custListView.Size = new System.Drawing.Size(860, 79);
            this.custListView.TabIndex = 6;
            this.custListView.UseCompatibleStateImageBehavior = false;
            this.custListView.View = System.Windows.Forms.View.Details;
            // 
            // customerName
            // 
            this.customerName.Text = "고객명";
            this.customerName.Width = 104;
            // 
            // customerTel
            // 
            this.customerTel.Text = "연락처";
            this.customerTel.Width = 148;
            // 
            // customerAddr
            // 
            this.customerAddr.Text = "주소";
            this.customerAddr.Width = 179;
            // 
            // customerInsuDate
            // 
            this.customerInsuDate.Text = "접수날짜";
            this.customerInsuDate.Width = 171;
            // 
            // customerBrith
            // 
            this.customerBrith.Text = "생일";
            this.customerBrith.Width = 181;
            // 
            // customerGender
            // 
            this.customerGender.Text = "성별";
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
            this.uiSymbolLabel2.Location = new System.Drawing.Point(3, 396);
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
            this.uiSymbolLabel3.Location = new System.Drawing.Point(3, 552);
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
            // carListView
            // 
            this.carListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.carName1,
            this.carColor1,
            this.carPrice1,
            this.carInsuDate1,
            this.manager1});
            this.carListView.HideSelection = false;
            this.carListView.Location = new System.Drawing.Point(3, 593);
            this.carListView.Name = "carListView";
            this.carListView.Size = new System.Drawing.Size(860, 79);
            this.carListView.TabIndex = 62;
            this.carListView.UseCompatibleStateImageBehavior = false;
            this.carListView.View = System.Windows.Forms.View.Details;
            // 
            // carName1
            // 
            this.carName1.Text = "차량명";
            this.carName1.Width = 108;
            // 
            // carColor1
            // 
            this.carColor1.Text = "색상";
            this.carColor1.Width = 103;
            // 
            // carPrice1
            // 
            this.carPrice1.Text = "가격";
            this.carPrice1.Width = 115;
            // 
            // carInsuDate1
            // 
            this.carInsuDate1.Text = "인수날짜";
            this.carInsuDate1.Width = 136;
            // 
            // manager1
            // 
            this.manager1.Text = "담당자";
            this.manager1.Width = 133;
            // 
            // selectSearchComboBox
            // 
            this.selectSearchComboBox.DataSource = null;
            this.selectSearchComboBox.FillColor = System.Drawing.Color.White;
            this.selectSearchComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.selectSearchComboBox.Items.AddRange(new object[] {
            "차종",
            "고객명"});
            this.selectSearchComboBox.Location = new System.Drawing.Point(182, 18);
            this.selectSearchComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectSearchComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.selectSearchComboBox.Name = "selectSearchComboBox";
            this.selectSearchComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.selectSearchComboBox.Size = new System.Drawing.Size(175, 35);
            this.selectSearchComboBox.TabIndex = 64;
            this.selectSearchComboBox.Text = "선택하세요";
            this.selectSearchComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.FillColor = System.Drawing.Color.White;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchTextBox.Location = new System.Drawing.Point(365, 18);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Maximum = 2147483647D;
            this.searchTextBox.Minimum = -2147483648D;
            this.searchTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(175, 35);
            this.searchTextBox.TabIndex = 65;
            this.searchTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchButton.Location = new System.Drawing.Point(547, 18);
            this.searchButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 35);
            this.searchButton.Symbol = 61442;
            this.searchButton.TabIndex = 66;
            this.searchButton.Text = "검색";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(738, 18);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(125, 35);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 61692;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.SymbolSize = 40;
            this.uiSymbolLabel4.TabIndex = 67;
            this.uiSymbolLabel4.Text = "고객 취미";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchUnion
            // 
            this.searchUnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchUnion.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchUnion.Location = new System.Drawing.Point(729, 314);
            this.searchUnion.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchUnion.Name = "searchUnion";
            this.searchUnion.Size = new System.Drawing.Size(120, 76);
            this.searchUnion.Symbol = 61442;
            this.searchUnion.TabIndex = 94;
            this.searchUnion.Text = "통합검색";
            this.searchUnion.Click += new System.EventHandler(this.searchUnion_Click);
            // 
            // searchManager
            // 
            this.searchManager.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchManager.FillColor = System.Drawing.Color.White;
            this.searchManager.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchManager.Location = new System.Drawing.Point(547, 355);
            this.searchManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchManager.Maximum = 2147483647D;
            this.searchManager.Minimum = -2147483648D;
            this.searchManager.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchManager.Name = "searchManager";
            this.searchManager.Size = new System.Drawing.Size(175, 35);
            this.searchManager.TabIndex = 91;
            this.searchManager.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchCust
            // 
            this.searchCust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCust.FillColor = System.Drawing.Color.White;
            this.searchCust.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchCust.Location = new System.Drawing.Point(547, 316);
            this.searchCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchCust.Maximum = 2147483647D;
            this.searchCust.Minimum = -2147483648D;
            this.searchCust.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchCust.Name = "searchCust";
            this.searchCust.Size = new System.Drawing.Size(175, 33);
            this.searchCust.TabIndex = 90;
            this.searchCust.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel7.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel7.Location = new System.Drawing.Point(368, 355);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(172, 35);
            this.uiSymbolLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel7.Symbol = 61508;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel7.SymbolSize = 40;
            this.uiSymbolLabel7.TabIndex = 93;
            this.uiSymbolLabel7.Text = "담당자";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel8.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel8.Location = new System.Drawing.Point(368, 314);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(172, 35);
            this.uiSymbolLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel8.Symbol = 61508;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel8.SymbolSize = 40;
            this.uiSymbolLabel8.TabIndex = 92;
            this.uiSymbolLabel8.Text = "고객명";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchJupsu
            // 
            this.searchJupsu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchJupsu.FillColor = System.Drawing.Color.White;
            this.searchJupsu.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchJupsu.Location = new System.Drawing.Point(182, 355);
            this.searchJupsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchJupsu.Maximum = 2147483647D;
            this.searchJupsu.Minimum = -2147483648D;
            this.searchJupsu.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchJupsu.Name = "searchJupsu";
            this.searchJupsu.Size = new System.Drawing.Size(175, 35);
            this.searchJupsu.TabIndex = 87;
            this.searchJupsu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchCar
            // 
            this.searchCar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchCar.FillColor = System.Drawing.Color.White;
            this.searchCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchCar.Location = new System.Drawing.Point(182, 316);
            this.searchCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchCar.Maximum = 2147483647D;
            this.searchCar.Minimum = -2147483648D;
            this.searchCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchCar.Name = "searchCar";
            this.searchCar.Size = new System.Drawing.Size(175, 33);
            this.searchCar.TabIndex = 86;
            this.searchCar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel6.Location = new System.Drawing.Point(3, 355);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(172, 35);
            this.uiSymbolLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel6.Symbol = 61508;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel6.SymbolSize = 40;
            this.uiSymbolLabel6.TabIndex = 89;
            this.uiSymbolLabel6.Text = "접수날짜";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(3, 314);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(172, 35);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.Symbol = 61508;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.SymbolSize = 40;
            this.uiSymbolLabel5.TabIndex = 88;
            this.uiSymbolLabel5.Text = "차량이름";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.searchUnion);
            this.Controls.Add(this.searchManager);
            this.Controls.Add(this.searchCust);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.searchJupsu);
            this.Controls.Add(this.searchCar);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.selectSearchComboBox);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.carListView);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.custListView);
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
        private System.Windows.Forms.ListView custListView;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private System.Windows.Forms.ListView carListView;
        private Sunny.UI.UIComboBox selectSearchComboBox;
        private Sunny.UI.UITextBox searchTextBox;
        private Sunny.UI.UISymbolButton searchButton;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader customerTel;
        private System.Windows.Forms.ColumnHeader customerAddr;
        private System.Windows.Forms.ColumnHeader customerInsuDate;
        private System.Windows.Forms.ColumnHeader customerBrith;
        private System.Windows.Forms.ColumnHeader customerGender;
        private System.Windows.Forms.ColumnHeader carName1;
        private System.Windows.Forms.ColumnHeader carColor1;
        private System.Windows.Forms.ColumnHeader carPrice1;
        private System.Windows.Forms.ColumnHeader carInsuDate1;
        private System.Windows.Forms.ColumnHeader manager1;
        private Sunny.UI.UISymbolButton searchUnion;
        private Sunny.UI.UITextBox searchManager;
        private Sunny.UI.UITextBox searchCust;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UITextBox searchJupsu;
        private Sunny.UI.UITextBox searchCar;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
    }
}
