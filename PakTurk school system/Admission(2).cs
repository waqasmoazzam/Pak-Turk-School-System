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
    public partial class Admission_2_ : Form
    {
        private int userid;
        private string FName;
        private string LName;
        private int vaccinated;
        private int debeties;
        private int normal;
        private int hepetitis;
        private string cLass;
        private string clsRoom;
        private string section;
        Admin ad = null;
        Admission_1_ adm;
        public Admission_2_(string userId,string fname,string lname,Admin a,Admission_1_ adm)
        {
            
            InitializeComponent();
            this.adm = adm;
            ad = a;
            userid = Convert.ToInt32(userId);
            FName = fname;
            LName = lname;
            vaccinated = -1;
            debeties = -1;
            normal = -1;
            hepetitis = -1;
            cLass = null;
            clsRoom = null;
            section = null;
        }

        private void Admission_2__Load(object sender, EventArgs e)
        {
            FName+="  ";
            stdName.Text = FName + LName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("All Fields must be provided. Enter Again!", "Attention!");
            }
            else
            {
                setFormData();
                string rollNo = null;
                AdmintTheStudent.AdmitStudent obj = new AdmintTheStudent.AdmitStudent(); ;
                rollNo = obj.enterStudentInfo(userid, cLass, clsRoom, section, vaccinated, normal, debeties, hepetitis);

                MessageBox.Show(rollNo, "ADMITTED STUDENT ROLL NO");
            }
            
        }

        private void setFormData()
        {
            cLass = textBox1.Text.ToString();
            clsRoom = comboBox1.Text.ToString();
            section = textBox2.Text.ToString();
            if (radioButton1.Checked)
            {
                vaccinated = 1;

            }
            else
            {
                vaccinated = 0;
            }
            if (radioButton9.Checked)
            {
                normal = 1;

            }
            else
            {
                normal = 0;
            }
            if (radioButton12.Checked)
            {
                debeties = 1;

            }
            else
            {
                debeties = 0;
            }
            if (radioButton14.Checked)
            {
                hepetitis = 1;

            }
            else
            {
                hepetitis = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ad.Show();
            //Admin obj = new Admin();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            adm.Show();
            this.Close();
        }

         
 
    }
}
