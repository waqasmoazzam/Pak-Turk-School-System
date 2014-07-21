using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PakturkDLL
{
    public class Login
    {

        public String login(string txtUsername, string txtPassword)
        {
            SqlConnection conn = RegisterStudentToDB.ConnectDB();
            string type = null;
            string verifyCmd = "select UserName, Password from Login where UserName= '" + txtUsername + "' AND Password='" + txtPassword + "'";
            string  loginCmd= "select LoginId from Login where UserName= '" + txtUsername + "' AND Password='" + txtPassword + "'";
            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(verifyCmd, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                bool i = dr.HasRows;
                if (!i)
                    return null;        // case: user name and password is incorrect.

                dr.Close();
                SqlDataAdapter userType = new SqlDataAdapter(loginCmd, conn);
                DataSet ds = new DataSet();
                userType.Fill(ds, "Login");
                conn.Close();
                DataTable dt = ds.Tables["Login"];
                string LID = ds.Tables[0].Rows[0][0].ToString();
                //conn.Close();
                //return LID;
                //conn.Open();
                string chkUserTypeCmd = "select * from Userz where Login_Id= '" + LID + "' ";
                userType = new SqlDataAdapter(chkUserTypeCmd, conn);
                DataSet ds1 = new DataSet();
                userType.Fill(ds1, "Userz");
                conn.Close();
                DataTable dt1 = ds1.Tables["Userz"];
                type = ds1.Tables[0].Rows[0][8].ToString();

                conn.Close();
            }
            catch
            {
                throw;
            }

            return type; 

        }
    }
}
