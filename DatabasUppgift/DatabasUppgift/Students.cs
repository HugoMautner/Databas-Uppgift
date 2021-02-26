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
            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //lägg till error om saker inte går igenom
            string firstName = tBoxFirstName.Text;
            string lastName = tBoxLastName.Text;
            string adress = tBoxAdress.Text;
            string telenr = tBoxTelenr.Text;
            string epost = tBoxEpost.Text;

            StudentModel student = new StudentModel(-1, tBoxFirstName.Text, 
                tBoxLastName.Text, tBoxAdress.Text, tBoxTelenr.Text, tBoxEpost.Text);
            new SqliteDataAccess().SaveStudent(student);

            var home = (Home)Tag;
            home.Show();
            Close();
        }

        private void BtnSubmitRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                id = Int32.Parse(tBoxID.Text);

                //DEN HÄR FUNKAR INTE AV NÅGON ANELDNING SEND HELP
                if (GetStudent(id) != null)
                {
                    Debug.WriteLine("Student found!");
                    pnlOptions.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = -1;
                tBoxID.Clear();
                pnlOptions.Show();
                return;
            }

            MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            id = -1;
            tBoxID.Clear();
            pnlOptions.Show();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }




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



        private void Btn_SubmitChange_Click(object sender, EventArgs e)
        {
            StudentModel studentToChange = GetStudent(id);
            StudentModel student = new StudentModel(
                1, 
                tb_ChangeFirstName.Text != "" ? tb_ChangeFirstName.Text : studentToChange.first_name,
                tb_ChangeLastName.Text != "" ? tb_ChangeLastName.Text : studentToChange.last_name,
                tb_ChangeAdress.Text != "" ? tb_ChangeAdress.Text : studentToChange.adress,
                tb_ChangePhoneNumber.Text != "" ? tb_ChangePhoneNumber.Text : studentToChange.phone_number,
                tb_ChangeEpost.Text != "" ? tb_ChangeEpost.Text : studentToChange.e_mail);
            
            new SqliteDataAccess().ChangeStudent(student);
        }

        private void BtnRemove_Click_1(object sender, EventArgs e)
        {
            new SqliteDataAccess().RemoveStudent(id);
        }
    }
}
