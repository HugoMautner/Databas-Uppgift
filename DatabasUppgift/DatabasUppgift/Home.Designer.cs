namespace DatabasUppgift
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnAddStudent;
            this.Title = new System.Windows.Forms.TextBox();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnGuardians = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnDefineStudent = new System.Windows.Forms.Button();
            this.btnDefineTeacher = new System.Windows.Forms.Button();
            this.btnAddTeachers = new System.Windows.Forms.Button();
            this.btnAddGuardian = new System.Windows.Forms.Button();
            this.btnAddCourses = new System.Windows.Forms.Button();
            this.btnAddClasses = new System.Windows.Forms.Button();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.pnlGuardians = new System.Windows.Forms.Panel();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.pnlClasses = new System.Windows.Forms.Panel();
            btnAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAddStudent.Location = new System.Drawing.Point(449, 219);
            btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new System.Drawing.Size(304, 79);
            btnAddStudent.TabIndex = 26;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click_1);
            // 
            // Title
            // 
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(528, 15);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(705, 112);
            this.Title.TabIndex = 1;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(81, 219);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(304, 79);
            this.btnStudents.TabIndex = 5;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnGuardians
            // 
            this.btnGuardians.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardians.Location = new System.Drawing.Point(81, 748);
            this.btnGuardians.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardians.Name = "btnGuardians";
            this.btnGuardians.Size = new System.Drawing.Size(304, 79);
            this.btnGuardians.TabIndex = 9;
            this.btnGuardians.Text = "Guardians";
            this.btnGuardians.UseVisualStyleBackColor = true;
            this.btnGuardians.Click += new System.EventHandler(this.btnAddGuardian_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Location = new System.Drawing.Point(81, 482);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(304, 79);
            this.btnCourses.TabIndex = 7;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.Location = new System.Drawing.Point(81, 352);
            this.btnTeachers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(304, 79);
            this.btnTeachers.TabIndex = 6;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(148, 31);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(64, 28);
            this.lblPage.TabIndex = 24;
            this.lblPage.Text = "Home";
            // 
            // btnClasses
            // 
            this.btnClasses.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasses.Location = new System.Drawing.Point(81, 615);
            this.btnClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(304, 79);
            this.btnClasses.TabIndex = 8;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnDefineStudent
            // 
            this.btnDefineStudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefineStudent.Location = new System.Drawing.Point(761, 219);
            this.btnDefineStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDefineStudent.Name = "btnDefineStudent";
            this.btnDefineStudent.Size = new System.Drawing.Size(304, 79);
            this.btnDefineStudent.TabIndex = 27;
            this.btnDefineStudent.Text = "Define";
            this.btnDefineStudent.UseVisualStyleBackColor = true;
            this.btnDefineStudent.Click += new System.EventHandler(this.btnDefineStudent_Click);
            // 
            // btnDefineTeacher
            // 
            this.btnDefineTeacher.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefineTeacher.Location = new System.Drawing.Point(761, 352);
            this.btnDefineTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDefineTeacher.Name = "btnDefineTeacher";
            this.btnDefineTeacher.Size = new System.Drawing.Size(304, 79);
            this.btnDefineTeacher.TabIndex = 29;
            this.btnDefineTeacher.Text = "Define";
            this.btnDefineTeacher.UseVisualStyleBackColor = true;
            this.btnDefineTeacher.Click += new System.EventHandler(this.btnDefineTeacher_Click);
            // 
            // btnAddTeachers
            // 
            this.btnAddTeachers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeachers.Location = new System.Drawing.Point(449, 352);
            this.btnAddTeachers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTeachers.Name = "btnAddTeachers";
            this.btnAddTeachers.Size = new System.Drawing.Size(304, 79);
            this.btnAddTeachers.TabIndex = 28;
            this.btnAddTeachers.Text = "Add";
            this.btnAddTeachers.UseVisualStyleBackColor = true;
            this.btnAddTeachers.Click += new System.EventHandler(this.btnAddTeachers_Click);
            // 
            // btnAddGuardian
            // 
            this.btnAddGuardian.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuardian.Location = new System.Drawing.Point(449, 748);
            this.btnAddGuardian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddGuardian.Name = "btnAddGuardian";
            this.btnAddGuardian.Size = new System.Drawing.Size(304, 79);
            this.btnAddGuardian.TabIndex = 30;
            this.btnAddGuardian.Text = "Add";
            this.btnAddGuardian.UseVisualStyleBackColor = true;
            this.btnAddGuardian.Click += new System.EventHandler(this.btnAddGuardian_Click_1);
            // 
            // btnAddCourses
            // 
            this.btnAddCourses.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourses.Location = new System.Drawing.Point(449, 482);
            this.btnAddCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCourses.Name = "btnAddCourses";
            this.btnAddCourses.Size = new System.Drawing.Size(304, 79);
            this.btnAddCourses.TabIndex = 31;
            this.btnAddCourses.Text = "Add";
            this.btnAddCourses.UseVisualStyleBackColor = true;
            this.btnAddCourses.Click += new System.EventHandler(this.btnAddCourses_Click);
            // 
            // btnAddClasses
            // 
            this.btnAddClasses.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClasses.Location = new System.Drawing.Point(449, 615);
            this.btnAddClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddClasses.Name = "btnAddClasses";
            this.btnAddClasses.Size = new System.Drawing.Size(304, 79);
            this.btnAddClasses.TabIndex = 32;
            this.btnAddClasses.Text = "Add";
            this.btnAddClasses.UseVisualStyleBackColor = true;
            this.btnAddClasses.Click += new System.EventHandler(this.btnAddClasses_Click);
            // 
            // pnlStudents
            // 
            this.pnlStudents.Location = new System.Drawing.Point(449, 265);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(616, 79);
            this.pnlStudents.TabIndex = 33;
            // 
            // pnlGuardians
            // 
            this.pnlGuardians.Location = new System.Drawing.Point(449, 780);
            this.pnlGuardians.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGuardians.Name = "pnlGuardians";
            this.pnlGuardians.Size = new System.Drawing.Size(616, 79);
            this.pnlGuardians.TabIndex = 34;
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Location = new System.Drawing.Point(449, 352);
            this.pnlTeachers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(616, 79);
            this.pnlTeachers.TabIndex = 34;
            // 
            // pnlCourses
            // 
            this.pnlCourses.Location = new System.Drawing.Point(449, 482);
            this.pnlCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(616, 79);
            this.pnlCourses.TabIndex = 34;
            // 
            // pnlClasses
            // 
            this.pnlClasses.Location = new System.Drawing.Point(449, 615);
            this.pnlClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlClasses.Name = "pnlClasses";
            this.pnlClasses.Size = new System.Drawing.Size(616, 79);
            this.pnlClasses.TabIndex = 35;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 1040);
            this.Controls.Add(this.pnlClasses);
            this.Controls.Add(this.pnlCourses);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlTeachers);
            this.Controls.Add(this.pnlGuardians);
            this.Controls.Add(this.btnAddClasses);
            this.Controls.Add(this.btnAddCourses);
            this.Controls.Add(this.btnAddGuardian);
            this.Controls.Add(this.btnDefineTeacher);
            this.Controls.Add(this.btnAddTeachers);
            this.Controls.Add(this.btnDefineStudent);
            this.Controls.Add(btnAddStudent);
            this.Controls.Add(this.btnClasses);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnGuardians);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnGuardians;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnDefineStudent;
        private System.Windows.Forms.Button btnDefineTeacher;
        private System.Windows.Forms.Button btnAddTeachers;
        private System.Windows.Forms.Button btnAddGuardian;
        private System.Windows.Forms.Button btnAddCourses;
        private System.Windows.Forms.Button btnAddClasses;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlGuardians;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlCourses;
        private System.Windows.Forms.Panel pnlClasses;
    }
}

