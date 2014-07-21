using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace PakturkDLL
{
    public class Attendance
    {
        public string markAttendanceDLL(string rollNo, string date, string isPresent, int flag)
        {
            DateTime d = DateTime.Parse(date);
            string sid;
            string aid="0";
            SqlConnection conn = RegisterStudentToDB.ConnectDB();
            try
            {
                conn.Open();
                string getStudentID = "select StudentId from Student where StudentRollNo='" + rollNo + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getStudentID, conn);
                dabt.Fill(ds, "student");
                DataTable dt = ds.Tables["student"];
                sid = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                conn.Open();
                string check = "select AttandanceId from Attandance where StudentId='" + sid + "' and date='"+ d+"'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(check, conn);
                dabt.Fill(ds, "s");
                DataTable dt = ds.Tables["s"];
                if (ds.Tables[0].Rows.Count != 0)
                {
                    aid = ds.Tables[0].Rows[0][0].ToString();
                   
                    if (flag == 0)
                        return "false";
                }
                conn.Close();
                /*if (Int32.Parse(aid) > 0)
                { 
                }
                else
                    return "false";*/

            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                string markAttendance = null;
                conn.Open();
                /*if(isPresent.ToLower()=="p")
                {
                    markAttendance = "insert into Attandance values('"+ date +"',P,null,'"+ sid +"');SELECT @@ IDENTITY";
                }*/
                //else if (isPresent.ToLower() == "a")
                if(flag==0)//0 means inserting new attendance values
                {
                    markAttendance = "insert into Attandance values('" + d + "','" + isPresent + "',null,'" + sid + "'); SELECT @@IDENTITY ";
                }
                else if (flag == 1)//1 means query for updating exitisting attendance
                {
                    
                    markAttendance = "update Attandance set isPresent='"+ isPresent +"' where (date='"+ d +"' and StudentId= '"+ sid +"' )";
                    
                }
                SqlCommand cmd = new SqlCommand(markAttendance, conn);
                object ident;
                if (flag == 0)
                {
                    
                    ident = cmd.ExecuteScalar();
                    int AttendanceID = Int32.Parse(ident.ToString());
                    if (AttendanceID > 0)
                        return "true";
                
                }
                else if (flag == 1)
                {
                    cmd.ExecuteScalar();
                    
                    
                    return "true"; 
                }
                                        
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return "false";
        
        }

        public DataSet displayStudentsDLL(string className)
        {
            string cid = null;
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            try
            {
                conn.Open();
                string getClassID = "select ClassId from Class where ClassName='" + className + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getClassID, conn);
                dabt.Fill(ds, "Class");
                DataTable dt = ds.Tables["Class"];
                cid = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();

            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                conn.Open();

                string getStudents = "select StudentRollNo from Student where Class_id='" + cid + "'";
                DataSet dsStudents = new DataSet();
                SqlDataAdapter dast = new SqlDataAdapter(getStudents, conn);
                dast.Fill(dsStudents, "student");
                DataTable dtStudents = dsStudents.Tables["student"];
                //string rollNo = dsStudents.Tables[0].Rows[0][0].ToString();

                conn.Close();
                return dsStudents;
            
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        public string display4UpdateStudentsDLL(string rollNo, string date)
        {
            string sid = null;
            DateTime d = DateTime.Parse(date);
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            try
            {
                conn.Open();
                string getStudentID = "select StudentId from Student where StudentRollNo='" + rollNo + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getStudentID, conn);
                dabt.Fill(ds, "Student");
                DataTable dt = ds.Tables["Student"];
                sid = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();

            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                conn.Open();

                string getStudents = "select  isPresent from Attandance where (StudentId='" + sid + "' and date='"+ d +"')";
                DataSet dsStudents = new DataSet();
                SqlDataAdapter dast = new SqlDataAdapter(getStudents, conn);
                dast.Fill(dsStudents, "present");
                DataTable dtStudents = dsStudents.Tables["present"];
                string isP;
                if(dsStudents.Tables[0].Rows.Count==0)
                    return "false";
                isP = dsStudents.Tables[0].Rows[0][0].ToString();


                conn.Close();
                if (isP == "A")
                    return rollNo;
                else
                    return "P";
                //return absentRollNo;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void getStudentDetailsDLL(string userName,ref string fName,ref string lName, ref string rollNo)
        {
            string sid;
            string lid;
            string uid;
            SqlConnection conn = RegisterStudentToDB.ConnectDB();

            try
            {
                conn.Open();
                lid = "select LoginId from Login where UserName='" + userName + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(lid, conn);
                dabt.Fill(ds, "l");
                DataTable dt = ds.Tables["l"];
                lid = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
            
            }
            catch (Exception)
            {
                throw;
            }
            
            try
            {
                conn.Open();
                string getName = "select UserId,FName,LName from Userz where Login_Id='" + lid + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getName, conn);
                dabt.Fill(ds, "Student");
                DataTable dt = ds.Tables["Student"];
                
                uid = ds.Tables[0].Rows[0][0].ToString();
                fName = ds.Tables[0].Rows[0][1].ToString();
                lName = ds.Tables[0].Rows[0][2].ToString();
                
                conn.Close();
            
            }
            catch (Exception)
            {
                throw;
            }
            
            try
            {
                conn.Open();
                string getRollNo = "select StudentRollNo from Student where UserId='" + uid + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getRollNo, conn);
                dabt.Fill(ds, "Std");
                DataTable dt = ds.Tables["Std"];

                rollNo = ds.Tables[0].Rows[0][0].ToString();

                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            

        }

        public DataSet getAttendanceDLL(string rollNo)
        {
            string sid;
            string lid;
            string aid;
            SqlConnection conn = RegisterStudentToDB.ConnectDB();

            try
            {
                conn.Open();
                string getStudentID = "select StudentId from Student where StudentRollNo='" + rollNo + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getStudentID, conn);
                dabt.Fill(ds, "Student");
                DataTable dt = ds.Tables["Student"];
                sid = ds.Tables[0].Rows[0][0].ToString();
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                conn.Open();
                string getAttendance = "select date,isPresent from Attandance where StudentId='" + sid + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getAttendance, conn);
                dabt.Fill(ds, "Student");
                DataTable dt = ds.Tables["Student"];
                //aid = ds.Tables[0].Rows[0][1].ToString();               
                conn.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
