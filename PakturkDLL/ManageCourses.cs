using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PakturkDLL
{
    public class ManageCourses
    {
        
        public string Delete_Course_DLL(String course)
        {
            
            SqlConnection conn = RegisterStudentToDB.ConnectDB();
            string verifyCmd = "select CourseName from Courses where CourseName= '" + course + "'";
            //string loginCmd = "select LoginId from Login where UserName= '" + txtUsername + "' AND Password='" + txtPassword + "'";
            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(verifyCmd, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                bool i = dr.HasRows;
                if (!i)
                    return "No Such Course Exist.";

                dr.Close();
                string deleteCmd = "DELETE FROM Courses WHERE CourseName='" + course + "'";
                cmd = new SqlCommand(deleteCmd, conn);
                dr = cmd.ExecuteReader();
                i = dr.HasRows;
                if (i)
                    return "Course deletion error, try again.";

                dr.Close();
                conn.Close();
            }
            catch
            {
                throw;
            }

            return "Course Deleted Successfully."; 

            
        }
        public String Assign_To_Class_DLL(string course, string className)
        {
            //string course = course.ToLower();
            //string type = type.ToLower();
            string cid = null;
            long sid;
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            
            
            string courseName = null;
            string courseType = null;

            //string CreateLoginCmd = "insert into Login values('"+  txtUsername +"',123)";
            string getCourseDetails = "select CourseName,CourseType from Courses where CourseName = '" + course + "'";
            try
            {
                conn.Open();
                
                SqlDataAdapter CourseDetails = new SqlDataAdapter(getCourseDetails, conn);
                DataSet ds = new DataSet();
                CourseDetails.Fill(ds,"Courses");
                //conn.Close();
                DataTable dt = ds.Tables["Courses"];
                //sid = long.Parse(ds.Tables[0].Rows[0][0].ToString());
                courseName = ds.Tables[0].Rows[0][0].ToString();
                courseType = ds.Tables[0].Rows[0][1].ToString();
                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }
            try
            {
                conn.Open();
                string EnterSubjectCmd = "insert into Subject values('" + courseName + "','" + courseType + "', null, null, null,null,null,null);SELECT @@IDENTITY";
                SqlCommand cmd = new SqlCommand(EnterSubjectCmd, conn);
                Object subjectID=cmd.ExecuteScalar();
                sid = long.Parse(subjectID.ToString());
                conn.Close();

            }
            
            catch (Exception e)
            {

                throw;
            }
            try
            {  
                conn.Open();
                string checkDuplicatonClassCmd = "select * from Class where ClassName = '" + className + "'";
          
                SqlCommand cmd = new SqlCommand(checkDuplicatonClassCmd, conn);
                SqlDataReader dr1 = cmd.ExecuteReader();
                bool i = dr1.HasRows;
                dr1.Close();
                
                if (i)
                {
                    string getClassID = "select * from Class where ClassName = '" + className + "'";
                    //conn.Open();
                    //SqlCommand cmd = new SqlCommand(CreateLoginCmd, conn);
                    //cmd.ExecuteScalar();

                    SqlDataAdapter ClassDetails = new SqlDataAdapter(getClassID, conn);
                    DataSet ds = new DataSet();
                    ClassDetails.Fill(ds, "Class");
                    //conn.Close();
                    DataTable dt = ds.Tables["Class"];
                    cid = ds.Tables[0].Rows[0][0].ToString();


                }
                else
                {
                    string EnterClassCmd = "insert into Class values(null, '" + className + "',null, null, null);SELECT @@IDENTITY";
                    cmd = new SqlCommand(EnterClassCmd, conn);
                    Object classID = cmd.ExecuteScalar();
                    cid = classID.ToString();
                }
                conn.Close();
                
            }
            catch (Exception e)
            {

                throw;
            }
            try
            {
                conn.Open();
                string EnterClassSubjectCmd = "insert into Class_Subjects values('" + cid + "','" + sid + "')";
                SqlCommand cmd = new SqlCommand(EnterClassSubjectCmd, conn);
                cmd.ExecuteScalar();


                conn.Close();
                return "true";
                
                
            }
            catch (Exception e)
            {

                throw;
            }

            return "false";
        }

        
        public string Add_Course_DLL(string course, string type)
        {
            course = course.ToLower();
            type = type.ToLower();
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            string checkDuplicatonCmd = "select * from Courses where CourseName = '" + course + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(checkDuplicatonCmd, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                bool i = dr.HasRows;
                if (i)
                    return "Course Already Exist";

                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }

            string AddCourseCommand = "insert into Courses values('" + course + "', '" + type + "')";
            //string AddCourseCommand = "insert into Sujects values('" + course + "', '" + type + "')";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(AddCourseCommand, conn);
                cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }

            return "Course Added Successfully";
        }

    }
}
