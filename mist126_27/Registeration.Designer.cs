namespace mist126_27
{
    partial class Registeration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registeration));
            this.txtReconfirmError = new System.Windows.Forms.Label();
            this.txtUserNameError = new System.Windows.Forms.Label();
            this.txtPasswordError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordCheck = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistraion = new System.Windows.Forms.Button();
            this.UsedUserNameError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReconfirmError
            // 
            this.txtReconfirmError.AutoSize = true;
            this.txtReconfirmError.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReconfirmError.ForeColor = System.Drawing.Color.Red;
            this.txtReconfirmError.Location = new System.Drawing.Point(847, 320);
            this.txtReconfirmError.Name = "txtReconfirmError";
            this.txtReconfirmError.Size = new System.Drawing.Size(0, 18);
            this.txtReconfirmError.TabIndex = 21;
            // 
            // txtUserNameError
            // 
            this.txtUserNameError.AutoSize = true;
            this.txtUserNameError.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserNameError.ForeColor = System.Drawing.Color.Red;
            this.txtUserNameError.Location = new System.Drawing.Point(847, 175);
            this.txtUserNameError.Name = "txtUserNameError";
            this.txtUserNameError.Size = new System.Drawing.Size(0, 19);
            this.txtUserNameError.TabIndex = 20;
            // 
            // txtPasswordError
            // 
            this.txtPasswordError.AutoSize = true;
            this.txtPasswordError.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPasswordError.ForeColor = System.Drawing.Color.Red;
            this.txtPasswordError.Location = new System.Drawing.Point(847, 250);
            this.txtPasswordError.Name = "txtPasswordError";
            this.txtPasswordError.Size = new System.Drawing.Size(0, 18);
            this.txtPasswordError.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "帳戶註冊";
            // 
            // txtPasswordCheck
            // 
            this.txtPasswordCheck.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordCheck.Location = new System.Drawing.Point(533, 320);
            this.txtPasswordCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordCheck.Name = "txtPasswordCheck";
            this.txtPasswordCheck.Size = new System.Drawing.Size(297, 47);
            this.txtPasswordCheck.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "確認密碼";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(533, 250);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(297, 47);
            this.txtPassword.TabIndex = 15;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(533, 175);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(297, 47);
            this.txtUserName.TabIndex = 14;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "密碼";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "用戶名稱";
            // 
            // btnRegistraion
            // 
            this.btnRegistraion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraion.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraion.ForeColor = System.Drawing.Color.White;
            this.btnRegistraion.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistraion.Image")));
            this.btnRegistraion.Location = new System.Drawing.Point(533, 394);
            this.btnRegistraion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistraion.Name = "btnRegistraion";
            this.btnRegistraion.Size = new System.Drawing.Size(167, 75);
            this.btnRegistraion.TabIndex = 11;
            this.btnRegistraion.Text = "註冊";
            this.btnRegistraion.UseVisualStyleBackColor = true;
            this.btnRegistraion.Click += new System.EventHandler(this.btnRegistraion_Click);
            // 
            // UsedUserNameError
            // 
            this.UsedUserNameError.AutoSize = true;
            this.UsedUserNameError.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UsedUserNameError.ForeColor = System.Drawing.Color.Red;
            this.UsedUserNameError.Location = new System.Drawing.Point(529, 224);
            this.UsedUserNameError.Name = "UsedUserNameError";
            this.UsedUserNameError.Size = new System.Drawing.Size(0, 19);
            this.UsedUserNameError.TabIndex = 22;
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 562);
            this.Controls.Add(this.UsedUserNameError);
            this.Controls.Add(this.txtReconfirmError);
            this.Controls.Add(this.txtUserNameError);
            this.Controls.Add(this.txtPasswordError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistraion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registeration";
            this.Text = "Registeration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtReconfirmError;
        private System.Windows.Forms.Label txtUserNameError;
        private System.Windows.Forms.Label txtPasswordError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistraion;
        internal System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label UsedUserNameError;
    }
}