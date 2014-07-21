using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using PakturkDLL;

/// <summary>
/// Summary description for CreateUserWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CreateUserWebService : System.Web.Services.WebService
{

    public CreateUserWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public String Create_User_Login(string txtFName, string txtLName, string txtPhoneNo, string txtMobileNo, string txtEMail, string txtAddress, string txtUsername, string txtCountry, string comboUserType)
    {
        CreateUserLogin UL = new CreateUserLogin();
        String s = UL.CreateUser(txtFName, txtLName, txtPhoneNo, txtMobileNo, txtEMail, txtAddress, txtUsername, txtCountry, comboUserType);
        return s;
    }

}

