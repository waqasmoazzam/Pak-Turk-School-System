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
    public partial class Teachers : Form
    {
        public Login li;
        public string ClassName = null;
        public Teachers(Login l)
        {
            li = l;
            
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            //Login li = new Login();
            li.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(null, this, null);
            this.Hide();
            cp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewMarksTeacher vm = new ViewMarksTeacher(this);
            this.Hide();
            vm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mark_Attendence ma = new Mark_Attendence(this);
            assignSubjectService.manageTeacher mtws = new PakTurk_school_system.assignSubjectService.manageTeacher();
            ClassName = mtws.getTeacherDetailsBLL(li.user);
            if (Int32.Parse(ClassName) > 0)
            {
                //MessageBox.Show(ClassID,"class Id returned ");
                this.Hide();
                ma.Show();
            }
            else 
            {
                MessageBox.Show("You have not been assigned as Class Teacher to any class","Permission Denied");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enter_Marks em = new Enter_Marks(this);
            em.Show();
            this.Hide();

        }
    }
}
