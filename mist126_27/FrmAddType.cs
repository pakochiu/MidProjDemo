using System;
using System.Windows.Forms;

namespace mist126_27
{
    public partial class FrmAddType : Form
    {
        public FrmAddType()
        {
            InitializeComponent();
        }

        private void productTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productTypeBindingSource.EndEdit();
            int x = this.tableAdapterManager.UpdateAll(this.mist126_27DataSet);
            MessageBox.Show($"{x}筆記錄新增成功");

        }

        private void FrmAddType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mist126_27DataSet.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.mist126_27DataSet.ProductType);

        }
    }
}
