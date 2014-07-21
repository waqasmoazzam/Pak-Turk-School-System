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
/// Summary description for SearchRegisteredStudent
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class SearchRegisteredStudent : System.Web.Services.WebService
{

    public SearchRegisteredStudent()
    {


        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DataSet searchStudentFromDB(string rgno, string fn, string ln )
    {
        
        DataSet InfoDS = new DataSet();
        InfoDS = makeDataSet(rgno,fn,ln);
        searchAndReturnStudents obj = new searchAndReturnStudents();
        obj.searchStudents(InfoDS);
        return InfoDS;
    }
    
    public DataSet makeDataSet(string rgNo, string fN, string lN )
    {
        DataSet DS = new DataSet();
        DataTable DStable = new DataTable("stdInfo");
        DataRow DStableRow = null;

        DStable.Columns.Add("RgNo", typeof(string));
        DStable.Columns.Add("FN", typeof(string));
        DStable.Columns.Add("LN", typeof(string));
         
        
        DStableRow = DStable.NewRow();
        
        DStableRow["RgNo"] = rgNo;
        DStableRow["FN"] = fN;
        DStableRow["LN"] = lN;
         

        DStable.Rows.Add(DStableRow);

        DS.Tables.Add(DStable);
        return DS;
    }

     
     

}

