using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabasUppgift
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = tBoxFirstName.Text;
            string lastName = tBoxLastName.Text;
            string adress = tBoxAdress.Text;
            string teleNr = tBoxTelenr.Text;
            string epost = tBoxEpost.Text;

            //Gotta check for bad input before
            //Student student = new Student(firstName, lastName, adress, teleNr, epost);
        }

        private void btnSubmitRemove_Click(object sender, EventArgs e)
        {
            string id = tBoxID.Text;

            //remove student(id)
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
