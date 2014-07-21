using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace PakturkDLL
{
    public class ManageTeacher
    {

        public bool makeIncharge(string cls, string teacher)
        {
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();

            int uid = 0;
            try
            {

                conn.Open();
                string getcourseid = "select UserId from Userz where (FName='" + teacher + "' and User_Type='teacher')";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getcourseid, conn);
                dabt.Fill(ds, "Userz");
                DataTable dt = ds.Tables["Userz"];
                string cid1 = ds.Tables[0].Rows[0][0].ToString();
                uid = Int32.Parse(cid1);
                conn.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            try
            {
                int cid = 0;
                conn.Open();
                string getclsid = "select ClassId from Class where ClassName='" + cls + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getclsid, conn);
                dabt.Fill(ds, "Class");
                DataTable dt = ds.Tables["Class"];
                string cid1 = ds.Tables[0].Rows[0][0].ToString();
                cid = Int32.Parse(cid1);
                if (cid!=0)
                {
                    SqlCommand cmd = null;
                    SqlDataReader dr = null;
                    string updateCmd = "UPDATE Teacher SET ClassIncharge='" +cid+"' WHERE User_Id='" + uid + "'";
                    cmd = new SqlCommand(updateCmd, conn);
                    dr = cmd.ExecuteReader();
                    bool i = dr.HasRows;
                    if (i)
                        return false;
                    dr.Close();

                    conn.Close();
                    return true;
                }





            }
            catch (Exception)
            {
                
                throw;
            }

            return false;
        }
        public bool assignSubjectToTeacher(string tName, string clname, string sbname,string sbt,string clsSec)
        {
            SqlConnection conn = null;
            int courseid = 0;
            int cid = 0;
            int uid = 0;
            int tid = 0;
            conn =RegisterStudentToDB.ConnectDB();
            try
            {
                conn.Open();
                string getcourseid = "select CourseID from Courses where CourseName='" + sbname + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getcourseid,conn);
                dabt.Fill(ds, "Courses");
                DataTable dt = ds.Tables["Courses"];
                string cid1 = ds.Tables[0].Rows[0][0].ToString();
                courseid = Int32.Parse(cid1);
                //if(cid!=0)
                  //    return cid;

                
                conn.Close();

            }
            catch (Exception)
            {
                
                throw;
            }

            try
            {
                conn.Open();
                string getclassid = "select ClassId from Class where ClassName='" + clname + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getclassid, conn);
                dabt.Fill(ds, "Class");
                DataTable dt = ds.Tables["Class"];
                string cid1 = ds.Tables[0].Rows[0][0].ToString();
                cid = Int32.Parse(cid1);
                //if (cid != 0)
                  //  return cid;


                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }


            try
            {
                conn.Open();
                string getcourseid = "select UserId from Userz where (FName='" + tName + "' and User_Type='teacher')";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getcourseid, conn);
                dabt.Fill(ds, "Userz");
                DataTable dt = ds.Tables["Userz"];
                string cid1 = ds.Tables[0].Rows[0][0].ToString();
                uid = Int32.Parse(cid1);
                //if (uid != 0)
                  //  return ;
                bool i;

                SqlCommand cmd = null;
                SqlDataReader dr = null;
                string updateCmd = "UPDATE Teacher SET Class_Id='" + cid + "',CourseId='"+courseid+"' WHERE User_Id='" + uid + "'";
                cmd = new SqlCommand(updateCmd, conn);
                dr = cmd.ExecuteReader();
                i = dr.HasRows;
                if (i)
                    return false;
                dr.Close();
                conn.Close();
                //return true;
            }
            catch (Exception)
            {

                throw;
            }
            string getTeacherId = "select TeacherId from Teacher where  User_Id= '" + uid + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getTeacherId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "teacher");
                DataTable dt = ds.Tables["teacher"];
                tid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }

            string insertSubject = "insert into Subject values('" + sbname + "','" + sbt + "',100,null,null,null,'" + tid + "','" + cid + "')";

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(insertSubject, conn);
                Object subIdent = cmd.ExecuteScalar();
                //Id = Int32.Parse(testIdent.ToString());
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                throw;
            }
            

            return false;

        }
        public string getTeacherDetailsDLL(string tName)
        {
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            try
            {
                conn.Open();

                string getUserID = "select UserId from Userz where (FName='" + tName + "' and User_Type='teacher')";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getUserID, conn);
                dabt.Fill(ds, "Userz");
                DataTable dt = ds.Tables["Userz"];
                string uid = ds.Tables[0].Rows[0][0].ToString();

                string getClassIncharge = "select ClassIncharge from Teacher where User_Id='" + uid + "'";
                DataSet ds1 = new DataSet();
                dabt = new SqlDataAdapter(getClassIncharge, conn);
                dabt.Fill(ds1, "class");
                DataTable dt1 = ds1.Tables["class"];
                string classIncharge=null;
                if (ds1.Tables[0].Rows.Count==0)
                {
                    classIncharge = "0";
                    return classIncharge;
                }
                else
                {
                    classIncharge = ds1.Tables[0].Rows[0][0].ToString();
                }

                string getClassName = "select ClassName from Class where ClassId='" + classIncharge + "'";
                ds = new DataSet();
                dabt = new SqlDataAdapter(getClassName, conn);
                dabt.Fill(ds, "C");
                DataTable dt2 = ds.Tables["C"];
                if (ds.Tables[0].Rows.Count == 0)
                {
                    return "0";
                }
                string name = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
                
                return name;
                
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
