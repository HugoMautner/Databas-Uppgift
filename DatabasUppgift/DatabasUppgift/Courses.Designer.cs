namespace DatabasUppgift
{
    partial class Courses
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
            this.lblPage = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.gBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.tBoxTeacher = new System.Windows.Forms.TextBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gBoxAddStudent.SuspendLayout();
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
            this.Title.TabIndex = 4;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(111, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(66, 23);
            this.lblPage.TabIndex = 27;
            this.lblPage.Text = "Courses";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1236, 786);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 47);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // gBoxAddStudent
            // 
            this.gBoxAddStudent.Controls.Add(this.tBoxTeacher);
            this.gBoxAddStudent.Controls.Add(this.lblTeacher);
            this.gBoxAddStudent.Controls.Add(this.btnSubmit);
            this.gBoxAddStudent.Controls.Add(this.tBoxName);
            this.gBoxAddStudent.Controls.Add(this.lblName);
            this.gBoxAddStudent.Location = new System.Drawing.Point(968, 178);
            this.gBoxAddStudent.Name = "gBoxAddStudent";
            this.gBoxAddStudent.Size = new System.Drawing.Size(282, 178);
            this.gBoxAddStudent.TabIndex = 29;
            this.gBoxAddStudent.TabStop = false;
            this.gBoxAddStudent.Text = "Enter Course Details";
            // 
            // tBoxTeacher
            // 
            this.tBoxTeacher.Location = new System.Drawing.Point(106, 61);
            this.tBoxTeacher.Name = "tBoxTeacher";
            this.tBoxTeacher.Size = new System.Drawing.Size(170, 20);
            this.tBoxTeacher.TabIndex = 7;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(6, 64);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(47, 13);
            this.lblTeacher.TabIndex = 6;
            this.lblTeacher.Text = "Teacher";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(201, 149);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(106, 30);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(170, 20);
            this.tBoxName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.gBoxAddStudent);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.Title);
            this.Name = "Courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.gBoxAddStudent.ResumeLayout(false);
            this.gBoxAddStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gBoxAddStudent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tBoxTeacher;
        private System.Windows.Forms.Label lblTeacher;
    }
}