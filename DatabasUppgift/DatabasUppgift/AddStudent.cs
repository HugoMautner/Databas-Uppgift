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
    public partial class AddStudent : Form
    {
        public AddStudent()
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
            string name = textBoxName.Text;

            //Student student = new Student();


            Home home = new Home();
            this.Close();

        }
    }
}
