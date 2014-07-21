using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using PakturkDLL;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Summary description for AttendanceWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class AttendanceWebService : System.Web.Services.WebService
{

    public AttendanceWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public DataSet displayStudentsBLL(string className)
    {
        Attendance a = new Attendance();
        DataSet s=a.displayStudentsDLL(className);
        return s;

    }
    [WebMethod]
    public string display4UpdateStudentsBLL(string rollNo, string date)
    {
        Attendance a = new Attendance();
        string s=a.display4UpdateStudentsDLL(rollNo,date);
        return s;

    }
    
    [WebMethod]
    public string markAttendanceBLL(string rollNo, string date, string isPresent,int flag)
    {
        Attendance a = new Attendance();
        string s = a.markAttendanceDLL(rollNo,date,isPresent,flag);
        return s;   
    }
    
    [WebMethod]
    public void getStudentDetailsBLL(string userName, ref string fName,ref string lName, ref string rollNo)
    {
        Attendance a = new Attendance();
        a.getStudentDetailsDLL(userName,ref fName,ref lName,ref rollNo);
        //return s;

    
    }
    [WebMethod]
    public DataSet getAttendanceBLL(string rollNo)
    {
        Attendance a = new Attendance();
        
        DataSet ds=a.getAttendanceDLL(rollNo);
        return ds;

    
    }
    




}

