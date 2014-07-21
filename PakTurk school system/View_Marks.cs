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
    public partial class View_Marks : Form
    {
        public Student_View_Information svi;
        public View_Marks(Student_View_Information s)
        {
            svi = s;
            InitializeComponent();
        }

        private void View_Marks_Load(object sender, EventArgs e)
        {
            lblName.Text = svi.fName + " " + svi.lName;
            lblRollNo.Text = svi.rollNo;
            ViewMarksWS.ViewMarksWebService vmws = new PakTurk_school_system.ViewMarksWS.ViewMarksWebService();
            DataSet s = vmws.getMarks4StudentsBLL(lblRollNo.Text);
            if (s.Tables[0].Rows.Count == 0)
                MessageBox.Show("No marks of any subject has been added yet.Check Back Later.","Report");
            gridViewMarks.DataSource = s.Tables[0];
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            svi.Show();

        }
    }
}
