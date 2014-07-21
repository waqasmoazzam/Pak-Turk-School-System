using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PakturkDLL
{
    public class UpdateUser
    {
        SqlConnection conn;
        SqlDataAdapter dapt;
        DataSet ds;
        int loginid;
        public DataSet returnUserz()
        {
            conn = RegisterStudentToDB.ConnectDB();
            ds = new DataSet();
            string getUserQuery = "select UserName from Login";

            try
            {
                conn.Open();
                dapt = new SqlDataAdapter(getUserQuery, conn);
                dapt.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                    return ds;
                //dapt.Fill(
                conn.Close();
                return ds;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataSet getUserDetail(string userName)
        {



            try
            {
                conn = RegisterStudentToDB.ConnectDB();
                conn.Open();
                string getLoginId = "select LoginId from Login where username = '" + userName + "'";
                SqlDataAdapter userLoginId = new SqlDataAdapter(getLoginId, conn);
                DataSet ds1 = new DataSet();
                userLoginId.Fill(ds1);

                //DataTable dt = ds1.Tables["Login"];
                string lid = ds1.Tables[0].Rows[0][0].ToString();
                loginid = Int32.Parse(lid);
                conn.Close();
                //return ds1;
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                //DataSet ds2 = new DataSet();
                //conn = RegisterStudentToDB.ConnectDB();
                conn.Open();
                ds = new DataSet();
                string getuserdetail = "select FName as 'First Name', LName as 'Last Name',PhoneNo as 'Phone No', MobNo as 'Mobile No',EmailAdress as 'Email Address',Address as 'Home Address'"
                    + " from Userz where Login_Id='" + loginid + "'";

                SqlDataAdapter dapt2 = new SqlDataAdapter(getuserdetail, conn);
                dapt2.Fill(ds);
                //if (ds.Tables[0].Rows.Count>0)
                //{
                return ds;
                // }

            }
            catch (Exception)
            {

                throw;
            }
             
        }

        public bool editUserdetail(DataSet Ds,string userName)
        {
            
            string fname = Ds.Tables[0].Rows[0][0].ToString();
            string lname = Ds.Tables[0].Rows[0][1].ToString();
            string phoneNo = Ds.Tables[0].Rows[0][2].ToString();
            string Mob = Ds.Tables[0].Rows[0][3].ToString();
            string email = Ds.Tables[0].Rows[0][4].ToString();
            string homeadd = Ds.Tables[0].Rows[0][5].ToString();

            

            try
            {

                conn = RegisterStudentToDB.ConnectDB();
                conn.Open();
                string getLoginId = "select LoginId from Login where username = '" + userName + "'";
                SqlDataAdapter userLoginId = new SqlDataAdapter(getLoginId, conn);
                DataSet ds1 = new DataSet();
                userLoginId.Fill(ds1);

                //DataTable dt = ds1.Tables["Login"];
                string lid = ds1.Tables[0].Rows[0][0].ToString();
                loginid = Int32.Parse(lid);

                string updateuserdetail = "UPDATE Userz set FName='" + fname + "', LName ='" + lname + "',PhoneNo='" + phoneNo + "', MobNo ='" + Mob + "',EmailAdress='" + email + "',Address='" + homeadd + "'"
                + "where Login_Id='" + loginid + "'";
                SqlCommand cmd = null;
                //SqlDataReader dr = null;
                int dr = 0;
                cmd = new SqlCommand(updateuserdetail, conn);
                dr = cmd.ExecuteNonQuery();
                
                if (dr>0)
                    return true;
                conn.Close();

                return false;
            }
            catch (Exception)
            {

                throw;
            }
             
        }

    }
}
