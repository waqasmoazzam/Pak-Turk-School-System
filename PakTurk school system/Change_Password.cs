using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PakTurk_school_system.ChangePassword;

namespace PakTurk_school_system
{
    public partial class Change_Password : Form
    {
        Admin a;
        Teachers t;
        Student_View_Information svi;
        int flag = 0;
        public Change_Password(Admin a,Teachers t, Student_View_Information svi)
        {
            
            this.a = a;
            this.t = t;
            this.svi = svi;
            if (a != null)
                flag = 1;
            else if (t != null)
                flag = 2;
            else if (svi != null)
                flag = 3;
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                lblUser.Text = a.li.user;
                lblInstructionHidden.Visible = true;
                lbluserhidden.Visible = true;
                txtUserHidden.Visible = true;
                btnReset.Visible = true;
            }

            else if (flag == 2)
                lblUser.Text = t.li.user;
            else if (flag == 3)
                lblUser.Text = svi.li.user;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            
            ChangePasswordWebService cpws = new ChangePasswordWebService();
            
            if (txtConfirmNewPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("New Password and Confirm New Password field doesnt match, Enter Again", "Error");
            }
            else
            {   
                s = cpws.ChangePasswordBLL(lblUser.Text, txtOldPassword.Text, txtNewPassword.Text, txtConfirmNewPassword.Text,0);
                MessageBox.Show(s, "Report"); 
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                a.Show();
                this.Close();
            }
            else if (flag == 2)
            {
                t.Show();
                this.Close();
            }   
            else if (flag == 3)
            {
                svi.Show();
                this.Close();
            }    
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string s;

            ChangePasswordWebService cpws = new ChangePasswordWebService();
            s = cpws.ChangePasswordBLL(txtUserHidden.Text, "oldpasssword", "123", "123",1);
            MessageBox.Show(s, "Report");
            if(s=="Password Updated Successfully. Use your New Password now.")
                MessageBox.Show("Your New Password is 123", "New Password");
            

        }
    }
}
