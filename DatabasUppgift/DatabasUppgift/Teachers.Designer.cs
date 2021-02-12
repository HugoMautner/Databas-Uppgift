namespace DatabasUppgift
{
    partial class Teachers
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
            this.gBoxAddTeacher = new System.Windows.Forms.GroupBox();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tBoxEpost = new System.Windows.Forms.TextBox();
            this.lblEpost = new System.Windows.Forms.Label();
            this.tBoxTelenr = new System.Windows.Forms.TextBox();
            this.tBoxAdress = new System.Windows.Forms.TextBox();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblTelenr = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gBoxAddTeacher.SuspendLayout();
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
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(111, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(76, 23);
            this.lblPage.TabIndex = 26;
            this.lblPage.Text = "Teachers";
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
            // gBoxAddTeacher
            // 
            this.gBoxAddTeacher.Controls.Add(this.tBoxLastName);
            this.gBoxAddTeacher.Controls.Add(this.btnSubmit);
            this.gBoxAddTeacher.Controls.Add(this.lblLastName);
            this.gBoxAddTeacher.Controls.Add(this.tBoxEpost);
            this.gBoxAddTeacher.Controls.Add(this.lblEpost);
            this.gBoxAddTeacher.Controls.Add(this.tBoxTelenr);
            this.gBoxAddTeacher.Controls.Add(this.tBoxAdress);
            this.gBoxAddTeacher.Controls.Add(this.tBoxFirstName);
            this.gBoxAddTeacher.Controls.Add(this.lblTelenr);
            this.gBoxAddTeacher.Controls.Add(this.lblAdress);
            this.gBoxAddTeacher.Controls.Add(this.lblFirstName);
            this.gBoxAddTeacher.Location = new System.Drawing.Point(1033, 172);
            this.gBoxAddTeacher.Name = "gBoxAddTeacher";
            this.gBoxAddTeacher.Size = new System.Drawing.Size(282, 219);
            this.gBoxAddTeacher.TabIndex = 29;
            this.gBoxAddTeacher.TabStop = false;
            this.gBoxAddTeacher.Text = "Enter Teacher Details";
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Location = new System.Drawing.Point(106, 61);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(170, 20);
            this.tBoxLastName.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(201, 190);
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
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 845);
            this.Controls.Add(this.gBoxAddTeacher);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.Title);
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            this.gBoxAddTeacher.ResumeLayout(false);
            this.gBoxAddTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox gBoxAddTeacher;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tBoxEpost;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.TextBox tBoxTelenr;
        private System.Windows.Forms.TextBox tBoxAdress;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.Label lblTelenr;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblFirstName;
    }
}