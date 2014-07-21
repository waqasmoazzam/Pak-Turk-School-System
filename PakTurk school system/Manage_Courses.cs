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
    public partial class Manage_Courses : Form
    {
        Admin ad;
        public Manage_Courses(Admin a)
        {
            ad=a;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_New_Courses anc = new Add_New_Courses(this);
            this.Hide();
            anc.Show();
        }

        private void Manage_Courses_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'school_SystemDataSet3.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.school_SystemDataSet3.Courses);
            // TODO: This line of code loads data into the 'school_SystemDataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.school_SystemDataSet2.Class);
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            ManageCourseWS.ManageCoursesWebService mcws = new ManageCourseWS.ManageCoursesWebService();
            s = mcws.Delete_Course_BLL(course.Text);
            
            MessageBox.Show(s,"Report");
            
            course.Text = null;
        }

        private void btnAssignToClass_Click(object sender, EventArgs e)
        {
            if (cmbClass.Text == "" || course.Text == "")
                MessageBox.Show("No Fields Should be Empty", "Required Filed Empty");
            else
            {
                string s;
                ManageCourseWS.ManageCoursesWebService mcws = new ManageCourseWS.ManageCoursesWebService();
                s = mcws.Assign_To_Class_BLL(course.Text, cmbClass.Text);
                if (s=="true")
                    MessageBox.Show("Subject Assigned to the class successfully", "Success Report");
                else
                    MessageBox.Show("Subject could not be Assigned to the class", "Failure Report");
                course.Text = null;
                cmbClass.Text = null;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userzTableAdapter.FillBy(this.school_SystemDataSet4.Userz);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userzTableAdapter.FillBy1(this.school_SystemDataSet4.Userz);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
