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
                lBoxClasses.Items.Add(c.name);
        }

        private void btnSubmitFind_Click(object sender, EventArgs e)
        {
            try
            {
                name = tBoxID.Text;
                var classes = SqliteDataAccess.LoadClasses();

                foreach (ClassModel cm in classes)
                {
                    if (name == cm.name)
                    {
                        MessageBox.Show("Found " + cm.name, "Found class!", MessageBoxButtons.OK);
                        tb_DisplayClass.Text = cm.name;
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.RemoveClass(name);
            MessageBox.Show("Class with name " + name + " deleted", "Success", MessageBoxButtons.OK);
            pnlOptions.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var classes = SqliteDataAccess.LoadClasses();
            foreach (ClassModel cm in classes)
            {
                if (tb_Name.Text == cm.name)
                {
                    MessageBox.Show("There is already a class with that name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (tb_Name.Text == "")
            {
                MessageBox.Show("Please enter a name for the class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassModel c = new ClassModel(tb_Name.Text, 0);
            SqliteDataAccess.SaveClass(c);

            LoadClasses();
        }
    }
}
