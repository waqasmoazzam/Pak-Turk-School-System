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
    public partial class Mark_Attendence : Form
    {
        public Teachers t;
        public DataSet s;
        
        public Mark_Attendence(Teachers teach)
        {
            
            t = teach;
            InitializeComponent();
        }

        private void Mark_Attendence_Load(object sender, EventArgs e)
        {
            lblClass.Text = t.ClassName;
            AttendanceWS.AttendanceWebService aws = new PakTurk_school_system.AttendanceWS.AttendanceWebService();
            s=aws.displayStudentsBLL(lblClass.Text);
            listStudents.Visible = true;
            for (int i = 0; i < s.Tables[0].Rows.Count; i++)
            {
                listStudents.Items.Add(s.Tables[0].Rows[i][0]);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AttendanceWS.AttendanceWebService aws = new PakTurk_school_system.AttendanceWS.AttendanceWebService();
            string res = null;
            string a=s.Tables[0].Rows[0][0].ToString();
           
            for (int i = 0; i < s.Tables[0].Rows.Count; i++)
            {
                
                if (listStudents.GetItemChecked(i))
                {
                    res=aws.markAttendanceBLL(s.Tables[0].Rows[i][0].ToString(),dt.Text,"P",0);// 0 indiactes to Mark New Attendance
                 
                    if (res == "false")
                        break;
                    
                }
                else
                {
                    res=aws.markAttendanceBLL(s.Tables[0].Rows[i][0].ToString(), dt.Text, "A",0);
                 
                    if (res == "false")
                        break;
                }
            }
                if(res=="false")
                    MessageBox.Show("Attendance Has Already Been Marked on This Date", "Permission Denied");
                else
                    MessageBox.Show("Attendance Has Been Successfully Marked","Success Report");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            t.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Attendance ua = new Update_Attendance(this);
            this.Hide();
            ua.Show();
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            AttendanceWS.AttendanceWebService aws = new PakTurk_school_system.AttendanceWS.AttendanceWebService();
           
            s.Clear();
            s = aws.displayStudentsBLL(lblClass.Text);
            listStudents.Items.Clear();
           

            for (int i = 0; i < s.Tables[0].Rows.Count; i++)
            {
                listStudents.Items.Add(s.Tables[0].Rows[i][0]);
            }
            
        }
    }
}
