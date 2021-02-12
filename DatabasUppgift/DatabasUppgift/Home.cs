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
            Students s = new Students();
            s.Tag = this;
            s.Show(this);
            Hide();
        }

        private void btnAddGuardian_Click(object sender, EventArgs e)
        {
            Guardians g = new Guardians();
            g.Tag = this;
            g.Show(this);
            Hide();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.Tag = this;
            t.Show(this);
            Hide();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            Courses c = new Courses();
            c.Tag = this;
            c.Show(this);
            Hide();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            Classes c = new Classes();
            c.Tag = this;
            c.Show(this);
            Hide();
        }
    }
}
