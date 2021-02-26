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
            this.Title = new System.Windows.Forms.TextBox();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnGuardians = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(396, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(529, 90);
            this.Title.TabIndex = 1;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(63, 198);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(228, 64);
            this.btnStudents.TabIndex = 5;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnGuardians
            // 
            this.btnGuardians.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardians.Location = new System.Drawing.Point(63, 307);
            this.btnGuardians.Name = "btnGuardians";
            this.btnGuardians.Size = new System.Drawing.Size(228, 64);
            this.btnGuardians.TabIndex = 6;
            this.btnGuardians.Text = "Guardians";
            this.btnGuardians.UseVisualStyleBackColor = true;
            this.btnGuardians.Click += new System.EventHandler(this.btnAddGuardian_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Location = new System.Drawing.Point(63, 418);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(228, 64);
            this.btnCourses.TabIndex = 7;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.Location = new System.Drawing.Point(63, 643);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(228, 64);
            this.btnTeachers.TabIndex = 8;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(111, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(49, 23);
            this.lblPage.TabIndex = 24;
            this.lblPage.Text = "Home";
            // 
            // btnClasses
            // 
            this.btnClasses.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasses.Location = new System.Drawing.Point(63, 530);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(228, 64);
            this.btnClasses.TabIndex = 25;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.btnClasses);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnGuardians);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.Title);
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
    }
}

