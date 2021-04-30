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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            LoadTeachers();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tBoxFirstName.Text == "" || tBoxLastName.Text == "")
            {
                MessageBox.Show("First Name and Last Name must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TeacherModel teacher = new TeacherModel(-1, tBoxFirstName.Text,
                tBoxLastName.Text, tBoxAdress.Text, tBoxTelenr.Text, tBoxEpost.Text);
            SqliteDataAccess.SaveTeacher(teacher);

            LoadTeachers();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }



        #region Help methods
        private void LoadTeachers()
        {
            lBoxTeachers.Items.Clear();
            var teachers = SqliteDataAccess.LoadTeachers();
            foreach (TeacherModel t in teachers)
                lBoxTeachers.Items.Add(t.NameAndId);
        }

        #endregion

    }
}
