using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mist126_27
{
    public partial class Registeration : Form
    {
        
        private bool IsStrongPassword(string Password)
        {

            return Regex.IsMatch(Password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\-\+\?\*\$\[\]\^\.\(\)\|`~!@#%&_ ={}:;',/]).{8,16}$");
        }

        public Registeration()
        {
            InitializeComponent();
        }

        //public object FormsAuthentication { get; private set; }

        private void btnRegistraion_Click(object sender, EventArgs e)
        {
            txtUserNameError.Text = "";
            //txtUserName_TextChanged(sender, e);
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                txtUserNameError.Text = "";
                txtPasswordError.Text = "";
                txtReconfirmError.Text = "";
                if (txtUserName.Text == "" && txtPassword.Text == "")
                {
                    txtUserNameError.Text = "請輸入帳號";
                    txtPasswordError.Text = "請輸入密碼";
                }
                else 
                {
                    if (txtPassword.Text == "")
                    {
                        txtPasswordError.Text = "請輸入密碼";
                    }
                    else
                        txtUserNameError.Text = "請輸入帳號";
                }      
                
            }
            else
            {
                try
                {
                    txtUserNameError.Text = "";
                    txtPasswordError.Text = "";
                    txtReconfirmError.Text = "";


                    if (!IsStrongPassword(txtPassword.Text))
                    {
                        txtPasswordError.Text = "密碼必需由包含\n1. 大小寫英文字元\n2. 一個數目字\n3.一個特殊符號如$#@%!";
                    }
                    else
                    {
                        if (txtPassword.Text == txtPasswordCheck.Text)
                        {
                            string sqlselect = @"InsertUsers";

                            string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
                            SqlConnection conn = new SqlConnection(strConn);
                            SqlCommand cmd = new SqlCommand(sqlselect, conn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter pUsername = new SqlParameter("@Username", SqlDbType.VarChar, 20);
                            pUsername.Direction = ParameterDirection.Input;
                            pUsername.Value = txtUserName.Text;
                            cmd.Parameters.Add(pUsername);

                            SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.VarBinary, 32);
                            pPassword.Direction = ParameterDirection.Input;
                            byte[] bytesPassword = Encoding.Unicode.GetBytes(txtPassword.Text);
                            SHA256Managed Algorithm = new SHA256Managed();
                            pPassword.Value = Algorithm.ComputeHash(bytesPassword);
                            cmd.Parameters.Add(pPassword);

                            conn.Open();
                            int a = cmd.ExecuteNonQuery();
                            if(a>0)
                            {
                                MessageBox.Show("使用者已新增成功");
                            }
                            cmd.Dispose();
                            conn.Close();
                            conn.Dispose();

                        }
                        else
                        {
                            txtReconfirmError.Text = "你輸入的驗證密碼不正確";
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("請聯絡系統管理員!!");
                }
                
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(strConn);
            string sqlCheckUser = @"CheckUsers";
            SqlCommand cmdcheckuser = new SqlCommand(sqlCheckUser, conn);
            cmdcheckuser.CommandType = CommandType.StoredProcedure;

            
            SqlParameter checkUsername = new SqlParameter("@CheckUsername", SqlDbType.VarChar, 20);
            checkUsername.Direction = ParameterDirection.Input;
            checkUsername.Value = txtUserName.Text;
            cmdcheckuser.Parameters.Add(checkUsername);

            SqlParameter pReturnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            pReturnValue.Direction = ParameterDirection.ReturnValue;
            cmdcheckuser.Parameters.Add(pReturnValue);

            conn.Open();
            cmdcheckuser.ExecuteScalar();
            int a = Convert.ToInt32(cmdcheckuser.Parameters["@RETURN_VALUE"].Value);
            if (a == 1)
            {
                UsedUserNameError.Text = "帳戶名稱已被使用";
            }
            else
                UsedUserNameError.Text = "";

        }
    }
}
