using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

/// <summary>
/// Summary description for ChangePasswordWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ChangePasswordWebService : System.Web.Services.WebService
{

    public ChangePasswordWebService()
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
    public string ChangePasswordBLL(string user, string password, string newPassword, string confirmNewPassword,int flag)
    {
        string s;
        PakturkDLL.ChangePassword cp = new PakturkDLL.ChangePassword();
        s = cp.changePasswordDLL(user, password, newPassword, confirmNewPassword,flag);
        return s;
    }

}

