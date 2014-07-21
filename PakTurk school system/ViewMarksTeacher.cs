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
    public partial class ViewMarksTeacher : Form
    {
        Teachers t;
        DataSet res;
        public ViewMarksTeacher(Teachers teach)
        {
            t = teach;
            InitializeComponent();
        }

        private void ViewMarksTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_SystemDataSet6.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.school_SystemDataSet6.Courses);
            // TODO: This line of code loads data into the 'school_SystemDataSet5.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_SystemDataSet5.Class);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            res = new DataSet();
            string s;
            
            ViewMarksWS.ViewMarksWebService vmws = new PakTurk_school_system.ViewMarksWS.ViewMarksWebService();
            if (cmbClass.Text == "" || cmbSubject.Text == "")
            {
                MessageBox.Show("You cannot leave the fields empty, enter again.", "Alert");
            }
            else
            {
                s = vmws.getMarks4TeachersBLL(t.li.user, cmbClass.Text, cmbSubject.Text, ref res);

                if (s == "true")
                {
                    gridMarks.DataSource = res.Tables[0];
                    gridMarks.Visible = true;
                    gridMarks.Height = (res.Tables[0].Rows.Count * 30) + 50;
                }
                else
                {
                    MessageBox.Show(s, "Alert");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            res.Tables[0].AcceptChanges();
            ViewMarksWS.ViewMarksWebService vmws = new PakTurk_school_system.ViewMarksWS.ViewMarksWebService();
            string s;
            s = vmws.SaveStudentMarksBLL(t.li.user, cmbClass.Text, cmbSubject.Text, ref res);
            MessageBox.Show(s, "Report");
        }
    }
}
