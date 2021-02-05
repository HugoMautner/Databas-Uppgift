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

        private void AppPerson_Click(object sender, EventArgs e)
        {
            pnlAddOptions.Hide();

            pnlChangeOptions.Show();
            pnlRemoveOptions.Show();
            pnlFindOptions.Show();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            pnlChangeOptions.Hide();

            pnlAddOptions.Show();
            pnlRemoveOptions.Show();
            pnlFindOptions.Show();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            pnlRemoveOptions.Hide();

            pnlChangeOptions.Show();
            pnlAddOptions.Show();
            pnlFindOptions.Show();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            pnlFindOptions.Hide();

            pnlChangeOptions.Show();
            pnlRemoveOptions.Show();
            pnlAddOptions.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Form active = Form.ActiveForm;
            //active.IsMdiContainer = true;
            AddStudent addStudent = new AddStudent();
            //addStudent.MdiParent = active;
            //addStudent.Show();

            addStudent.ShowDialog();
        }


        private void btnChangeStudent_Click(object sender, EventArgs e)
        {

        }

    }
}
