using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using PakturkDLL;

/// <summary>
/// Summary description for ManageCourses
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ManageCoursesWebService : System.Web.Services.WebService
{

    public ManageCoursesWebService()
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
    public string Delete_Course_BLL(string course)
    {
        string s;
        ManageCourses mc = new ManageCourses();
        s = mc.Delete_Course_DLL(course);
        return s;
    }
    [WebMethod]
    public string Add_Course_BLL(string course,string type)
    {
        string s;
        ManageCourses mc = new ManageCourses();
        s = mc.Add_Course_DLL(course,type);
        return s;
    }
    [WebMethod]
    public string Assign_To_Class_BLL(string course, string className)
    {
        string s;
        ManageCourses mc = new ManageCourses();
        s = mc.Assign_To_Class_DLL(course, className);
        return s;
    }

}

