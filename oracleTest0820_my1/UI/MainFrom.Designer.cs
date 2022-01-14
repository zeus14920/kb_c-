
namespace oracleTest0820_my1
{
    partial class MainFrom
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.createTabel = new System.Windows.Forms.Button();
            this.dropTable = new System.Windows.Forms.Button();
            this.ProExit = new System.Windows.Forms.Button();
            this.addRandomDB = new System.Windows.Forms.Button();
            this.searchNameUI = new System.Windows.Forms.Button();
            this.deleteNameUI = new System.Windows.Forms.Button();
            this.allDataDB = new System.Windows.Forms.Button();
            this.addDateUI = new System.Windows.Forms.Button();
            this.changeNameUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB 연습 프로그램 V1.0";
            // 
            // createTabel
            // 
            this.createTabel.Location = new System.Drawing.Point(74, 107);
            this.createTabel.Name = "createTabel";
            this.createTabel.Size = new System.Drawing.Size(288, 52);
            this.createTabel.TabIndex = 1;
            this.createTabel.Text = "1. 테이블 생성";
            this.createTabel.UseVisualStyleBackColor = true;
            this.createTabel.Click += new System.EventHandler(this.createTabel_Click);
            // 
            // dropTable
            // 
            this.dropTable.Location = new System.Drawing.Point(74, 165);
            this.dropTable.Name = "dropTable";
            this.dropTable.Size = new System.Drawing.Size(288, 52);
            this.dropTable.TabIndex = 2;
            this.dropTable.Text = "2. 테이블 삭제";
            this.dropTable.UseVisualStyleBackColor = true;
            this.dropTable.Click += new System.EventHandler(this.dropTable_Click);
            // 
            // ProExit
            // 
            this.ProExit.Location = new System.Drawing.Point(74, 571);
            this.ProExit.Name = "ProExit";
            this.ProExit.Size = new System.Drawing.Size(288, 52);
            this.ProExit.TabIndex = 3;
            this.ProExit.Text = "4. 프로그램 종료";
            this.ProExit.UseVisualStyleBackColor = true;
            this.ProExit.Click += new System.EventHandler(this.ProExit_Click);
            // 
            // addRandomDB
            // 
            this.addRandomDB.Location = new System.Drawing.Point(74, 223);
            this.addRandomDB.Name = "addRandomDB";
            this.addRandomDB.Size = new System.Drawing.Size(288, 52);
            this.addRandomDB.TabIndex = 4;
            this.addRandomDB.Text = "3. 랜덤 생성 데이터 추가";
            this.addRandomDB.UseVisualStyleBackColor = true;
            this.addRandomDB.Click += new System.EventHandler(this.addRandomDB_Click);
            // 
            // searchNameUI
            // 
            this.searchNameUI.Location = new System.Drawing.Point(74, 397);
            this.searchNameUI.Name = "searchNameUI";
            this.searchNameUI.Size = new System.Drawing.Size(288, 52);
            this.searchNameUI.TabIndex = 5;
            this.searchNameUI.Text = "6. 데이터 검색(이름)";
            this.searchNameUI.UseVisualStyleBackColor = true;
            // 
            // deleteNameUI
            // 
            this.deleteNameUI.Location = new System.Drawing.Point(74, 455);
            this.deleteNameUI.Name = "deleteNameUI";
            this.deleteNameUI.Size = new System.Drawing.Size(288, 52);
            this.deleteNameUI.TabIndex = 6;
            this.deleteNameUI.Text = "7. 데이터 삭제(이름)";
            this.deleteNameUI.UseVisualStyleBackColor = true;
            // 
            // allDataDB
            // 
            this.allDataDB.Location = new System.Drawing.Point(74, 281);
            this.allDataDB.Name = "allDataDB";
            this.allDataDB.Size = new System.Drawing.Size(288, 52);
            this.allDataDB.TabIndex = 7;
            this.allDataDB.Text = "4. 전체 데이터 보기";
            this.allDataDB.UseVisualStyleBackColor = true;
            this.allDataDB.Click += new System.EventHandler(this.allDataDB_Click);
            // 
            // addDateUI
            // 
            this.addDateUI.Location = new System.Drawing.Point(74, 339);
            this.addDateUI.Name = "addDateUI";
            this.addDateUI.Size = new System.Drawing.Size(288, 52);
            this.addDateUI.TabIndex = 8;
            this.addDateUI.Text = "5. 수동으로 데이터 추가";
            this.addDateUI.UseVisualStyleBackColor = true;
            // 
            // changeNameUI
            // 
            this.changeNameUI.Location = new System.Drawing.Point(74, 513);
            this.changeNameUI.Name = "changeNameUI";
            this.changeNameUI.Size = new System.Drawing.Size(288, 52);
            this.changeNameUI.TabIndex = 9;
            this.changeNameUI.Text = "8. 데이터 변경(이름)";
            this.changeNameUI.UseVisualStyleBackColor = true;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 648);
            this.Controls.Add(this.changeNameUI);
            this.Controls.Add(this.addDateUI);
            this.Controls.Add(this.allDataDB);
            this.Controls.Add(this.deleteNameUI);
            this.Controls.Add(this.searchNameUI);
            this.Controls.Add(this.addRandomDB);
            this.Controls.Add(this.ProExit);
            this.Controls.Add(this.dropTable);
            this.Controls.Add(this.createTabel);
            this.Controls.Add(this.label1);
            this.Name = "MainFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createTabel;
        private System.Windows.Forms.Button dropTable;
        private System.Windows.Forms.Button ProExit;
        private System.Windows.Forms.Button addRandomDB;
        private System.Windows.Forms.Button searchNameUI;
        private System.Windows.Forms.Button deleteNameUI;
        private System.Windows.Forms.Button allDataDB;
        private System.Windows.Forms.Button addDateUI;
        private System.Windows.Forms.Button changeNameUI;
    }
}

