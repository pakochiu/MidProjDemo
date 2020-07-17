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
    public partial class PendingItemUserControl1 : UserControl
    {
        public PendingItemUserControl1()
        {
            InitializeComponent();
        }

        public string content
        {
            set
            {
                this.richTextBox1.Text = value;
            }

        }

        public int pK       
        { set
            {
                label3.Text = value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            
            MainPage.pendingitemscontent = richTextBox1.Text;
            MainPage.pendingitemsCheckBoxStatus = checkBox1.Checked;
        }

        mist126_27Entities2 dbcontect = new mist126_27Entities2();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //dbcontect.PendingItem.Add
        }

    }
}
