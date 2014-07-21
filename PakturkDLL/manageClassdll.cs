using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PakturkDLL
{
    public class manageClassdll
    {
        SqlDataAdapter obj;
        
        public bool updateclass(DataSet a)
        {
        //    obj.Update(ds1);
           // return true;
            SqlConnection conn = null;
            try
            {
                int capacity = Int32.Parse(a.Tables[0].Rows[0][1].ToString());
                int roomno = Int32.Parse(a.Tables[0].Rows[0][2].ToString());
                int roomid = Int32.Parse(a.Tables[0].Rows[0][0].ToString());
                conn = RegisterStudentToDB.ConnectDB();

                string update = "UPDATE ClassRooms SET ClassCapacity='" + capacity + "'"
                    + ",ClassROomNumber='" + roomno + "'"
                    + ",ClassRoomStatus='" + a.Tables[0].Rows[0][3].ToString() + "' "
                    + "WHERE (ClassRoomId='" + roomid +"')";
                conn.Open();
                SqlCommand cmd = null;
                SqlDataReader dr = null;
                bool i = false;
                cmd = new SqlCommand(update, conn);
                dr = cmd.ExecuteReader();
                i = dr.HasRows;
                if (i)
                    return true;
                dr.Close();
                conn.Close();
                return false;

            }
            catch (Exception)
            {
                
                throw;
            }
            
 
        }
        
         

        public DataSet getclassinfo(string clsname)
        {
            int clsnam = Int32.Parse(clsname);
            int cid = 0;
            //int crid = 0;
            try
            {

                SqlConnection conn = null;
                //int clsIdentity = 0;
                //object ident = null;
                //int cid = 0;

                conn = RegisterStudentToDB.ConnectDB();
                conn.Open();
                string getclassid = "select ClassRoom_Id from Class where ClassName='" + clsnam + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getclassid, conn);
                dabt.Fill(ds, "Class");
                DataTable dt = ds.Tables["Class"];
                if (ds.Tables[0].Rows.Count !=0)
                {
                    string cid1 = ds.Tables[0].Rows[0][0].ToString();
                     
                    cid = Int32.Parse(cid1);
                     

                }
                //return ds;
               if (cid!=0)
                {
                      
                    string getinfo = "select * from ClassRooms where (ClassRoomId='"+cid+"')";
                    obj = new SqlDataAdapter(getinfo, conn);
                    DataSet ds1 = new DataSet();
                    obj.Fill(ds1, "classinfo");
                    if (ds1.Tables[0].Rows.Count!=0)
                    {
                        return ds1;
                        
                    }
                  
                    
                }
                conn.Close();
                return ds;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public bool enterClassToDb(string clsname, string section, string roomno, string capacity, string st)
        {
            
            SqlConnection conn = null;
            int clsIdentity = 0;
            object ident = null;
            int cid = 0;
            

            try
            {
                conn = RegisterStudentToDB.ConnectDB();
                conn.Open();
                string getclassid = "select ClassId from Class where ClassName='" + clsname + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dabt = new SqlDataAdapter(getclassid, conn);
                dabt.Fill(ds, "Class");
                DataTable dt = ds.Tables["Class"];
                if (ds.Tables[0].Rows.Count !=0)
                {
                    string cid1 = ds.Tables[0].Rows[0][0].ToString();
                    cid = Int32.Parse(cid1);
                }
                 
                conn.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            
            if (cid !=0)
            {
                return false;
            }

            else
            {
                try
                {
                   // conn = RegisterStudentToDB.ConnectDB();
                    conn.Open();

                    string enterClassRoomInfo = "insert into ClassRooms values('" + capacity + "','" + roomno + "','" +st + "');SELECT @@IDENTITY ";
                    SqlCommand cmd = new SqlCommand(enterClassRoomInfo, conn);
                    ident = cmd.ExecuteScalar();

                    clsIdentity = Int32.Parse(ident.ToString());
                   // return clsIdentity;
                    conn.Close();
                    //return true;

                }
                catch(Exception)
                {
                    throw;
                }
                    
                try
                {
                    conn.Open();


                    string enterClassInfo = "insert into Class values('" + section + "','" + clsname + "','"+clsIdentity+"',null,null);SELECT @@IDENTITY ";
                    SqlCommand cmd = new SqlCommand(enterClassInfo, conn);
                    ident = cmd.ExecuteScalar();

                    clsIdentity = Int32.Parse(ident.ToString());
                    conn.Close();
                   /* string enterClassInfo = "insert into Class values('" + section + "','" + clsname + "','"+clsIdentity+"',null,null)";
                    SqlCommand cmd1 = new SqlCommand(enterClassInfo, conn);
                    ident = cmd1.ExecuteScalar();
                    conn.Close();*/
                    return true;
                    //return clsIdentity;

                }
                    
                catch (Exception)
                {

                    throw;
                }

                return false;
            }
        }

    }
}
