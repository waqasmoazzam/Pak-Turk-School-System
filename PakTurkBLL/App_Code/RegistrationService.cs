using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using PakturkDLL;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class RegistrationService : System.Web.Services.WebService
{
    public RegistrationService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string CheckStudentToRegister(string txtClass, string txtFName, string txtLName, string txtHPhone, string txtPMob, string txtSMail, string txtCountryCombo, string txtCityCombo, string txtStreetAddress)
    {
        RegisterStudentToDB a=new RegisterStudentToDB();
        return a.EnterStdRegData(txtClass, txtFName, txtLName, txtHPhone, txtPMob, txtSMail, txtCountryCombo, txtCityCombo, txtStreetAddress);
         
    }
    
    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    
}
