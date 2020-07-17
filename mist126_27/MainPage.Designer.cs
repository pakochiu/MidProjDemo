namespace mist126_27
{
    partial class MainPage
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label reoderLevelLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label bidFeeLabel;
            System.Windows.Forms.Label shippingFeeLabel;
            System.Windows.Forms.Label totalPriceLabel;
            System.Windows.Forms.Label platformIDLabel;
            System.Windows.Forms.Label purchasingOrderIDLabel;
            System.Windows.Forms.Label purchasingDateLabel;
            System.Windows.Forms.Label paymentMethodIDLabel;
            System.Windows.Forms.Label serviceFeeLabel;
            System.Windows.Forms.Label importDutyLabel;
            System.Windows.Forms.Label tariffLabel;
            System.Windows.Forms.Label totalPriceLabel1;
            System.Windows.Forms.Label shippingFeeLabel1;
            System.Windows.Forms.Label currencyIDLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pendingdelete = new System.Windows.Forms.TextBox();
            this.savePendingItems = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reoderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mist126_27DataSet = new mist126_27.mist126_27DataSet();
            this.label17 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ProductAdd = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddType = new System.Windows.Forms.Button();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.newProductBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.newProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.newProductBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.reoderLevelTextBox = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.PurchasingHistory = new System.Windows.Forms.Panel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Purchasing = new System.Windows.Forms.Panel();
            this.CalTotal = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.currencyIDCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.purchasingOrderIDTextBox = new System.Windows.Forms.TextBox();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.serviceFeeTextBox = new System.Windows.Forms.TextBox();
            this.importDutyTextBox = new System.Windows.Forms.TextBox();
            this.tariffTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox1 = new System.Windows.Forms.TextBox();
            this.shippingFeeTextBox1 = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.OrderQuery = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPid = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.shippingFeeTextBox = new System.Windows.Forms.TextBox();
            this.bidFeeTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proudctColor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuery = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.newProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.首頁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.產品資訊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增產品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查詢產品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.訂單管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查詢訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.採購管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新品採購ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歷史查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.庫存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.庫存查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.聊聊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.mist126_27DataSet1 = new mist126_27.mist126_27DataSet1();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newProductTableAdapter = new mist126_27.mist126_27DataSetTableAdapters.NewProductTableAdapter();
            this.tableAdapterManager = new mist126_27.mist126_27DataSetTableAdapters.TableAdapterManager();
            this.picturesTableAdapter = new mist126_27.mist126_27DataSetTableAdapters.PicturesTableAdapter();
            this.productTypeTableAdapter = new mist126_27.mist126_27DataSetTableAdapters.ProductTypeTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new mist126_27.mist126_27DataSetTableAdapters.OrdersTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new mist126_27.mist126_27DataSetTableAdapters.DataTable2TableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            reoderLevelLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            bidFeeLabel = new System.Windows.Forms.Label();
            shippingFeeLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            platformIDLabel = new System.Windows.Forms.Label();
            purchasingOrderIDLabel = new System.Windows.Forms.Label();
            purchasingDateLabel = new System.Windows.Forms.Label();
            paymentMethodIDLabel = new System.Windows.Forms.Label();
            serviceFeeLabel = new System.Windows.Forms.Label();
            importDutyLabel = new System.Windows.Forms.Label();
            tariffLabel = new System.Windows.Forms.Label();
            totalPriceLabel1 = new System.Windows.Forms.Label();
            shippingFeeLabel1 = new System.Windows.Forms.Label();
            currencyIDLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mist126_27DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.ProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductBindingNavigator)).BeginInit();
            this.newProductBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            this.Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.PurchasingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.Purchasing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.OrderQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            this.ProductQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mist126_27DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            productIDLabel.Location = new System.Drawing.Point(31, 73);
            productIDLabel.Margin = new System.Windows.Forms.Padding(20);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(92, 25);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "產品編號";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            productNameLabel.Location = new System.Drawing.Point(31, 120);
            productNameLabel.Margin = new System.Windows.Forms.Padding(20);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(92, 25);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "產品名稱";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            typeLabel.Location = new System.Drawing.Point(32, 165);
            typeLabel.Margin = new System.Windows.Forms.Padding(20);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(92, 25);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "產品類別";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            statusLabel.Location = new System.Drawing.Point(31, 212);
            statusLabel.Margin = new System.Windows.Forms.Padding(20);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 25);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "狀態";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            colorLabel.Location = new System.Drawing.Point(31, 259);
            colorLabel.Margin = new System.Windows.Forms.Padding(20);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(52, 25);
            colorLabel.TabIndex = 8;
            colorLabel.Text = "顏色";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            priceLabel.Location = new System.Drawing.Point(31, 307);
            priceLabel.Margin = new System.Windows.Forms.Padding(20);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(52, 25);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "售價";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            stockLabel.Location = new System.Drawing.Point(32, 355);
            stockLabel.Margin = new System.Windows.Forms.Padding(20);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(72, 25);
            stockLabel.TabIndex = 12;
            stockLabel.Text = "庫存量";
            // 
            // reoderLevelLabel
            // 
            reoderLevelLabel.AutoSize = true;
            reoderLevelLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            reoderLevelLabel.Location = new System.Drawing.Point(32, 402);
            reoderLevelLabel.Margin = new System.Windows.Forms.Padding(20);
            reoderLevelLabel.Name = "reoderLevelLabel";
            reoderLevelLabel.Size = new System.Drawing.Size(92, 25);
            reoderLevelLabel.TabIndex = 14;
            reoderLevelLabel.Text = "再訂購量";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            orderIDLabel.Location = new System.Drawing.Point(31, 28);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(92, 25);
            orderIDLabel.TabIndex = 26;
            orderIDLabel.Text = "訂單編號";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            orderDateLabel.Location = new System.Drawing.Point(1116, 28);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(52, 25);
            orderDateLabel.TabIndex = 27;
            orderDateLabel.Text = "日期";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            customerIDLabel.Location = new System.Drawing.Point(31, 78);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(92, 25);
            customerIDLabel.TabIndex = 28;
            customerIDLabel.Text = "客戶名稱";
            // 
            // bidFeeLabel
            // 
            bidFeeLabel.AutoSize = true;
            bidFeeLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            bidFeeLabel.Location = new System.Drawing.Point(375, 29);
            bidFeeLabel.Name = "bidFeeLabel";
            bidFeeLabel.Size = new System.Drawing.Size(112, 25);
            bidFeeLabel.TabIndex = 29;
            bidFeeLabel.Text = "拍賣手續費";
            // 
            // shippingFeeLabel
            // 
            shippingFeeLabel.AutoSize = true;
            shippingFeeLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            shippingFeeLabel.Location = new System.Drawing.Point(375, 102);
            shippingFeeLabel.Name = "shippingFeeLabel";
            shippingFeeLabel.Size = new System.Drawing.Size(52, 25);
            shippingFeeLabel.TabIndex = 31;
            shippingFeeLabel.Text = "運費";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            totalPriceLabel.Location = new System.Drawing.Point(654, 29);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(52, 25);
            totalPriceLabel.TabIndex = 32;
            totalPriceLabel.Text = "總價";
            // 
            // platformIDLabel
            // 
            platformIDLabel.AutoSize = true;
            platformIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            platformIDLabel.Location = new System.Drawing.Point(35, 132);
            platformIDLabel.Name = "platformIDLabel";
            platformIDLabel.Size = new System.Drawing.Size(92, 25);
            platformIDLabel.TabIndex = 33;
            platformIDLabel.Text = "購買平台";
            // 
            // purchasingOrderIDLabel
            // 
            purchasingOrderIDLabel.AutoSize = true;
            purchasingOrderIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            purchasingOrderIDLabel.Location = new System.Drawing.Point(11, 176);
            purchasingOrderIDLabel.Name = "purchasingOrderIDLabel";
            purchasingOrderIDLabel.Size = new System.Drawing.Size(92, 25);
            purchasingOrderIDLabel.TabIndex = 0;
            purchasingOrderIDLabel.Text = "採購編號";
            // 
            // purchasingDateLabel
            // 
            purchasingDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            purchasingDateLabel.AutoSize = true;
            purchasingDateLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            purchasingDateLabel.Location = new System.Drawing.Point(1056, 28);
            purchasingDateLabel.Name = "purchasingDateLabel";
            purchasingDateLabel.Size = new System.Drawing.Size(92, 25);
            purchasingDateLabel.TabIndex = 2;
            purchasingDateLabel.Text = "採購日期";
            // 
            // paymentMethodIDLabel
            // 
            paymentMethodIDLabel.AutoSize = true;
            paymentMethodIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            paymentMethodIDLabel.Location = new System.Drawing.Point(447, 171);
            paymentMethodIDLabel.Name = "paymentMethodIDLabel";
            paymentMethodIDLabel.Size = new System.Drawing.Size(92, 25);
            paymentMethodIDLabel.TabIndex = 4;
            paymentMethodIDLabel.Text = "付款方式";
            // 
            // serviceFeeLabel
            // 
            serviceFeeLabel.AutoSize = true;
            serviceFeeLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            serviceFeeLabel.Location = new System.Drawing.Point(447, 222);
            serviceFeeLabel.Name = "serviceFeeLabel";
            serviceFeeLabel.Size = new System.Drawing.Size(72, 25);
            serviceFeeLabel.TabIndex = 6;
            serviceFeeLabel.Text = "手續費";
            // 
            // importDutyLabel
            // 
            importDutyLabel.AutoSize = true;
            importDutyLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            importDutyLabel.Location = new System.Drawing.Point(913, 168);
            importDutyLabel.Name = "importDutyLabel";
            importDutyLabel.Size = new System.Drawing.Size(92, 25);
            importDutyLabel.TabIndex = 8;
            importDutyLabel.Text = "進口關稅";
            // 
            // tariffLabel
            // 
            tariffLabel.AutoSize = true;
            tariffLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            tariffLabel.Location = new System.Drawing.Point(913, 219);
            tariffLabel.Name = "tariffLabel";
            tariffLabel.Size = new System.Drawing.Size(72, 25);
            tariffLabel.TabIndex = 10;
            tariffLabel.Text = "營業稅";
            // 
            // totalPriceLabel1
            // 
            totalPriceLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            totalPriceLabel1.AutoSize = true;
            totalPriceLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            totalPriceLabel1.Location = new System.Drawing.Point(943, 107);
            totalPriceLabel1.Name = "totalPriceLabel1";
            totalPriceLabel1.Size = new System.Drawing.Size(72, 25);
            totalPriceLabel1.TabIndex = 12;
            totalPriceLabel1.Text = "總金額";
            // 
            // shippingFeeLabel1
            // 
            shippingFeeLabel1.AutoSize = true;
            shippingFeeLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            shippingFeeLabel1.Location = new System.Drawing.Point(11, 228);
            shippingFeeLabel1.Name = "shippingFeeLabel1";
            shippingFeeLabel1.Size = new System.Drawing.Size(52, 25);
            shippingFeeLabel1.TabIndex = 14;
            shippingFeeLabel1.Text = "運費";
            // 
            // currencyIDLabel
            // 
            currencyIDLabel.AutoSize = true;
            currencyIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            currencyIDLabel.Location = new System.Drawing.Point(11, 270);
            currencyIDLabel.Name = "currencyIDLabel";
            currencyIDLabel.Size = new System.Drawing.Size(92, 25);
            currencyIDLabel.TabIndex = 16;
            currencyIDLabel.Text = "結算貨幣";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            discountLabel.Location = new System.Drawing.Point(447, 269);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(52, 25);
            discountLabel.TabIndex = 34;
            discountLabel.Text = "折扣";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(1329, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "登出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.AutoSizeChanged += new System.EventHandler(this.MainPage_Load);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Controls.Add(this.Delete);
            this.Home.Controls.Add(this.label20);
            this.Home.Controls.Add(this.label19);
            this.Home.Controls.Add(this.pendingdelete);
            this.Home.Controls.Add(this.savePendingItems);
            this.Home.Controls.Add(this.dataGridView3);
            this.Home.Controls.Add(this.label17);
            this.Home.Controls.Add(this.button8);
            this.Home.Controls.Add(this.label16);
            this.Home.Controls.Add(this.flowLayoutPanel2);
            this.Home.Controls.Add(this.label15);
            this.Home.Controls.Add(this.label14);
            this.Home.Controls.Add(this.label5);
            this.Home.Controls.Add(this.dateTimePicker4);
            this.Home.Controls.Add(this.dateTimePicker3);
            this.Home.Controls.Add(this.chart1);
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.Location = new System.Drawing.Point(0, 33);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1416, 735);
            this.Home.TabIndex = 7;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.Delete.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(1301, 24);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(82, 30);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "刪除";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(1256, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 22);
            this.label20.TabIndex = 15;
            this.label20.Text = "資料";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(1147, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 22);
            this.label19.TabIndex = 14;
            this.label19.Text = "刪除第";
            // 
            // pendingdelete
            // 
            this.pendingdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pendingdelete.Location = new System.Drawing.Point(1216, 28);
            this.pendingdelete.Name = "pendingdelete";
            this.pendingdelete.Size = new System.Drawing.Size(31, 25);
            this.pendingdelete.TabIndex = 13;
            // 
            // savePendingItems
            // 
            this.savePendingItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savePendingItems.BackColor = System.Drawing.Color.MidnightBlue;
            this.savePendingItems.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.savePendingItems.ForeColor = System.Drawing.Color.White;
            this.savePendingItems.Location = new System.Drawing.Point(1072, 24);
            this.savePendingItems.Name = "savePendingItems";
            this.savePendingItems.Size = new System.Drawing.Size(66, 30);
            this.savePendingItems.TabIndex = 11;
            this.savePendingItems.Text = "儲存";
            this.savePendingItems.UseVisualStyleBackColor = false;
            this.savePendingItems.Click += new System.EventHandler(this.savePendingItems_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.reoderLevelDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.newProductBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(83, 355);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(729, 341);
            this.dataGridView3.TabIndex = 10;
            this.dataGridView3.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView3_DataError);
            this.dataGridView3.Leave += new System.EventHandler(this.dataGridView3_Leave);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // reoderLevelDataGridViewTextBoxColumn
            // 
            this.reoderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReoderLevel";
            this.reoderLevelDataGridViewTextBoxColumn.HeaderText = "ReoderLevel";
            this.reoderLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reoderLevelDataGridViewTextBoxColumn.Name = "reoderLevelDataGridViewTextBoxColumn";
            this.reoderLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // newProductBindingSource1
            // 
            this.newProductBindingSource1.DataMember = "NewProduct";
            this.newProductBindingSource1.DataSource = this.mist126_27DataSet;
            // 
            // mist126_27DataSet
            // 
            this.mist126_27DataSet.DataSetName = "mist126_27DataSet";
            this.mist126_27DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label17.Location = new System.Drawing.Point(51, 310);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 25);
            this.label17.TabIndex = 9;
            this.label17.Text = "庫存狀況";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.MidnightBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(977, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 30);
            this.button8.TabIndex = 8;
            this.button8.Text = "新增事項";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(872, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 7;
            this.label16.Text = "待辦事項";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(877, 74);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(506, 622);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(597, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "結束日期";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(360, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "開始日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(51, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "營業額";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(685, 26);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(127, 25);
            this.dateTimePicker4.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(448, 26);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(132, 25);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 73);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(770, 179);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ProductAdd
            // 
            this.ProductAdd.BackColor = System.Drawing.Color.White;
            this.ProductAdd.Controls.Add(this.pictureBox1);
            this.ProductAdd.Controls.Add(this.AddType);
            this.ProductAdd.Controls.Add(this.picturePictureBox);
            this.ProductAdd.Controls.Add(this.btnChoose);
            this.ProductAdd.Controls.Add(this.label2);
            this.ProductAdd.Controls.Add(this.txtFilename);
            this.ProductAdd.Controls.Add(this.newProductBindingNavigator);
            this.ProductAdd.Controls.Add(productIDLabel);
            this.ProductAdd.Controls.Add(this.productIDTextBox);
            this.ProductAdd.Controls.Add(productNameLabel);
            this.ProductAdd.Controls.Add(this.productNameTextBox);
            this.ProductAdd.Controls.Add(typeLabel);
            this.ProductAdd.Controls.Add(this.typeComboBox);
            this.ProductAdd.Controls.Add(statusLabel);
            this.ProductAdd.Controls.Add(this.statusComboBox);
            this.ProductAdd.Controls.Add(colorLabel);
            this.ProductAdd.Controls.Add(this.colorTextBox);
            this.ProductAdd.Controls.Add(priceLabel);
            this.ProductAdd.Controls.Add(this.priceTextBox);
            this.ProductAdd.Controls.Add(stockLabel);
            this.ProductAdd.Controls.Add(this.stockTextBox);
            this.ProductAdd.Controls.Add(reoderLevelLabel);
            this.ProductAdd.Controls.Add(this.reoderLevelTextBox);
            this.ProductAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductAdd.Location = new System.Drawing.Point(0, 33);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(1416, 735);
            this.ProductAdd.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.picturesBindingSource, "ProductID", true));
            this.pictureBox1.Location = new System.Drawing.Point(684, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // picturesBindingSource
            // 
            this.picturesBindingSource.DataMember = "Pictures";
            this.picturesBindingSource.DataSource = this.mist126_27DataSet;
            // 
            // AddType
            // 
            this.AddType.Location = new System.Drawing.Point(522, 165);
            this.AddType.Margin = new System.Windows.Forms.Padding(4);
            this.AddType.Name = "AddType";
            this.AddType.Size = new System.Drawing.Size(87, 25);
            this.AddType.TabIndex = 22;
            this.AddType.Text = "新增類別";
            this.AddType.UseVisualStyleBackColor = true;
            this.AddType.Click += new System.EventHandler(this.AddType_Click);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePictureBox.Location = new System.Drawing.Point(683, 123);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(548, 354);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePictureBox.TabIndex = 21;
            this.picturePictureBox.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(1131, 66);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 29);
            this.btnChoose.TabIndex = 19;
            this.btnChoose.Text = "上傳圖片";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "檔案名稱: ";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(683, 70);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(424, 25);
            this.txtFilename.TabIndex = 17;
            // 
            // newProductBindingNavigator
            // 
            this.newProductBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.newProductBindingNavigator.BindingSource = this.newProductBindingSource;
            this.newProductBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.newProductBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.newProductBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.newProductBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.newProductBindingNavigatorSaveItem});
            this.newProductBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.newProductBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.newProductBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.newProductBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.newProductBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.newProductBindingNavigator.Name = "newProductBindingNavigator";
            this.newProductBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.newProductBindingNavigator.Size = new System.Drawing.Size(1416, 27);
            this.newProductBindingNavigator.TabIndex = 12;
            this.newProductBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // newProductBindingSource
            // 
            this.newProductBindingSource.DataMember = "NewProduct";
            this.newProductBindingSource.DataSource = this.mist126_27DataSet;
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
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // newProductBindingNavigatorSaveItem
            // 
            this.newProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newProductBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("newProductBindingNavigatorSaveItem.Image")));
            this.newProductBindingNavigatorSaveItem.Name = "newProductBindingNavigatorSaveItem";
            this.newProductBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.newProductBindingNavigatorSaveItem.Text = "Save Data";
            this.newProductBindingNavigatorSaveItem.Click += new System.EventHandler(this.newProductBindingNavigatorSaveItem_Click);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newProductBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(163, 73);
            this.productIDTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(334, 25);
            this.productIDTextBox.TabIndex = 1;
            this.productIDTextBox.TextChanged += new System.EventHandler(this.productIDTextBox_TextChanged_1);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newProductBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(163, 120);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(334, 25);
            this.productNameTextBox.TabIndex = 3;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newProductBindingSource, "Type", true));
            this.typeComboBox.DataSource = this.productTypeBindingSource;
            this.typeComboBox.DisplayMember = "ProductType";
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(164, 165);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(20);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(334, 23);
            this.typeComboBox.TabIndex = 5;
            this.typeComboBox.ValueMember = "ProductType";
            this.typeComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeComboBox_MouseClick);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.mist126_27DataSet;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newProductBindingSource, "Status", true));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "上架中",
            "已下架",
            "缺貨",
            "樣品"});
            this.statusComboBox.Location = new System.Drawing.Point(163, 214);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(20);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(334, 23);
            this.statusComboBox.TabIndex = 7;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newProductBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(163, 259);
            this.colorTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(334, 25);
            this.colorTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newProductBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(163, 307);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(334, 25);
            this.priceTextBox.TabIndex = 11;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newProductBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(164, 355);
            this.stockTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(334, 25);
            this.stockTextBox.TabIndex = 13;
            // 
            // reoderLevelTextBox
            // 
            this.reoderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newProductBindingSource, "ReoderLevel", true));
            this.reoderLevelTextBox.Location = new System.Drawing.Point(164, 402);
            this.reoderLevelTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.reoderLevelTextBox.Name = "reoderLevelTextBox";
            this.reoderLevelTextBox.Size = new System.Drawing.Size(334, 25);
            this.reoderLevelTextBox.TabIndex = 15;
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.White;
            this.Stock.Controls.Add(this.dataGridView4);
            this.Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stock.Location = new System.Drawing.Point(0, 33);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(1416, 735);
            this.Stock.TabIndex = 9;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(27, 78);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.Size = new System.Drawing.Size(1356, 632);
            this.dataGridView4.TabIndex = 0;
            // 
            // PurchasingHistory
            // 
            this.PurchasingHistory.BackColor = System.Drawing.Color.White;
            this.PurchasingHistory.Controls.Add(this.dataGridView5);
            this.PurchasingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchasingHistory.Location = new System.Drawing.Point(0, 33);
            this.PurchasingHistory.Name = "PurchasingHistory";
            this.PurchasingHistory.Size = new System.Drawing.Size(1416, 735);
            this.PurchasingHistory.TabIndex = 10;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(27, 147);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 27;
            this.dataGridView5.Size = new System.Drawing.Size(1322, 563);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView5_DataError);
            // 
            // Purchasing
            // 
            this.Purchasing.BackColor = System.Drawing.Color.White;
            this.Purchasing.Controls.Add(this.CalTotal);
            this.Purchasing.Controls.Add(this.button7);
            this.Purchasing.Controls.Add(this.label13);
            this.Purchasing.Controls.Add(this.label12);
            this.Purchasing.Controls.Add(this.panel2);
            this.Purchasing.Controls.Add(this.flowLayoutPanel1);
            this.Purchasing.Controls.Add(this.currencyIDCB);
            this.Purchasing.Controls.Add(this.label11);
            this.Purchasing.Controls.Add(this.comboBoxPaymentMethod);
            this.Purchasing.Controls.Add(this.label6);
            this.Purchasing.Controls.Add(this.panel1);
            this.Purchasing.Controls.Add(this.button6);
            this.Purchasing.Controls.Add(purchasingOrderIDLabel);
            this.Purchasing.Controls.Add(this.purchasingOrderIDTextBox);
            this.Purchasing.Controls.Add(purchasingDateLabel);
            this.Purchasing.Controls.Add(this.purchasingDateDateTimePicker);
            this.Purchasing.Controls.Add(paymentMethodIDLabel);
            this.Purchasing.Controls.Add(serviceFeeLabel);
            this.Purchasing.Controls.Add(this.serviceFeeTextBox);
            this.Purchasing.Controls.Add(importDutyLabel);
            this.Purchasing.Controls.Add(this.importDutyTextBox);
            this.Purchasing.Controls.Add(tariffLabel);
            this.Purchasing.Controls.Add(this.tariffTextBox);
            this.Purchasing.Controls.Add(totalPriceLabel1);
            this.Purchasing.Controls.Add(this.totalPriceTextBox1);
            this.Purchasing.Controls.Add(shippingFeeLabel1);
            this.Purchasing.Controls.Add(this.shippingFeeTextBox1);
            this.Purchasing.Controls.Add(currencyIDLabel);
            this.Purchasing.Controls.Add(discountLabel);
            this.Purchasing.Controls.Add(this.discountTextBox);
            this.Purchasing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Purchasing.Location = new System.Drawing.Point(0, 33);
            this.Purchasing.Name = "Purchasing";
            this.Purchasing.Size = new System.Drawing.Size(1416, 735);
            this.Purchasing.TabIndex = 10;
            // 
            // CalTotal
            // 
            this.CalTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CalTotal.Location = new System.Drawing.Point(147, 384);
            this.CalTotal.Name = "CalTotal";
            this.CalTotal.Size = new System.Drawing.Size(111, 43);
            this.CalTotal.TabIndex = 49;
            this.CalTotal.Text = "計算總價";
            this.CalTotal.UseVisualStyleBackColor = true;
            this.CalTotal.Click += new System.EventHandler(this.CalTotal_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(30, 384);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 43);
            this.button7.TabIndex = 48;
            this.button7.Text = "新增商品";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label13.Location = new System.Drawing.Point(3, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 47;
            this.label13.Text = "採購主表";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(3, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "採購明細";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(3, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1425, 10);
            this.panel2.TabIndex = 41;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 433);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1367, 290);
            this.flowLayoutPanel1.TabIndex = 45;
            // 
            // currencyIDCB
            // 
            this.currencyIDCB.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.currencyIDCB.FormattingEnabled = true;
            this.currencyIDCB.Location = new System.Drawing.Point(130, 270);
            this.currencyIDCB.Name = "currencyIDCB";
            this.currencyIDCB.Size = new System.Drawing.Size(200, 33);
            this.currencyIDCB.TabIndex = 44;
            this.currencyIDCB.Leave += new System.EventHandler(this.currencyIDCB_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(1267, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "USD";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(565, 168);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(200, 33);
            this.comboBoxPaymentMethod.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(131, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(-2, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 10);
            this.panel1.TabIndex = 40;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(36, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 45);
            this.button6.TabIndex = 36;
            this.button6.Text = "儲存";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // purchasingOrderIDTextBox
            // 
            this.purchasingOrderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable2BindingSource, "PurchasingOrderID", true));
            this.purchasingOrderIDTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.purchasingOrderIDTextBox.Location = new System.Drawing.Point(130, 173);
            this.purchasingOrderIDTextBox.Name = "purchasingOrderIDTextBox";
            this.purchasingOrderIDTextBox.ReadOnly = true;
            this.purchasingOrderIDTextBox.Size = new System.Drawing.Size(200, 34);
            this.purchasingOrderIDTextBox.TabIndex = 1;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.mist126_27DataSet;
            // 
            // purchasingDateDateTimePicker
            // 
            this.purchasingDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataTable2BindingSource, "PurchasingDate", true));
            this.purchasingDateDateTimePicker.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.purchasingDateDateTimePicker.Location = new System.Drawing.Point(1165, 28);
            this.purchasingDateDateTimePicker.Name = "purchasingDateDateTimePicker";
            this.purchasingDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.purchasingDateDateTimePicker.TabIndex = 3;
            // 
            // serviceFeeTextBox
            // 
            this.serviceFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable2BindingSource, "ServiceFee", true));
            this.serviceFeeTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serviceFeeTextBox.Location = new System.Drawing.Point(565, 218);
            this.serviceFeeTextBox.Name = "serviceFeeTextBox";
            this.serviceFeeTextBox.Size = new System.Drawing.Size(200, 34);
            this.serviceFeeTextBox.TabIndex = 7;
            this.serviceFeeTextBox.Text = "0";
            // 
            // importDutyTextBox
            // 
            this.importDutyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable2BindingSource, "ImportDuty", true));
            this.importDutyTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.importDutyTextBox.Location = new System.Drawing.Point(1031, 168);
            this.importDutyTextBox.Name = "importDutyTextBox";
            this.importDutyTextBox.Size = new System.Drawing.Size(200, 34);
            this.importDutyTextBox.TabIndex = 9;
            // 
            // tariffTextBox
            // 
            this.tariffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable2BindingSource, "tariff", true));
            this.tariffTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tariffTextBox.Location = new System.Drawing.Point(1031, 216);
            this.tariffTextBox.Name = "tariffTextBox";
            this.tariffTextBox.Size = new System.Drawing.Size(200, 34);
            this.tariffTextBox.TabIndex = 11;
            // 
            // totalPriceTextBox1
            // 
            this.totalPriceTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable2BindingSource, "TotalPrice", true));
            this.totalPriceTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalPriceTextBox1.Location = new System.Drawing.Point(1061, 104);
            this.totalPriceTextBox1.Name = "totalPriceTextBox1";
            this.totalPriceTextBox1.Size = new System.Drawing.Size(200, 34);
            this.totalPriceTextBox1.TabIndex = 13;
            // 
            // shippingFeeTextBox1
            // 
            this.shippingFeeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable2BindingSource, "ShippingFee", true));
            this.shippingFeeTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shippingFeeTextBox1.Location = new System.Drawing.Point(130, 222);
            this.shippingFeeTextBox1.Name = "shippingFeeTextBox1";
            this.shippingFeeTextBox1.Size = new System.Drawing.Size(200, 34);
            this.shippingFeeTextBox1.TabIndex = 15;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable2BindingSource, "Discount", true));
            this.discountTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discountTextBox.Location = new System.Drawing.Point(565, 270);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(200, 34);
            this.discountTextBox.TabIndex = 35;
            this.discountTextBox.Text = "0";
            // 
            // OrderQuery
            // 
            this.OrderQuery.BackColor = System.Drawing.Color.White;
            this.OrderQuery.Controls.Add(this.chart2);
            this.OrderQuery.Controls.Add(this.dataGridView2);
            this.OrderQuery.Controls.Add(this.label9);
            this.OrderQuery.Controls.Add(this.label8);
            this.OrderQuery.Controls.Add(this.dateTimePicker2);
            this.OrderQuery.Controls.Add(this.dateTimePicker1);
            this.OrderQuery.Controls.Add(this.btnSearch);
            this.OrderQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderQuery.Location = new System.Drawing.Point(0, 33);
            this.OrderQuery.Name = "OrderQuery";
            this.OrderQuery.Size = new System.Drawing.Size(1416, 735);
            this.OrderQuery.TabIndex = 10;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(819, 121);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(575, 356);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 121);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(771, 531);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(334, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "結束日期";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(39, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "開始日期";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Location = new System.Drawing.Point(409, 42);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(628, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.White;
            this.Order.Controls.Add(this.label7);
            this.Order.Controls.Add(this.label4);
            this.Order.Controls.Add(this.cbxPid);
            this.Order.Controls.Add(this.save);
            this.Order.Controls.Add(this.customerIDTextBox);
            this.Order.Controls.Add(platformIDLabel);
            this.Order.Controls.Add(totalPriceLabel);
            this.Order.Controls.Add(this.totalPriceTextBox);
            this.Order.Controls.Add(shippingFeeLabel);
            this.Order.Controls.Add(this.shippingFeeTextBox);
            this.Order.Controls.Add(bidFeeLabel);
            this.Order.Controls.Add(this.bidFeeTextBox);
            this.Order.Controls.Add(customerIDLabel);
            this.Order.Controls.Add(orderDateLabel);
            this.Order.Controls.Add(this.orderDateDateTimePicker);
            this.Order.Controls.Add(orderIDLabel);
            this.Order.Controls.Add(this.orderIDTextBox);
            this.Order.Controls.Add(this.dataTable1DataGridView);
            this.Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order.Location = new System.Drawing.Point(0, 33);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(1416, 735);
            this.Order.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(504, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(504, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 39;
            // 
            // cbxPid
            // 
            this.cbxPid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPid.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxPid.FormattingEnabled = true;
            this.cbxPid.Location = new System.Drawing.Point(146, 129);
            this.cbxPid.Name = "cbxPid";
            this.cbxPid.Size = new System.Drawing.Size(194, 33);
            this.cbxPid.TabIndex = 37;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.save.Location = new System.Drawing.Point(1174, 82);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(200, 75);
            this.save.TabIndex = 36;
            this.save.Text = "儲存資料";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customerIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.customerIDTextBox.Location = new System.Drawing.Point(146, 72);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(194, 34);
            this.customerIDTextBox.TabIndex = 35;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalPriceTextBox.Location = new System.Drawing.Point(712, 26);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 34);
            this.totalPriceTextBox.TabIndex = 33;
            // 
            // shippingFeeTextBox
            // 
            this.shippingFeeTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shippingFeeTextBox.Location = new System.Drawing.Point(509, 99);
            this.shippingFeeTextBox.Name = "shippingFeeTextBox";
            this.shippingFeeTextBox.Size = new System.Drawing.Size(100, 34);
            this.shippingFeeTextBox.TabIndex = 32;
            this.shippingFeeTextBox.TextChanged += new System.EventHandler(this.shippingFeeTextBox_TextChanged);
            // 
            // bidFeeTextBox
            // 
            this.bidFeeTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bidFeeTextBox.Location = new System.Drawing.Point(509, 26);
            this.bidFeeTextBox.Name = "bidFeeTextBox";
            this.bidFeeTextBox.Size = new System.Drawing.Size(100, 34);
            this.bidFeeTextBox.TabIndex = 30;
            this.bidFeeTextBox.TextChanged += new System.EventHandler(this.bidFeeTextBox_TextChanged);
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(1174, 24);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.orderDateDateTimePicker.TabIndex = 28;
            this.orderDateDateTimePicker.ValueChanged += new System.EventHandler(this.orderDateDateTimePicker_ValueChanged);
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orderIDTextBox.Location = new System.Drawing.Point(146, 24);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(194, 34);
            this.orderIDTextBox.TabIndex = 27;
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.proudctColor,
            this.Quantity,
            this.Price,
            this.Discount,
            this.SubTotal});
            this.dataTable1DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(36, 180);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.RowHeadersWidth = 51;
            this.dataTable1DataGridView.RowTemplate.Height = 27;
            this.dataTable1DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(1338, 460);
            this.dataTable1DataGridView.TabIndex = 26;
            this.dataTable1DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable1DataGridView_CellEndEdit);
            this.dataTable1DataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataTable1DataGridView_EditingControlShowing);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "產品名稱";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // proudctColor
            // 
            this.proudctColor.HeaderText = "顏色";
            this.proudctColor.MinimumWidth = 6;
            this.proudctColor.Name = "proudctColor";
            this.proudctColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proudctColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "數量";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price.HeaderText = "價格";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "折扣";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "項目小計";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // ProductQuery
            // 
            this.ProductQuery.BackColor = System.Drawing.Color.White;
            this.ProductQuery.Controls.Add(this.button3);
            this.ProductQuery.Controls.Add(this.label3);
            this.ProductQuery.Controls.Add(this.txtProductSearch);
            this.ProductQuery.Controls.Add(this.txtSearch);
            this.ProductQuery.Controls.Add(this.button2);
            this.ProductQuery.Controls.Add(this.newProductDataGridView);
            this.ProductQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductQuery.Location = new System.Drawing.Point(0, 33);
            this.ProductQuery.Name = "ProductQuery";
            this.ProductQuery.Size = new System.Drawing.Size(1416, 735);
            this.ProductQuery.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "顯示全部產品";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 4;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.AutoSize = true;
            this.txtProductSearch.Location = new System.Drawing.Point(111, 43);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(67, 15);
            this.txtProductSearch.TabIndex = 3;
            this.txtProductSearch.Text = "產品搜尋";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(199, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "搜尋";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newProductDataGridView
            // 
            this.newProductDataGridView.AutoGenerateColumns = false;
            this.newProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.newProductDataGridView.DataSource = this.newProductBindingSource;
            this.newProductDataGridView.Location = new System.Drawing.Point(83, 91);
            this.newProductDataGridView.Name = "newProductDataGridView";
            this.newProductDataGridView.RowHeadersWidth = 51;
            this.newProductDataGridView.RowTemplate.Height = 27;
            this.newProductDataGridView.Size = new System.Drawing.Size(1065, 376);
            this.newProductDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "產品編號";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "產品名稱";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "類別";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "狀態";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn5.HeaderText = "顏色";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "價錢";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn7.HeaderText = "庫存";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReoderLevel";
            this.dataGridViewTextBoxColumn8.HeaderText = "再訂購量";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 24);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // 首頁ToolStripMenuItem
            // 
            this.首頁ToolStripMenuItem.Name = "首頁ToolStripMenuItem";
            this.首頁ToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.首頁ToolStripMenuItem.Text = "首頁";
            this.首頁ToolStripMenuItem.Click += new System.EventHandler(this.首頁ToolStripMenuItem_Click);
            // 
            // 產品資訊ToolStripMenuItem
            // 
            this.產品資訊ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增產品ToolStripMenuItem,
            this.查詢產品ToolStripMenuItem});
            this.產品資訊ToolStripMenuItem.Name = "產品資訊ToolStripMenuItem";
            this.產品資訊ToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.產品資訊ToolStripMenuItem.Text = "產品管理";
            // 
            // 新增產品ToolStripMenuItem
            // 
            this.新增產品ToolStripMenuItem.Name = "新增產品ToolStripMenuItem";
            this.新增產品ToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.新增產品ToolStripMenuItem.Text = "新增產品";
            this.新增產品ToolStripMenuItem.Click += new System.EventHandler(this.新增產品ToolStripMenuItem_Click);
            // 
            // 查詢產品ToolStripMenuItem
            // 
            this.查詢產品ToolStripMenuItem.Name = "查詢產品ToolStripMenuItem";
            this.查詢產品ToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.查詢產品ToolStripMenuItem.Text = "查詢產品";
            this.查詢產品ToolStripMenuItem.Click += new System.EventHandler(this.查詢產品ToolStripMenuItem_Click);
            // 
            // 訂單管理ToolStripMenuItem
            // 
            this.訂單管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增訂單ToolStripMenuItem,
            this.查詢訂單ToolStripMenuItem});
            this.訂單管理ToolStripMenuItem.Name = "訂單管理ToolStripMenuItem";
            this.訂單管理ToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.訂單管理ToolStripMenuItem.Text = "訂單管理";
            // 
            // 新增訂單ToolStripMenuItem
            // 
            this.新增訂單ToolStripMenuItem.Name = "新增訂單ToolStripMenuItem";
            this.新增訂單ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.新增訂單ToolStripMenuItem.Text = "新增訂單";
            this.新增訂單ToolStripMenuItem.Click += new System.EventHandler(this.新增訂單ToolStripMenuItem_Click);
            // 
            // 查詢訂單ToolStripMenuItem
            // 
            this.查詢訂單ToolStripMenuItem.Name = "查詢訂單ToolStripMenuItem";
            this.查詢訂單ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.查詢訂單ToolStripMenuItem.Text = "查詢訂單";
            this.查詢訂單ToolStripMenuItem.Click += new System.EventHandler(this.查詢訂單ToolStripMenuItem_Click);
            // 
            // 採購管理ToolStripMenuItem
            // 
            this.採購管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新品採購ToolStripMenuItem,
            this.歷史查詢ToolStripMenuItem});
            this.採購管理ToolStripMenuItem.Name = "採購管理ToolStripMenuItem";
            this.採購管理ToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.採購管理ToolStripMenuItem.Text = "採購管理";
            // 
            // 新品採購ToolStripMenuItem
            // 
            this.新品採購ToolStripMenuItem.Name = "新品採購ToolStripMenuItem";
            this.新品採購ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.新品採購ToolStripMenuItem.Text = "新品採購";
            this.新品採購ToolStripMenuItem.Click += new System.EventHandler(this.新品採購ToolStripMenuItem_Click);
            // 
            // 歷史查詢ToolStripMenuItem
            // 
            this.歷史查詢ToolStripMenuItem.Name = "歷史查詢ToolStripMenuItem";
            this.歷史查詢ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.歷史查詢ToolStripMenuItem.Text = "歷史查詢";
            this.歷史查詢ToolStripMenuItem.Click += new System.EventHandler(this.歷史查詢ToolStripMenuItem_Click);
            // 
            // 庫存管理ToolStripMenuItem
            // 
            this.庫存管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.庫存查詢ToolStripMenuItem});
            this.庫存管理ToolStripMenuItem.Name = "庫存管理ToolStripMenuItem";
            this.庫存管理ToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.庫存管理ToolStripMenuItem.Text = "庫存管理";
            // 
            // 庫存查詢ToolStripMenuItem
            // 
            this.庫存查詢ToolStripMenuItem.Name = "庫存查詢ToolStripMenuItem";
            this.庫存查詢ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.庫存查詢ToolStripMenuItem.Text = "庫存查詢";
            this.庫存查詢ToolStripMenuItem.Click += new System.EventHandler(this.庫存查詢ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首頁ToolStripMenuItem,
            this.產品資訊ToolStripMenuItem,
            this.訂單管理ToolStripMenuItem,
            this.採購管理ToolStripMenuItem,
            this.庫存管理ToolStripMenuItem,
            this.聊聊ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1416, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 聊聊ToolStripMenuItem
            // 
            this.聊聊ToolStripMenuItem.Name = "聊聊ToolStripMenuItem";
            this.聊聊ToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.聊聊ToolStripMenuItem.Text = "聊聊";
            this.聊聊ToolStripMenuItem.Click += new System.EventHandler(this.聊聊ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1178, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.AutoSizeChanged += new System.EventHandler(this.MainPage_Load);
            // 
            // mist126_27DataSet1
            // 
            this.mist126_27DataSet1.DataSetName = "mist126_27DataSet1";
            this.mist126_27DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // newProductTableAdapter
            // 
            this.newProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.NewProductTableAdapter = this.newProductTableAdapter;
            this.tableAdapterManager.OrderDetailTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PicturesTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = mist126_27.mist126_27DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.mist126_27DataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 768);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.OrderQuery);
            this.Controls.Add(this.ProductQuery);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Purchasing);
            this.Controls.Add(this.PurchasingHistory);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mist126_27DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ProductAdd.ResumeLayout(false);
            this.ProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductBindingNavigator)).EndInit();
            this.newProductBindingNavigator.ResumeLayout(false);
            this.newProductBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.Stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.PurchasingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.Purchasing.ResumeLayout(false);
            this.Purchasing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.OrderQuery.ResumeLayout(false);
            this.OrderQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            this.ProductQuery.ResumeLayout(false);
            this.ProductQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newProductDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mist126_27DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Panel ProductAdd;
        private System.Windows.Forms.Panel Stock;
        private System.Windows.Forms.Panel PurchasingHistory;
        private System.Windows.Forms.Panel Purchasing;
        private System.Windows.Forms.Panel OrderQuery;
        private System.Windows.Forms.Panel Order;
        private System.Windows.Forms.Panel ProductQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem 首頁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 產品資訊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增產品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查詢產品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 訂單管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增訂單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查詢訂單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 採購管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新品採購ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歷史查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 庫存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 庫存查詢ToolStripMenuItem;
        private mist126_27DataSet mist126_27DataSet;
        private System.Windows.Forms.BindingSource newProductBindingSource;
        private mist126_27DataSetTableAdapters.NewProductTableAdapter newProductTableAdapter;
        private mist126_27DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator newProductBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton newProductBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox reoderLevelTextBox;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private mist126_27DataSetTableAdapters.PicturesTableAdapter picturesTableAdapter;
        private System.Windows.Forms.DataGridView newProductDataGridView;
        private System.Windows.Forms.Label txtProductSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 聊聊ToolStripMenuItem;
        public System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private mist126_27DataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private System.Windows.Forms.Button AddType;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        protected System.Windows.Forms.TextBox totalPriceTextBox;
        protected System.Windows.Forms.TextBox shippingFeeTextBox;
        protected System.Windows.Forms.TextBox bidFeeTextBox;
        protected System.Windows.Forms.TextBox orderIDTextBox;
        protected System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox cbxPid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private mist126_27DataSet1 mist126_27DataSet1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn proudctColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.DateTimePicker dateTimePicker2;
        protected System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private mist126_27DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private mist126_27DataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.TextBox purchasingOrderIDTextBox;
        private System.Windows.Forms.DateTimePicker purchasingDateDateTimePicker;
        private System.Windows.Forms.TextBox serviceFeeTextBox;
        private System.Windows.Forms.TextBox importDutyTextBox;
        private System.Windows.Forms.TextBox tariffTextBox;
        private System.Windows.Forms.TextBox shippingFeeTextBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox currencyIDCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox discountTextBox;
        internal System.Windows.Forms.TextBox totalPriceTextBox1;
        private System.Windows.Forms.Button CalTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource newProductBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reoderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button savePendingItems;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pendingdelete;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}