
namespace MESDesign.UI
{
    partial class MaterialManagementUI
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
            this.materialListView = new System.Windows.Forms.ListView();
            this.materialCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialreceiving = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marerialAddClose = new Sunny.UI.UISymbolButton();
            this.materialAdd = new Sunny.UI.UISymbolButton();
            this.materialManag = new Sunny.UI.UISymbolButton();
            this.matterialPlus = new Sunny.UI.UISymbolButton();
            this.materialSub = new Sunny.UI.UISymbolButton();
            this.materialShipping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // materialListView
            // 
            this.materialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.materialCode,
            this.materialName,
            this.materialPrice,
            this.materialreceiving,
            this.materialShipping,
            this.materialInventory,
            this.materialTime});
            this.materialListView.HideSelection = false;
            this.materialListView.Location = new System.Drawing.Point(12, 83);
            this.materialListView.Name = "materialListView";
            this.materialListView.Size = new System.Drawing.Size(947, 446);
            this.materialListView.TabIndex = 20;
            this.materialListView.UseCompatibleStateImageBehavior = false;
            this.materialListView.View = System.Windows.Forms.View.Details;
            // 
            // materialCode
            // 
            this.materialCode.Text = "코드";
            this.materialCode.Width = 117;
            // 
            // materialName
            // 
            this.materialName.Text = "제품명";
            this.materialName.Width = 101;
            // 
            // materialPrice
            // 
            this.materialPrice.Text = "가격";
            this.materialPrice.Width = 85;
            // 
            // materialreceiving
            // 
            this.materialreceiving.Text = "입고수량";
            this.materialreceiving.Width = 141;
            // 
            // materialInventory
            // 
            this.materialInventory.Text = "재고수량";
            this.materialInventory.Width = 139;
            // 
            // materialTime
            // 
            this.materialTime.Text = "자재입출고시간";
            this.materialTime.Width = 201;
            // 
            // marerialAddClose
            // 
            this.marerialAddClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marerialAddClose.FillColor = System.Drawing.Color.Tomato;
            this.marerialAddClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marerialAddClose.Location = new System.Drawing.Point(769, 574);
            this.marerialAddClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.marerialAddClose.Name = "marerialAddClose";
            this.marerialAddClose.Size = new System.Drawing.Size(164, 72);
            this.marerialAddClose.Style = Sunny.UI.UIStyle.Custom;
            this.marerialAddClose.Symbol = 61453;
            this.marerialAddClose.SymbolSize = 36;
            this.marerialAddClose.TabIndex = 19;
            this.marerialAddClose.Text = "닫기";
            this.marerialAddClose.Click += new System.EventHandler(this.materialAddClose_Click);
            // 
            // materialAdd
            // 
            this.materialAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialAdd.FillColor = System.Drawing.Color.DarkGreen;
            this.materialAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialAdd.Location = new System.Drawing.Point(278, 574);
            this.materialAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialAdd.Name = "materialAdd";
            this.materialAdd.Size = new System.Drawing.Size(164, 72);
            this.materialAdd.Style = Sunny.UI.UIStyle.Custom;
            this.materialAdd.Symbol = 57466;
            this.materialAdd.SymbolSize = 36;
            this.materialAdd.TabIndex = 18;
            this.materialAdd.Text = "입 고";
            this.materialAdd.Click += new System.EventHandler(this.materialAdd_Click);
            // 
            // materialManag
            // 
            this.materialManag.BackColor = System.Drawing.Color.Transparent;
            this.materialManag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialManag.FillColor = System.Drawing.Color.Transparent;
            this.materialManag.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.materialManag.Location = new System.Drawing.Point(287, 12);
            this.materialManag.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialManag.Name = "materialManag";
            this.materialManag.RectColor = System.Drawing.Color.Transparent;
            this.materialManag.RectDisableColor = System.Drawing.Color.Transparent;
            this.materialManag.RectHoverColor = System.Drawing.Color.Transparent;
            this.materialManag.RectPressColor = System.Drawing.Color.Transparent;
            this.materialManag.RectSelectedColor = System.Drawing.Color.Transparent;
            this.materialManag.Size = new System.Drawing.Size(381, 44);
            this.materialManag.Style = Sunny.UI.UIStyle.Custom;
            this.materialManag.Symbol = 61875;
            this.materialManag.SymbolSize = 50;
            this.materialManag.TabIndex = 17;
            this.materialManag.Text = "자재 관리";
            // 
            // matterialPlus
            // 
            this.matterialPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matterialPlus.FillColor = System.Drawing.Color.DarkGreen;
            this.matterialPlus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matterialPlus.Location = new System.Drawing.Point(26, 574);
            this.matterialPlus.MinimumSize = new System.Drawing.Size(1, 1);
            this.matterialPlus.Name = "matterialPlus";
            this.matterialPlus.Size = new System.Drawing.Size(164, 72);
            this.matterialPlus.Style = Sunny.UI.UIStyle.Custom;
            this.matterialPlus.Symbol = 57466;
            this.matterialPlus.SymbolSize = 36;
            this.matterialPlus.TabIndex = 21;
            this.matterialPlus.Text = "자재추가";
            this.matterialPlus.Click += new System.EventHandler(this.matterialPlus_Click);
            // 
            // materialSub
            // 
            this.materialSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialSub.FillColor = System.Drawing.Color.DarkGreen;
            this.materialSub.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSub.Location = new System.Drawing.Point(527, 574);
            this.materialSub.MinimumSize = new System.Drawing.Size(1, 1);
            this.materialSub.Name = "materialSub";
            this.materialSub.Size = new System.Drawing.Size(164, 72);
            this.materialSub.Style = Sunny.UI.UIStyle.Custom;
            this.materialSub.Symbol = 57466;
            this.materialSub.SymbolSize = 36;
            this.materialSub.TabIndex = 22;
            this.materialSub.Text = "출 고";
            this.materialSub.Click += new System.EventHandler(this.materialSub_Click);
            // 
            // materialShipping
            // 
            this.materialShipping.Text = "출고수량";
            this.materialShipping.Width = 147;
            // 
            // MaterialManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 680);
            this.ControlBox = false;
            this.Controls.Add(this.materialSub);
            this.Controls.Add(this.matterialPlus);
            this.Controls.Add(this.materialListView);
            this.Controls.Add(this.marerialAddClose);
            this.Controls.Add(this.materialAdd);
            this.Controls.Add(this.materialManag);
            this.Name = "MaterialManagementUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Activated += new System.EventHandler(this.MaterialManagementUI_Activated);
            this.Load += new System.EventHandler(this.MaterialManagementUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView materialListView;
        private System.Windows.Forms.ColumnHeader materialCode;
        private System.Windows.Forms.ColumnHeader materialName;
        private System.Windows.Forms.ColumnHeader materialPrice;
        private System.Windows.Forms.ColumnHeader materialInventory;
        private System.Windows.Forms.ColumnHeader materialreceiving;
        private Sunny.UI.UISymbolButton marerialAddClose;
        private Sunny.UI.UISymbolButton materialAdd;
        private Sunny.UI.UISymbolButton materialManag;
        private Sunny.UI.UISymbolButton matterialPlus;
        private System.Windows.Forms.ColumnHeader materialTime;
        private Sunny.UI.UISymbolButton materialSub;
        private System.Windows.Forms.ColumnHeader materialShipping;
    }
}