namespace DatabasUppgift
{
    partial class Students
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
            this.btnHome = new System.Windows.Forms.Button();
            this.gBoxAdd = new System.Windows.Forms.GroupBox();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.btnSubmitAdd = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tBoxEpost = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.tBoxTelenr = new System.Windows.Forms.TextBox();
            this.tBoxAdress = new System.Windows.Forms.TextBox();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblTelenr = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.gBoxRemove = new System.Windows.Forms.GroupBox();
            this.btnSubmitRemove = new System.Windows.Forms.Button();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gBoxStudents = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lBoxStudents = new System.Windows.Forms.ListBox();
            this.gBoxAdd.SuspendLayout();
            this.gBoxRemove.SuspendLayout();
            this.gBoxStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(396, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(529, 97);
            this.Title.TabIndex = 2;
            this.Title.Text = "Softschool";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1236, 786);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 47);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // gBoxAdd
            // 
            this.gBoxAdd.Controls.Add(this.tBoxLastName);
            this.gBoxAdd.Controls.Add(this.btnSubmitAdd);
            this.gBoxAdd.Controls.Add(this.lblLastName);
            this.gBoxAdd.Controls.Add(this.tBoxEpost);
            this.gBoxAdd.Controls.Add(this.lblEpost);
            this.gBoxAdd.Controls.Add(this.tBoxTelenr);
            this.gBoxAdd.Controls.Add(this.tBoxAdress);
            this.gBoxAdd.Controls.Add(this.tBoxFirstName);
            this.gBoxAdd.Controls.Add(this.lblTelenr);
            this.gBoxAdd.Controls.Add(this.lblAdress);
            this.gBoxAdd.Controls.Add(this.lblFirstName);
            this.gBoxAdd.Location = new System.Drawing.Point(516, 175);
            this.gBoxAdd.Name = "gBoxAdd";
            this.gBoxAdd.Size = new System.Drawing.Size(282, 219);
            this.gBoxAdd.TabIndex = 4;
            this.gBoxAdd.TabStop = false;
            this.gBoxAdd.Text = "Enter student to add";
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Location = new System.Drawing.Point(106, 61);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(170, 20);
            this.tBoxLastName.TabIndex = 9;
            // 
            // btnSubmitAdd
            // 
            this.btnSubmitAdd.Location = new System.Drawing.Point(201, 190);
            this.btnSubmitAdd.Name = "btnSubmitAdd";
            this.btnSubmitAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAdd.TabIndex = 5;
            this.btnSubmitAdd.Text = "Submit";
            this.btnSubmitAdd.UseVisualStyleBackColor = true;
            this.btnSubmitAdd.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // tBoxEpost
            // 
            this.tBoxEpost.Location = new System.Drawing.Point(106, 153);
            this.tBoxEpost.Name = "tBoxEpost";
            this.tBoxEpost.Size = new System.Drawing.Size(170, 20);
            this.tBoxEpost.TabIndex = 7;
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(6, 156);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(37, 13);
            this.lblEpost.TabIndex = 6;
            this.lblEpost.Text = "E-post";
            // 
            // tBoxTelenr
            // 
            this.tBoxTelenr.Location = new System.Drawing.Point(106, 123);
            this.tBoxTelenr.Name = "tBoxTelenr";
            this.tBoxTelenr.Size = new System.Drawing.Size(170, 20);
            this.tBoxTelenr.TabIndex = 5;
            // 
            // tBoxAdress
            // 
            this.tBoxAdress.Location = new System.Drawing.Point(106, 93);
            this.tBoxAdress.Name = "tBoxAdress";
            this.tBoxAdress.Size = new System.Drawing.Size(170, 20);
            this.tBoxAdress.TabIndex = 4;
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.Location = new System.Drawing.Point(106, 30);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(170, 20);
            this.tBoxFirstName.TabIndex = 3;
            // 
            // lblTelenr
            // 
            this.lblTelenr.AutoSize = true;
            this.lblTelenr.Location = new System.Drawing.Point(6, 126);
            this.lblTelenr.Name = "lblTelenr";
            this.lblTelenr.Size = new System.Drawing.Size(80, 13);
            this.lblTelenr.TabIndex = 2;
            this.lblTelenr.Text = "Telefonnummer";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(6, 96);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Adress";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(111, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(75, 23);
            this.lblPage.TabIndex = 25;
            this.lblPage.Text = "Students";
            // 
            // gBoxRemove
            // 
            this.gBoxRemove.Controls.Add(this.btnSubmitRemove);
            this.gBoxRemove.Controls.Add(this.tBoxID);
            this.gBoxRemove.Controls.Add(this.lblID);
            this.gBoxRemove.Location = new System.Drawing.Point(933, 175);
            this.gBoxRemove.Name = "gBoxRemove";
            this.gBoxRemove.Size = new System.Drawing.Size(282, 109);
            this.gBoxRemove.TabIndex = 10;
            this.gBoxRemove.TabStop = false;
            this.gBoxRemove.Text = "Enter student to remove";
            // 
            // btnSubmitRemove
            // 
            this.btnSubmitRemove.Location = new System.Drawing.Point(201, 80);
            this.btnSubmitRemove.Name = "btnSubmitRemove";
            this.btnSubmitRemove.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitRemove.TabIndex = 5;
            this.btnSubmitRemove.Text = "Submit";
            this.btnSubmitRemove.UseVisualStyleBackColor = true;
            this.btnSubmitRemove.Click += new System.EventHandler(this.btnSubmitRemove_Click);
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(106, 30);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(170, 20);
            this.tBoxID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // gBoxStudents
            // 
            this.gBoxStudents.Controls.Add(this.lBoxStudents);
            this.gBoxStudents.Controls.Add(this.btnLoad);
            this.gBoxStudents.Location = new System.Drawing.Point(70, 175);
            this.gBoxStudents.Name = "gBoxStudents";
            this.gBoxStudents.Size = new System.Drawing.Size(282, 611);
            this.gBoxStudents.TabIndex = 11;
            this.gBoxStudents.TabStop = false;
            this.gBoxStudents.Text = "Students";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(181, 577);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 28);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load students";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lBoxStudents
            // 
            this.lBoxStudents.FormattingEnabled = true;
            this.lBoxStudents.Location = new System.Drawing.Point(6, 30);
            this.lBoxStudents.Name = "lBoxStudents";
            this.lBoxStudents.Size = new System.Drawing.Size(270, 537);
            this.lBoxStudents.TabIndex = 11;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.gBoxStudents);
            this.Controls.Add(this.gBoxRemove);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.gBoxAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.Title);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.gBoxAdd.ResumeLayout(false);
            this.gBoxAdd.PerformLayout();
            this.gBoxRemove.ResumeLayout(false);
            this.gBoxRemove.PerformLayout();
            this.gBoxStudents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gBoxAdd;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.Label lblTelenr;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tBoxTelenr;
        private System.Windows.Forms.TextBox tBoxAdress;
        private System.Windows.Forms.Button btnSubmitAdd;
        private System.Windows.Forms.TextBox tBoxEpost;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.GroupBox gBoxRemove;
        private System.Windows.Forms.Button btnSubmitRemove;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gBoxStudents;
        private System.Windows.Forms.ListBox lBoxStudents;
        private System.Windows.Forms.Button btnLoad;
    }
}