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
    public partial class Admission_1_ : Form
    {
        private string Fname;
        private string Lname;
        private string RegistrationNo;
        private string Country;
        private string City;
        Admin ad;
        public Admission_1_(Admin a)
        {
            ad = a;
            InitializeComponent();
            Fname = null;
            Lname = null;
            RegistrationNo = null;
            Country = null;
            City = null;
        }

        public void setValue()
        {
            if (rgNo.Text=="")
            {
                RegistrationNo = "R";
            }
            else 
            {
                RegistrationNo = rgNo.Text;
            }
            
            Fname = Fn.Text;
            Lname = Ln.Text;
        }

        private void Admission_1__Load(object sender, EventArgs e)
        {

        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (rgNo.Text == "" && Fn.Text == "" && Ln.Text == "")
            {
                MessageBox.Show("Atleast 1 field must be provided", "Attention!");
            }
            else
            {
                setValue();
                DataSet DDateSet = null;
                searchStudent.SearchRegisteredStudent a = new searchStudent.SearchRegisteredStudent();
                DDateSet = a.searchStudentFromDB(RegistrationNo, Fname, Lname);
                dataGridView1.DataSource = DDateSet.Tables[1];
            }
           
        }

        private void go_Click(object sender, EventArgs e)
        {
            AdmitStudent();
            
        }

        private void AdmitStudent()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                string fn = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string ln = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                //MessageBox.Show(userid+fn+ln);
                Admission_2_ obj = new Admission_2_(userid, fn, ln,ad,this);
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please Select atleast one student", "IMPORTANT MESSAGE");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ad.Show();
        }
        
    }
}
