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
    
    public partial class Login : Form
    {
        public string user = null;
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //txtPassword.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAuthenticate.LoginWebService a = new UserAuthenticate.LoginWebService();
            string type = a.loginService(txtUsername.Text.ToString(), txtPassword.Text.ToString());
            if (type == null)
            {
                MessageBox.Show("Username or Password is incorrect, enter again.","Login Error");
            }
            else
            {
                type = type.ToLower();
                if (type == "student")
                {
                    user = txtUsername.Text;
                    Student_View_Information svi = new Student_View_Information(this);
                    svi.Show();
                    this.Hide();
                }
                else if (type == "teacher")
                {
                    user = txtUsername.Text;
                    Teachers t = new Teachers(this);
                    t.Show();
                    this.Hide();
                }
                else if (type == "admin")
                {
                    user = txtUsername.Text;
                    Admin ad = new Admin(this);
                    ad.Show();
                    this.Hide();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
            
        }
    }
}
