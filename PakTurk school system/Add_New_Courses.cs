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
    public partial class Add_New_Courses : Form
    {
        Manage_Courses mc;
        public Add_New_Courses(Manage_Courses c)
        {
            mc = c;
            InitializeComponent();
            cmbType.Items.Add("Compulsory");
            cmbType.Items.Add("Optional");
        }

        private void Add_New_Courses_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mc.Show();
            this.Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbType.Text == "" || txtCourse.Text == "")
            {
                MessageBox.Show("All Fields must be Filled. Enter Again!", "Error");
            }
            else
            {
                string s;
                ManageCourseWS.ManageCoursesWebService mcws = new ManageCourseWS.ManageCoursesWebService();
                s = mcws.Add_Course_BLL(txtCourse.Text, cmbType.Text);

                MessageBox.Show(s, "Report");

                txtCourse.Text = null;
                cmbType.Text = null;
                
            }
            
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
