
namespace CarManager0811.UI
{
    partial class processUI
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
            this.workName = new Sunny.UI.UILabel();
            this.workName2 = new Sunny.UI.UILabel();
            this.processView = new Sunny.UI.UILabel();
            this.workStop = new Sunny.UI.UIButton();
            this.workProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // workName
            // 
            this.workName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.workName.Location = new System.Drawing.Point(94, 12);
            this.workName.Name = "workName";
            this.workName.Size = new System.Drawing.Size(48, 32);
            this.workName.TabIndex = 0;
            this.workName.Text = "공정";
            this.workName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workName2
            // 
            this.workName2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.workName2.Location = new System.Drawing.Point(148, 12);
            this.workName2.Name = "workName2";
            this.workName2.Size = new System.Drawing.Size(164, 32);
            this.workName2.TabIndex = 1;
            this.workName2.Text = "공정이 진행중입니다";
            this.workName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processView
            // 
            this.processView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.processView.Location = new System.Drawing.Point(318, 12);
            this.processView.Name = "processView";
            this.processView.Size = new System.Drawing.Size(164, 32);
            this.processView.TabIndex = 2;
            this.processView.Text = "진행 상황 표시: 0%";
            this.processView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workStop
            // 
            this.workStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workStop.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.workStop.Location = new System.Drawing.Point(524, 12);
            this.workStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.workStop.Name = "workStop";
            this.workStop.Size = new System.Drawing.Size(123, 63);
            this.workStop.TabIndex = 3;
            this.workStop.Text = "작업 중지";
            this.workStop.Click += new System.EventHandler(this.workStop_Click);
            // 
            // workProgress
            // 
            this.workProgress.Location = new System.Drawing.Point(98, 47);
            this.workProgress.Name = "workProgress";
            this.workProgress.Size = new System.Drawing.Size(384, 28);
            this.workProgress.TabIndex = 4;
            // 
            // processUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 95);
            this.Controls.Add(this.workProgress);
            this.Controls.Add(this.workStop);
            this.Controls.Add(this.processView);
            this.Controls.Add(this.workName2);
            this.Controls.Add(this.workName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "processUI";
            this.Text = "ProcessUI";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel workName;
        private Sunny.UI.UILabel workName2;
        private Sunny.UI.UILabel processView;
        private Sunny.UI.UIButton workStop;
        private System.Windows.Forms.ProgressBar workProgress;
    }
}