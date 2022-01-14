
namespace CarManager0811.UI
{
    partial class MainLoginUI
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
            this.mainPasswd = new Sunny.UI.UITextBox();
            this.mainUser = new Sunny.UI.UITextBox();
            this.mainLoginCancel = new System.Windows.Forms.Button();
            this.mainLoginOK = new System.Windows.Forms.Button();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // mainPasswd
            // 
            this.mainPasswd.BackColor = System.Drawing.Color.Transparent;
            this.mainPasswd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainPasswd.FillColor = System.Drawing.Color.Black;
            this.mainPasswd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainPasswd.ForeColor = System.Drawing.Color.White;
            this.mainPasswd.Location = new System.Drawing.Point(107, 236);
            this.mainPasswd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPasswd.Maximum = 2147483647D;
            this.mainPasswd.Minimum = -2147483648D;
            this.mainPasswd.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainPasswd.Name = "mainPasswd";
            this.mainPasswd.RectColor = System.Drawing.Color.Black;
            this.mainPasswd.Size = new System.Drawing.Size(337, 51);
            this.mainPasswd.Style = Sunny.UI.UIStyle.Custom;
            this.mainPasswd.TabIndex = 13;
            this.mainPasswd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainUser
            // 
            this.mainUser.BackColor = System.Drawing.Color.Transparent;
            this.mainUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainUser.FillColor = System.Drawing.Color.Black;
            this.mainUser.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainUser.ForeColor = System.Drawing.Color.White;
            this.mainUser.Location = new System.Drawing.Point(107, 109);
            this.mainUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainUser.Maximum = 2147483647D;
            this.mainUser.Minimum = -2147483648D;
            this.mainUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainUser.Name = "mainUser";
            this.mainUser.RectColor = System.Drawing.Color.Black;
            this.mainUser.Size = new System.Drawing.Size(337, 51);
            this.mainUser.Style = Sunny.UI.UIStyle.Custom;
            this.mainUser.TabIndex = 12;
            this.mainUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainLoginCancel
            // 
            this.mainLoginCancel.BackColor = System.Drawing.Color.Black;
            this.mainLoginCancel.ForeColor = System.Drawing.Color.White;
            this.mainLoginCancel.Location = new System.Drawing.Point(423, 335);
            this.mainLoginCancel.Name = "mainLoginCancel";
            this.mainLoginCancel.Size = new System.Drawing.Size(271, 57);
            this.mainLoginCancel.TabIndex = 11;
            this.mainLoginCancel.Text = "취소";
            this.mainLoginCancel.UseVisualStyleBackColor = false;
            // 
            // mainLoginOK
            // 
            this.mainLoginOK.BackColor = System.Drawing.Color.Black;
            this.mainLoginOK.ForeColor = System.Drawing.Color.White;
            this.mainLoginOK.Location = new System.Drawing.Point(107, 335);
            this.mainLoginOK.Name = "mainLoginOK";
            this.mainLoginOK.Size = new System.Drawing.Size(271, 57);
            this.mainLoginOK.TabIndex = 10;
            this.mainLoginOK.Text = "로그인";
            this.mainLoginOK.UseVisualStyleBackColor = false;
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.Location = new System.Drawing.Point(107, 295);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(587, 2);
            this.uiLine2.TabIndex = 9;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(107, 168);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(587, 2);
            this.uiLine1.TabIndex = 8;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(107, 23);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(587, 63);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = "차량 관리 프로그램 3.5";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.mainPasswd);
            this.Controls.Add(this.mainUser);
            this.Controls.Add(this.mainLoginCancel);
            this.Controls.Add(this.mainLoginOK);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainLoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox mainPasswd;
        private Sunny.UI.UITextBox mainUser;
        private System.Windows.Forms.Button mainLoginCancel;
        private System.Windows.Forms.Button mainLoginOK;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel1;
    }
}
