using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabasUppgift
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ShowAllPanels();
            pnlStudents.Hide();
        }


        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            Students s = new Students();
            s.Tag = this;
            s.Show(this);
            Hide();
        }
        private void btnDefineStudent_Click(object sender, EventArgs e)
        {
            StudentDefine sd = new StudentDefine();
            sd.Tag = this;
            sd.Show(this);
            Hide();
        }

        private void btnAddGuardian_Click(object sender, EventArgs e)
        {
            ShowAllPanels();
            pnlGuardians.Hide();
        }
        private void btnAddGuardian_Click_1(object sender, EventArgs e)
        {
            Guardians g = new Guardians();
            g.Tag = this;
            g.Show(this);
            Hide();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ShowAllPanels();
            pnlTeachers.Hide();
        }
        private void btnAddTeachers_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.Tag = this;
            t.Show(this);
            Hide();
        }
        private void btnDefineTeacher_Click(object sender, EventArgs e)
        {
            //Go to define teacher form
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            ShowAllPanels();
            pnlCourses.Hide();
        }
        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            Courses c = new Courses();
            c.Tag = this;
            c.Show(this);
            Hide();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            ShowAllPanels();
            pnlClasses.Hide();
        }
        private void btnAddClasses_Click(object sender, EventArgs e)
        {
            Classes c = new Classes();
            c.Tag = this;
            c.Show(this);
            Hide();
        }

        private void ShowAllPanels()
        {
            foreach (var c in Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    Panel p = c as Panel;
                    p.Show();
                }
            }
        }

    }
}
