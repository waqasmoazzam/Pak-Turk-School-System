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
    public partial class Update_Attendance : Form
    {
        Mark_Attendence ma;
        int count = 0;
        public DataSet update;
        public DataRow dr;
        public DataColumn dc;
        public DataTable dTable;
        int temp=0;
        public Update_Attendance(Mark_Attendence m)
        {
            ma = m;
            InitializeComponent();
        }

        private void Update_Attendance_Load(object sender, EventArgs e)
        {
            lblClass.Text = ma.t.ClassName;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listStudents.Items.Clear();
            
            AttendanceWS.AttendanceWebService aws = new PakTurk_school_system.AttendanceWS.AttendanceWebService();
            
            //DataSet s = new DataSet();
            //ma.s = aws.displayStudentsBLL(lblClass.Text);

            /*for (int i = 0; i < s.Tables[0].Rows.Count; i++)
            {
                listStudents.Items.Add(s.Tables[0].Rows[i][0]);
            }*/

           
            update = new DataSet();
            
            dTable = new DataTable("present");
            update.Tables.Add(dTable);
  
            update.Tables[0].Rows.Add(dTable.NewRow());
            dc = new DataColumn();
            update.Tables[0].Columns.Add(dc);
            
            
            for (int i = 0; i < ma.s.Tables[0].Rows.Count; i++)
            {
                string a = aws.display4UpdateStudentsBLL(ma.s.Tables[0].Rows[i][0].ToString(), dt.Text);
                if (a == "P")
                    continue;
                else if (a == "false")
                {
                    MessageBox.Show("First you have to use Mark Attendance button from the previos screen to mark attendance on this date only then you can update on this date. ","Permission Denied");
                    break;
                }
                else
                {

                    listStudents.Items.Add(a);
                    update.Tables[0].Rows[count][0] = a;
                    update.Tables[0].Rows.Add(dTable.NewRow());
                    count++;
                }
            }
            temp = count;
            count = 0;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ma.t.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AttendanceWS.AttendanceWebService aws = new PakTurk_school_system.AttendanceWS.AttendanceWebService();
            string res = null;
                      
            for (int i = 0; i < temp; i++)
            {
                if (listStudents.GetItemChecked(i))
                {
                    
                    res = aws.markAttendanceBLL(update.Tables[0].Rows[i][0].ToString(), dt.Text, "P",1);//1 indiactes  update existing attendance    
                }
                else
                {
                    res = aws.markAttendanceBLL(update.Tables[0].Rows[i][0].ToString(), dt.Text, "A",1);
                }
            }
            MessageBox.Show("Attendance Has Been Successfully Updated", "Success Report");
            dTable.Clear();
            update.Clear();
            count = 0;
            temp = 0;
            
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

