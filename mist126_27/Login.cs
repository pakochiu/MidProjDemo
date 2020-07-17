using System;
using System.Windows.Forms;
using System.Threading;

namespace mist126_27
{
    public partial class Login : Form
    {
        
        Thread th;
        public Login()
        {
            InitializeComponent();            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClassLogin classLogin = new ClassLogin();
            int a = classLogin.LoginMethod(this.UserNameTextBox.Text, this.PasswordTextBox.Text);
            if(a == 1)
            {
                
                ClassLogin.userName = UserNameTextBox.Text;                
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("你輸入的使用者名稱或密碼不正確!");
            }
        }

        private void opennewform(object obj)
        {
            Application.Run(new MainPage());
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {    
            Registeration rg = new Registeration();
            rg.ShowDialog();
        }
    }
}
