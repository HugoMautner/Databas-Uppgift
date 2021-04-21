using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ta bort senare
using System.Diagnostics;

//Kanske är trevligt med en confirm-box innan man tar livet av folk

namespace DatabasUppgift
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            LoadStudents();
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            GoBack();
        }


        private void BtnSubmitAdd_Click(object sender, EventArgs e)
        {
            if (tBoxFirstName.Text == "" || tBoxLastName.Text == "")
            {
                MessageBox.Show("First Name and Last Name must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StudentModel student = new StudentModel(-1, tBoxFirstName.Text, 
                tBoxLastName.Text, tBoxAdress.Text, tBoxTelenr.Text, tBoxEpost.Text);
            SqliteDataAccess.SaveStudent(student);

            LoadStudents();
        }

        
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        


        #region Hjälpmetoder

        private void LoadStudents()
        {
            lBoxStudents.Items.Clear();
            var students = SqliteDataAccess.LoadStudents();
            foreach (StudentModel s in students)
                lBoxStudents.Items.Add(s.NameAndId);
        }


        private void GoBack()
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }



        #endregion
    }
}
