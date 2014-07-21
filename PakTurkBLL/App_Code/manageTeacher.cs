using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;
using PakturkDLL;
/// <summary>
/// Summary description for manageTeacher
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class manageTeacher : System.Web.Services.WebService
{

    public manageTeacher()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]
    public bool assignSubject(string teacher, string ClsName, string subject,string subjectType,string classsection)
    {
        ManageTeacher obj = new ManageTeacher();
        return obj.assignSubjectToTeacher(teacher, ClsName, subject,subjectType,classsection);
    }
    [WebMethod]
    public bool makeClassIncharge(string cls,string inch)
    {
        ManageTeacher obj = new ManageTeacher();
        return obj.makeIncharge(cls, inch);
        
    }
    [WebMethod]
    public string getTeacherDetailsBLL(string tName)
    {
        ManageTeacher obj = new ManageTeacher();
        string s = obj.getTeacherDetailsDLL(tName);
        return s;
        
    }
    

}

