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
        int id = -1;

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
            new SqliteDataAccess().SaveStudent(student);

            LoadStudents();
        }

        private void BtnSubmitId_Click(object sender, EventArgs e)
        {
            id = ConvertToInt(tBoxID.Text);

            if (GetStudent(id) != null)
            {
                pnlOptions.Hide();
            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxID.Clear();
                pnlOptions.Show();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void Btn_SubmitChange_Click(object sender, EventArgs e)
        {
            if (tb_ChangeFirstName.Text == "" || tb_ChangeLastName.Text == "")
            {
                MessageBox.Show("First Name and Last Name must be filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StudentModel student = new StudentModel(
                id,
                tb_ChangeFirstName.Text,
                tb_ChangeLastName.Text,
                tb_ChangeAdress.Text,
                tb_ChangePhoneNumber.Text,
                tb_ChangeEpost.Text);


            new SqliteDataAccess().ChangeStudent(student);
            LoadStudents();
            pnlOptions.Show();
        }

        private void BtnRemove_Click_1(object sender, EventArgs e)
        {
            new SqliteDataAccess().RemoveStudent(id);
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


        private StudentModel GetStudent(int id)
        {
            var students = SqliteDataAccess.LoadStudents();

            foreach (StudentModel student in students)
            {
                if (id == student.id)
                {
                    return student;
                }
            }

            return null;
        }


        private int ConvertToInt(string id)
        {
            try
            {
                return Int32.Parse(id);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private void GoBack()
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }


        #endregion

        private void BtnChange_Click(object sender, EventArgs e)
        {
            StudentModel studentToChange = GetStudent(id);
            int count = 0;

            foreach (Control c in gBoxChange.Controls)
            {
                TextBox t = c as TextBox;

                if (t != null)
                {
                    t.Text = studentToChange.AllChangeableInfoArr()[count];
                    count++;
                }
            }
        }
    }
}
