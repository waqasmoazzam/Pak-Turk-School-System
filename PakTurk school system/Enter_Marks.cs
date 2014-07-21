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
    public partial class Enter_Marks : Form
    {
        Teachers t;
        DataSet res;
        
        public Enter_Marks(Teachers teach)
        {
            t = teach;
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbClass.Text == "" || cmbSubject.Text == "")
            {
                MessageBox.Show("All Fields must be provided","Attention!");
            }
            else
            {

                res = new DataSet();
                string s;

                ViewMarksWS.ViewMarksWebService vmws = new PakTurk_school_system.ViewMarksWS.ViewMarksWebService();
                if (cmbClass.Text == "" || cmbSubject.Text == "")
                {
                    MessageBox.Show("You cannot leave the fields empty, enter again.", "Alert");
                }
                else
                {
                    s = vmws.enterStudentMarksBLL(t.li.user, cmbClass.Text, cmbSubject.Text, ref res);
                    if (s != "true")
                        MessageBox.Show(s, "Alert");
                    else if (s == "true")
                    {
                        gridMarks.DataSource = res.Tables[0];
                        gridMarks.Visible = true;
                        gridMarks.Height = (res.Tables[0].Rows.Count * 30) + 50;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            t.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClass.Text == "" || cmbSubject.Text == "")
            {
                MessageBox.Show("All Fields must be provided", "Attention!");
            }
            else
            {

                res.Tables[0].Rows[0].AcceptChanges();
                //MessageBox.Show(res.Tables[0].Rows[0][4].ToString(), "checking");
                ViewMarksWS.ViewMarksWebService vmws = new PakTurk_school_system.ViewMarksWS.ViewMarksWebService();
                string s;
                s = vmws.SaveStudentMarksBLL(t.li.user, cmbClass.Text, cmbSubject.Text, ref res);
                MessageBox.Show(s, "Report");
            }

        }
    }
}
