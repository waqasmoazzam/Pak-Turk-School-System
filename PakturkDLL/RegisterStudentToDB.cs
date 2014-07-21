using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PakturkDLL
{
    public class RegisterStudentToDB
    {
                       
             

            public static SqlConnection ConnectDB()
            {
                try
                {
                    //string connectionString = "Data Source=GULSOFTE-9D6F32\\SQLEXPRESS;Initial Catalog=School_System;Integrated Security=True";
                    string connectionString = "Data Source=BUTT-94DC6D2530\\SQLEXPRESS;Initial Catalog=School_System;Integrated Security=True";
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = connectionString;

                    conn.Open();
                    conn.Close();
                    return conn;
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            public string EnterStdRegData(String stdClass, string fName, string lName, string hPhone, string pMoblieNo, string stdEmail, string stdCountry, string stdCity, string stdStreetAddress)
            {
                long cId= insertCountery(stdCountry);

                long cityId=insertCity(stdCity, cId);

                string registrationId = RegisterStudent(stdClass);

                //long identity = 0;
                //object ident = null;
                string std = "student";
                SqlConnection conn = null;
                conn = ConnectDB();
                string enterCountry = "insert into Userz values('" + fName + "', '" + lName + "', '" + hPhone + "', '" + pMoblieNo + "', '" + stdEmail + "', '" + stdStreetAddress + "',null ,'"+std+"' ,'"+registrationId+"' , '" + cId + "')";
                try
                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand(enterCountry, conn);
                    cmd.ExecuteScalar();

                    //identity = long.Parse(ident.ToString());

                    conn.Close();

                    //return identity;
                }
                catch (Exception e)
                {

                    throw;
                }

                return registrationId;
            }

            private static string RegisterStudent(String stdClass)
            {
                string identity = null;
                object ident = null;
                SqlConnection conn = null;

                conn = ConnectDB();

                string register = "DECLARE @MyGUID uniqueidentifier SELECT @MyGUID = NewID() insert into Registration values(@MyGUID,'" + Convert.ToString(System.DateTime.Now) + "', '" + stdClass + "') SELECT @MyGUID AS MyGUID";

                try
                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand(register, conn);
                    ident = cmd.ExecuteScalar();

                    identity = ident.ToString();

                    conn.Close();

                    return identity;
                }
                catch (Exception e)
                {

                    throw;
                }
            }

            private static long insertCity(string stdCity, long cId)
            {
                long identity = 0;
                object ident = null;
                SqlConnection conn = null;
                conn = ConnectDB();
                string enterCountry = "insert into City values('" + stdCity + "', '" + cId + "'); SELECT @@IDENTITY ";
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

            private static long insertCountery(string country)
            {
                long identity = 0;
                object ident = null;
                SqlConnection conn = null;
                conn = ConnectDB();
                string enterCountry = "insert into Country values('"+country+"'); SELECT @@IDENTITY ";
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
