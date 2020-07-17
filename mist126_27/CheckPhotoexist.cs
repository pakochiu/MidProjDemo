using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mist126_27
{
    class CheckPhotoexist : MainPage
    {
        //public bool CheckPhoto()
        //{
        //    bool CheckPhotoResult;
        //    string strConn = ConfigurationManager.ConnectionStrings["mist126_27.Properties.Settings.mist126_27ConnectionString"].ConnectionString;
        //    string Query = "Select * from Pictures where ProductID = @ProductID";
        //    using (SqlConnection conn = new SqlConnection(strConn))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(Query, conn))
        //        {
        //                cmd.CommandType = CommandType.Text;
                    

        //                SqlParameter pID = new SqlParameter("@ProductID", SqlDbType.Int);
        //                pID.Direction = ParameterDirection.Input;
        //                pID.Value = productIDTextBox.Text;
        //                cmd.Parameters.Add(pID);

        //                conn.Open();
        //                cmd.ExecuteScalar();
        //            //if(i == 0)
        //            //{
        //            //    return CheckPhotoResult = false;
        //            //}
        //            //else
        //            return CheckPhotoResult = true;
        //        }
        //    }

        //}
    }
}
