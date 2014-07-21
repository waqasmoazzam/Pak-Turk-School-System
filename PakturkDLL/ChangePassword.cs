using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PakturkDLL
{
    public class ChangePassword
    {
        public String changePasswordDLL(string txtUsername, string txtPassword,string txtNewPassword, string ConfirmNewPassword,int flag)
        {
            SqlConnection conn = RegisterStudentToDB.ConnectDB();
            //string type = null;
            
            string verifyCmd = "select UserName, Password from Login where UserName= '" + txtUsername + "' AND Password='" + txtPassword + "'";
            
            string updateCmd = "UPDATE Login SET Password='" + txtNewPassword + "' WHERE UserName='" + txtUsername + "'";
            try
            {

                conn.Open();
                SqlCommand cmd;
                SqlDataReader dr;
                bool i;

                if (flag == 0)
                {
                    cmd = new SqlCommand(verifyCmd, conn);
                    dr = cmd.ExecuteReader();
                    i = dr.HasRows;
                    if (!i)
                        return " Old Password that you provided is Incorrect, Enter Again.";
                    dr.Close();
                }
                else if (flag == 1)
                {
                    verifyCmd = "select UserName from Login where UserName= '" + txtUsername + "'";
                    cmd = new SqlCommand(verifyCmd, conn);
                    dr = cmd.ExecuteReader();
                    i = dr.HasRows;
                    if (!i)
                        return " User does not exist, Enter Again.";
                    dr.Close();
                }

                cmd = new SqlCommand(updateCmd, conn);
                dr = cmd.ExecuteReader();
                i = dr.HasRows;
                if (i)
                    return "password updation failed.";
                dr.Close();
                conn.Close();
            }
            catch
            {
                throw;
            }

            return "Password Updated Successfully. Use your New Password now.";

        }

    }
}
