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
            this.gBoxAddCourse = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gBoxCourses = new System.Windows.Forms.GroupBox();
            this.btnLoadCourses = new System.Windows.Forms.Button();
            this.lBoxCourses = new System.Windows.Forms.ListBox();
            this.gBoxFindGuardian = new System.Windows.Forms.GroupBox();
            this.btnSubmitFind = new System.Windows.Forms.Button();
            this.tBoxFindName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_DisplayCourse = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gBoxAddCourse.SuspendLayout();
            this.gBoxCourses.SuspendLayout();
            this.gBoxFindGuardian.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // gBoxAddCourse
            // 
            this.gBoxAddCourse.Controls.Add(this.btnSubmit);
            this.gBoxAddCourse.Controls.Add(this.tBoxName);
            this.gBoxAddCourse.Controls.Add(this.lblName);
            this.gBoxAddCourse.Location = new System.Drawing.Point(497, 175);
            this.gBoxAddCourse.Name = "gBoxAddCourse";
            this.gBoxAddCourse.Size = new System.Drawing.Size(282, 103);
            this.gBoxAddCourse.TabIndex = 29;
            this.gBoxAddCourse.TabStop = false;
            this.gBoxAddCourse.Text = "Enter Course Details";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(201, 74);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(96, 30);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(180, 20);
            this.tBoxName.TabIndex = 6;
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
            // gBoxCourses
            // 
            this.gBoxCourses.Controls.Add(this.btnLoadCourses);
            this.gBoxCourses.Controls.Add(this.lBoxCourses);
            this.gBoxCourses.Location = new System.Drawing.Point(70, 175);
            this.gBoxCourses.Name = "gBoxCourses";
            this.gBoxCourses.Size = new System.Drawing.Size(282, 611);
            this.gBoxCourses.TabIndex = 31;
            this.gBoxCourses.TabStop = false;
            this.gBoxCourses.Text = "Classes";
            // 
            // btnLoadCourses
            // 
            this.btnLoadCourses.Location = new System.Drawing.Point(181, 577);
            this.btnLoadCourses.Name = "btnLoadCourses";
            this.btnLoadCourses.Size = new System.Drawing.Size(95, 28);
            this.btnLoadCourses.TabIndex = 10;
            this.btnLoadCourses.Text = "Load courses";
            this.btnLoadCourses.UseVisualStyleBackColor = true;
            this.btnLoadCourses.Click += new System.EventHandler(this.btnLoadCourses_Click);
            // 
            // lBoxCourses
            // 
            this.lBoxCourses.FormattingEnabled = true;
            this.lBoxCourses.Location = new System.Drawing.Point(6, 34);
            this.lBoxCourses.Name = "lBoxCourses";
            this.lBoxCourses.Size = new System.Drawing.Size(270, 537);
            this.lBoxCourses.TabIndex = 11;
            // 
            // gBoxFindGuardian
            // 
            this.gBoxFindGuardian.Controls.Add(this.btnSubmitFind);
            this.gBoxFindGuardian.Controls.Add(this.tBoxFindName);
            this.gBoxFindGuardian.Controls.Add(this.lblID);
            this.gBoxFindGuardian.Location = new System.Drawing.Point(907, 175);
            this.gBoxFindGuardian.Name = "gBoxFindGuardian";
            this.gBoxFindGuardian.Size = new System.Drawing.Size(282, 109);
            this.gBoxFindGuardian.TabIndex = 35;
            this.gBoxFindGuardian.TabStop = false;
            this.gBoxFindGuardian.Text = "Enter course to find";
            // 
            // btnSubmitFind
            // 
            this.btnSubmitFind.Location = new System.Drawing.Point(201, 80);
            this.btnSubmitFind.Name = "btnSubmitFind";
            this.btnSubmitFind.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitFind.TabIndex = 5;
            this.btnSubmitFind.Text = "Submit";
            this.btnSubmitFind.UseVisualStyleBackColor = true;
            this.btnSubmitFind.Click += new System.EventHandler(this.btnSubmitFind_Click);
            // 
            // tBoxFindName
            // 
            this.tBoxFindName.Location = new System.Drawing.Point(106, 30);
            this.tBoxFindName.Name = "tBoxFindName";
            this.tBoxFindName.Size = new System.Drawing.Size(170, 20);
            this.tBoxFindName.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_DisplayCourse);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Location = new System.Drawing.Point(907, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 106);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose action for";
            // 
            // tb_DisplayCourse
            // 
            this.tb_DisplayCourse.Enabled = false;
            this.tb_DisplayCourse.Location = new System.Drawing.Point(6, 33);
            this.tb_DisplayCourse.Name = "tb_DisplayCourse";
            this.tb_DisplayCourse.Size = new System.Drawing.Size(270, 20);
            this.tb_DisplayCourse.TabIndex = 33;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(201, 78);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 22);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(897, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 149);
            this.panel1.TabIndex = 41;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoxCourses);
            this.Controls.Add(this.gBoxFindGuardian);
            this.Controls.Add(this.gBoxAddCourse);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.Title);
            this.Name = "Courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.gBoxAddCourse.ResumeLayout(false);
            this.gBoxAddCourse.PerformLayout();
            this.gBoxCourses.ResumeLayout(false);
            this.gBoxFindGuardian.ResumeLayout(false);
            this.gBoxFindGuardian.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gBoxAddCourse;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gBoxCourses;
        private System.Windows.Forms.Button btnLoadCourses;
        private System.Windows.Forms.ListBox lBoxCourses;
        private System.Windows.Forms.GroupBox gBoxFindGuardian;
        private System.Windows.Forms.Button btnSubmitFind;
        private System.Windows.Forms.TextBox tBoxFindName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_DisplayCourse;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
    }
}