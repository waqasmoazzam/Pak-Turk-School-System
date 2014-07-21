using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using PakturkDLL;

/// <summary>
/// Summary description for AdmitStudent
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class AdmitStudent : System.Web.Services.WebService
{

    public AdmitStudent()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string enterStudentInfo(int userid,string clas, string clsroom, string section,int vac, int normal, int deb,int hep)
    {
        EnterStudentAdmission obj = new EnterStudentAdmission();
        return obj.DataToDB(userid, clas, clsroom, section, vac, normal, deb, hep);
        
    }
     

}

