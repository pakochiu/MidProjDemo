namespace mist126_27
{
    partial class AddNewProductUserControl1
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label productIDLabel1;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label label2;
            this.comboxColor = new System.Windows.Forms.ComboBox();
            this.productIDTextBox1 = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            productIDLabel1 = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label5.Location = new System.Drawing.Point(291, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 25);
            label5.TabIndex = 44;
            label5.Text = "顏色";
            // 
            // productIDLabel1
            // 
            productIDLabel1.AutoSize = true;
            productIDLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            productIDLabel1.Location = new System.Drawing.Point(13, 12);
            productIDLabel1.Name = "productIDLabel1";
            productIDLabel1.Size = new System.Drawing.Size(92, 25);
            productIDLabel1.TabIndex = 40;
            productIDLabel1.Text = "產品名稱";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            quantityLabel.Location = new System.Drawing.Point(524, 12);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(52, 25);
            quantityLabel.TabIndex = 42;
            quantityLabel.Text = "數量";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            unitPriceLabel.Location = new System.Drawing.Point(796, 12);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(52, 25);
            unitPriceLabel.TabIndex = 46;
            unitPriceLabel.Text = "單價";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label2.Location = new System.Drawing.Point(1068, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 25);
            label2.TabIndex = 49;
            label2.Text = "小計";
            // 
            // comboxColor
            // 
            this.comboxColor.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboxColor.FormattingEnabled = true;
            this.comboxColor.Location = new System.Drawing.Point(349, 9);
            this.comboxColor.Name = "comboxColor";
            this.comboxColor.Size = new System.Drawing.Size(132, 30);
            this.comboxColor.TabIndex = 45;
            this.comboxColor.Leave += new System.EventHandler(this.comboxColor_Leave);
            // 
            // productIDTextBox1
            // 
            this.productIDTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productIDTextBox1.Location = new System.Drawing.Point(111, 9);
            this.productIDTextBox1.Name = "productIDTextBox1";
            this.productIDTextBox1.Size = new System.Drawing.Size(165, 30);
            this.productIDTextBox1.TabIndex = 41;
            this.productIDTextBox1.Leave += new System.EventHandler(this.productIDTextBox1_Leave);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.quantityTextBox.Location = new System.Drawing.Point(582, 9);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(153, 30);
            this.quantityTextBox.TabIndex = 43;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            this.quantityTextBox.Leave += new System.EventHandler(this.quantityTextBox_Leave);
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.unitPriceTextBox.Location = new System.Drawing.Point(854, 9);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.ReadOnly = true;
            this.unitPriceTextBox.Size = new System.Drawing.Size(154, 30);
            this.unitPriceTextBox.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(578, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 48;
            // 
            // SubTotal
            // 
            this.SubTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SubTotal.Location = new System.Drawing.Point(1126, 9);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Size = new System.Drawing.Size(152, 30);
            this.SubTotal.TabIndex = 50;
            this.SubTotal.TextChanged += new System.EventHandler(this.SubTotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(848, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 53;
            // 
            // AddNewProductUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.comboxColor);
            this.Controls.Add(label5);
            this.Controls.Add(productIDLabel1);
            this.Controls.Add(this.productIDTextBox1);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Name = "AddNewProductUserControl1";
            this.Size = new System.Drawing.Size(1331, 70);
            this.Load += new System.EventHandler(this.AddNewProductUserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxColor;
        internal System.Windows.Forms.TextBox productIDTextBox1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubTotal;
        private System.Windows.Forms.Label label3;
    }
}
