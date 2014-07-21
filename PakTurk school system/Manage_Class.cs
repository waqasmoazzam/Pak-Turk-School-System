using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace PakTurk_school_system
{
    public partial class Manage_Class : Form
    {
        Admin a;
        DataSet classDs;
        public Manage_Class(Admin ab)
        {
            a = ab;
            InitializeComponent();
        }

        private void Manage_Class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_SystemDataSet7.ClassRooms' table. You can move, or remove it, as needed.
            this.classRoomsTableAdapter.Fill(this.school_SystemDataSet7.ClassRooms);
            
            
            //flag = 

        }
        
        

         

        private void select(object sender, MouseEventArgs e)
        {
            dataGridView1.Visible = true;
            //btncancel.Visible = true;
            btnsave.Visible = true;
            
           

        }

        private void btnsave1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            //int check = 0;
            ManageclsService.manageClass obj = new PakTurk_school_system.ManageclsService.manageClass();
            flag = obj.makeclass(clsName.Text, clsSection.Text, clsRoomNo.Text, clsCapacity.Text, comboStatus.Text);
     //       check = obj.makeclass(clsName.Text, txtsection.Text, clsRoomNo.Text, clsCapacity.Text, comboStatus.Text);

            
            if (flag == true)
            {
                MessageBox.Show("Class Created Successfully", "Success");
            }
            else
            {
                MessageBox.Show("Class already exits","Error");
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataSet a = new DataSet();
            a = classDs;
            
            bool flag = false;
            ManageclsService.manageClass obj = new PakTurk_school_system.ManageclsService.manageClass();
            flag=obj.update(a);
            if (flag==true)
            {
                MessageBox.Show("updated!!!","Success");
            }
            
           MessageBox.Show(a.Tables[0].Rows[0][2].ToString());
            
        }
 

         

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clsname = null;
            clsname = comboClass.Text;
            //MessageBox.Show(clsname);
            classDs = new DataSet();           
            ManageclsService.manageClass obj = new PakTurk_school_system.ManageclsService.manageClass();
            classDs = obj.managecls(clsname);
            if (classDs.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = classDs.Tables[0];
                //dataGridView1.DataMember = "ClassRooms";
                classDs.AcceptChanges();
                // MessageBox.Show

            }
            else
            {
                MessageBox.Show("there is no class of this name", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            a.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btncancle1_Click(object sender, EventArgs e)
        {

        }
    }
}
