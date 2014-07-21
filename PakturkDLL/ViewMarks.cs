using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PakturkDLL
{
    public class ViewMarks
    {
        public DataSet getMarks4StudentsDLL(string rollNo)
        {
            DataSet s=new DataSet();
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            long sid = 0;
            string getStudentId = "select StudentId from Student where  StudentRollNo= '" + rollNo + "'";
            try
            {
                conn.Open();

                SqlDataAdapter CourseDetails = new SqlDataAdapter(getStudentId, conn);
                DataSet ds = new DataSet();
                CourseDetails.Fill(ds, "std");
                //conn.Close();
                DataTable dt = ds.Tables["std"];
                sid = long.Parse(ds.Tables[0].Rows[0][0].ToString());
                
                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }

            string getMarks = "select SubjectName,SubjectType,TotalMarks,ObtainedMarks,Test1Marks,Test2Marks,Test3Marks,Test4Marks,Test5Marks,Assignment1Marks,Assignment2Marks,Assignment3Marks,Assignment4Marks,Assignment5Marks,weightage from Subject s,Tests_Assignments a where  (s.StudentId= '" + sid + "' and a.TestId=s.Test_Id)";
            try
            {
                conn.Open();

                SqlDataAdapter CourseDetails = new SqlDataAdapter(getMarks, conn);
                s = new DataSet();
                CourseDetails.Fill(s, "marks");
                //conn.Close();
                DataTable dt = s.Tables["marks"];
                
                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }
            return s;
        }
        public string getMarks4TeacherDLL(string userName, string className, string subjectName, ref DataSet res)
        {
            DataSet s = new DataSet();
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            DataSet result = new DataSet();
            int lid,uid,stdid,cid,tid,subid;
            string getLoginId = "select LoginId from  Login where  UserName= '" + userName + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getLoginId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "login");

                DataTable dt = ds.Tables["login"];
                lid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }

           
            string getUserId = "select UserId from Userz where  Login_Id= '" + lid + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getUserId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "user");
                DataTable dt = ds.Tables["user"];
                uid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
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
            string getClassId = "select ClassId from Class where  ClassName= '" + className + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getClassId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "class");
                DataTable dt = ds.Tables["class"];
                if (ds.Tables[0].Rows.Count == 0)
                    return "This Class doesnt Exist";
                cid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            string getCourseId = "select CourseId from Courses where  CourseName= '" + subjectName + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getCourseId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "course");
                DataTable dt = ds.Tables["course"];
                if (ds.Tables[0].Rows.Count == 0)
                    return "This Subject doesnt Exist, Enter Again";
                subid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }


            int csid;
            string chkClassSubject= "select * from Subject where  (TeacherId= '" + tid + "' and ClassId='"+ cid +"' and SubjectName='"+ subjectName+"')";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(chkClassSubject, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "CS");
                DataTable dt = ds.Tables["CS"];
                if (ds.Tables[0].Rows.Count == 0)
                    return "This Subject is not Associated with this Class or you might not have been assigned to this class or subject., Enter Again";
                //csid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            string getAllMarks = "select StudentRollNo,SubjectName,SubjectType,TotalMarks,ObtainedMarks,Test1Marks,Test2Marks,Test3Marks,Test4Marks,Test5Marks,Assignment1Marks,Assignment2Marks,Assignment3Marks,Assignment4Marks,Assignment5Marks,weightage from Subject s,Tests_Assignments a, Student std where  (s.TeacherId= '" + tid + "' and s.ClassId= '" + cid + "' and s.SubjectName= '" + subjectName + "' and std.StudentId=s.StudentId and a.TestId=s.Test_Id)";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getAllMarks, conn);
                DataSet ds = new DataSet();
                marks.Fill(res, "allMarks");
                DataTable dt = res.Tables["allMarks"];
                if (res.Tables[0].Rows.Count == 0)
                    return "You have not yet entered marks for this subject. Go to Enter Marks Section.";
                //csid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }

            return "true";
        }

        public string enterStudentMarksDLL(string userName, string className, string subjectName, ref DataSet res)
        {
            DataSet s = new DataSet();
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            DataSet result = new DataSet();
            int lid, uid, stdid, cid, tid, subid;
            string getLoginId = "select LoginId from  Login where  UserName= '" + userName + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getLoginId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "login");

                DataTable dt = ds.Tables["login"];
                lid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }


            string getUserId = "select UserId from Userz where  Login_Id= '" + lid + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getUserId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "user");
                DataTable dt = ds.Tables["user"];
                uid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
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
            string getClassId = "select ClassId from Class where  ClassName= '" + className + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getClassId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "class");
                DataTable dt = ds.Tables["class"];
                if (ds.Tables[0].Rows.Count == 0)
                    return "This Class doesnt Exist";
                cid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            string cType;
            string getCourseId = "select CourseId,CourseType from Courses where  CourseName= '" + subjectName + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getCourseId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "course");
                DataTable dt = ds.Tables["course"];
                if (ds.Tables[0].Rows.Count == 0)
                    return "This Subject doesnt Exist, Enter Again";
                subid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                cType = ds.Tables[0].Rows[0][1].ToString();
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            
            string chkClassSubject = "select * from Subject where  (TeacherId= '" + tid + "' and ClassId='" + cid + "' and SubjectName='" + subjectName + "')";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(chkClassSubject, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "CS");
                DataTable dt = ds.Tables["CS"];
                if (ds.Tables[0].Rows.Count == 0)
                    return "This Subject is not Associated with this Class or you might not have been assigned to this class or subject., Enter Again";
                //csid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            string getClassStudents= "select StudentId from Student where Class_Id='"+ cid +"'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getClassStudents, conn);
                DataSet ds = new DataSet();
                marks.Fill(res, "std");
                DataTable dt = res.Tables["std"];
                if (res.Tables[0].Rows.Count == 0)
                    return "There are no students addmitted in this class yet.";
                //csid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            string getAllMarks = "select StudentRollNo,SubjectName,SubjectType,TotalMarks,ObtainedMarks,Test1Marks,Test2Marks,Test3Marks,Test4Marks,Test5Marks,Assignment1Marks,Assignment2Marks,Assignment3Marks,Assignment4Marks,Assignment5Marks,weightage from Subject s,Tests_Assignments a, Student std where  (s.TeacherId= '" + tid + "' and s.ClassId= '" + cid + "' and s.SubjectName= '" + subjectName + "' and std.StudentId=s.StudentId and a.TestId=s.Test_Id)";
            try
            {
                conn.Open();
                SqlDataAdapter marks = new SqlDataAdapter(getAllMarks, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "allMarks");
                DataTable dt = ds.Tables["allMarks"];
                if(ds.Tables[0].Rows.Count != 0)
                    return "Marks have all ready been entered for this subject. To view/update go back and select 'View/Update Marks'.";
                //csid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            int testId;
            for (int i = 0; i < res.Tables[0].Rows.Count; i++)
            {
                int a;
                testId = 0;
                a = Int32.Parse(res.Tables[0].Rows[i][0].ToString());
                string createMarksAreaInTest = "insert into Tests_Assignments values(null,null,null,null,null,null,null,null,null,null,50);SELECT @@IDENTITY";
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(createMarksAreaInTest, conn);
                    Object testIdent = cmd.ExecuteScalar();
                    testId = Int32.Parse(testIdent.ToString());
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw;
                }
                string createMarksAreaInSubject = "insert into Subject values('" + subjectName + "','" + cType + "',100,null,'" + testId + "','" + a + "','" + tid + "','" + cid + "');SELECT @@IDENTITY";
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(createMarksAreaInSubject, conn);
                    Object subIdent = cmd.ExecuteScalar();
                    //Id = Int32.Parse(testIdent.ToString());
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw;
                }
            
            }
            res.Clear();
            res.Reset();
            getAllMarks = "select StudentRollNo,SubjectName,SubjectType,TotalMarks,ObtainedMarks,Test1Marks,Test2Marks,Test3Marks,Test4Marks,Test5Marks,Assignment1Marks,Assignment2Marks,Assignment3Marks,Assignment4Marks,Assignment5Marks,weightage from Subject s,Tests_Assignments a, Student std where  (s.TeacherId= '" + tid + "' and s.ClassId= '" + cid + "' and s.SubjectName= '" + subjectName + "' and std.StudentId=s.StudentId and a.TestId=s.Test_Id)";
            try
            {
                conn.Open();
                SqlDataAdapter marks = new SqlDataAdapter(getAllMarks, conn);
                DataSet ds = new DataSet();
                marks.Fill(res, "allMarks");
                DataTable dt = res.Tables["allMarks"];
                if (res.Tables[0].Rows.Count == 0)
                    return "Memory allocation error.";
                //csid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            return "true";
        }
        public string saveStudentMarksDLL(string userName, string className, string subjectName,ref DataSet res)
        {
            DataSet s = new DataSet();
            SqlConnection conn = null;
            conn = RegisterStudentToDB.ConnectDB();
            DataSet result = new DataSet();
            int lid, uid, stdid, cid, tid, subid;
            string getLoginId = "select LoginId from  Login where  UserName= '" + userName + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getLoginId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "login");

                DataTable dt = ds.Tables["login"];
                lid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {

                throw;
            }


            string getUserId = "select UserId from Userz where  Login_Id= '" + lid + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getUserId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "user");
                DataTable dt = ds.Tables["user"];
                uid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
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
            string getClassId = "select ClassId from Class where  ClassName= '" + className + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getClassId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "class");
                DataTable dt = ds.Tables["class"];
                if (ds.Tables[0].Rows.Count == 0)
                    return "This Class doesnt Exist";
                cid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            string cType;
            string getCourseId = "select CourseId,CourseType from Courses where  CourseName= '" + subjectName + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getCourseId, conn);
                DataSet ds = new DataSet();
                marks.Fill(ds, "course");
                DataTable dt = ds.Tables["course"];
                if (ds.Tables[0].Rows.Count == 0)
                    return "This Subject doesnt Exist, Enter Again";
                subid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                cType = ds.Tables[0].Rows[0][1].ToString();
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            DataSet std;
            string getClassStudents = "select StudentId from Student where Class_Id='" + cid + "'";
            try
            {
                conn.Open();

                SqlDataAdapter marks = new SqlDataAdapter(getClassStudents, conn);
                std = new DataSet();
                marks.Fill(std, "std");
                DataTable dt = std.Tables["std"];
                if (std.Tables[0].Rows.Count == 0)
                    return "There are no students addmitted in this class yet.";
                //csid = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                conn.Close();
            }
            catch (Exception e)
            {
                throw;
            }

            for (int i = 0; i < res.Tables[0].Rows.Count; i++)
            {
                string saveMarks = "update Subject set obtainedMarks='" + res.Tables[0].Rows[i][4] + "' where(TeacherId= '" + tid + "' and ClassId= '" + cid + "' and SubjectName= '" + subjectName + "' and StudentId='"+std.Tables[0].Rows[i][0]+"')";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(saveMarks, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    bool c = dr.HasRows;
                    //if (c)
                      //  return "Marks Saved Successfully.";
                    dr.Close();
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw;
                }
                string getTestId = "select Test_Id from Subject where(TeacherId= '" + tid + "' and ClassId= '" + cid + "' and SubjectName= '" + subjectName + "' and StudentId='" + std.Tables[0].Rows[i][0] + "')";
                int testId;
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(getTestId, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "t");
                    DataTable dt = ds.Tables["t"];
                    //if (ds.Tables[0].Rows.Count == 0)
                      //  return "problem in getting test id in Save part.";
                    testId = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw;
                }
                string saveMarksInTest = "update Tests_Assignments set Test1Marks='" + res.Tables[0].Rows[i][5] + "', Test2Marks='" + res.Tables[0].Rows[i][6] + "',Test3Marks='" + res.Tables[0].Rows[i][7] + "',Test4Marks='" + res.Tables[0].Rows[i][8] + "',Test5Marks='" + res.Tables[0].Rows[i][9] + "', Assignment1Marks='" + res.Tables[0].Rows[i][10] + "', Assignment2Marks='" + res.Tables[0].Rows[i][11] + "', Assignment3Marks='" + res.Tables[0].Rows[i][12] + "', Assignment4Marks='" + res.Tables[0].Rows[i][13] + "', Assignment5Marks='" + res.Tables[0].Rows[i][14] + "', Weightage='" + res.Tables[0].Rows[i][15] + "' where testId= '" + testId + "'";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(saveMarksInTest, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    bool c = dr.HasRows;
                    //if (c)
                      //  return "Marks Saved Successfully in Test.";
                    dr.Close();
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return "true";

        }

    }
}
