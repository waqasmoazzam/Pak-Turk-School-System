using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PakturkDLL
{
    public class EnterStudentAdmission
    {
        long medIdentity = 0;
        long clsIndentity = 0;
        object ident = null;
        string stdRollNo = null;
        public string DataToDB(int userid, string clas, string clsroom, string section, int vac, int normal, int deb, int hep)
        {
            enterMedicalInfo(vac, normal, deb, hep);
            EnterStudentClassInfo(clas, section);
            SqlConnection conn = null;
            try                
            {
                stdRollNo = clas + section + userid;
                conn = RegisterStudentToDB.ConnectDB();

                conn.Open();

                string enterClassInfo = "insert into Student values('" + stdRollNo + "','" + clsIndentity + "','" + userid + "','" + medIdentity + "','" + Convert.ToString(System.DateTime.Now) + "','"+clas+"');SELECT @@IDENTITY ";
                SqlCommand cmd = new SqlCommand(enterClassInfo, conn);
                ident = cmd.ExecuteScalar();

                clsIndentity = long.Parse(ident.ToString());

                conn.Close();
                return stdRollNo;
            }
            catch (Exception e)
            {


            }
            return null;

        }

        private void EnterStudentClassInfo(string clas, string section)
        {
            SqlConnection conn = null;
            try
            {
                conn = RegisterStudentToDB.ConnectDB();

                conn.Open();
                string checkDuplicate = "select ClassId from Class where ClassName='"+ clas +"'";
                SqlCommand cmd = new SqlCommand(checkDuplicate, conn);
                


                /*string enterClassInfo = "insert into Class values('" + section + "','" + clas + "',null,null,null);SELECT @@IDENTITY ";
                cmd = new SqlCommand(enterClassInfo, conn);*/
                ident = cmd.ExecuteScalar();

                clsIndentity = long.Parse(ident.ToString());

                conn.Close();
                
            }
            catch (Exception e)
            {


            }
             
        }

        private void enterMedicalInfo(int vac, int normal, int deb, int hep)
        {
            SqlConnection conn = null;
            try
            {
                conn = RegisterStudentToDB.ConnectDB();

                conn.Open();

                string enterMedicalInfo = "insert into MedicalInfo values('" + vac + "','" + deb + "','" + hep + "','" + normal + "');SELECT @@IDENTITY ";
                SqlCommand cmd = new SqlCommand(enterMedicalInfo, conn);
                ident = cmd.ExecuteScalar();

                medIdentity = long.Parse(ident.ToString());

                conn.Close();
                
            }
            catch (Exception e)
            {


            }
            
        }
    }
}
