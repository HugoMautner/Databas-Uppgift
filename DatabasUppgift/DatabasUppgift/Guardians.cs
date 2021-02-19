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
    public partial class Guardians : Form
    {
        public Guardians()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void btnLoadGuardians_Click(object sender, EventArgs e)
        {
            //Loading students, change to load guardians later

            var students = SqliteDataAccess.LoadStudents();
            foreach (StudentModel s in students)
                lBoxGuardians.Items.Add(s.first_name);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
