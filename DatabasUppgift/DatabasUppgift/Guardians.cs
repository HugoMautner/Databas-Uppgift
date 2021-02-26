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
        int id;

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
                id = Int32.Parse(tBoxID.Text);
                var guardians = SqliteDataAccess.LoadGuardians();

                foreach (GuardianModel gm in guardians)
                {
                    if (id == gm.id)
                    {
                        MessageBox.Show("Found " + gm.FullName + " with id: " + gm.id, "Found guardian!", MessageBoxButtons.OK);
                        tb_DisplayGuardian.Text = gm.FullName;
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

            var guardians = SqliteDataAccess.LoadGuardians();
            foreach (GuardianModel g in guardians)
                lBoxGuardians.Items.Add(g.first_name);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            pnlNewDetails.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            new SqliteDataAccess().RemoveGuardian(id);
            MessageBox.Show("Guardian with ID " + id + "deleted", "Success", MessageBoxButtons.OK);
        }

        private void btn_SubmitChange_Click(object sender, EventArgs e)
        {
            GuardianModel guardian = new GuardianModel(id, tb_ChangeFirstName.Text, tb_ChangeLastName.Text, tb_ChangeAdress.Text, tb_ChangePhoneNumber.Text, tb_ChangeEpost.Text);
            new SqliteDataAccess().ChangeGuardian(guardian);
        }
    }
}
