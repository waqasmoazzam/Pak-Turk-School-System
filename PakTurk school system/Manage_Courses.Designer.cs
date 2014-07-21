namespace PakTurk_school_system
{
    partial class Manage_Courses
    {
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
            this.course = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_SystemDataSet3 = new PakTurk_school_system.School_SystemDataSet3();
            this.userzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_SystemDataSet4 = new PakTurk_school_system.School_SystemDataSet4();
            this.btnback = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNewCourse = new System.Windows.Forms.Button();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_SystemDataSet2 = new PakTurk_school_system.School_SystemDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssignToClass = new System.Windows.Forms.Button();
            this.classTableAdapter = new PakTurk_school_system.School_SystemDataSet2TableAdapters.ClassTableAdapter();
            this.coursesTableAdapter = new PakTurk_school_system.School_SystemDataSet3TableAdapters.CoursesTableAdapter();
            this.userzTableAdapter = new PakTurk_school_system.School_SystemDataSet4TableAdapters.UserzTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // course
            // 
            this.course.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "CourseName", true));
            this.course.DataSource = this.coursesBindingSource;
            this.course.DisplayMember = "CourseName";
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(396, 64);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(168, 21);
            this.course.TabIndex = 0;
            this.course.ValueMember = "CourseName";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.school_SystemDataSet3;
            // 
            // school_SystemDataSet3
            // 
            this.school_SystemDataSet3.DataSetName = "School_SystemDataSet3";
            this.school_SystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userzBindingSource
            // 
            this.userzBindingSource.DataMember = "Userz";
            this.userzBindingSource.DataSource = this.school_SystemDataSet4;
            // 
            // school_SystemDataSet4
            // 
            this.school_SystemDataSet4.DataSetName = "School_SystemDataSet4";
            this.school_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(372, 171);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.back_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(489, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCourse.Location = new System.Drawing.Point(396, 215);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.Size = new System.Drawing.Size(168, 23);
            this.btnAddNewCourse.TabIndex = 3;
            this.btnAddNewCourse.Text = "Add New Course(s)";
            this.btnAddNewCourse.UseVisualStyleBackColor = true;
            this.btnAddNewCourse.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.BackColor = System.Drawing.Color.Black;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(304, 67);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(86, 13);
            this.lblSelectCourse.TabIndex = 4;
            this.lblSelectCourse.Text = "Select Course";
            // 
            // cmbClass
            // 
            this.cmbClass.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classBindingSource, "ClassName", true));
            this.cmbClass.DataSource = this.classBindingSource;
            this.cmbClass.DisplayMember = "ClassName";
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(396, 108);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(168, 21);
            this.cmbClass.TabIndex = 5;
            this.cmbClass.ValueMember = "ClassName";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.school_SystemDataSet2;
            // 
            // school_SystemDataSet2
            // 
            this.school_SystemDataSet2.DataSetName = "School_SystemDataSet2";
            this.school_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(304, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Class";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAssignToClass
            // 
            this.btnAssignToClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignToClass.Location = new System.Drawing.Point(209, 215);
            this.btnAssignToClass.Name = "btnAssignToClass";
            this.btnAssignToClass.Size = new System.Drawing.Size(161, 23);
            this.btnAssignToClass.TabIndex = 7;
            this.btnAssignToClass.Text = "Assign Subject To Class";
            this.btnAssignToClass.UseVisualStyleBackColor = true;
            this.btnAssignToClass.Click += new System.EventHandler(this.btnAssignToClass_Click);
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // userzTableAdapter
            // 
            this.userzTableAdapter.ClearBeforeFill = true;
            // 
            // Manage_Courses
            // 
            this.AcceptButton = this.btnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::PakTurk_school_system.Properties.Resources._1_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(790, 464);
            this.Controls.Add(this.btnAssignToClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.btnAddNewCourse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.course);
            this.Name = "Manage_Courses";
            this.Text = "Manage_Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Manage_Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNewCourse;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssignToClass;
        private School_SystemDataSet2 school_SystemDataSet2;
        private System.Windows.Forms.BindingSource classBindingSource;
        private PakTurk_school_system.School_SystemDataSet2TableAdapters.ClassTableAdapter classTableAdapter;
        private School_SystemDataSet3 school_SystemDataSet3;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private PakTurk_school_system.School_SystemDataSet3TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private School_SystemDataSet4 school_SystemDataSet4;
        private System.Windows.Forms.BindingSource userzBindingSource;
        private PakTurk_school_system.School_SystemDataSet4TableAdapters.UserzTableAdapter userzTableAdapter;
    }
}