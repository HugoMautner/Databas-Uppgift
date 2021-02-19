﻿using System;
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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = tBoxFirstName.Text;
            string lastName = tBoxLastName.Text;
            string adress = tBoxAdress.Text;
            string telenr = tBoxTelenr.Text;
            string epost = tBoxEpost.Text;

            StudentModel student = new StudentModel(-1, tBoxFirstName.Text, tBoxLastName.Text, tBoxAdress.Text, tBoxTelenr.Text, tBoxEpost.Text);
            new SqliteDataAccess().SaveStudent(student);

            Home home = new Home();
            this.Close();
        }
    }
}
