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
    public partial class Admin : Form
    {
        public Login li;
        public Admin(Login L)
        {
            li = L;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Login li = new Login();
            this.Close();
            li.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration obj = new Registration(this);
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admission_1_ obj = new Admission_1_(this);
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Create_User_Login cul = new Create_User_Login(this);
            this.Hide();
            cul.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Teacher obj = new Manage_Teacher(this);
            obj.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Courses mc = new Manage_Courses(this);
            this.Hide();
            mc.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(this, null, null);
            this.Hide();
            cp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manage_Class obj = new Manage_Class(this);
            this.Hide();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Edit_User eu = new Edit_User(this);
            this.Hide();
            eu.Show();
        }
    }
}
