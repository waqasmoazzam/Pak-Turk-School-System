using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using PakturkDLL;
/// <summary>
/// Summary description for UpadateUser
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class UpadateUser : System.Web.Services.WebService
{

    public UpadateUser()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DataSet getUserNames()
    {
        PakturkDLL.UpdateUser obj = new PakturkDLL.UpdateUser();
        return obj.returnUserz();
    }
    [WebMethod]
    public DataSet getUserDetail(string usrN)
    {
        PakturkDLL.UpdateUser obj = new PakturkDLL.UpdateUser();
        return obj.getUserDetail(usrN);
    }
    [WebMethod]
    public bool editUserInfo(DataSet DS,string usrN)
    {
        PakturkDLL.UpdateUser obj = new PakturkDLL.UpdateUser();
        return obj.editUserdetail(DS,usrN);
    }
}

