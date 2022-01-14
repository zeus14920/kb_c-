
namespace oracleTest0820
{
    partial class MainWin
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
            this.mainExit = new System.Windows.Forms.Button();
            this.createTable = new System.Windows.Forms.Button();
            this.dropTable = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainExit
            // 
            this.mainExit.Location = new System.Drawing.Point(224, 315);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(371, 123);
            this.mainExit.TabIndex = 0;
            this.mainExit.Text = "종료";
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // createTable
            // 
            this.createTable.Location = new System.Drawing.Point(71, 41);
            this.createTable.Name = "createTable";
            this.createTable.Size = new System.Drawing.Size(299, 116);
            this.createTable.TabIndex = 1;
            this.createTable.Text = "테이블 생성";
            this.createTable.UseVisualStyleBackColor = true;
            this.createTable.Click += new System.EventHandler(this.createTable_Click);
            // 
            // dropTable
            // 
            this.dropTable.Location = new System.Drawing.Point(418, 41);
            this.dropTable.Name = "dropTable";
            this.dropTable.Size = new System.Drawing.Size(299, 116);
            this.dropTable.TabIndex = 2;
            this.dropTable.Text = "테이블 삭제";
            this.dropTable.UseVisualStyleBackColor = true;
            this.dropTable.Click += new System.EventHandler(this.dropTable_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(71, 181);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(299, 116);
            this.insert.TabIndex = 3;
            this.insert.Text = "데이터 추가";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(418, 181);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(299, 116);
            this.select.TabIndex = 4;
            this.select.Text = "테이블 정보 보기";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.select);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dropTable);
            this.Controls.Add(this.createTable);
            this.Controls.Add(this.mainExit);
            this.Name = "MainWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainExit;
        private System.Windows.Forms.Button createTable;
        private System.Windows.Forms.Button dropTable;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button select;
    }
}

