using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mist126_27
{

    public partial class MainPage : Form
    {
        Login login = new Login();
        MidProjectEntities DBContext = new MidProjectEntities();

        public MainPage()
        {
            InitializeComponent();
            label1.Text = ClassLogin.userName;
            label1.Text = "Hello " + label1.Text;
        }



        private void MainPage_Load(object sender, EventArgs e)
        {
            FillTable();
            shippingFeeTextBox.Text = "60";            

            PurchasingHistory.Visible = false;
            Purchasing.Visible = false;
            OrderQuery.Visible = false;
            Order.Visible = false;
            ProductQuery.Visible = false;
            Stock.Visible = false;
            ProductAdd.Visible = false;
            Home.Visible = true;

            //以下首頁報表資訊=======================================
            Char1update();
           

            //以下MainPage DataGrid 庫存量table

            CheckStock();

            //for (int i = 0; i < dataGridView3.Rows.Count -1; i++)
            //{

            //    int stock =Convert.ToInt32(dataGridView3.Rows[i].Cells["stockDataGridViewTextBoxColumn"].Value);

            //    int RecoderLevel = Convert.ToInt32(dataGridView3.Rows[i].Cells["reoderLevelDataGridViewTextBoxColumn"].Value);
            //    if (stock<RecoderLevel)
            //    {
            //        dataGridView3.Rows[i].Cells["stockDataGridViewTextBoxColumn"].Style.BackColor = Color.Red;
            //    }                
            //}

            //首頁存取 Pending Item 項目=========================================
            pendingItemUpdate();



            //以下存取目前orderID==================================
            CallOderID();

            //以下orderplaform 平台增加東西======================

            var q2 = from pid in DBContext.tOrderPlatforms
                     select pid.OrderPlatform;
            foreach (string i in q2)
            {
                cbxPid.Items.Add(i);
            }


            //以下是AutoComplete自動帶入===============================
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (mist126_27DataSet.NewProductRow row in mist126_27DataSet.NewProduct.Rows)
            {
                ac.Add(row.ProductName);
            }
            txtSearch.AutoCompleteCustomSource = ac;

            IEnumerable<string> customerID = from cus in DBContext.tCustomers
                                             select cus.Account;

            AutoCompleteStringCollection customerName = new AutoCompleteStringCollection();

            foreach (string i in customerID)
            {
                customerName.Add(i);
            }

            customerIDTextBox.AutoCompleteCustomSource = customerName;


            //自動帶入上品名稱============================
            var pro = from p in DBContext.tNewProducts
                      select p.ProductName;

            autoProduct = new AutoCompleteStringCollection();
            foreach (string i in pro)
            {
                autoProduct.Add(i);
            }

        }

        private void Char1update()
        {
            try
            {
                var q = from o in this.mist126_27DataSet.Orders
                        orderby o.OrderDate.Month descending
                        group o by o.OrderDate.Month into g
                        select new { MyKey = g.Key, Revenue = g.Sum(od => od.TotalPrice) };  //select 匿名型別

                this.chart1.DataSource = q.ToList();
                this.chart1.Series.Clear();
                this.chart1.Series.Add("Orders By Month");
                this.chart1.Series[0].XValueMember = "MyKey";
                this.chart1.Series[0].YValueMembers = "Revenue";
                this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                this.chart1.Series[0].BorderWidth = 4;
            }
            catch { }
        }

        private void CheckStock()
        {
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {

                int stock = Convert.ToInt32(dataGridView3.Rows[i].Cells["stockDataGridViewTextBoxColumn"].Value);

                int RecoderLevel = Convert.ToInt32(dataGridView3.Rows[i].Cells["reoderLevelDataGridViewTextBoxColumn"].Value);
                if (stock < RecoderLevel)
                {
                    dataGridView3.Rows[i].Cells["stockDataGridViewTextBoxColumn"].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView3.Rows[i].Cells["stockDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                }
            }
        }

        AutoCompleteStringCollection autoProduct;

        private void CallOderID()
        {

            var od = (from odid in DBContext.tOrders
                      orderby odid.OrderID descending
                      select odid.OrderID).FirstOrDefault();

            orderIDTextBox.Text = (od + 1).ToString();
        }

        private void FillTable()
        {
            // TODO: This line of code loads data into the 'mist126_27DataSet.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.mist126_27DataSet.ProductType);
            // TODO: This line of code loads data into the 'mist126_27DataSet.Pictures' table. You can move, or remove it, as needed.
            this.picturesTableAdapter.Fill(this.mist126_27DataSet.Pictures);
            // TODO: This line of code loads data into the 'mist126_27DataSet.NewProduct' table. You can move, or remove it, as needed.
            this.newProductTableAdapter.Fill(this.mist126_27DataSet.NewProduct);
            // TODO: This line of code loads data into the 'mist126_27DataSet.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.mist126_27DataSet.DataTable2);
            // TODO: This line of code loads data into the 'mist126_27DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.mist126_27DataSet.Orders);

        }

        private void 首頁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasingHistory.Visible = false;
            Purchasing.Visible = false;
            OrderQuery.Visible = false;
            Order.Visible = false;
            ProductQuery.Visible = false;
            Stock.Visible = false;
            ProductAdd.Visible = false;
            Home.Visible = true;
            pendingItemUpdate();
            FillTable();
            Char1update();
            CheckStock();
        }

        private void 新增產品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasingHistory.Visible = false;
            Purchasing.Visible = false;
            OrderQuery.Visible = false;
            Order.Visible = false;
            ProductQuery.Visible = false;
            Stock.Visible = false;
            ProductAdd.Visible = true;
            Home.Visible = false;

        }

        private void 查詢產品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasingHistory.Visible = false;
            Purchasing.Visible = false;
            OrderQuery.Visible = false;
            Order.Visible = false;
            ProductQuery.Visible = true;
            Stock.Visible = false;
            ProductAdd.Visible = false;
            Home.Visible = false;

            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            var q = from i in DBContext.tOrderDetails
                    join o in DBContext.tOrders
                    on i.OrderID equals o.OrderID
                    join p in DBContext.tNewProducts
                    on i.ProductID equals p.ProductID
                    group i by p.ProductName into g
                    select new { ProductName = g.Key,  Total = g.Sum(r => r.subtotal) };

            chart2.DataSource= q.ToList();
            this.chart2.Series[0].XValueMember = "ProductName";
            this.chart2.Series[0].YValueMembers = "ProductName";
            this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;



        }

        private void 新增訂單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasingHistory.Visible = false;
            Purchasing.Visible = false;
            OrderQuery.Visible = false;
            Order.Visible = true;
            ProductQuery.Visible = false;
            Stock.Visible = false;
            ProductAdd.Visible = false;
            Home.Visible = false;
        }

        private void 查詢訂單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasingHistory.Visible = false;
            Purchasing.Visible = false;
            OrderQuery.Visible = true;
            Order.Visible = false;
            ProductQuery.Visible = false;
            Stock.Visible = false;
            ProductAdd.Visible = false;
            Home.Visible = false;
            QueryForOrder();

            var q = from o in DBContext.tOrders
                    join od in DBContext.tOrderDetails
                    on o.OrderID equals od.OrderID
                    join p in DBContext.tNewProducts
                    on od.ProductID equals p.ProductID               
                    group o by p.ProductName into g
                    select new { MyKey = g.Key, Revenue = g.Sum(od => od.TotalPrice)};  //select 匿名型別

            this.chart2.DataSource = q.ToList();
            this.chart2.Series.Clear();
            this.chart2.Series.Add("Orders By Month");
            this.chart2.Series[0].XValueMember = "MyKey";
            this.chart2.Series[0].YValueMembers = "Revenue";
            this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart2.Series[0].BorderWidth = 4;
        }

        private void 新品採購ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasingHistory.Visible = false;
            Purchasing.Visible = true;
            OrderQuery.Visible = false;
            Order.Visible = false;
            ProductQuery.Visible = false;
            Stock.Visible = false;
            ProductAdd.Visible = false;
            Home.Visible = false;

            //以下選取PO============================================
            clearmethod();
            UpdatePOID();

            ////以下選取產品自動填入===========================================

            //productIDTextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //productIDTextBox1.AutoCompleteCustomSource = autoProduct;
            //productIDTextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //以下付款方式自動填入===========================================

            var paymentMethod1 = from pi in DBContext.tPaymentMethods
                                 select pi.PaymentMethod;

            foreach (string i in paymentMethod1)
            {
                comboBoxPaymentMethod.Items.Add(i);
            }

            //以下貨幣自動填入=============================================

            var currency = from c in DBContext.tCurrencies
                           select c.Currency;

            currencyIDCB.DataSource = currency.ToList();
        }

        private void UpdatePOID()
        {
            var q = (from p in DBContext.tPurchasingOrders
                     orderby p.PurchasingOrderID descending
                     select p.PurchasingOrderID).FirstOrDefault();

            PurchasingID = q + 1;
            purchasingOrderIDTextBox.Text = (q + 1).ToString();
        }

        public int PurchasingID { get; set; }

        private void 歷史查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasingHistory.Visible = true;
            Purchasing.Visible = false;
            OrderQuery.Visible = false;
            Order.Visible = false;
            ProductQuery.Visible = false;
            Stock.Visible = false;
            ProductAdd.Visible = false;
            Home.Visible = false;

            //以下datagridview 顯示採購商品的記錄

            var q = 
                    from po in DBContext.tPurchasingOrderDetails
                    join i in this.DBContext.tPurchasingOrders
                    on po.PurchasingOrderID equals i.PurchasingOrderID
                    join p in this.DBContext.tNewProducts 
                    on po.ProductID equals p.ProductID
                    select new { i.PurchasingOrderID, i.PurchasingDate, i.ServiceFee, i.ShippingFee, p.ProductName, p.Color, po.SubTotal };

            dataGridView5.DataSource = q.ToList();

        }

        private void 庫存查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasingHistory.Visible = false;
            Purchasing.Visible = false;
            OrderQuery.Visible = false;
            Order.Visible = false;
            ProductQuery.Visible = false;
            Stock.Visible = true;
            ProductAdd.Visible = false;
            Home.Visible = false;

            var q = from i in DBContext.tNewProducts
                    where i.ReoderLevel > i.Stock
                    select i;
            dataGridView4.DataSource = q.ToList();


        }

        private void newProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.newProductBindingSource.EndEdit();
                this.newProductTableAdapter.Update(this.mist126_27DataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("請檢查你輸入的資料是否正確!");
            }
            CheckStock();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {

                CheckPhotoexist cx = new CheckPhotoexist();
                //bool a = cx.CheckPhoto();
                //if (a)
                //{
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Visible = false;
                    picturePictureBox.Visible = true;
                    txtFilename.Text = picturePictureBox.ImageLocation = openFileDialog1.FileName;
                    string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
                    string strSQL = "insert into Pictures(ProductID, Picture) values (@ProductID, @Picture)";
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                        {
                            using (FileStream fs = new FileStream(txtFilename.Text, FileMode.Open, FileAccess.Read))
                            {
                                cmd.CommandType = CommandType.Text;

                                SqlParameter p = new SqlParameter("@Picture", SqlDbType.VarBinary);
                                p.Direction = ParameterDirection.Input;
                                byte[] data = new byte[fs.Length];
                                fs.Read(data, 0, (int)fs.Length);
                                p.Value = data;
                                cmd.Parameters.Add(p);

                                SqlParameter pID = new SqlParameter("@ProductID", SqlDbType.Int);
                                pID.Direction = ParameterDirection.Input;
                                pID.Value = productIDTextBox.Text;
                                cmd.Parameters.Add(pID);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                }
                //}
                //else

            }
            catch (Exception)
            {
                MessageBox.Show("圖片已存在!");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";


            var q = from p in DBContext.tNewProducts
                    where p.ProductName.Contains(txtSearch.Text) || p.Color == txtSearch.Text || p.Status == txtSearch.Text || p.Type.Contains(txtSearch.Text)
                    select p;

            newProductDataGridView.DataSource = q.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void opennewform(object obj)
        {
            Application.Run(new Login());
        }

        private void AddType_Click(object sender, EventArgs e)
        {
            FrmAddType at = new FrmAddType();
            at.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var q = from p in DBContext.tNewProducts
                    select p;

            newProductDataGridView.DataSource = q.ToList();

        }


        private void productIDTextBox_TextChanged_1(object sender, EventArgs e)
        {
            //try
            //{
            if (productIDTextBox.Text != null)
            {
                string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
                string strSQL = "select Picture from Pictures where ProductID = @ProductID";
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productIDTextBox.Text));
                conn.Open();
                byte[] data = (byte[])cmd.ExecuteScalar();
                cmd.Dispose();
                MemoryStream ms = new MemoryStream(data);
                Bitmap bmp = new Bitmap(ms);
                pictureBox1.Image = bmp;
                ms.Close();
                ms.Dispose();
                conn.Close();
                conn.Dispose();



            }

            //}
            //catch { }



            //foreach (var i in q)
            //{
            //    this.pictureBox1.Image = Image.FromStream(new MemoryStream(i));
            //}

            //pictureBox1.Image = 



            //if (productIDTextBox.Text != "")
            //{
            //    string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
            //    string strSQL = "select Picture from Pictures where ProductID = @ProductID";
            //    SqlConnection conn = new SqlConnection(strConn);
            //    SqlCommand cmd = new SqlCommand(strSQL, conn);
            //    cmd.CommandType = CommandType.Text;

            //    cmd.Parameters.AddWithValue("@ProductID", int.Parse( productIDTextBox.Text));
            //    conn.Open();
            //    byte[] data = (byte[])cmd.ExecuteScalar();
            //    cmd.Dispose();
            //    MemoryStream ms = new MemoryStream(data);
            //    Bitmap bmp = new Bitmap(ms);
            //    pictureBox1.Image = bmp;
            //    ms.Close();
            //    ms.Dispose();
            //    conn.Close();
            //    conn.Dispose();
            //}
        }
        private void productIDTextBox_TextChanged(object sender, EventArgs e)
        {


        }



        private void typeComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.productTypeTableAdapter.Fill(this.mist126_27DataSet.ProductType);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var q = from p in DBContext.tNewProducts
                    select p;

            newProductDataGridView.DataSource = q.ToList();
        }


        //以下Order 頁的儲存===========================================
        DateTime dateTime = DateTime.Now;
        private void save_Click(object sender, EventArgs e)
        {
            DateTime dateTime = orderDateDateTimePicker.Value;
            if (customerIDTextBox.Text != "" && cbxPid.Text != "" && bidFeeTextBox.Text != "" && shippingFeeTextBox.Text != "" && totalPriceTextBox.Text != "")
            {
                //以下Order分頁上半部份SAVE=====================================================
                tCustomer c = new tCustomer { Account = customerIDTextBox.Text, PlatformID = cbxPid.SelectedIndex + 1 };
                this.DBContext.tCustomers.Add(c);
                this.DBContext.SaveChanges();

                var cust = from cu in DBContext.tCustomers
                           where cu.Account == customerIDTextBox.Text
                           select cu.CustomerID;

                List<int> a = cust.ToList();

                int oorderID = int.Parse(orderIDTextBox.Text);

                int total = 0;
                for (int i = 0; i < dataTable1DataGridView.Rows.Count - 1; i++)
                {
                    string x = dataTable1DataGridView.Rows[i].Cells["SubTotal"].Value.ToString();
                    int z = int.Parse(x);
                    total = z + total;
                }


                tOrder o = new tOrder { OrderDate = dateTime, PlatformID = cbxPid.SelectedIndex + 1, BidFee = int.Parse(bidFeeTextBox.Text), CustomerID = a[0], ShippingFee = int.Parse(shippingFeeTextBox.Text), TotalPrice = total };
                this.DBContext.tOrders.Add(o);
                int save = this.DBContext.SaveChanges();
                MessageBox.Show($"有 {save} 筆記錄成功新增");

                //以下SAVE datagridview=========================================================

                //string productName; 測試中 未完成 Foregin key 問題
                try
                {
                    if (save > 0)
                    {
                        for (int i = 0; i < dataTable1DataGridView.Rows.Count - 1; i++)
                        {
                            int orderID = oorderID;
                            string ProductName = dataTable1DataGridView.Rows[i].Cells["ProductName"].Value.ToString();
                            string ProductColor = dataTable1DataGridView.Rows[i].Cells["proudctColor"].Value.ToString();
                            string price = dataTable1DataGridView.Rows[i].Cells["Price"].Value.ToString();
                            int intPrice = int.Parse(price);
                            string discount = dataTable1DataGridView.Rows[i].Cells["Discount"].Value.ToString();
                            int intDiscount = Convert.ToInt32(discount);
                            string quantity = dataTable1DataGridView.Rows[i].Cells["Quantity"].Value.ToString();
                            int intQuantity = int.Parse(quantity);
                            string sub = dataTable1DataGridView.Rows[i].Cells["SubTotal"].Value.ToString();
                            int intSub = int.Parse(sub);

                            var pid = from p1 in DBContext.tNewProducts
                                      where p1.ProductName == ProductName && p1.Color == ProductColor
                                      select p1.ProductID;

                            List<int> x = pid.ToList();

                            var test = new tOrderDetail { OrderID = orderID, ProductID = x[0], Price = intPrice, Discount = intDiscount, Quantity = intQuantity, subtotal = intSub };
                            DBContext.tOrderDetails.Add(test);
                            this.DBContext.SaveChanges();

                        }
                    }
                }
                catch
                {

                }
                //===========================================================

                this.Read_RefreshDataGridView();

                DataRefresh();
            }
            else
            {
                MessageBox.Show("請輸入所需資料!");
            }
        }

        private void DataRefresh()
        {
            customerIDTextBox.Text = null;
            bidFeeTextBox.Text = null;
            totalPriceTextBox.Text = null;
            label4.Text = "";
            label7.Text = "";
            CallOderID();
            dataTable1DataGridView.Rows.Clear();
        }

        private void Read_RefreshDataGridView()
        {

        }

        private void orderDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bidFeeTextBox_TextChanged(object sender, EventArgs e)
        {
            bool x = testnum(bidFeeTextBox.Text);
            if (!x)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "請輸入數字";
            }
            else
                label4.Text = "";
        }

        private bool testnum(string txt)
        {
            int result = 0;
            int.TryParse(txt, out result);
            if (result == 0)
            {
                return false;
            }
            else
                return true;
        }

        private void shippingFeeTextBox_TextChanged(object sender, EventArgs e)
        {
            bool x = testnum(shippingFeeTextBox.Text);
            if (!x)
            {
                label7.ForeColor = Color.Red;
                label7.Text = "請輸入數字";
            }
            else
                label7.Text = "";
        }


        //private void totalPriceTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    bool x = testnum(totalPriceTextBox.Text);
        //    if (!x)
        //    {
        //        label6.ForeColor = Color.Red;
        //        label6.Text = "請輸入數字";
        //    }
        //    else
        //        label6.Text = "";
        //}

        private void dataTable1DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataTable1DataGridView.CurrentCell.ColumnIndex == 0)
            {
                TextBox prodCode = e.Control as TextBox;
                if (prodCode != null)
                {
                    prodCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    prodCode.AutoCompleteCustomSource = autoProduct;
                    prodCode.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
            }
            else
            {
                TextBox prodCode = e.Control as TextBox;
                if (prodCode != null)
                {
                    prodCode.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }

        //以下DataGridView 資料連動=====================================
        string productNameCellValue;
        int xRowIndex;

        private void dataTable1DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dataTable1DataGridView.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.GetType();
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        productNameCellValue = dataTable1DataGridView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                        xRowIndex = e.RowIndex;

                        if (productNameCellValue != "")
                        {
                            var q = from p in DBContext.tNewProducts
                                    where p.ProductName == productNameCellValue
                                    select p.Color;

                            DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)dataTable1DataGridView.Rows[xRowIndex].Cells["proudctColor"];
                            cbCell.DataSource = q.ToList();
                        }
                        else
                            MessageBox.Show("請先選取產品!");
                        break;
                    case 1:
                        string productColor = dataTable1DataGridView.Rows[e.RowIndex].Cells["proudctColor"].Value.ToString();
                        if (productColor != null)
                        {
                            var price = from p1 in DBContext.tNewProducts
                                        where p1.ProductName == productNameCellValue && p1.Color == productColor
                                        select p1.Price;
                            //DataGridViewComboBoxCell cbPrice = (DataGridViewComboBoxCell)dataTable1DataGridView.Rows[xRowIndex].Cells["proudctColor"];
                            List<int> x = price.ToList();

                            dataTable1DataGridView.Rows[e.RowIndex].Cells["Price"].Value = x[0];
                        }
                        break;
                }
            }
            catch
            {

            }
            try
            {
                string p = dataTable1DataGridView.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string q = dataTable1DataGridView.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                string d = dataTable1DataGridView.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
                int dpPrice = int.Parse(p);
                int dpQuantity = int.Parse(q);
                int dpDiscount = Convert.ToInt32(d);
                dataTable1DataGridView.Rows[e.RowIndex].Cells["SubTotal"].Value = dpPrice * dpQuantity * (100 - dpDiscount) / 100;

                TotalCount();


            }
            catch (Exception)
            {

            }
        }


        private void TotalCount()
        {
            int total = 0;
            for (int i = 0; i < dataTable1DataGridView.Rows.Count - 1; i++)
            {
                string x = dataTable1DataGridView.Rows[i].Cells["SubTotal"].Value.ToString();
                int z = int.Parse(x);
                total = z + total;
            }

            totalPriceTextBox.Text = total.ToString();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            QueryForOrder();      

        }

        private void QueryForOrder()
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            var q = from i in DBContext.tOrderDetails
                    join o in DBContext.tOrders
                    on i.OrderID equals o.OrderID
                    join p in DBContext.tNewProducts
                    on i.ProductID equals p.ProductID
                    where o.OrderDate >= startDate && o.OrderDate <= endDate 
                    select new { o.OrderDate, i.OrderID, p.ProductName, i.Price, i.Quantity };

            this.bindingSource1.DataSource = q.ToList();

            this.dataGridView2.DataSource = this.bindingSource1;
        }

    
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //NOTE
                var OrderID = ((mist126_27DataSet.OrdersRow)this.bindingSource1.Current).OrderID;

                var q = from o in this.mist126_27DataSet.OrderDetail
                        where o.OrderID == OrderID
                        select o;

                //this.dataGridView1.DataSource = q.ToList();

            }
            catch
            {

            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //try
            //{
            var cur = (from i in DBContext.tCurrencies
                       where i.Currency == currencyIDCB.Text
                       select i.CurrencyID).ToList().FirstOrDefault();

            var pi = (from pm in DBContext.tPaymentMethods
                      where pm.PaymentMethod == comboBoxPaymentMethod.Text
                      select pm.PaymentMethodID).ToList().FirstOrDefault();

            var user = (from u in DBContext.tUsers
                        where u.UserName == ClassLogin.userName
                        select u.UserID).ToList().FirstOrDefault();

            tPurchasingOrder purchasingOrder = new tPurchasingOrder { ShippingFee = int.Parse(shippingFeeTextBox1.Text), CurrencyID = cur, PaymentMethodID = pi, ServiceFee = Convert.ToDecimal(serviceFeeTextBox.Text), tariff = Convert.ToDecimal(importDutyTextBox.Text), PurchasingDate = purchasingDateDateTimePicker.Value/*, UserID = user*/ };
            this.DBContext.tPurchasingOrders.Add(purchasingOrder);
            int x = this.DBContext.SaveChanges();

            if (AddNewProductData != null)
            {
                string color = AddNewProductData[1];
                string productname = AddNewProductData[0];

                var productID = (from pid in DBContext.tNewProducts
                                 where pid.Color == color && pid.ProductName == productname
                                 select pid.ProductID).ToList().FirstOrDefault();

                int quantity = Convert.ToInt32(AddNewProductData[2]);
                int unitprice = Convert.ToInt32(AddNewProductData[3]);
                int subtotal = Convert.ToInt32(AddNewProductData[4]);

                tPurchasingOrderDetail pod = new tPurchasingOrderDetail { ProductID = productID, PurchasingOrderID = PurchasingID, Quantity = quantity, UnitPrice = unitprice, SubTotal = subtotal };
                DBContext.tPurchasingOrderDetails.Add(pod);
                DBContext.SaveChanges();
            }

            if (AddNewProductData1 != null)
            {
                string color = AddNewProductData1[1];
                string productname = AddNewProductData1[0];

                var productID = (from pid in DBContext.tNewProducts
                                 where pid.Color == color && pid.ProductName == productname
                                 select pid.ProductID).ToList().FirstOrDefault();

                int quantity = Convert.ToInt32(AddNewProductData1[2]);
                int unitprice = Convert.ToInt32(AddNewProductData1[3]);
                int subtotal = Convert.ToInt32(AddNewProductData1[4]);

                tPurchasingOrderDetail pod = new tPurchasingOrderDetail { ProductID = productID, PurchasingOrderID = PurchasingID, Quantity = quantity, UnitPrice = unitprice, SubTotal = subtotal };
                DBContext.tPurchasingOrderDetails.Add(pod);
                DBContext.SaveChanges();
            }

            //foreach(var i in PO)
            //{
            //    DBContext.PurchasingOrderDetail.Add(i);
            //    DBContext.SaveChanges();
            //}

            MessageBox.Show($"己成功新增{x}筆記錄");

            clearmethod();
            UpdatePOID();
            //}
            //catch
            //{
            //    MessageBox.Show("請檢查資料是否正確填入!");
            //}
        }

        private void clearmethod()
        {
            shippingFeeTextBox1.Text = "";
            serviceFeeTextBox.Text = "";
            discountTextBox.Text = "";
            importDutyTextBox.Text = "";
            tariffTextBox.Text = "";
            totalPriceTextBox1.Text = "0";
            TotalPrice = 0;
            this.flowLayoutPanel1.Controls.Clear();

            if (AddNewProductData != null) {
                for (int i = 0; i <= AddNewProductData.Length - 1; i++)
                {
                    Array.Clear(AddNewProductData, i, 1);
                }
            }

        }


        private void currencyIDCB_Leave(object sender, EventArgs e)
        {
            label11.Text = currencyIDCB.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddNewProductUserControl1 us = new AddNewProductUserControl1();

            this.flowLayoutPanel1.Controls.Add(us);

            Application.DoEvents();
        }

        internal static int TotalPrice { get; set; }

        private void CalTotal_Click(object sender, EventArgs e)
        {
            totalPriceTextBox1.Text = TotalPrice.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PendingItemUserControl1 pu = new PendingItemUserControl1();
            flowLayoutPanel2.Controls.Add(pu);
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                dynamic d = this.bindingSource2.Current;
                this.dataGridView2.DataSource = d.MyGroup;  //this.dataGridView2.DataSource =( (IGrouping<int, FileInfo> ) d.MyGroup).ToList(); dynamic的一個小坑-- RuntimeBinderException：“object”未包含“xxx”的定義
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        // 以下pending Item 控制
        mist126_27Entities2 dbcontect2 = new mist126_27Entities2();
        internal static string pendingitemscontent;
        internal static bool pendingitemsCheckBoxStatus;

        private void savePendingItems_Click(object sender, EventArgs e)
        {

            PendingItem pendingItem = new PendingItem { Date = DateTime.Now, Contents = pendingitemscontent, CheckBox = pendingitemsCheckBoxStatus };
            dbcontect2.PendingItem.Add(pendingItem);
            int x = dbcontect2.SaveChanges();
            MessageBox.Show($"有{x}項待辦事項新增成功!");
            ClearPendingItem();
            pendingItemUpdate();
        }

        public int checkPendingPK()
        {
            var q = (from p in dbcontect2.PendingItem
                     orderby p.PendingPK descending
                     select p.PendingPK).FirstOrDefault();
            int x = q;
            return x;
        }

        private void ClearPendingItem()
        {
            pendingitemscontent = null;
            pendingitemsCheckBoxStatus = false;
        }

        private void pendingItemUpdate()
        {
            this.flowLayoutPanel2.Controls.Clear();
            var content = from pd in dbcontect2.PendingItem
                          where pd.CheckBox == false
                          select pd;

            foreach (var i in content)
            {
                PendingItemUserControl1 pend = new PendingItemUserControl1();
                pend.content = i.Contents;
                pend.pK = i.PendingPK;
                this.flowLayoutPanel2.Controls.Add(pend);
                Application.DoEvents();

            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(pendingdelete.Text);

            var q = (from i in dbcontect2.PendingItem
                     where i.PendingPK == x
                     select i).ToList().FirstOrDefault();

            if (x == null) return;
            this.dbcontect2.PendingItem.Remove(q);
            this.dbcontect2.SaveChanges();
            pendingItemUpdate();
        }

        private void dataGridView3_Leave(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            picturePictureBox.Visible = false;
            pictureBox1.Visible = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            picturePictureBox.Visible = false;
            pictureBox1.Visible = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            picturePictureBox.Visible = false;
            pictureBox1.Visible = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            picturePictureBox.Visible = false;
            pictureBox1.Visible = true;
        }

        private void 聊聊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChar frmChar = new FrmChar();
            frmChar.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            picturePictureBox.Visible = true;
            pictureBox1.Visible = false;
        }

        public static string[] AddNewProductData
        { get; set; }
        public static string[] AddNewProductData1
        { get; set; }

        private void dataGridView5_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //public static List<PurchasingOrderDetail> PO;
    }
}
