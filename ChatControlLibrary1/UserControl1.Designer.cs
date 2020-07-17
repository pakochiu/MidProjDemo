namespace ChatControlLibrary1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UserName.Location = new System.Drawing.Point(131, 11);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(95, 22);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "使用者名稱";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Date.Location = new System.Drawing.Point(20, 11);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(44, 22);
            this.Date.TabIndex = 1;
            this.Date.Text = "日期";
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Content.Location = new System.Drawing.Point(23, 51);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(78, 22);
            this.Content.TabIndex = 2;
            this.Content.Text = "Content";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.UserName);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(446, 136);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Content;
    }
}
