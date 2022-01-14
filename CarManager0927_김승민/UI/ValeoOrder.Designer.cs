
namespace CarManager0811.UI
{
    partial class ValeoOrder
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
            this.lboxMake = new Sunny.UI.UIListBox();
            this.btnClose = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // lboxMake
            // 
            this.lboxMake.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lboxMake.FormatString = "";
            this.lboxMake.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lboxMake.Location = new System.Drawing.Point(158, 27);
            this.lboxMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lboxMake.MinimumSize = new System.Drawing.Size(1, 1);
            this.lboxMake.Name = "lboxMake";
            this.lboxMake.Padding = new System.Windows.Forms.Padding(2);
            this.lboxMake.Size = new System.Drawing.Size(459, 235);
            this.lboxMake.TabIndex = 0;
            this.lboxMake.Text = "uiListBox1";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnClose.Location = new System.Drawing.Point(256, 307);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 69);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "검사중입니다...";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ValeoOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lboxMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ValeoOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIListBox lboxMake;
        private Sunny.UI.UIButton btnClose;
    }
}