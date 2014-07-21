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
    public partial class Registration : Form
    {
        Admin ad = null;
        public Registration(Admin a)
        {
            InitializeComponent();
            ad = a;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'school_SystemDataSet.City' table. You can move, or remove it, as needed.
            //this.cityTableAdapter.Fill(this.school_SystemDataSet.City);
            // TODO: This line of code loads data into the 'country.Country' table. You can move, or remove it, as needed.
            //this.countryTableAdapter.Fill(this.country.Country);

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtCityCombo.Text=="" || txtClass.Text==""|| txtCountryCombo.Text==""||txtFName.Text==""|| txtHPhone.Text==""||txtLName.Text==""|| txtPMob.Text==""||txtSMail.Text=="" ||txtSMob.Text==""||txtStreetAddress.Text=="" ) 
            {
                MessageBox.Show("All Fields Must be Provided","Attention!");
            }
            else
            {
                lblRegistrationValue.Text = RegisterStudent();
            }
              
        }
        public string RegisterStudent()
        {

            localhost1.RegistrationService a = new localhost1.RegistrationService();

             
            return a.CheckStudentToRegister(txtClass.Text.ToString(), txtFName.Text.ToString(), txtLName.Text.ToString(), txtHPhone.Text.ToString(), txtPMob.Text.ToString(), txtSMail.Text.ToString(), txtCountryCombo.Text.ToString(), txtCityCombo.Text.ToString(), txtStreetAddress.Text.ToString());
             
        }

        private void cityboundToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cityTableAdapter.citybound(this.school_SystemDataSet.City);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.countryTableAdapter.FillBy(this.country.Country);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmPrint cp = new ConfirmPrint(this);
            this.Hide();
            cp.Show();
            cp.lblRegistrationValue.Text = this.lblRegistrationValue.Text;
            cp.lblClassValue.Text = this.txtClass.Text;
            cp.lblFirstNameValue.Text = this.txtFName.Text;
            cp.lblLastNameValue.Text = this.txtLName.Text;
            cp.lblHomePhoneNoValue.Text = this.txtHPhone.Text;
            cp.lblParentMobileNoValue.Text = this.txtPMob.Text;
            cp.lblStudentMobileNoValue.Text = this.txtSMob.Text;
            cp.lblStudentEmailValue.Text = this.txtSMail.Text;
            cp.lblCountryValue.Text = this.txtCountryCombo.Text;
            cp.lblCityValue.Text = this.txtCityCombo.Text;
            cp.lblStreetAddressValue.Text = this.txtStreetAddress.Text;

        }
    }
}
