using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace mist126_27
{
    internal class MyConnect
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        internal static void Connect(string SqlCommand)
        {
            string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
            string sqlselect = SqlCommand;

            conn = new SqlConnection(strConn);
            cmd = new SqlCommand(sqlselect, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        internal static void myConnect(string SqlCommand)
        {
            string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
            string sqlselect = SqlCommand;

            conn = new SqlConnection(strConn);
            cmd = new SqlCommand(sqlselect, conn);
        }

        internal static void ConnectStoredPro(string StoredProcedureName, string StoredParam1, string textBoxUserName, string textBoxPassword, string StoredParam2)
        {
            string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
            string sqlselect = StoredProcedureName;

            conn = new SqlConnection(strConn);
            cmd = new SqlCommand(sqlselect, conn);
            cmd.CommandType = CommandType.StoredProcedure;            

            SqlParameter pUserName = new SqlParameter(StoredParam1, SqlDbType.VarChar, 20);
            pUserName.Direction = ParameterDirection.Output;
            pUserName.Value = textBoxUserName;
            cmd.Parameters.Add(pUserName);

            SqlParameter pPassword = new SqlParameter(StoredParam2, SqlDbType.VarBinary, 32);
            pPassword.Direction = ParameterDirection.Output;
            pPassword.Value = textBoxPassword;
            cmd.Parameters.Add(pPassword);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        internal static void ConnectStoredProInput(string StoredProcedureName, string StoredParam1, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
            string sqlselect = StoredProcedureName;

            conn = new SqlConnection(strConn);
            cmd = new SqlCommand(sqlselect, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pImage = new SqlParameter(StoredParam1, SqlDbType.VarBinary);
            pImage.Direction = ParameterDirection.Input;
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, (int)fs.Length);
            pImage.Value = data;
            cmd.Parameters.Add(pImage);
            
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        static void Disconnect()
        {
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }
    }


}
