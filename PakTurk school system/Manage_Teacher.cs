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
    public partial class Manage_Teacher : Form
    {
        Admin a;
        public Manage_Teacher(Admin ab)
        {
            a = ab;
            InitializeComponent();
        }

        private void Manage_Teacher_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboClass.Text == "" || comboSubject.Text == "" || comboTeacher.Text == "" || comboType.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("All Fileds must be provided", "Attention!");

            }
            else
            {

                bool flag = false;
                string teachername = comboTeacher.Text;
                string classname = comboClass.Text;
                string subjectname = comboSubject.Text;
                string subjectTyp = comboType.Text;
                string classSection = comboBox2.Text;
                assignSubjectService.manageTeacher obj = new PakTurk_school_system.assignSubjectService.manageTeacher();
                flag = obj.assignSubject(teachername, classname, subjectname, subjectTyp, classSection);
                if (flag == true)
                {
                    //string a = null;
                    //a = flag.ToString();
                    MessageBox.Show("Successfully Assigned", "Assigned");
                }
                else
                {
                    MessageBox.Show("give the input correctly", "ERROR");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboClass1.Text == "" || comboIncharge.Text == "")
            {
                MessageBox.Show("All Fields must be provided", "Attention!");
            }
            else
            {
                bool flag = false;
                string class1 = comboClass1.Text;
                string incharge = comboIncharge.Text;
                assignSubjectService.manageTeacher obj = new PakTurk_school_system.assignSubjectService.manageTeacher();
                flag = obj.makeClassIncharge(class1, incharge);
                if (flag == true)
                {
                    MessageBox.Show("Assigned Successfully!!", "Success");
                }
                else
                {
                    MessageBox.Show("Please Enter Data Correctly", "ERROR");
                }
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Close();
        }
    }
}
