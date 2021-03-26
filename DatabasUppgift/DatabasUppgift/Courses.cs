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
        public Courses()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void tBoxName_Enter(object sender, EventArgs e)
        {
            if (tBoxName.Text == "Hugibert")
            {
                tBoxName.Text = "";
                tBoxName.ForeColor = Color.Black;
            }
        }
        private void tBoxName_Leave(object sender, EventArgs e)
        {
            if (tBoxName.Text == "")
            {
                tBoxName.Text = "Hugibert";
                tBoxName.ForeColor = Color.DimGray;
            }
        }
    }
}
