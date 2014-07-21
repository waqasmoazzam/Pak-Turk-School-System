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
    public partial class Edit_User : Form
    {
        public Admin a;
        DataSet userInfo;
        public Edit_User(Admin ab)
        {
            a = ab;
            InitializeComponent();
            
        }

        

        private void Edit_User_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            UpdateUserInfo.UpadateUser obj = new PakTurk_school_system.UpdateUserInfo.UpadateUser();
            ds=obj.getUserNames();
            comboUser.DataSource = ds.Tables[0];
            comboUser.DisplayMember = "UserName";
            comboUser.ValueMember = "UserName";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            a.Show();
                
        }

        private void Go_Click(object sender, EventArgs e)
        {
//            DataSet ds = new DataSet();
            if (comboUser.Text == "")
            {
                MessageBox.Show("All Fields must be provided","Attention!");
            }
            else
            {
                userInfo = new DataSet();
                if (comboUser.Text == null)
                {
                    MessageBox.Show("please select a user first");
                }
                else
                {
                    string username = comboUser.Text;
                    UpdateUserInfo.UpadateUser obj = new PakTurk_school_system.UpdateUserInfo.UpadateUser();
                    userInfo = obj.getUserDetail(username);
                    dataGridView1.DataSource = userInfo.Tables[0];
                    userInfo.AcceptChanges();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userInfo.Tables[0].Rows[0][3].ToString());
            bool flag = false;
            UpdateUserInfo.UpadateUser obj = new PakTurk_school_system.UpdateUserInfo.UpadateUser();
            flag = obj.editUserInfo(userInfo,comboUser.Text.ToString());
            if (flag == true)
            {
                MessageBox.Show("User Updated","success" );
            }
            else
            {
                MessageBox.Show("sorry!!","Error");
            }
        }

         
         
    }
}
