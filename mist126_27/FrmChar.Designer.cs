namespace mist126_27
{
    partial class FrmChar
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
            this.sendbox = new System.Windows.Forms.Panel();
            this.txtMessagebox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sendbox.SuspendLayout();
            this.MessageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendbox
            // 
            this.sendbox.Controls.Add(this.txtMessagebox);
            this.sendbox.Controls.Add(this.button1);
            this.sendbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendbox.Location = new System.Drawing.Point(0, 511);
            this.sendbox.Name = "sendbox";
            this.sendbox.Size = new System.Drawing.Size(487, 68);
            this.sendbox.TabIndex = 1;
            // 
            // txtMessagebox
            // 
            this.txtMessagebox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMessagebox.Location = new System.Drawing.Point(0, 0);
            this.txtMessagebox.Name = "txtMessagebox";
            this.txtMessagebox.Size = new System.Drawing.Size(406, 65);
            this.txtMessagebox.TabIndex = 1;
            this.txtMessagebox.Text = "";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(412, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "傳送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Controls.Add(this.flowLayoutPanel1);
            this.MessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MessageBox.Location = new System.Drawing.Point(0, 0);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(487, 511);
            this.MessageBox.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(487, 511);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FrmChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 579);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.sendbox);
            this.Name = "FrmChar";
            this.Text = "聊聊";
            this.sendbox.ResumeLayout(false);
            this.MessageBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sendbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MessageBox;
        private System.Windows.Forms.RichTextBox txtMessagebox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}