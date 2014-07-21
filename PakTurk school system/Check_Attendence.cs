using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PakTurk_school_system
{
    public partial class Check_Attendence : Form
    {
        Student_View_Information svi;
        
        public Check_Attendence(Student_View_Information obj)
        {
            svi = obj;
            
            InitializeComponent();
        }

        private void Check_Attendence_Load(object sender, EventArgs e)
        {
            AttendanceWS.AttendanceWebService aws = new PakTurk_school_system.AttendanceWS.AttendanceWebService();
            aws.getStudentDetailsBLL(svi.li.user, ref svi.fName, ref svi.lName, ref svi.rollNo);
            lblName.Text = svi.fName + " " + svi.lName;
            lblRollNo.Text = svi.rollNo;
            
            DataSet attd = new DataSet();
            attd=aws.getAttendanceBLL(svi.rollNo);
            gridCheckAttendance.DataSource = attd.Tables[0];
            int p = 0, a = 0,totalDays=0;
            for (int i = 0; i < attd.Tables[0].Rows.Count; i++)
            {
                if (attd.Tables[0].Rows[i][1].ToString()=="P")
                {
                    p++;
                }
                if (attd.Tables[0].Rows[i][1].ToString()== "A")
                {
                    a++;
                }
            }
            totalDays = a + p;
            lblTotalAbsents.Text = a.ToString();
            lblTotalPresents.Text = p.ToString();
            lblTotalDays.Text = totalDays.ToString();
            


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            svi.Show();
            this.Close();
        }
    }
}
