namespace DatabasUppgift
{
    partial class Classes
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
            this.gBoxClasses = new System.Windows.Forms.GroupBox();
            this.lBoxClasses = new System.Windows.Forms.ListBox();
            this.btnLoadClasses = new System.Windows.Forms.Button();
            this.gBoxAddClass = new System.Windows.Forms.GroupBox();
            this.tb_Teacher = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_DisplayClass = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ChangeTeacher = new System.Windows.Forms.TextBox();
            this.btn_SubmitChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ChangeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNewDetails = new System.Windows.Forms.Panel();
            this.gBoxFindGuardian = new System.Windows.Forms.GroupBox();
            this.btnSubmitFind = new System.Windows.Forms.Button();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gBoxClasses.SuspendLayout();
            this.gBoxAddClass.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxFindGuardian.SuspendLayout();
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
            this.Title.TabIndex = 5;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(111, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(62, 23);
            this.lblPage.TabIndex = 28;
            this.lblPage.Text = "Classes";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1236, 786);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 47);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // gBoxClasses
            // 
            this.gBoxClasses.Controls.Add(this.lBoxClasses);
            this.gBoxClasses.Controls.Add(this.btnLoadClasses);
            this.gBoxClasses.Location = new System.Drawing.Point(70, 175);
            this.gBoxClasses.Name = "gBoxClasses";
            this.gBoxClasses.Size = new System.Drawing.Size(282, 611);
            this.gBoxClasses.TabIndex = 30;
            this.gBoxClasses.TabStop = false;
            this.gBoxClasses.Text = "Classes";
            // 
            // lBoxClasses
            // 
            this.lBoxClasses.FormattingEnabled = true;
            this.lBoxClasses.Location = new System.Drawing.Point(6, 30);
            this.lBoxClasses.Name = "lBoxClasses";
            this.lBoxClasses.Size = new System.Drawing.Size(270, 537);
            this.lBoxClasses.TabIndex = 11;
            // 
            // btnLoadClasses
            // 
            this.btnLoadClasses.Location = new System.Drawing.Point(181, 577);
            this.btnLoadClasses.Name = "btnLoadClasses";
            this.btnLoadClasses.Size = new System.Drawing.Size(95, 28);
            this.btnLoadClasses.TabIndex = 10;
            this.btnLoadClasses.Text = "Load classes";
            this.btnLoadClasses.UseVisualStyleBackColor = true;
            this.btnLoadClasses.Click += new System.EventHandler(this.btnLoadClasses_Click);
            // 
            // gBoxAddClass
            // 
            this.gBoxAddClass.Controls.Add(this.tb_Teacher);
            this.gBoxAddClass.Controls.Add(this.btnSubmit);
            this.gBoxAddClass.Controls.Add(this.lblLastName);
            this.gBoxAddClass.Controls.Add(this.tb_Name);
            this.gBoxAddClass.Controls.Add(this.lblFirstName);
            this.gBoxAddClass.Location = new System.Drawing.Point(497, 175);
            this.gBoxAddClass.Name = "gBoxAddClass";
            this.gBoxAddClass.Size = new System.Drawing.Size(282, 142);
            this.gBoxAddClass.TabIndex = 31;
            this.gBoxAddClass.TabStop = false;
            this.gBoxAddClass.Text = "Enter new class details";
            // 
            // tb_Teacher
            // 
            this.tb_Teacher.Location = new System.Drawing.Point(106, 61);
            this.tb_Teacher.Name = "tb_Teacher";
            this.tb_Teacher.Size = new System.Drawing.Size(170, 20);
            this.tb_Teacher.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(201, 110);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(47, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Teacher";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(106, 30);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(170, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Name";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Location = new System.Drawing.Point(575, 353);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(297, 126);
            this.pnlOptions.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_DisplayClass);
            this.groupBox2.Controls.Add(this.btnChange);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Location = new System.Drawing.Point(931, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 122);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose action for";
            // 
            // tb_DisplayClass
            // 
            this.tb_DisplayClass.Enabled = false;
            this.tb_DisplayClass.Location = new System.Drawing.Point(6, 19);
            this.tb_DisplayClass.Name = "tb_DisplayClass";
            this.tb_DisplayClass.Size = new System.Drawing.Size(270, 20);
            this.tb_DisplayClass.TabIndex = 33;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(6, 73);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(106, 41);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(156, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 41);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ChangeTeacher);
            this.groupBox1.Controls.Add(this.btn_SubmitChange);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_ChangeName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(931, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 133);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter new class details";
            // 
            // tb_ChangeTeacher
            // 
            this.tb_ChangeTeacher.Location = new System.Drawing.Point(106, 61);
            this.tb_ChangeTeacher.Name = "tb_ChangeTeacher";
            this.tb_ChangeTeacher.Size = new System.Drawing.Size(170, 20);
            this.tb_ChangeTeacher.TabIndex = 9;
            // 
            // btn_SubmitChange
            // 
            this.btn_SubmitChange.Location = new System.Drawing.Point(201, 104);
            this.btn_SubmitChange.Name = "btn_SubmitChange";
            this.btn_SubmitChange.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitChange.TabIndex = 5;
            this.btn_SubmitChange.Text = "Submit";
            this.btn_SubmitChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Teacher (id)";
            // 
            // tb_ChangeName
            // 
            this.tb_ChangeName.Location = new System.Drawing.Point(106, 30);
            this.tb_ChangeName.Name = "tb_ChangeName";
            this.tb_ChangeName.Size = new System.Drawing.Size(170, 20);
            this.tb_ChangeName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // pnlNewDetails
            // 
            this.pnlNewDetails.Location = new System.Drawing.Point(575, 499);
            this.pnlNewDetails.Name = "pnlNewDetails";
            this.pnlNewDetails.Size = new System.Drawing.Size(297, 235);
            this.pnlNewDetails.TabIndex = 10;
            // 
            // gBoxFindGuardian
            // 
            this.gBoxFindGuardian.Controls.Add(this.btnSubmitFind);
            this.gBoxFindGuardian.Controls.Add(this.tBoxID);
            this.gBoxFindGuardian.Controls.Add(this.lblName);
            this.gBoxFindGuardian.Location = new System.Drawing.Point(933, 175);
            this.gBoxFindGuardian.Name = "gBoxFindGuardian";
            this.gBoxFindGuardian.Size = new System.Drawing.Size(282, 109);
            this.gBoxFindGuardian.TabIndex = 36;
            this.gBoxFindGuardian.TabStop = false;
            this.gBoxFindGuardian.Text = "Enter class to find/edit";
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
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(106, 30);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(170, 20);
            this.tBoxID.TabIndex = 3;
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
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.pnlNewDetails);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxFindGuardian);
            this.Controls.Add(this.gBoxAddClass);
            this.Controls.Add(this.gBoxClasses);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.Title);
            this.Name = "Classes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes";
            this.gBoxClasses.ResumeLayout(false);
            this.gBoxAddClass.ResumeLayout(false);
            this.gBoxAddClass.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxFindGuardian.ResumeLayout(false);
            this.gBoxFindGuardian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gBoxClasses;
        private System.Windows.Forms.ListBox lBoxClasses;
        private System.Windows.Forms.Button btnLoadClasses;
        private System.Windows.Forms.GroupBox gBoxAddClass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_DisplayClass;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlNewDetails;
        private System.Windows.Forms.Button btn_SubmitChange;
        private System.Windows.Forms.TextBox tb_ChangeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gBoxFindGuardian;
        private System.Windows.Forms.Button btnSubmitFind;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tb_ChangeTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Teacher;
    }
}