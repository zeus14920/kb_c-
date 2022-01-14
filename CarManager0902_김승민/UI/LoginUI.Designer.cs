
namespace CarManager0811.UI
{
    partial class LoginUI
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.loginOK = new System.Windows.Forms.Button();
            this.loginCancel = new System.Windows.Forms.Button();
            this.user = new Sunny.UI.UITextBox();
            this.passwd = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(277, 40);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(240, 63);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "관리자 모드";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(96, 185);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(587, 2);
            this.uiLine1.TabIndex = 1;
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.Location = new System.Drawing.Point(96, 312);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(587, 2);
            this.uiLine2.TabIndex = 2;
            // 
            // loginOK
            // 
            this.loginOK.BackColor = System.Drawing.Color.Black;
            this.loginOK.ForeColor = System.Drawing.Color.White;
            this.loginOK.Location = new System.Drawing.Point(96, 352);
            this.loginOK.Name = "loginOK";
            this.loginOK.Size = new System.Drawing.Size(271, 57);
            this.loginOK.TabIndex = 3;
            this.loginOK.Text = "로그인";
            this.loginOK.UseVisualStyleBackColor = false;
            this.loginOK.Click += new System.EventHandler(this.loginOK_Click);
            // 
            // loginCancel
            // 
            this.loginCancel.BackColor = System.Drawing.Color.Black;
            this.loginCancel.ForeColor = System.Drawing.Color.White;
            this.loginCancel.Location = new System.Drawing.Point(412, 352);
            this.loginCancel.Name = "loginCancel";
            this.loginCancel.Size = new System.Drawing.Size(271, 57);
            this.loginCancel.TabIndex = 4;
            this.loginCancel.Text = "취소";
            this.loginCancel.UseVisualStyleBackColor = false;
            this.loginCancel.Click += new System.EventHandler(this.loginCancel_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.FillColor = System.Drawing.Color.Black;
            this.user.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(96, 126);
            this.user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user.Maximum = 2147483647D;
            this.user.Minimum = -2147483648D;
            this.user.MinimumSize = new System.Drawing.Size(1, 1);
            this.user.Name = "user";
            this.user.RectColor = System.Drawing.Color.Black;
            this.user.Size = new System.Drawing.Size(337, 51);
            this.user.Style = Sunny.UI.UIStyle.Custom;
            this.user.TabIndex = 5;
            this.user.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwd
            // 
            this.passwd.BackColor = System.Drawing.Color.Transparent;
            this.passwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwd.FillColor = System.Drawing.Color.Black;
            this.passwd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.passwd.ForeColor = System.Drawing.Color.White;
            this.passwd.Location = new System.Drawing.Point(96, 253);
            this.passwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwd.Maximum = 2147483647D;
            this.passwd.Minimum = -2147483648D;
            this.passwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwd.Name = "passwd";
            this.passwd.RectColor = System.Drawing.Color.Black;
            this.passwd.Size = new System.Drawing.Size(337, 51);
            this.passwd.Style = Sunny.UI.UIStyle.Custom;
            this.passwd.TabIndex = 6;
            this.passwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.user);
            this.Controls.Add(this.loginCancel);
            this.Controls.Add(this.loginOK);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiLabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginUI";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private System.Windows.Forms.Button loginOK;
        private System.Windows.Forms.Button loginCancel;
        private Sunny.UI.UITextBox user;
        private Sunny.UI.UITextBox passwd;
    }
}