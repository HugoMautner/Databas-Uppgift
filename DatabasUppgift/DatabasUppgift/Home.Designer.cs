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
            this.btnAdd = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddGuardian = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.pnlAddOptions = new System.Windows.Forms.Panel();
            this.btnChangeTeacher = new System.Windows.Forms.Button();
            this.btnChangeCourse = new System.Windows.Forms.Button();
            this.btnChangeGuardian = new System.Windows.Forms.Button();
            this.btnChangeStudent = new System.Windows.Forms.Button();
            this.pnlChangeOptions = new System.Windows.Forms.Panel();
            this.pnlRemoveOptions = new System.Windows.Forms.Panel();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnRemoveGuardian = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnFindTeacher = new System.Windows.Forms.Button();
            this.btnFindCourse = new System.Windows.Forms.Button();
            this.btnFindGuardian = new System.Windows.Forms.Button();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.pnlFindOptions = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(111, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 64);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AppPerson_Click);
            // 
            // Title
            // 
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(396, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(529, 97);
            this.Title.TabIndex = 1;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(111, 348);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(228, 64);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(111, 488);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(228, 64);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(111, 628);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(228, 64);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(396, 207);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(228, 64);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddGuardian
            // 
            this.btnAddGuardian.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuardian.Location = new System.Drawing.Point(630, 207);
            this.btnAddGuardian.Name = "btnAddGuardian";
            this.btnAddGuardian.Size = new System.Drawing.Size(228, 64);
            this.btnAddGuardian.TabIndex = 6;
            this.btnAddGuardian.Text = "Guardian";
            this.btnAddGuardian.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(864, 207);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(228, 64);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Location = new System.Drawing.Point(1098, 207);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(228, 64);
            this.btnAddTeacher.TabIndex = 8;
            this.btnAddTeacher.Text = "Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // pnlAddOptions
            // 
            this.pnlAddOptions.Location = new System.Drawing.Point(396, 253);
            this.pnlAddOptions.Name = "pnlAddOptions";
            this.pnlAddOptions.Size = new System.Drawing.Size(930, 64);
            this.pnlAddOptions.TabIndex = 9;
            // 
            // btnChangeTeacher
            // 
            this.btnChangeTeacher.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTeacher.Location = new System.Drawing.Point(1098, 348);
            this.btnChangeTeacher.Name = "btnChangeTeacher";
            this.btnChangeTeacher.Size = new System.Drawing.Size(228, 64);
            this.btnChangeTeacher.TabIndex = 14;
            this.btnChangeTeacher.Text = "Teacher";
            this.btnChangeTeacher.UseVisualStyleBackColor = true;
            // 
            // btnChangeCourse
            // 
            this.btnChangeCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCourse.Location = new System.Drawing.Point(864, 348);
            this.btnChangeCourse.Name = "btnChangeCourse";
            this.btnChangeCourse.Size = new System.Drawing.Size(228, 64);
            this.btnChangeCourse.TabIndex = 13;
            this.btnChangeCourse.Text = "Course";
            this.btnChangeCourse.UseVisualStyleBackColor = true;
            // 
            // btnChangeGuardian
            // 
            this.btnChangeGuardian.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeGuardian.Location = new System.Drawing.Point(630, 348);
            this.btnChangeGuardian.Name = "btnChangeGuardian";
            this.btnChangeGuardian.Size = new System.Drawing.Size(228, 64);
            this.btnChangeGuardian.TabIndex = 12;
            this.btnChangeGuardian.Text = "Guardian";
            this.btnChangeGuardian.UseVisualStyleBackColor = true;
            // 
            // btnChangeStudent
            // 
            this.btnChangeStudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStudent.Location = new System.Drawing.Point(396, 348);
            this.btnChangeStudent.Name = "btnChangeStudent";
            this.btnChangeStudent.Size = new System.Drawing.Size(228, 64);
            this.btnChangeStudent.TabIndex = 11;
            this.btnChangeStudent.Text = "Student";
            this.btnChangeStudent.UseVisualStyleBackColor = true;
            this.btnChangeStudent.Click += new System.EventHandler(this.btnChangeStudent_Click);
            // 
            // pnlChangeOptions
            // 
            this.pnlChangeOptions.Location = new System.Drawing.Point(396, 392);
            this.pnlChangeOptions.Name = "pnlChangeOptions";
            this.pnlChangeOptions.Size = new System.Drawing.Size(930, 64);
            this.pnlChangeOptions.TabIndex = 10;
            // 
            // pnlRemoveOptions
            // 
            this.pnlRemoveOptions.Location = new System.Drawing.Point(396, 534);
            this.pnlRemoveOptions.Name = "pnlRemoveOptions";
            this.pnlRemoveOptions.Size = new System.Drawing.Size(930, 64);
            this.pnlRemoveOptions.TabIndex = 15;
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTeacher.Location = new System.Drawing.Point(1098, 488);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(228, 64);
            this.btnRemoveTeacher.TabIndex = 19;
            this.btnRemoveTeacher.Text = "Teacher";
            this.btnRemoveTeacher.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.Location = new System.Drawing.Point(864, 488);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(228, 64);
            this.btnRemoveCourse.TabIndex = 18;
            this.btnRemoveCourse.Text = "Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            // 
            // btnRemoveGuardian
            // 
            this.btnRemoveGuardian.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGuardian.Location = new System.Drawing.Point(630, 488);
            this.btnRemoveGuardian.Name = "btnRemoveGuardian";
            this.btnRemoveGuardian.Size = new System.Drawing.Size(228, 64);
            this.btnRemoveGuardian.TabIndex = 17;
            this.btnRemoveGuardian.Text = "Guardian";
            this.btnRemoveGuardian.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(396, 488);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(228, 64);
            this.btnRemoveStudent.TabIndex = 16;
            this.btnRemoveStudent.Text = "Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // btnFindTeacher
            // 
            this.btnFindTeacher.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindTeacher.Location = new System.Drawing.Point(1098, 628);
            this.btnFindTeacher.Name = "btnFindTeacher";
            this.btnFindTeacher.Size = new System.Drawing.Size(228, 64);
            this.btnFindTeacher.TabIndex = 23;
            this.btnFindTeacher.Text = "Teacher";
            this.btnFindTeacher.UseVisualStyleBackColor = true;
            // 
            // btnFindCourse
            // 
            this.btnFindCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCourse.Location = new System.Drawing.Point(864, 628);
            this.btnFindCourse.Name = "btnFindCourse";
            this.btnFindCourse.Size = new System.Drawing.Size(228, 64);
            this.btnFindCourse.TabIndex = 22;
            this.btnFindCourse.Text = "Course";
            this.btnFindCourse.UseVisualStyleBackColor = true;
            // 
            // btnFindGuardian
            // 
            this.btnFindGuardian.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindGuardian.Location = new System.Drawing.Point(630, 628);
            this.btnFindGuardian.Name = "btnFindGuardian";
            this.btnFindGuardian.Size = new System.Drawing.Size(228, 64);
            this.btnFindGuardian.TabIndex = 21;
            this.btnFindGuardian.Text = "Guardian";
            this.btnFindGuardian.UseVisualStyleBackColor = true;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindStudent.Location = new System.Drawing.Point(396, 628);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(228, 64);
            this.btnFindStudent.TabIndex = 20;
            this.btnFindStudent.Text = "Student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            // 
            // pnlFindOptions
            // 
            this.pnlFindOptions.Location = new System.Drawing.Point(396, 675);
            this.pnlFindOptions.Name = "pnlFindOptions";
            this.pnlFindOptions.Size = new System.Drawing.Size(930, 64);
            this.pnlFindOptions.TabIndex = 16;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.pnlFindOptions);
            this.Controls.Add(this.btnFindTeacher);
            this.Controls.Add(this.btnFindCourse);
            this.Controls.Add(this.btnFindGuardian);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.pnlRemoveOptions);
            this.Controls.Add(this.btnRemoveTeacher);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnRemoveGuardian);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.pnlChangeOptions);
            this.Controls.Add(this.btnChangeTeacher);
            this.Controls.Add(this.btnChangeCourse);
            this.Controls.Add(this.btnChangeGuardian);
            this.Controls.Add(this.btnChangeStudent);
            this.Controls.Add(this.pnlAddOptions);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnAddGuardian);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnAdd);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddGuardian;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Panel pnlAddOptions;
        private System.Windows.Forms.Button btnChangeTeacher;
        private System.Windows.Forms.Button btnChangeCourse;
        private System.Windows.Forms.Button btnChangeGuardian;
        private System.Windows.Forms.Button btnChangeStudent;
        private System.Windows.Forms.Panel pnlChangeOptions;
        private System.Windows.Forms.Panel pnlRemoveOptions;
        private System.Windows.Forms.Button btnRemoveTeacher;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnRemoveGuardian;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnFindTeacher;
        private System.Windows.Forms.Button btnFindCourse;
        private System.Windows.Forms.Button btnFindGuardian;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Panel pnlFindOptions;
    }
}

