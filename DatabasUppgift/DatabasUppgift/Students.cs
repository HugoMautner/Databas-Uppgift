﻿using System;
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
                int id = Int32.Parse(tBoxID.Text);
                var students = SqliteDataAccess.LoadStudents();

                foreach (StudentModel sm in students)
                {
                    if (id == sm.id)
                    {
                        Debug.WriteLine("Student found!");
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

            MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tBoxID.Clear();
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

    }
}
