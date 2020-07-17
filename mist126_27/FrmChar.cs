using ChatControlLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mist126_27
{
    public partial class FrmChar : Form
    {
        public FrmChar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 userControl = new UserControl1();
            this.flowLayoutPanel1.Controls.Add(userControl);
        }
    }
}
