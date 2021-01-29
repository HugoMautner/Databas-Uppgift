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
            this.pnlAddOptions.Location = new System.Drawing.Point(396, 249);
            this.pnlAddOptions.Name = "pnlAddOptions";
            this.pnlAddOptions.Size = new System.Drawing.Size(930, 64);
            this.pnlAddOptions.TabIndex = 9;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
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
    }
}

