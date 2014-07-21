using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using PakturkDLL;


/// <summary>
/// Summary description for LoginWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class LoginWebService : System.Web.Services.WebService
{

    public LoginWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    public String loginService(string txtUsername, string txtPassword)
    {
        Login li = new Login();
        string type = li.login(txtUsername, txtPassword);
        return type;

    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

}

