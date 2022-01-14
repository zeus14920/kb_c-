
namespace MESDesign_code.UI
{
    partial class EmployeeManagementUI
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
            this.employManag = new Sunny.UI.UISymbolButton();
            this.custAddClose = new Sunny.UI.UISymbolButton();
            this.employAdd = new Sunny.UI.UISymbolButton();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.employNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // employManag
            // 
            this.employManag.BackColor = System.Drawing.Color.Transparent;
            this.employManag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employManag.FillColor = System.Drawing.Color.Transparent;
            this.employManag.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.employManag.Location = new System.Drawing.Point(161, 12);
            this.employManag.MinimumSize = new System.Drawing.Size(1, 1);
            this.employManag.Name = "employManag";
            this.employManag.RectColor = System.Drawing.Color.Transparent;
            this.employManag.RectDisableColor = System.Drawing.Color.Transparent;
            this.employManag.RectHoverColor = System.Drawing.Color.Transparent;
            this.employManag.RectPressColor = System.Drawing.Color.Transparent;
            this.employManag.RectSelectedColor = System.Drawing.Color.Transparent;
            this.employManag.Size = new System.Drawing.Size(447, 44);
            this.employManag.Style = Sunny.UI.UIStyle.Custom;
            this.employManag.Symbol = 62144;
            this.employManag.SymbolSize = 40;
            this.employManag.TabIndex = 12;
            this.employManag.Text = "사원 관리";
            // 
            // custAddClose
            // 
            this.custAddClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custAddClose.FillColor = System.Drawing.Color.Tomato;
            this.custAddClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddClose.Location = new System.Drawing.Point(431, 481);
            this.custAddClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddClose.Name = "custAddClose";
            this.custAddClose.Size = new System.Drawing.Size(164, 72);
            this.custAddClose.Style = Sunny.UI.UIStyle.Custom;
            this.custAddClose.Symbol = 61453;
            this.custAddClose.SymbolSize = 36;
            this.custAddClose.TabIndex = 14;
            this.custAddClose.Text = "닫기";
            this.custAddClose.Click += new System.EventHandler(this.custAddClose_Click);
            // 
            // employAdd
            // 
            this.employAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employAdd.FillColor = System.Drawing.Color.DarkGreen;
            this.employAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employAdd.Location = new System.Drawing.Point(198, 481);
            this.employAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.employAdd.Name = "employAdd";
            this.employAdd.Size = new System.Drawing.Size(164, 72);
            this.employAdd.Style = Sunny.UI.UIStyle.Custom;
            this.employAdd.Symbol = 62004;
            this.employAdd.SymbolSize = 36;
            this.employAdd.TabIndex = 13;
            this.employAdd.Text = "추 가";
            this.employAdd.Click += new System.EventHandler(this.employAdd_Click);
            // 
            // employeeListView
            // 
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employNum,
            this.employName,
            this.employGender,
            this.employTel,
            this.employDepart,
            this.employPosition,
            this.employWork});
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(49, 81);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(700, 368);
            this.employeeListView.TabIndex = 16;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            // 
            // employNum
            // 
            this.employNum.Text = "번호";
            // 
            // employName
            // 
            this.employName.Text = "이름";
            this.employName.Width = 67;
            // 
            // employGender
            // 
            this.employGender.Text = "성별";
            this.employGender.Width = 48;
            // 
            // employTel
            // 
            this.employTel.Text = "전화번호";
            this.employTel.Width = 160;
            // 
            // employDepart
            // 
            this.employDepart.Text = "부서";
            this.employDepart.Width = 93;
            // 
            // employPosition
            // 
            this.employPosition.Text = "직급";
            this.employPosition.Width = 91;
            // 
            // employWork
            // 
            this.employWork.Text = "업무";
            this.employWork.Width = 130;
            // 
            // EmployeeManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.ControlBox = false;
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.custAddClose);
            this.Controls.Add(this.employAdd);
            this.Controls.Add(this.employManag);
            this.Name = "EmployeeManagementUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Activated += new System.EventHandler(this.EmployeeManagementUI_Activated);
            this.Load += new System.EventHandler(this.EmployeeManagementUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton employManag;
        private Sunny.UI.UISymbolButton custAddClose;
        private Sunny.UI.UISymbolButton employAdd;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ColumnHeader employName;
        private System.Windows.Forms.ColumnHeader employGender;
        private System.Windows.Forms.ColumnHeader employTel;
        private System.Windows.Forms.ColumnHeader employDepart;
        private System.Windows.Forms.ColumnHeader employPosition;
        private System.Windows.Forms.ColumnHeader employWork;
        private System.Windows.Forms.ColumnHeader employNum;
    }
}