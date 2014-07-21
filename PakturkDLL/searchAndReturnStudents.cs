using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PakturkDLL
{
    public class searchAndReturnStudents
    {
        private string fname;
        private string lname ;
        private string registrationNo ;
        private string cmd;

        public searchAndReturnStudents()
        {
              fname = null;
              lname = null;
              registrationNo=null;
              cmd = null;
        }
        public void SetInfo(DataSet ds)
        {
            registrationNo= ds.Tables["stdInfo"].Rows[0]["RgNo"].ToString();
            fname = ds.Tables["stdInfo"].Rows[0]["FN"].ToString();
            lname = ds.Tables["stdInfo"].Rows[0]["LN"].ToString();
             
                         
        }
        public void makeQuery()
        {
            if (registrationNo =="R")
            {
                cmd = "select UserId, FName, LName, PhoneNo, MobNo, EmailAdress, Address from Userz where(FName='" + fname + "') OR (LName='" + lname + "')";
                
            }
            else
            {
                cmd = "select UserId, FName, LName, PhoneNo, MobNo, EmailAdress, Address from Userz where (RegistrationId='" + registrationNo + "')";
            }
        }
        public void searchStudents(DataSet stdInfo)
        {
            SetInfo(stdInfo);
            makeQuery();
            SqlConnection conn = null;
            SqlDataAdapter stdDA= null;
            //DataSet stdDS = new DataSet(); ;, Country.CountryName AS Country, City.CityName AS City " +
 
            
            
            /*string cmd = " SELECT Registration.RegistraionDate, Registration.RegisteredInClass,Userz.FName AS 'Frist Name', Userz.LName AS 'Last Name', " +
                "Userz.PhoneNo AS 'Ph No', Userz.MobNo AS 'Mobile No', Userz.EmailAdress AS Email, Userz.Address " +
                "FROM Registration"+
                "INNER JOIN  Userz ON Registration.RegistrationId = Userz.RegistrationId " +
            "INNER JOIN Country ON Userz.Country_Id = Country.CountryId " +
            "INNER JOIN City ON Country.CountryId = City.CountryId " +
            "where ((Registration.RegistraionId='" + registrationNo + "') AND (Userz.FName='" + fname + "' ))" +
            " OR((Userz.FName='" + fname + "') AND (Userz.LName='" + lname + "')) " +
            " OR (Userz.FName='" + fname + "') OR (Userz.LName='" + lname + "') OR (City.CityName='" + city + "') OR (Country.CountryName='" + Country + "')";

            //"ORDER BY 'Frist Name', 'Last Name'"; */
            try
            {
                conn=RegisterStudentToDB.ConnectDB();
                conn.Open();
                stdDA = new SqlDataAdapter(cmd, conn);
                
                stdDA.Fill(stdInfo);
                return;
            }
            catch (Exception e)
            {
                e.StackTrace.GetType();
            }

        }
        /*
          try
            {
                SqlConnection conn = makeConnection();
                conn.Open();
                SqlDataAdapter dataAdapt=null;
                dataAdapt = new SqlDataAdapter(com, conn);
                int a = dataAdapt.Fill(data);
                if (data.Tables[1].Rows.Count==0)
                {
                    return false;
                }
                return true;
         * /
        
        /**/
    }
}
/*
 SELECT     Registration.RegistraionDate, Registration.RegisteredInClass, Userz.FName AS 'Frist Name', Userz.LName AS 'Last Name', 
                      Userz.PhoneNo AS 'Ph No', Userz.MobNo AS 'Mobile No', Userz.EmailAdress AS Email, Userz.Address, Country.CountryName AS Country, 
                      City.CityName AS City
FROM         Registration INNER JOIN
                      Userz ON Registration.RegistrationId = Userz.RegistrationId INNER JOIN
                      Country ON Userz.Country_Id = Country.CountryId INNER JOIN
                      City ON Country.CountryId = City.CountryId
         
ORDER BY 'Frist Name', 'Last Name'
 */