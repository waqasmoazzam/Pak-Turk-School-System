namespace PakTurk_school_system
{
    partial class Manage_Class
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clsSection = new System.Windows.Forms.Label();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clsRoomNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clsCapacity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsave1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.school_SystemDataSet7 = new PakTurk_school_system.School_SystemDataSet7();
            this.classRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRoomsTableAdapter = new PakTurk_school_system.School_SystemDataSet7TableAdapters.ClassRoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(96, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "1",
            "2",
            "11",
            "12"});
            this.comboClass.Location = new System.Drawing.Point(155, 477);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(208, 21);
            this.comboClass.TabIndex = 1;
            this.comboClass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.select);
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 504);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(289, 675);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(96, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "To Edit any class information select below";
            // 
            // clsName
            // 
            this.clsName.Location = new System.Drawing.Point(398, 132);
            this.clsName.Name = "clsName";
            this.clsName.Size = new System.Drawing.Size(159, 20);
            this.clsName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(297, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class Name";
            // 
            // clsSection
            // 
            this.clsSection.AutoSize = true;
            this.clsSection.BackColor = System.Drawing.Color.Black;
            this.clsSection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsSection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clsSection.Location = new System.Drawing.Point(286, 181);
            this.clsSection.Name = "clsSection";
            this.clsSection.Size = new System.Drawing.Size(93, 16);
            this.clsSection.TabIndex = 9;
            this.clsSection.Text = "Class Section";
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(398, 177);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(159, 20);
            this.txtsection.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(276, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Class Room No";
            // 
            // clsRoomNo
            // 
            this.clsRoomNo.Location = new System.Drawing.Point(398, 228);
            this.clsRoomNo.Name = "clsRoomNo";
            this.clsRoomNo.Size = new System.Drawing.Size(159, 20);
            this.clsRoomNo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(238, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Class Room Capacity";
            // 
            // clsCapacity
            // 
            this.clsCapacity.Location = new System.Drawing.Point(398, 275);
            this.clsCapacity.Name = "clsCapacity";
            this.clsCapacity.Size = new System.Drawing.Size(159, 20);
            this.clsCapacity.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(254, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Class Room Status";
            // 
            // btnsave1
            // 
            this.btnsave1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave1.Location = new System.Drawing.Point(398, 368);
            this.btnsave1.Name = "btnsave1";
            this.btnsave1.Size = new System.Drawing.Size(75, 23);
            this.btnsave1.TabIndex = 16;
            this.btnsave1.Text = "Save";
            this.btnsave1.UseVisualStyleBackColor = true;
            this.btnsave1.Click += new System.EventHandler(this.btnsave1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(381, 675);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(398, 311);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(159, 21);
            this.comboStatus.TabIndex = 19;
            // 
            // school_SystemDataSet7
            // 
            this.school_SystemDataSet7.DataSetName = "School_SystemDataSet7";
            this.school_SystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classRoomsBindingSource
            // 
            this.classRoomsBindingSource.DataMember = "ClassRooms";
            this.classRoomsBindingSource.DataSource = this.school_SystemDataSet7;
            // 
            // classRoomsTableAdapter
            // 
            this.classRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // Manage_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PakTurk_school_system.Properties.Resources._1_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 752);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsave1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clsCapacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clsRoomNo);
            this.Controls.Add(this.clsSection);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clsName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Class";
            this.Text = "Class Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Manage_Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_SystemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clsSection;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clsRoomNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clsCapacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsave1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboStatus;
        private School_SystemDataSet7 school_SystemDataSet7;
        private System.Windows.Forms.BindingSource classRoomsBindingSource;
        private PakTurk_school_system.School_SystemDataSet7TableAdapters.ClassRoomsTableAdapter classRoomsTableAdapter;
    }
}