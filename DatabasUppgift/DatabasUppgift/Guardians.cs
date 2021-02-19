using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace DatabasUppgift
{
    public partial class Guardians : Form
    {
        public Guardians()
        {
            InitializeComponent();

            LoadGuardians();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void btnLoadGuardians_Click(object sender, EventArgs e)
        {
            LoadGuardians();
        }

        private void btnSubmitFind_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(tBoxID.Text);
                //ändra till .LoadGuardians()
                var guardians = SqliteDataAccess.LoadStudents();

                foreach (StudentModel gm in guardians)
                {
                    if (id == gm.id)
                    {
                        Debug.WriteLine("Guardian found!");
                        pnlOptions.Hide();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxID.Clear();
                return;
            }

            MessageBox.Show("Guardian not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tBoxID.Clear();
        }

        private void LoadGuardians()
        {
            //Loading students, change to load guardians later

            lBoxGuardians.Items.Clear();

            var students = SqliteDataAccess.LoadStudents();
            foreach (StudentModel s in students)
                lBoxGuardians.Items.Add(s.first_name);
        }

    }
}
