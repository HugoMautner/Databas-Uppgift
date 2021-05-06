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
    //Fixa med show/hide paneler
    //Börja arbeta på dependency mellan student och guardian
    //under btn submitclick lägg till all infromation med enters mellan grejerna, glöm inte helelr attt displaya klasser
    //guardians etc.


    public partial class StudentDefine : Form
    {
        int id = -1;

        public StudentDefine()
        {
            InitializeComponent();
            LoadAll();
        }

        private void BtnSubmitId_Click(object sender, EventArgs e)
        {
            id = ConvertToInt(tBoxID.Text);
            StudentModel student = GetStudent(id);

            if (student != null)
            {
                pnlOptions.Hide();
                tbStudentInformation.Text = student.AllInfoText;
                
                foreach (GuardianModel gm in SqliteDataAccess.GetGuardianRegistration(student))
                {
                    tbStudentInformation.AppendText(Environment.NewLine);
                    tbStudentInformation.AppendText("Guardian: " + gm.FullName + " ");
                }
            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxID.Clear();
                pnlOptions.Show();
                pnlChange.Show();
            }
        }


        private void BtnChange_Click(object sender, EventArgs e)
        {
            pnlChange.Hide();

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


        private void BtnRemove_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.RemoveStudent(id);
            pnlOptions.Show();
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


            SqliteDataAccess.ChangeStudent(student);
            LoadStudents();
            pnlChange.Show();
            pnlOptions.Show();
        }


        private void BtnSubmitGuardianId_Click(object sender, EventArgs e)
        {
            int guardianId = ConvertToInt(tbGuardianId.Text);

            if (GetGuardian(guardianId) != null)
            {
                GuardianRegistration gr = new GuardianRegistration(-1, id, guardianId);
                SqliteDataAccess.SaveGuardianRegistration(gr);

                ShowAllPanels();
                pnlOptions.Hide();
            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbGuardianId.Clear();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            var home = (Home)Tag;
            home.Show();
            Close();
        }


        #region Help Methods

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

        private GuardianModel GetGuardian(int id)
        {
            var guardians = SqliteDataAccess.LoadGuardians();

            foreach (GuardianModel guardian in guardians)
            {
                if (id == guardian.id)
                {
                    return guardian;
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


        private void LoadStudents()
        {
            lbStudents.Items.Clear();
            var students = SqliteDataAccess.LoadStudents();
            foreach (StudentModel s in students)
                lbStudents.Items.Add(s.NameAndId);
        }


        private void LoadGuardians()
        {
            lbGuardians.Items.Clear();
            var guardians = SqliteDataAccess.LoadGuardians();
            foreach (GuardianModel g in guardians)
            {
                lbGuardians.Items.Add(g.NameAndId);
            }
        }


        private void LoadAll()
        {
            LoadStudents();
            LoadGuardians();
        }


        private void ShowAllPanels()
        {
            foreach (var c in Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    Panel p = c as Panel;
                    p.Show();
                }
            }
        }


        #endregion

        private void BtnAddGuardian_Click(object sender, EventArgs e)
        {
            pnlGuardian.Hide();
        }

    }
}
