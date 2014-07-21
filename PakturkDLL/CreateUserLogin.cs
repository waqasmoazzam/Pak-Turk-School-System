using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PakturkDLL
{
    public class CreateUserLogin
    {
           
        public String CreateUser(string txtFName, string txtLName, string txtPhoneNo, string txtMobileNo, string txtEmail, string txtAddress, string txtUsername, string txtCountry, string comboUserType)
        {
            
            long CId = insertCountry(txtCountry);
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            string checkDuplicatonCmd = "select * from Login where UserName = '" + txtUsername + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(checkDuplicatonCmd, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                bool i = dr.HasRows;
                if (i)
                    return "user Already Exist";
                
                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }

            string LID = null;
            string CreateLoginCmd = "insert into Login values('"+  txtUsername +"',123)";
            string getLoginId = "select LoginId from Login where username = '" + txtUsername + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(CreateLoginCmd, conn);
                cmd.ExecuteScalar();

                SqlDataAdapter userLoginId = new SqlDataAdapter(getLoginId, conn);
                DataSet ds = new DataSet();
                userLoginId.Fill(ds,"Login");
              
                DataTable dt = ds.Tables["Login"];
                LID = ds.Tables[0].Rows[0][0].ToString();
                
                conn.Close();
                
            }
            catch (Exception e)
            {
                throw;
                
            }
            object ident=null;
            string createUserLoginCommand = "insert into Userz values('" + txtFName + "', '" + txtLName + "', '" + txtPhoneNo + "', '" + txtMobileNo + "', '" + txtEmail + "', '" + txtAddress + "', '" + LID + "', '" + comboUserType + "' , null , '" + CId + "');SELECT @@IDENTITY ";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(createUserLoginCommand, conn);
                ident=cmd.ExecuteScalar();
                conn.Close();
                long id = long.Parse(ident.ToString());
                if (comboUserType.ToLower() == "teacher")
                {
                    string enterTeacher = "insert into Teacher values(null,null,null,'"+id+"')";
                    conn.Open();
                    cmd = new SqlCommand(enterTeacher, conn);
                    cmd.ExecuteScalar();
                    conn.Close();
                }
                else if (comboUserType.ToLower() == "admin")
                {
                    string enterAdmin = "insert into Admin values('" + id + "')";
                    conn.Open();
                    cmd = new SqlCommand(enterAdmin, conn);
                    cmd.ExecuteScalar();
                    conn.Close();
                }
                return "true";

            }
            catch (Exception e)
            {

                throw;
            }
            return "false";
            
        }

        private static long insertCountry(string country)
        {
            long identity = 0;
            object ident = null;
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            string enterCountry = "insert into Country values('" + country + "'); SELECT @@IDENTITY ";
            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(enterCountry, conn);
                ident = cmd.ExecuteScalar();

                identity = long.Parse(ident.ToString());

                conn.Close();

                return identity;
            }
            catch (Exception e)
            {

                throw;
            }
        }

    }
}
