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
    public partial class Create_User_Login : Form
    {
        Admin ad=null;
        public Create_User_Login(Admin a)
        {
            ad = a;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_User_Login_Load(object sender, EventArgs e)
        {
            comboUserType.Items.Add("Student");
            comboUserType.Items.Add("Teacher");
            comboUserType.Items.Add("Admin");
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

            creatUser.CreateUserWebService cu = new creatUser.CreateUserWebService();

            if (txtAddress.Text == "" || txtCountry.Text == "" || txtEmail.Text == "" || txtFName.Text == "" || txtLName.Text == "" || txtMobileNo.Text == "" || txtPhoneNo.Text == "" || txtUsername.Text == "" || comboUserType.Text == "")
            {
                MessageBox.Show("All Fields must be filled", "Attention!");
            }
            else
            {
                string s = cu.Create_User_Login(txtFName.Text.ToString(), txtLName.Text.ToString(), txtPhoneNo.Text.ToString(), txtMobileNo.Text.ToString(), txtEmail.Text.ToString(), txtAddress.Text.ToString(), txtUsername.Text.ToString(), txtCountry.Text.ToString(), comboUserType.Text.ToString());
                if (s == "true")
                {
                    MessageBox.Show("User created successfully", "Success Report");
                    txtFName.Text = null;
                    txtLName.Text = null;
                    txtPhoneNo.Text = null;
                    txtMobileNo.Text = null;
                    txtEmail.Text = null;
                    txtAddress.Text = null;
                    txtUsername.Text = null;
                    txtCountry.Text = null;
                    comboUserType.Text = null;


                }
                else if (s == "false")
                {
                    MessageBox.Show("User creation error, enter again", "Failure Report");
                }
            }
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ad.Show();
            this.Close();
        }
    }
}
