using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mist126_27
{


    public partial class AddNewProductUserControl1 : UserControl
    {

        public AddNewProductUserControl1()
        {
            InitializeComponent();
        }

        int Subtotal;

        MidProjectEntities DBContext = new MidProjectEntities();
        private void AddNewProductUserControl1_Load(object sender, EventArgs e)
        {
            //自動帶入上品名稱============================
            AutoCompleteStringCollection autoProduct;
            var pro = from p in DBContext.tNewProducts
                      select p.ProductName;

            autoProduct = new AutoCompleteStringCollection();
            foreach (string i in pro)
            {
                autoProduct.Add(i);
            }             


        productIDTextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            productIDTextBox1.AutoCompleteCustomSource = autoProduct;
            productIDTextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void productIDTextBox1_Leave(object sender, EventArgs e)
        {
            var color = from p in DBContext.tNewProducts
                        where p.ProductName == productIDTextBox1.Text
                        select p.Color;

            comboxColor.DataSource = color.ToList();
        }

        private void comboxColor_Leave(object sender, EventArgs e)
        {
            var q = (from p in DBContext.tNewProducts
                     where p.ProductName == productIDTextBox1.Text && p.Color == comboxColor.Text
                     select p.Price).FirstOrDefault();

            unitPriceTextBox.Text = q.ToString();
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            bool x = testnum(quantityTextBox.Text);
            if (x)
            {
                label1.Text = "";
            }
            else
                label1.Text = "請輸入數字!";
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

        private void quantityTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                SubTotal.Text = (Convert.ToInt32(quantityTextBox.Text) * Convert.ToInt32(unitPriceTextBox.Text) ).ToString();
                
            }
            catch { }
        }


        private void SubTotal_TextChanged(object sender, EventArgs e)
        {
            //這邊有bug總金額無限加不會減
            Subtotal = Convert.ToInt32(SubTotal.Text);
            MainPage.TotalPrice += Subtotal;

            var q = (from i in DBContext.tNewProducts
                    where i.ProductName == productIDTextBox1.Text && i.Color == comboxColor.Text
                    select i.ProductID).ToList().FirstOrDefault();

            string[] UC = { productIDTextBox1.Text, comboxColor.Text, quantityTextBox.Text, unitPriceTextBox.Text, SubTotal.Text };
            if(MainPage.AddNewProductData == null)
            {
                MainPage.AddNewProductData = UC;
            }
            else
            {
                MainPage.AddNewProductData1 = UC;
            }


            //decimal subtotal = Convert.ToDecimal(SubTotal.Text);
            //int unitprice = Convert.ToInt32(unitPriceTextBox.Text);
            //int quantity = Convert.ToInt32(quantityTextBox.Text);

            //MainPage mp = new MainPage();
            //MainPage.PO.Add(new PurchasingOrderDetail() { SubTotal = subtotal, UnitPrice = unitprice, Quantity = quantity,  ProductID = q });

        }
    }
}
