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
/// Summary description for manageClass
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class manageClass : System.Web.Services.WebService
{

    public manageClass()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public  DataSet managecls(string clsname)
    {
        manageClassdll obj = new manageClassdll();
        return obj.getclassinfo(clsname);
    }
    
    [WebMethod]
    public bool makeclass(string clsname, string section, string roomno, string capacity, string status)
    {
        manageClassdll obj = new manageClassdll();
        return obj.enterClassToDb(clsname, section, roomno, capacity, status);
        //return true;
    }
    [WebMethod]
    public bool update(DataSet a)
    {
        manageClassdll obj = new manageClassdll();
        return obj.updateclass(a);
    }

}

