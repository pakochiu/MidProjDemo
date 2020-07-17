namespace mist126_27
{
    partial class FrmAddType
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productTypeLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddType));
            this.mist126_27DataSet = new mist126_27.mist126_27DataSet();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeTableAdapter = new mist126_27.mist126_27DataSetTableAdapters.ProductTypeTableAdapter();
            this.tableAdapterManager = new mist126_27.mist126_27DataSetTableAdapters.TableAdapterManager();
            this.productTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productTypeTextBox = new System.Windows.Forms.TextBox();
            this.productTypeIDTextBox = new System.Windows.Forms.TextBox();
            productTypeLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mist126_27DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingNavigator)).BeginInit();
            this.productTypeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;
            productTypeLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            productTypeLabel.Location = new System.Drawing.Point(43, 102);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new System.Drawing.Size(147, 25);
            productTypeLabel.TabIndex = 1;
            productTypeLabel.Text = "Product Type:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            productTypeIDLabel.Location = new System.Drawing.Point(43, 166);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(173, 25);
            productTypeIDLabel.TabIndex = 3;
            productTypeIDLabel.Text = "Product Type ID:";
            // 
            // mist126_27DataSet
            // 
            this.mist126_27DataSet.DataSetName = "mist126_27DataSet";
            this.mist126_27DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.mist126_27DataSet;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NewProductTableAdapter = null;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = this.productTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = mist126_27.mist126_27DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTypeBindingNavigator
            // 
            this.productTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productTypeBindingNavigator.BindingSource = this.productTypeBindingSource;
            this.productTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productTypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productTypeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productTypeBindingNavigatorSaveItem});
            this.productTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productTypeBindingNavigator.Name = "productTypeBindingNavigator";
            this.productTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productTypeBindingNavigator.Size = new System.Drawing.Size(612, 27);
            this.productTypeBindingNavigator.TabIndex = 0;
            this.productTypeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(46, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // productTypeBindingNavigatorSaveItem
            // 
            this.productTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productTypeBindingNavigatorSaveItem.Image")));
            this.productTypeBindingNavigatorSaveItem.Name = "productTypeBindingNavigatorSaveItem";
            this.productTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.productTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.productTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.productTypeBindingNavigatorSaveItem_Click);
            // 
            // productTypeTextBox
            // 
            this.productTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productTypeBindingSource, "ProductType", true));
            this.productTypeTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productTypeTextBox.Location = new System.Drawing.Point(279, 99);
            this.productTypeTextBox.Name = "productTypeTextBox";
            this.productTypeTextBox.Size = new System.Drawing.Size(210, 34);
            this.productTypeTextBox.TabIndex = 2;
            // 
            // productTypeIDTextBox
            // 
            this.productTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productTypeBindingSource, "ProductTypeID", true));
            this.productTypeIDTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.productTypeIDTextBox.Location = new System.Drawing.Point(279, 163);
            this.productTypeIDTextBox.Name = "productTypeIDTextBox";
            this.productTypeIDTextBox.ReadOnly = true;
            this.productTypeIDTextBox.Size = new System.Drawing.Size(210, 34);
            this.productTypeIDTextBox.TabIndex = 4;
            // 
            // FrmAddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 329);
            this.Controls.Add(productTypeLabel);
            this.Controls.Add(this.productTypeTextBox);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(this.productTypeIDTextBox);
            this.Controls.Add(this.productTypeBindingNavigator);
            this.Name = "FrmAddType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddType";
            ((System.ComponentModel.ISupportInitialize)(this.mist126_27DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingNavigator)).EndInit();
            this.productTypeBindingNavigator.ResumeLayout(false);
            this.productTypeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mist126_27DataSet mist126_27DataSet;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private mist126_27DataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private mist126_27DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productTypeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productTypeTextBox;
        private System.Windows.Forms.TextBox productTypeIDTextBox;
    }
}