namespace PakTurk_school_system
{
    partial class Registration
    {
        public string registrationNo;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtHPhone = new System.Windows.Forms.TextBox();
            this.txtPMob = new System.Windows.Forms.TextBox();
            this.txtSMob = new System.Windows.Forms.TextBox();
            this.txtSMail = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtCountryCombo = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.country = new PakTurk_school_system.country();
            this.CountryLable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCityCombo = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_SystemDataSet = new PakTurk_school_system.School_SystemDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistrationValue = new System.Windows.Forms.Label();
            this.countryTableAdapter = new PakTurk_school_system.countryTableAdapters.CountryTableAdapter();
            this.cityTableAdapter = new PakTurk_school_system.School_SystemDataSetTableAdapters.CityTableAdapter();
            this.cityboundToolStrip = new System.Windows.Forms.ToolStrip();
            this.cityboundToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.country)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet)).BeginInit();
            this.cityboundToolStrip.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(144, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(145, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(162, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Home Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(153, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parent Mobile No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(143, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student Mobile No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(169, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Student Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(121, 594);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Student Street Address";
            // 
            // btnPrint
            // 
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(427, 645);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(149, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(208, 645);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(656, 645);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(285, 206);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(198, 20);
            this.txtFName.TabIndex = 12;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(286, 247);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(197, 20);
            this.txtLName.TabIndex = 13;
            // 
            // txtHPhone
            // 
            this.txtHPhone.Location = new System.Drawing.Point(286, 296);
            this.txtHPhone.Name = "txtHPhone";
            this.txtHPhone.Size = new System.Drawing.Size(197, 20);
            this.txtHPhone.TabIndex = 14;
            // 
            // txtPMob
            // 
            this.txtPMob.Location = new System.Drawing.Point(286, 349);
            this.txtPMob.Name = "txtPMob";
            this.txtPMob.Size = new System.Drawing.Size(197, 20);
            this.txtPMob.TabIndex = 15;
            // 
            // txtSMob
            // 
            this.txtSMob.Location = new System.Drawing.Point(285, 397);
            this.txtSMob.Name = "txtSMob";
            this.txtSMob.Size = new System.Drawing.Size(198, 20);
            this.txtSMob.TabIndex = 16;
            // 
            // txtSMail
            // 
            this.txtSMail.Location = new System.Drawing.Point(285, 444);
            this.txtSMail.Name = "txtSMail";
            this.txtSMail.Size = new System.Drawing.Size(198, 20);
            this.txtSMail.TabIndex = 17;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(285, 590);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(198, 20);
            this.txtStreetAddress.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlText;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(232, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Class";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(285, 166);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(198, 20);
            this.txtClass.TabIndex = 20;
            // 
            // txtCountryCombo
            // 
            this.txtCountryCombo.DataSource = this.countryBindingSource;
            this.txtCountryCombo.DisplayMember = "CountryName";
            this.txtCountryCombo.FormattingEnabled = true;
            this.txtCountryCombo.Location = new System.Drawing.Point(286, 488);
            this.txtCountryCombo.Name = "txtCountryCombo";
            this.txtCountryCombo.Size = new System.Drawing.Size(197, 21);
            this.txtCountryCombo.TabIndex = 21;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.country;
            // 
            // country
            // 
            this.country.DataSetName = "country";
            this.country.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CountryLable
            // 
            this.CountryLable.AutoSize = true;
            this.CountryLable.BackColor = System.Drawing.SystemColors.ControlText;
            this.CountryLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CountryLable.Location = new System.Drawing.Point(216, 488);
            this.CountryLable.Name = "CountryLable";
            this.CountryLable.Size = new System.Drawing.Size(57, 16);
            this.CountryLable.TabIndex = 22;
            this.CountryLable.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlText;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(241, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "City";
            // 
            // txtCityCombo
            // 
            this.txtCityCombo.DataSource = this.cityBindingSource;
            this.txtCityCombo.DisplayMember = "CityName";
            this.txtCityCombo.FormattingEnabled = true;
            this.txtCityCombo.Location = new System.Drawing.Point(285, 536);
            this.txtCityCombo.Name = "txtCityCombo";
            this.txtCityCombo.Size = new System.Drawing.Size(197, 21);
            this.txtCityCombo.TabIndex = 23;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.school_SystemDataSet;
            // 
            // school_SystemDataSet
            // 
            this.school_SystemDataSet.DataSetName = "School_SystemDataSet";
            this.school_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(241, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration No";
            // 
            // lblRegistrationValue
            // 
            this.lblRegistrationValue.AutoSize = true;
            this.lblRegistrationValue.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistrationValue.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationValue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRegistrationValue.Location = new System.Drawing.Point(395, 81);
            this.lblRegistrationValue.Name = "lblRegistrationValue";
            this.lblRegistrationValue.Size = new System.Drawing.Size(203, 25);
            this.lblRegistrationValue.TabIndex = 25;
            this.lblRegistrationValue.Text = "Registration No.";
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // cityboundToolStrip
            // 
            this.cityboundToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cityboundToolStripButton});
            this.cityboundToolStrip.Location = new System.Drawing.Point(0, 0);
            this.cityboundToolStrip.Name = "cityboundToolStrip";
            this.cityboundToolStrip.Size = new System.Drawing.Size(892, 25);
            this.cityboundToolStrip.TabIndex = 26;
            this.cityboundToolStrip.Text = "cityboundToolStrip";
            this.cityboundToolStrip.Visible = false;
            // 
            // cityboundToolStripButton
            // 
            this.cityboundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cityboundToolStripButton.Name = "cityboundToolStripButton";
            this.cityboundToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.cityboundToolStripButton.Text = "citybound";
            this.cityboundToolStripButton.Click += new System.EventHandler(this.cityboundToolStripButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(892, 25);
            this.fillByToolStrip.TabIndex = 27;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(35, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Registration
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PakTurk_school_system.Properties.Resources._1_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(892, 708);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.cityboundToolStrip);
            this.Controls.Add(this.lblRegistrationValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCityCombo);
            this.Controls.Add(this.CountryLable);
            this.Controls.Add(this.txtCountryCombo);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtSMail);
            this.Controls.Add(this.txtSMob);
            this.Controls.Add(this.txtPMob);
            this.Controls.Add(this.txtHPhone);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.country)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet)).EndInit();
            this.cityboundToolStrip.ResumeLayout(false);
            this.cityboundToolStrip.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtHPhone;
        private System.Windows.Forms.TextBox txtPMob;
        private System.Windows.Forms.TextBox txtSMob;
        private System.Windows.Forms.TextBox txtSMail;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.ComboBox txtCountryCombo;
        private System.Windows.Forms.Label CountryLable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtCityCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistrationValue;
        private country country;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private PakTurk_school_system.countryTableAdapters.CountryTableAdapter countryTableAdapter;
        private School_SystemDataSet school_SystemDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private PakTurk_school_system.School_SystemDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.ToolStrip cityboundToolStrip;
        private System.Windows.Forms.ToolStripButton cityboundToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;

    }
}