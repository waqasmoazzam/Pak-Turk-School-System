using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Data;


/// <summary>
/// Summary description for ViewMarksWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ViewMarksWebService : System.Web.Services.WebService
{

    public ViewMarksWebService()
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
    public DataSet getMarks4StudentsBLL(string rollNo)
    {
        DataSet s=new DataSet();
        PakturkDLL.ViewMarks v = new PakturkDLL.ViewMarks();
        s=v.getMarks4StudentsDLL(rollNo);
        return s;
    }
    [WebMethod]
    public string getMarks4TeachersBLL(string userName, string className, string subjectName, ref DataSet res)
    {
        
        string s;
        PakturkDLL.ViewMarks vm = new PakturkDLL.ViewMarks();
        s = vm.getMarks4TeacherDLL(userName, className, subjectName, ref res);
        return s;
    }
    [WebMethod]
    public string enterStudentMarksBLL(string userName, string className, string subjectName, ref DataSet res)
    {

        string s;
        PakturkDLL.ViewMarks vm = new PakturkDLL.ViewMarks();
        s = vm.enterStudentMarksDLL(userName, className, subjectName, ref res);
        return s;
    }

    [WebMethod]
    public string SaveStudentMarksBLL(string userName, string className, string subjectName, ref DataSet res)
    {

        string s;
        PakturkDLL.ViewMarks vm = new PakturkDLL.ViewMarks();
        s = vm.saveStudentMarksDLL(userName, className,subjectName,ref res);
        return s;
    }



}

