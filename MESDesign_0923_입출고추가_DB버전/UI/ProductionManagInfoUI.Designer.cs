
namespace MESDesign.UI
{
    partial class ProductionManagInfoUI
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
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.productionFinished = new Sunny.UI.UISymbolLabel();
            this.productiondeFective = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.prodManagInfoClose = new Sunny.UI.UISymbolButton();
            this.productionEnvInfo = new Sunny.UI.UISymbolButton();
            this.lineProdListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productionTime = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(29, 165);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(205, 54);
            this.uiSymbolLabel2.TabIndex = 1;
            this.uiSymbolLabel2.Text = "부품타입";
            // 
            // productionFinished
            // 
            this.productionFinished.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.productionFinished.Location = new System.Drawing.Point(29, 250);
            this.productionFinished.MinimumSize = new System.Drawing.Size(1, 1);
            this.productionFinished.Name = "productionFinished";
            this.productionFinished.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.productionFinished.Size = new System.Drawing.Size(205, 54);
            this.productionFinished.TabIndex = 2;
            this.productionFinished.Text = "양품수량";
            // 
            // productiondeFective
            // 
            this.productiondeFective.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.productiondeFective.Location = new System.Drawing.Point(29, 336);
            this.productiondeFective.MinimumSize = new System.Drawing.Size(1, 1);
            this.productiondeFective.Name = "productiondeFective";
            this.productiondeFective.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.productiondeFective.Size = new System.Drawing.Size(205, 54);
            this.productiondeFective.TabIndex = 3;
            this.productiondeFective.Text = "불량품 수량";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(29, 419);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(205, 54);
            this.uiSymbolLabel5.TabIndex = 4;
            this.uiSymbolLabel5.Text = "불량발생기계";
            // 
            // prodManagInfoClose
            // 
            this.prodManagInfoClose.BackColor = System.Drawing.Color.Transparent;
            this.prodManagInfoClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prodManagInfoClose.FillColor = System.Drawing.Color.Transparent;
            this.prodManagInfoClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.prodManagInfoClose.Location = new System.Drawing.Point(803, 12);
            this.prodManagInfoClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.prodManagInfoClose.Name = "prodManagInfoClose";
            this.prodManagInfoClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prodManagInfoClose.RectPressColor = System.Drawing.Color.Red;
            this.prodManagInfoClose.Size = new System.Drawing.Size(74, 50);
            this.prodManagInfoClose.Style = Sunny.UI.UIStyle.Custom;
            this.prodManagInfoClose.Symbol = 61453;
            this.prodManagInfoClose.SymbolSize = 32;
            this.prodManagInfoClose.TabIndex = 11;
            this.prodManagInfoClose.Click += new System.EventHandler(this.prodManagInfoClose_Click_1);
            // 
            // productionEnvInfo
            // 
            this.productionEnvInfo.BackColor = System.Drawing.Color.Transparent;
            this.productionEnvInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productionEnvInfo.FillColor = System.Drawing.Color.Transparent;
            this.productionEnvInfo.FillDisableColor = System.Drawing.Color.Transparent;
            this.productionEnvInfo.FillHoverColor = System.Drawing.Color.Transparent;
            this.productionEnvInfo.FillPressColor = System.Drawing.Color.Transparent;
            this.productionEnvInfo.FillSelectedColor = System.Drawing.Color.Transparent;
            this.productionEnvInfo.Font = new System.Drawing.Font("Microsoft YaHei", 25F);
            this.productionEnvInfo.ForeHoverColor = System.Drawing.Color.Black;
            this.productionEnvInfo.Location = new System.Drawing.Point(12, 12);
            this.productionEnvInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.productionEnvInfo.Name = "productionEnvInfo";
            this.productionEnvInfo.RectColor = System.Drawing.Color.Transparent;
            this.productionEnvInfo.Size = new System.Drawing.Size(315, 50);
            this.productionEnvInfo.Style = Sunny.UI.UIStyle.Custom;
            this.productionEnvInfo.Symbol = 61573;
            this.productionEnvInfo.SymbolSize = 50;
            this.productionEnvInfo.TabIndex = 16;
            this.productionEnvInfo.Text = "생산 관리 정보";
            // 
            // lineProdListView
            // 
            this.lineProdListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lineProdListView.HideSelection = false;
            this.lineProdListView.Location = new System.Drawing.Point(240, 83);
            this.lineProdListView.Name = "lineProdListView";
            this.lineProdListView.Size = new System.Drawing.Size(617, 470);
            this.lineProdListView.TabIndex = 17;
            this.lineProdListView.UseCompatibleStateImageBehavior = false;
            this.lineProdListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "작업 시간";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "부품 타입";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "양품 수량";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "불량품 수량";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "불량발생기계";
            this.columnHeader5.Width = 171;
            // 
            // productionTime
            // 
            this.productionTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.productionTime.Location = new System.Drawing.Point(29, 83);
            this.productionTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.productionTime.Name = "productionTime";
            this.productionTime.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.productionTime.Size = new System.Drawing.Size(205, 54);
            this.productionTime.TabIndex = 18;
            this.productionTime.Text = "작업시간";
            // 
            // ProductionManagInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 565);
            this.ControlBox = false;
            this.Controls.Add(this.productionTime);
            this.Controls.Add(this.lineProdListView);
            this.Controls.Add(this.productionEnvInfo);
            this.Controls.Add(this.prodManagInfoClose);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.productiondeFective);
            this.Controls.Add(this.productionFinished);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Name = "ProductionManagInfoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ProductionManagInfoUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel productionFinished;
        private Sunny.UI.UISymbolLabel productiondeFective;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolButton prodManagInfoClose;
        private Sunny.UI.UISymbolButton productionEnvInfo;
        private System.Windows.Forms.ListView lineProdListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Sunny.UI.UISymbolLabel productionTime;
    }
}