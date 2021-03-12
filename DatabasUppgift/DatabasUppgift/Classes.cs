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
    public partial class Classes : Form
    {
        string name;

        public Classes()
        {
            InitializeComponent();

            LoadClasses();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void btnLoadClasses_Click(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            lBoxClasses.Items.Clear();

            var classes = SqliteDataAccess.LoadClasses();
            foreach (ClassModel c in classes)
                lBoxClasses.Items.Add(c.ToString());
        }

        private void btnSubmitFind_Click(object sender, EventArgs e)
        {
            try
            {
                name = tBoxID.Text;
                var classes = SqliteDataAccess.LoadClasses();

                foreach (ClassModel cm in classes)
                {
                    if (name == cm.ToString())
                    {
                        MessageBox.Show("Found " + cm, "Found class!", MessageBoxButtons.OK);
                        tb_DisplayClass.Text = cm.ToString();
                        pnlOptions.Hide();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxID.Clear();
                return;
            }

            MessageBox.Show("Class not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tBoxID.Clear();
        }
    }
}
