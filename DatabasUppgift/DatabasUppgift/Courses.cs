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
    public partial class Courses : Form
    {
        string name;

        public Courses()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void btnLoadCourses_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var courses = SqliteDataAccess.LoadCourses();
            foreach (CourseModel cm in courses)
            {
                if (tBoxName.Text == cm.name)
                {
                    MessageBox.Show("There is already a class with that name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (tBoxName.Text == "")
            {
                MessageBox.Show("Please enter a name for the course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CourseModel c = new CourseModel(tBoxName.Text, 0);
            SqliteDataAccess.SaveCourse(c);

            LoadCourses();
        }


        private void LoadCourses()
        {
            lBoxCourses.Items.Clear();

            var courses = SqliteDataAccess.LoadCourses();
            foreach (CourseModel c in courses)
                lBoxCourses.Items.Add(c.name);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.RemoveCourse(name);
            MessageBox.Show("Course with name " + name + " deleted", "Success", MessageBoxButtons.OK);
            panel1.Show();
        }

        private void btnSubmitFind_Click(object sender, EventArgs e)
        {
            try
            {
                name = tBoxFindName.Text;
                var courses = SqliteDataAccess.LoadCourses();

                foreach (CourseModel c in courses)
                {
                    if (name == c.name)
                    {
                        MessageBox.Show("Found " + c.name, "Found course!", MessageBoxButtons.OK);
                        tb_DisplayCourse.Text = c.name;
                        panel1.Hide();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxFindName.Clear();
                return;
            }

            MessageBox.Show("Course not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tBoxFindName.Clear();
        }
    }
}
