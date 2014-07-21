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
    public partial class Student_View_Information : Form
    {
        public Login li;
        public string fName;
        public string lName;
        public string rollNo;
        public Student_View_Information(Login l)
        {
            li = l;

            fName = null;
            lName = null;
            rollNo = null; 

            InitializeComponent();
        }

        private void Student_View_Information_Load(object sender, EventArgs e)
        {
            AttendanceWS.AttendanceWebService aws = new PakTurk_school_system.AttendanceWS.AttendanceWebService();
            aws.getStudentDetailsBLL(li.user, ref fName, ref lName, ref rollNo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login li = new Login();
            li.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change_Password  cp = new Change_Password(null,null,this);
            this.Hide();
            cp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_Attendence ca = new Check_Attendence(this);
            this.Hide();
            ca.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Marks vm = new View_Marks(this);
            this.Hide();
            vm.Show();
        }
    }
}
