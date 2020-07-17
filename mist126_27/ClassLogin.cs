using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace mist126_27
{
    class ClassLogin
    {
        public static string userName;
        public int LoginMethod(string UserName, String Password)
        {
            
            string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
            string sqlselect = "LoginCheck";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pUserName = new SqlParameter("@UserName", SqlDbType.VarChar, 20);
            pUserName.Direction = ParameterDirection.Input;
            pUserName.Value = UserName;
            cmd.Parameters.Add(pUserName);


            SqlParameter pPassword = new SqlParameter("@Password", SqlDbType.VarBinary, 32);
            pPassword.Direction = ParameterDirection.Input;
            byte[] bytePassword = Encoding.Unicode.GetBytes(Password);
            SHA256Managed Algorithm = new SHA256Managed();
            pPassword.Value = Algorithm.ComputeHash(bytePassword);
            cmd.Parameters.Add(pPassword);

            SqlParameter returnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(returnValue);


            conn.Open();
            cmd.ExecuteScalar(); //Select 語法多於一個值不能用 ExecuteScalar

            int a = Convert.ToInt32(cmd.Parameters["@RETURN_VALUE"].Value);

            return a;
        }
    }

    
}
